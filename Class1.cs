using System.Windows.Forms;

namespace imagePuzzle {
	public class Puzzle : Form {
		private Button _button1;
		private TextBox _nameTextBox;
		private TextBox _numberOfPersonsTextBox;
		private Label _label1;
		private Label _label2;
		private DataGridView _dataGridView1;

		public Puzzle() {
			InitializeComponent();
		}


		private void InitializeComponent() {
			this._button1 = new Button();
			this._nameTextBox = new TextBox();
			this._numberOfPersonsTextBox = new TextBox();
			this._label1 = new Label();
			this._label2 = new Label();
			this._dataGridView1 = new DataGridView();
			((System.ComponentModel.ISupportInitialize) (this._dataGridView1)).BeginInit();
			this.SuspendLayout();
		}
	}
}