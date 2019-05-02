using System;
using System.Drawing;
using System.Windows.Forms;


namespace puzzle {
	public partial class FirstWindow : Form {

		private string selectedPath;

		public FirstWindow() {
			InitializeComponent();
		}

		private void uploadButton_Click(object sender, EventArgs e) {

			OpenFileDialog dialog = new OpenFileDialog();
			dialog.Filter = "jpg files(*.jpg)|*.jpg| PNG files(*.ppg)|*.ppg| All files (*.*)|*.*";

			if (dialog.ShowDialog() == DialogResult.OK) {
				selectedPath = dialog.FileName;
			}

		}

		private void startButton_Click(object sender, EventArgs e) {
			int numberOfCells = Convert.ToInt32(numberOfCellsNumeric.Value);
			Image image = Image.FromFile(selectedPath);
			Controller controller = new Controller(numberOfCells, image);

			Puzzle puzzleForm = new Puzzle(controller) {
				Width = controller.GetOriginalImage().Width,
				Height = controller.GetOriginalImage().Height
			};

			Hide();
			puzzleForm.Show();
		}
	}
}
