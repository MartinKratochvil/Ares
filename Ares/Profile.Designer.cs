namespace Ares
{
	partial class Profile
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
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.labelNickname = new System.Windows.Forms.Label();
			this.labelUsername = new System.Windows.Forms.Label();
			this.labelPocet = new System.Windows.Forms.Label();
			this.labelRegistrationDate = new System.Windows.Forms.Label();
			this.buttonUpravitProfil = new System.Windows.Forms.Button();
			this.textBoxBio = new System.Windows.Forms.TextBox();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			this.SuspendLayout();
			// 
			// pictureBox1
			// 
			this.pictureBox1.Location = new System.Drawing.Point(27, 89);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(109, 112);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			// 
			// pictureBox2
			// 
			this.pictureBox2.Location = new System.Drawing.Point(13, 13);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(775, 126);
			this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox2.TabIndex = 1;
			this.pictureBox2.TabStop = false;
			// 
			// labelNickname
			// 
			this.labelNickname.AutoSize = true;
			this.labelNickname.Location = new System.Drawing.Point(142, 145);
			this.labelNickname.Name = "labelNickname";
			this.labelNickname.Size = new System.Drawing.Size(77, 13);
			this.labelNickname.TabIndex = 2;
			this.labelNickname.Text = "labelNickname";
			// 
			// labelUsername
			// 
			this.labelUsername.AutoSize = true;
			this.labelUsername.Location = new System.Drawing.Point(142, 173);
			this.labelUsername.Name = "labelUsername";
			this.labelUsername.Size = new System.Drawing.Size(77, 13);
			this.labelUsername.TabIndex = 3;
			this.labelUsername.Text = "labelUsername";
			// 
			// labelPocet
			// 
			this.labelPocet.AutoSize = true;
			this.labelPocet.Location = new System.Drawing.Point(290, 145);
			this.labelPocet.Name = "labelPocet";
			this.labelPocet.Size = new System.Drawing.Size(57, 13);
			this.labelPocet.TabIndex = 6;
			this.labelPocet.Text = "labelPocet";
			// 
			// labelRegistrationDate
			// 
			this.labelRegistrationDate.AutoSize = true;
			this.labelRegistrationDate.Location = new System.Drawing.Point(290, 173);
			this.labelRegistrationDate.Name = "labelRegistrationDate";
			this.labelRegistrationDate.Size = new System.Drawing.Size(59, 13);
			this.labelRegistrationDate.TabIndex = 7;
			this.labelRegistrationDate.Text = "labelRegist";
			// 
			// buttonUpravitProfil
			// 
			this.buttonUpravitProfil.Location = new System.Drawing.Point(690, 145);
			this.buttonUpravitProfil.Name = "buttonUpravitProfil";
			this.buttonUpravitProfil.Size = new System.Drawing.Size(98, 32);
			this.buttonUpravitProfil.TabIndex = 8;
			this.buttonUpravitProfil.Text = "Upravit profil";
			this.buttonUpravitProfil.UseVisualStyleBackColor = true;
			this.buttonUpravitProfil.Click += new System.EventHandler(this.buttonUpravitProfil_Click);
			// 
			// textBoxBio
			// 
			this.textBoxBio.BackColor = System.Drawing.Color.Gray;
			this.textBoxBio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.textBoxBio.Location = new System.Drawing.Point(353, 145);
			this.textBoxBio.Multiline = true;
			this.textBoxBio.Name = "textBoxBio";
			this.textBoxBio.Size = new System.Drawing.Size(331, 56);
			this.textBoxBio.TabIndex = 11;
			// 
			// Profile
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Gray;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.textBoxBio);
			this.Controls.Add(this.buttonUpravitProfil);
			this.Controls.Add(this.labelRegistrationDate);
			this.Controls.Add(this.labelPocet);
			this.Controls.Add(this.labelUsername);
			this.Controls.Add(this.labelNickname);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.pictureBox2);
			this.Name = "Profile";
			this.Text = "Profile";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Profile_FormClosing);
			this.Load += new System.EventHandler(this.Profile_Load);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.Label labelNickname;
		private System.Windows.Forms.Label labelUsername;
		private System.Windows.Forms.Label labelPocet;
		private System.Windows.Forms.Label labelRegistrationDate;
		private System.Windows.Forms.Button buttonUpravitProfil;
		private System.Windows.Forms.TextBox textBoxBio;
	}
}