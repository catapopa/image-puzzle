using System.Drawing;

namespace puzzle {
	public class Repository {

		private Cell[,] grid;

		public Cell[,] GetGrid() {
			return grid;
		}

		public Cell[,] SetGrid(Cell[,] grid) {
			this.grid = grid;
			return grid;
		}

	}
}
