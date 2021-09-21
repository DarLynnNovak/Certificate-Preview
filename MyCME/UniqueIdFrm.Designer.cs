
namespace ACSPreviewCertificate
{
	partial class UniqueIdFrm
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
			this.UniqueIdTxtBox = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.PreviewBtn = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// UniqueIdTxtBox
			// 
			this.UniqueIdTxtBox.Location = new System.Drawing.Point(17, 33);
			this.UniqueIdTxtBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.UniqueIdTxtBox.Name = "UniqueIdTxtBox";
			this.UniqueIdTxtBox.Size = new System.Drawing.Size(121, 20);
			this.UniqueIdTxtBox.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(36, 12);
			this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(82, 13);
			this.label1.TabIndex = 1;
			this.label1.Text = "Insert Unique Id";
			// 
			// PreviewBtn
			// 
			this.PreviewBtn.Location = new System.Drawing.Point(46, 60);
			this.PreviewBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.PreviewBtn.Name = "PreviewBtn";
			this.PreviewBtn.Size = new System.Drawing.Size(62, 21);
			this.PreviewBtn.TabIndex = 2;
			this.PreviewBtn.Text = "Preview";
			this.PreviewBtn.UseVisualStyleBackColor = true;
			this.PreviewBtn.Click += new System.EventHandler(this.PreviewBtn_Click);
			// 
			// UniqueIdFrm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(167, 96);
			this.Controls.Add(this.PreviewBtn);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.UniqueIdTxtBox);
			this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.Name = "UniqueIdFrm";
			this.Text = "Preview";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox UniqueIdTxtBox;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button PreviewBtn;
	}
}