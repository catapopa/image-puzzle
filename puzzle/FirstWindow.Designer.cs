namespace puzzle {
	partial class FirstWindow {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			this.nrOfPiecesLabel = new System.Windows.Forms.Label();
			this.uploadImageLabel = new System.Windows.Forms.Label();
			this.uploadButton = new System.Windows.Forms.Button();
			this.startButton = new System.Windows.Forms.Button();
			this.numberOfCellsNumeric = new System.Windows.Forms.NumericUpDown();
			((System.ComponentModel.ISupportInitialize)(this.numberOfCellsNumeric)).BeginInit();
			this.SuspendLayout();
			// 
			// nrOfPiecesLabel
			// 
			this.nrOfPiecesLabel.AutoSize = true;
			this.nrOfPiecesLabel.Font = new System.Drawing.Font("Trebuchet MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.nrOfPiecesLabel.Location = new System.Drawing.Point(91, 35);
			this.nrOfPiecesLabel.Name = "nrOfPiecesLabel";
			this.nrOfPiecesLabel.Size = new System.Drawing.Size(123, 18);
			this.nrOfPiecesLabel.TabIndex = 1;
			this.nrOfPiecesLabel.Text = "number of pieces:";
			// 
			// uploadImageLabel
			// 
			this.uploadImageLabel.AutoSize = true;
			this.uploadImageLabel.Font = new System.Drawing.Font("Trebuchet MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.uploadImageLabel.Location = new System.Drawing.Point(91, 106);
			this.uploadImageLabel.Name = "uploadImageLabel";
			this.uploadImageLabel.Size = new System.Drawing.Size(123, 18);
			this.uploadImageLabel.TabIndex = 2;
			this.uploadImageLabel.Text = "upload your image";
			// 
			// uploadButton
			// 
			this.uploadButton.Font = new System.Drawing.Font("Trebuchet MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.uploadButton.Location = new System.Drawing.Point(94, 127);
			this.uploadButton.Name = "uploadButton";
			this.uploadButton.Size = new System.Drawing.Size(120, 26);
			this.uploadButton.TabIndex = 3;
			this.uploadButton.Text = "upload";
			this.uploadButton.UseVisualStyleBackColor = true;
			this.uploadButton.Click += new System.EventHandler(this.uploadButton_Click);
			// 
			// startButton
			// 
			this.startButton.Font = new System.Drawing.Font("Trebuchet MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.startButton.Location = new System.Drawing.Point(94, 194);
			this.startButton.Name = "startButton";
			this.startButton.Size = new System.Drawing.Size(120, 50);
			this.startButton.TabIndex = 4;
			this.startButton.Text = "start";
			this.startButton.UseVisualStyleBackColor = true;
			this.startButton.Click += new System.EventHandler(this.startButton_Click);
			// 
			// numberOfCellsNumeric
			// 
			this.numberOfCellsNumeric.Location = new System.Drawing.Point(91, 56);
			this.numberOfCellsNumeric.Name = "numberOfCellsNumeric";
			this.numberOfCellsNumeric.Size = new System.Drawing.Size(123, 22);
			this.numberOfCellsNumeric.TabIndex = 5;
			this.numberOfCellsNumeric.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.numberOfCellsNumeric.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
			// 
			// FirstWindow
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(299, 274);
			this.Controls.Add(this.numberOfCellsNumeric);
			this.Controls.Add(this.startButton);
			this.Controls.Add(this.uploadButton);
			this.Controls.Add(this.uploadImageLabel);
			this.Controls.Add(this.nrOfPiecesLabel);
			this.Name = "FirstWindow";
			this.Text = "Preferences";
			((System.ComponentModel.ISupportInitialize)(this.numberOfCellsNumeric)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Label nrOfPiecesLabel;
		private System.Windows.Forms.Label uploadImageLabel;
		private System.Windows.Forms.Button uploadButton;
		private System.Windows.Forms.Button startButton;
		private System.Windows.Forms.NumericUpDown numberOfCellsNumeric;
	}
}