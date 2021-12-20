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
            this.components = new System.ComponentModel.Container();
            this.pictureBoxPic = new System.Windows.Forms.PictureBox();
            this.pictureBoxBan = new System.Windows.Forms.PictureBox();
            this.labelNickname = new System.Windows.Forms.Label();
            this.labelUsername = new System.Windows.Forms.Label();
            this.labelPocet = new System.Windows.Forms.Label();
            this.labelRegistrationDate = new System.Windows.Forms.Label();
            this.buttonUpravitProfil = new System.Windows.Forms.Button();
            this.textBoxBio = new System.Windows.Forms.TextBox();
            this.timerCheck = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBan)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxPic
            // 
            this.pictureBoxPic.Location = new System.Drawing.Point(36, 110);
            this.pictureBoxPic.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBoxPic.Name = "pictureBoxPic";
            this.pictureBoxPic.Size = new System.Drawing.Size(145, 138);
            this.pictureBoxPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxPic.TabIndex = 0;
            this.pictureBoxPic.TabStop = false;
            // 
            // pictureBoxBan
            // 
            this.pictureBoxBan.Location = new System.Drawing.Point(17, 16);
            this.pictureBoxBan.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBoxBan.Name = "pictureBoxBan";
            this.pictureBoxBan.Size = new System.Drawing.Size(1033, 155);
            this.pictureBoxBan.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxBan.TabIndex = 1;
            this.pictureBoxBan.TabStop = false;
            // 
            // labelNickname
            // 
            this.labelNickname.AutoSize = true;
            this.labelNickname.Location = new System.Drawing.Point(189, 178);
            this.labelNickname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNickname.Name = "labelNickname";
            this.labelNickname.Size = new System.Drawing.Size(98, 16);
            this.labelNickname.TabIndex = 2;
            this.labelNickname.Text = "labelNickname";
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.Location = new System.Drawing.Point(189, 213);
            this.labelUsername.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(100, 16);
            this.labelUsername.TabIndex = 3;
            this.labelUsername.Text = "labelUsername";
            // 
            // labelPocet
            // 
            this.labelPocet.AutoSize = true;
            this.labelPocet.Location = new System.Drawing.Point(387, 178);
            this.labelPocet.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPocet.Name = "labelPocet";
            this.labelPocet.Size = new System.Drawing.Size(72, 16);
            this.labelPocet.TabIndex = 6;
            this.labelPocet.Text = "labelPocet";
            // 
            // labelRegistrationDate
            // 
            this.labelRegistrationDate.AutoSize = true;
            this.labelRegistrationDate.Location = new System.Drawing.Point(387, 213);
            this.labelRegistrationDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelRegistrationDate.Name = "labelRegistrationDate";
            this.labelRegistrationDate.Size = new System.Drawing.Size(76, 16);
            this.labelRegistrationDate.TabIndex = 7;
            this.labelRegistrationDate.Text = "labelRegist";
            // 
            // buttonUpravitProfil
            // 
            this.buttonUpravitProfil.Location = new System.Drawing.Point(920, 178);
            this.buttonUpravitProfil.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonUpravitProfil.Name = "buttonUpravitProfil";
            this.buttonUpravitProfil.Size = new System.Drawing.Size(131, 39);
            this.buttonUpravitProfil.TabIndex = 8;
            this.buttonUpravitProfil.Text = "Upravit profil";
            this.buttonUpravitProfil.UseVisualStyleBackColor = true;
            this.buttonUpravitProfil.Click += new System.EventHandler(this.buttonUpravitProfil_Click);
            // 
            // textBoxBio
            // 
            this.textBoxBio.BackColor = System.Drawing.Color.Gray;
            this.textBoxBio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxBio.Location = new System.Drawing.Point(471, 178);
            this.textBoxBio.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxBio.Multiline = true;
            this.textBoxBio.Name = "textBoxBio";
            this.textBoxBio.Size = new System.Drawing.Size(440, 68);
            this.textBoxBio.TabIndex = 11;
            // 
            // timerCheck
            // 
            this.timerCheck.Tick += new System.EventHandler(this.timerCheck_Tick);
            // 
            // Profile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.textBoxBio);
            this.Controls.Add(this.buttonUpravitProfil);
            this.Controls.Add(this.labelRegistrationDate);
            this.Controls.Add(this.labelPocet);
            this.Controls.Add(this.labelUsername);
            this.Controls.Add(this.labelNickname);
            this.Controls.Add(this.pictureBoxPic);
            this.Controls.Add(this.pictureBoxBan);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Profile";
            this.Text = "Profile";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Profile_FormClosed);
            this.Load += new System.EventHandler(this.Profile_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.PictureBox pictureBoxPic;
		private System.Windows.Forms.PictureBox pictureBoxBan;
		private System.Windows.Forms.Label labelNickname;
		private System.Windows.Forms.Label labelUsername;
		private System.Windows.Forms.Label labelPocet;
		private System.Windows.Forms.Label labelRegistrationDate;
		private System.Windows.Forms.Button buttonUpravitProfil;
		private System.Windows.Forms.TextBox textBoxBio;
        private System.Windows.Forms.Timer timerCheck;
    }
}