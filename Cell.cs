using System.Drawing;

namespace imagePuzzle {
	public class Cell {
		private int _length;
		private Image _image;

		public Cell(int lengthValue) {
			_length = lengthValue;
			_image = new Bitmap(_length, _length);
		}

		public int GetLength() {
			return _length;
		}

		public Image GetImage() {
			return _image;
		}

		public void SetLength(int lengthValue) {
			_length = lengthValue;
		}

		public void SetImage(Image imageValue) {
			_image = imageValue;
		}
	}
}