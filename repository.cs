namespace imagePuzzle {
	public class CellRepository {
		private Cell[,] _table;
		private int _lengthTable = 2000;
		private int _numberOfPieces; // number of pieces per row/column

		public CellRepository(int numberOfPieces) {
			_table = new Cell[_lengthTable, _lengthTable];
			_numberOfPieces = numberOfPieces;
		}

		private void PopulateTable() {
			for (var i = 0; i < _numberOfPieces; i++) {
				for (var j = 0; j < _numberOfPieces; j++) {
					var piece = new Cell(_lengthTable / _numberOfPieces);
					_table[i, j] = piece;
				}
			}
		}
	}
}