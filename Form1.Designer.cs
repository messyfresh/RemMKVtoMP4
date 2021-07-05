
namespace RemMKVtoMP4
{
	partial class MainForm
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.mkvFileButton = new System.Windows.Forms.Button();
			this.mp4FileButton = new System.Windows.Forms.Button();
			this.convertButton = new System.Windows.Forms.Button();
			this.mkvFileLabel = new System.Windows.Forms.Label();
			this.mp4FileLabel = new System.Windows.Forms.Label();
			this.conversionProgressLabel = new System.Windows.Forms.Label();
			this.conversionProgressBar = new System.Windows.Forms.ProgressBar();
			this.SuspendLayout();
			// 
			// mkvFileButton
			// 
			this.mkvFileButton.Location = new System.Drawing.Point(23, 22);
			this.mkvFileButton.Name = "mkvFileButton";
			this.mkvFileButton.Size = new System.Drawing.Size(115, 45);
			this.mkvFileButton.TabIndex = 0;
			this.mkvFileButton.Text = "MKV File";
			this.mkvFileButton.UseVisualStyleBackColor = true;
			this.mkvFileButton.Click += new System.EventHandler(this.mkvFileButton_Click);
			// 
			// mp4FileButton
			// 
			this.mp4FileButton.Location = new System.Drawing.Point(23, 93);
			this.mp4FileButton.Name = "mp4FileButton";
			this.mp4FileButton.Size = new System.Drawing.Size(115, 45);
			this.mp4FileButton.TabIndex = 1;
			this.mp4FileButton.Text = "MP4 File";
			this.mp4FileButton.UseVisualStyleBackColor = true;
			this.mp4FileButton.Click += new System.EventHandler(this.mp4FileButton_Click);
			// 
			// convertButton
			// 
			this.convertButton.Location = new System.Drawing.Point(23, 160);
			this.convertButton.Name = "convertButton";
			this.convertButton.Size = new System.Drawing.Size(115, 45);
			this.convertButton.TabIndex = 2;
			this.convertButton.Text = "Convert";
			this.convertButton.UseVisualStyleBackColor = true;
			this.convertButton.Click += new System.EventHandler(this.convertButton_Click);
			// 
			// mkvFileLabel
			// 
			this.mkvFileLabel.AutoSize = true;
			this.mkvFileLabel.Location = new System.Drawing.Point(171, 37);
			this.mkvFileLabel.Name = "mkvFileLabel";
			this.mkvFileLabel.Size = new System.Drawing.Size(53, 15);
			this.mkvFileLabel.TabIndex = 4;
			this.mkvFileLabel.Text = "MKV File";
			// 
			// mp4FileLabel
			// 
			this.mp4FileLabel.AutoSize = true;
			this.mp4FileLabel.Location = new System.Drawing.Point(171, 106);
			this.mp4FileLabel.Name = "mp4FileLabel";
			this.mp4FileLabel.Size = new System.Drawing.Size(52, 15);
			this.mp4FileLabel.TabIndex = 5;
			this.mp4FileLabel.Text = "MP4 File";
			// 
			// conversionProgressLabel
			// 
			this.conversionProgressLabel.AutoSize = true;
			this.conversionProgressLabel.Location = new System.Drawing.Point(159, 175);
			this.conversionProgressLabel.Name = "conversionProgressLabel";
			this.conversionProgressLabel.Size = new System.Drawing.Size(119, 15);
			this.conversionProgressLabel.TabIndex = 6;
			this.conversionProgressLabel.Text = "Click Convert to Start";
			// 
			// conversionProgressBar
			// 
			this.conversionProgressBar.Location = new System.Drawing.Point(284, 171);
			this.conversionProgressBar.Name = "conversionProgressBar";
			this.conversionProgressBar.Size = new System.Drawing.Size(100, 23);
			this.conversionProgressBar.TabIndex = 7;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(407, 217);
			this.Controls.Add(this.conversionProgressBar);
			this.Controls.Add(this.conversionProgressLabel);
			this.Controls.Add(this.mp4FileLabel);
			this.Controls.Add(this.mkvFileLabel);
			this.Controls.Add(this.convertButton);
			this.Controls.Add(this.mp4FileButton);
			this.Controls.Add(this.mkvFileButton);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "MainForm";
			this.Text = "Rem\'s MKV to MP4 Converter";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button mkvFileButton;
		private System.Windows.Forms.Button mp4FileButton;
		private System.Windows.Forms.Button convertButton;
		private System.Windows.Forms.Label mkvFileLabel;
		private System.Windows.Forms.Label mp4FileLabel;
		private System.Windows.Forms.Label conversionProgressLabel;
		private System.Windows.Forms.ProgressBar conversionProgressBar;
	}
}

