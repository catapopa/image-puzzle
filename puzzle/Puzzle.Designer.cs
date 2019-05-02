namespace puzzle
{
    partial class Puzzle
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
			this.puzzleImage = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.puzzleImage)).BeginInit();
			this.SuspendLayout();
			// 
			// puzzleImage
			// 
			this.puzzleImage.Dock = System.Windows.Forms.DockStyle.Fill;
			this.puzzleImage.Location = new System.Drawing.Point(0, 0);
			this.puzzleImage.Margin = new System.Windows.Forms.Padding(5);
			this.puzzleImage.Name = "puzzleImage";
			this.puzzleImage.Size = new System.Drawing.Size(782, 753);
			this.puzzleImage.TabIndex = 0;
			this.puzzleImage.TabStop = false;
			// 
			// Puzzle
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(782, 753);
			this.Controls.Add(this.puzzleImage);
			this.Name = "Puzzle";
			this.Text = "Puzzle";
			this.Load += new System.EventHandler(this.Puzzle_Load);
			((System.ComponentModel.ISupportInitialize)(this.puzzleImage)).EndInit();
			this.ResumeLayout(false);

        }

		#endregion

		private System.Windows.Forms.PictureBox puzzleImage;
	}
}

