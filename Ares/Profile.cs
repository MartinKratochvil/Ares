using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WebSocketSharp;

namespace Ares {
	public partial class Profile : Form {
		public Profile() {
			InitializeComponent();
		}
		private void Profile_FormClosed(object sender, FormClosedEventArgs e) {
			MainMenu mainMenu = new MainMenu();
			mainMenu.Show();
		}
		WebSocket ws = new WebSocket("ws://194.15.112.30:5000");
		string received = "";
		private void Profile_Load(object sender, EventArgs e) {
			//pictureBoxPic.ImageLocation = @"https://www.ceskapic.cz/img/pic_logo2.png";
			timerCheck.Start();
			ws.Connect();
			ws.Send("rqprf$" + Login.Username);
			ws.OnMessage += Ws_OnMessage;
			/*byte[] b = File.ReadAllBytes("");
			Byte[] result = (Byte[])new ImageConverter().ConvertTo("../../Heart.png", typeof(Byte[]));
			MessageBox.Show(String.Join(" ", result));*/
		}
		private void Ws_OnMessage(object sender, MessageEventArgs e) {
			received = e.Data;
			MessageBox.Show(received);
			ws.OnMessage -= Ws_OnMessage;
		}
        private void timerCheck_Tick(object sender, EventArgs e) {
			if (received.StartsWith("prf")) {
				labelNickname.Text = received.Split('$')[2];
				labelUsername.Text = "@" + received.Split('$')[1];
				labelPocet.Text = received.Split('$')[4] + " ariees";
				labelRegistrationDate.Text = received.Split('$')[3];
				textBoxBio.Text = received.Split('$')[5];
				received = "";
			}
		}
		private void buttonUpravitProfil_Click(object sender, EventArgs e) {
			
		}
	}
}
