using System;
using System.Drawing;


namespace puzzle {
	public class Controller {

		private Repository repository;
		private int numberOfCells;
		private Image image;


		public Controller(int numberOfCells, Image image) {

			repository = new Repository();
			this.numberOfCells = numberOfCells;
			this.image = image;
		}

		public Controller() {
			repository = new Repository();
		}

		public Image GetOriginalImage() {
			return image;
		}

		public Cell[,] GetGrid() {
			return repository.GetGrid();
		}

		public void SetNumberOfCells(int numberOfCellsValue) {
			numberOfCells = numberOfCellsValue;
		}

		public void SetImage(Image image) {
			this.image = image;
		}

		public int GetNumberOfCells() {
			return numberOfCells;
		}


		public Cell[,] PopulateGrid() {
			int position = 0;
			Cell[,] grid = new Cell[numberOfCells, numberOfCells];
			for (int i = 0; i < numberOfCells; i++) {
				for (int j = 0; j < numberOfCells; j++) {
					Cell cell = SeparateImage(i, j, position);
					grid[i, j] = cell;
					position++;
				}
			}
			return repository.SetGrid(grid);
		}

		public Cell[,] Move(int x, int y) {
			Cell[,] grid = GetGrid();
			int selectedRow = numberOfCells * x / image.Width;
			int selectedColumn = numberOfCells * y / image.Height;
	
			Tuple<int, int> emptyPosition = getEmptyPosition();
			int emptyRow = emptyPosition.Item1;
			int emptyColumn = emptyPosition.Item2;

			if(!(((emptyRow + 1 == selectedRow || emptyRow - 1 == selectedRow) && emptyColumn == selectedColumn) || ((emptyColumn + 1 == selectedColumn || emptyColumn - 1 == selectedColumn) && emptyRow == selectedRow))) {
				return grid;
			}

			Cell bufferCell = grid[selectedRow, selectedColumn];
			grid[selectedRow, selectedColumn] = grid[emptyRow, emptyColumn];
			grid[emptyRow, emptyColumn] = bufferCell;
			return repository.SetGrid(grid);
		}

		public Cell[,] ShuffleGrid() {
			Random rnd = new Random();
			Cell[,] grid = GetGrid();
			Cell[,] initializedGrid = EmptyFirstCell();
			Cell[,] shuffleGrid = Shuffle(rnd, initializedGrid);
			return repository.SetGrid(grid);
		}

		private Cell SeparateImage(int row, int column, int position) {
			int width = image.Width / numberOfCells;
			int height = image.Height / numberOfCells;
			int x = width * row;
			int y = height * column;
			Rectangle rectangle = new Rectangle(x, y, width, height);
			Bitmap cellImage = new Bitmap(image).Clone(rectangle, image.PixelFormat);
			return new Cell(cellImage, position);
		}

		private Tuple<int, int> getEmptyPosition() {
			Cell[,] grid = GetGrid();

			for (int i = 0; i < grid.GetLength(0); i++) {
				for (int j = 0; j < grid.GetLength(1); j++) {
					if (grid[i, j].getPosition().Equals(0)) {
						return Tuple.Create(i, j);
					}
				}
			}
			return Tuple.Create(-1, -1);
		}

		private Cell[,] EmptyFirstCell() {
			Cell[,] grid = GetGrid();
			Cell firstCell = grid[0, 0];
			Bitmap emptyBitmap = new Bitmap(firstCell.getImage().Width, firstCell.getImage().Height);
			firstCell.setImage(emptyBitmap);
			return grid;
		}

		// Using the Fisher-Yates algorithm
		private T[,] Shuffle<T>(Random random, T[,] array) {
			int lengthRow = array.GetLength(1);

			for (int i = array.Length - 1; i > 0; i--) {
				int i0 = i / lengthRow;
				int i1 = i % lengthRow;

				int j = random.Next(i + 1);
				int j0 = j / lengthRow;
				int j1 = j % lengthRow;

				T temp = array[i0, i1];
				array[i0, i1] = array[j0, j1];
				array[j0, j1] = temp;
			}

			return array;
		}
	}
}
