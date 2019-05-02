using System;
using System.Drawing;
using System.Windows.Forms;

namespace puzzle {
	public partial class Puzzle : Form {

		private Controller controller;

		public Puzzle(Controller controllerValue) {
			InitializeComponent();
			controller = controllerValue;
		}

		private void Puzzle_Load(object sender, EventArgs e) {
			controller.PopulateGrid();
			Cell[,] grid = controller.ShuffleGrid();
			drawGrid(grid);

			puzzleImage.MouseDown += PuzzleImage_Click;
		}

		private void drawGrid(Cell[,] grid) {
			Image originalImage = controller.GetOriginalImage();
			int numberOfCells = controller.GetNumberOfCells();

			Bitmap bitmap = new Bitmap(originalImage.Width, originalImage.Height);
			Graphics g = Graphics.FromImage(bitmap);

			for (int i = 0; i < numberOfCells; i++) {
				for (int j = 0; j < numberOfCells; j++) {
					var image = grid[i, j].getImage();
					int width = image.Width;
					int height = image.Height;
					g.DrawImage(image, new Point(i * width, j * height));
				}
			}
			puzzleImage.Image = bitmap;
		}

		private void PuzzleImage_Click(object sender, MouseEventArgs e) {
			Cell[,] grid = controller.Move(e.X, e.Y);
			drawGrid(grid);
		}
	}
}