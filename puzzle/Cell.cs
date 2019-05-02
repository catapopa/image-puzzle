
using System.Drawing;


namespace puzzle {
    public class Cell {


        private Bitmap image;
		private int position;

        public Cell() {
        }

        public Cell(Bitmap image, int position) {

            this.image = image;
			this.position = position;
        }

        public Bitmap getImage() {
            return image;
        }

        public void setImage(Bitmap value) {
            image = value;
        }

		public int getPosition() {
			return position;
		}

		public void setPosition(int value) {
			position = value;
		}

		public override string ToString() {
            return base.ToString();
        }
    }
}
