namespace LEARNING_WINDOWS_FORMS_APPLICATION
{
	partial class MainForm
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
			this.fullNameTextBox = new System.Windows.Forms.TextBox();
			this.fullNameLabel = new System.Windows.Forms.Label();
			this.insertButton = new System.Windows.Forms.Button();
			this.fullNameslistBox = new System.Windows.Forms.ListBox();
			this.SuspendLayout();
			// 
			// fullNameTextBox
			// 
			this.fullNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.fullNameTextBox.Location = new System.Drawing.Point(72, 12);
			this.fullNameTextBox.Name = "fullNameTextBox";
			this.fullNameTextBox.Size = new System.Drawing.Size(204, 20);
			this.fullNameTextBox.TabIndex = 1;
			// 
			// fullNameLabel
			// 
			this.fullNameLabel.AutoSize = true;
			this.fullNameLabel.Location = new System.Drawing.Point(12, 15);
			this.fullNameLabel.Name = "fullNameLabel";
			this.fullNameLabel.Size = new System.Drawing.Size(54, 13);
			this.fullNameLabel.TabIndex = 0;
			this.fullNameLabel.Text = "&Full Name";
			// 
			// insertButton
			// 
			this.insertButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.insertButton.Location = new System.Drawing.Point(282, 10);
			this.insertButton.Name = "insertButton";
			this.insertButton.Size = new System.Drawing.Size(29, 23);
			this.insertButton.TabIndex = 2;
			this.insertButton.Text = "...";
			this.insertButton.UseVisualStyleBackColor = true;
			this.insertButton.Click += new System.EventHandler(this.insertButton_Click);
			// 
			// fullNameslistBox
			// 
			this.fullNameslistBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.fullNameslistBox.FormattingEnabled = true;
			this.fullNameslistBox.Location = new System.Drawing.Point(12, 38);
			this.fullNameslistBox.Name = "fullNameslistBox";
			this.fullNameslistBox.Size = new System.Drawing.Size(299, 290);
			this.fullNameslistBox.TabIndex = 3;
			this.fullNameslistBox.Enter += new System.EventHandler(this.fullNameslistBox_Enter);
			this.fullNameslistBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.fullNameslistBox_KeyDown);
			// 
			// MainForm
			// 
			this.AcceptButton = this.insertButton;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(323, 336);
			this.Controls.Add(this.fullNameslistBox);
			this.Controls.Add(this.insertButton);
			this.Controls.Add(this.fullNameLabel);
			this.Controls.Add(this.fullNameTextBox);
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Main";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.TextBox fullNameTextBox;
		private System.Windows.Forms.Label fullNameLabel;
		private System.Windows.Forms.Button insertButton;
		private System.Windows.Forms.ListBox fullNameslistBox;
	}
}

