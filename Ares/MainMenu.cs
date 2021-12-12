using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using WebSocketSharp;

namespace Ares {
    public partial class MainMenu : Form {
        public MainMenu() {
            InitializeComponent();
        }
        private void MainMenu_FormClosed(object sender, FormClosedEventArgs e) {
            Application.Exit();
        }
        Label[,] pole = new Label[5, 6];
        int index = 0, poc = 1;
        string[] Text1 = new string[5], ShareId = new string[5];
        WebSocket ws = new WebSocket("ws://194.15.112.30:5000");
        private void MainMenu_Load(object sender, EventArgs e) {
            timerCheck.Start();
            for (int i = 0; i < 5; i++) {
                pole[i, 0] = new Label {
                    Name = "Username" + i + 0,
                    Location = new Point(120, 120 * i + 15),
                    Size = new Size(120, 25),
                    Font = new Font("Microsoft YaHei", 14, FontStyle.Regular),
                    Text = "lol" + i + 0,
                    BackColor = Color.LightBlue
                };
                this.Controls.Add(pole[i, 0]);
                pole[i, 1] = new Label {
                    Name = "Text" + i + 1,
                    Location = new Point(130, 120 * i + 40),
                    Size = new Size(500, 60),
                    Text = "lol" + i + 1,
                    BackColor = Color.LightBlue
                };
                this.Controls.Add(pole[i, 1]);
                pole[i, 2] = new Label {
                    Name = "Time" + i + 2,
                    Location = new Point(500, 120 * i + 20),
                    Size = new Size(130, 20),
                    Text = "lol" + i + 2,
                    BackColor = Color.LightBlue
                };
                this.Controls.Add(pole[i, 2]);
                pole[i, 3] = new Label {
                    Name = "label" + i + 3,
                    Location = new Point(370, 120 * i + 110),
                    Size = new Size(40, 20),
                    Text = "lol" + i + 3,
                    BackColor = Color.LightBlue
                };
                this.Controls.Add(pole[i, 3]);
                pole[i, 4] = new Label {
                    Name = "label" + i + 4,
                    Location = new Point(470, 120 * i + 110),
                    Size = new Size(40, 20),
                    Text = "lol" + i + 4,
                    BackColor = Color.LightBlue
                };
                this.Controls.Add(pole[i, 4]);
                pole[i, 5] = new Label {
                    Name = "label" + i + 5,
                    Location = new Point(570, 120 * i + 110),
                    Size = new Size(40, 20),
                    Text = "lol" + i + 5,
                    BackColor = Color.LightBlue,
                };
                this.Controls.Add(pole[i, 5]);
                PictureBox pictureBox1 = new PictureBox() {
                    Name = "pictureBox" + 0 + i,
                    Size = new Size(30, 30),
                    Location = new Point(340, 120 * i + 105),
                    ImageLocation = @"../../Heart.png",
                    SizeMode = PictureBoxSizeMode.StretchImage,
                    BackColor = Color.Transparent,
                };
                this.Controls.Add(pictureBox1);
                PictureBox pictureBox2 = new PictureBox() {
                    Name = "pictureBox" + 1 + i,
                    Size = new Size(30, 30),
                    Location = new Point(440, 120 * i + 105),
                    ImageLocation = @"../../Poop.png",
                    SizeMode = PictureBoxSizeMode.StretchImage,
                    BackColor = Color.Transparent
                };
                this.Controls.Add(pictureBox2);
                PictureBox pictureBox3 = new PictureBox() {
                    Name = "pictureBox" + 2 + i,
                    Size = new Size(30, 30),
                    Location = new Point(540, 120 * i + 105),
                    ImageLocation = @"../../Comment.png",
                    SizeMode = PictureBoxSizeMode.StretchImage,
                    BackColor = Color.Transparent
                };
                this.Controls.Add(pictureBox3);
                pictureBox1.Click += this.ReactSnd;
                pictureBox2.Click += this.ReactSnd;
                pictureBox3.Click += this.ReactSnd;
            }
            ws.Connect();
            ws.Send("req$1");
            ws.OnMessage += Ws_OnMessage;
        }
        private void Ws_OnMessage(object sender, MessageEventArgs e) {
            if (index < 5 && e.Data.StartsWith("snd")) {
                Text1[index] = e.Data;
                ++index;
            }
            else if (e.Data.StartsWith("ans")) { Text1[0] = e.Data; }
        }
        private void timerCheck_Tick(object sender, EventArgs e) {
            if (index >= 5) {
                index = 0;
                for (int i = 0; i < 5; ++i) {
                    for (int j = 0; j < 6; ++j) {
                        pole[i, j].Text = Text1[i].Split('$')[j + 2];
                    }
                    ShareId[i] = Text1[i].Split('$')[1];
                }
            }
            if (Text1[0].StartsWith("ans")) {
                if (Text1[0].Split('$')[1] == "like") { pole[Array.IndexOf(ShareId, Text1[0].Split('$')[2]), 3].Text = (Int32.Parse(pole[Array.IndexOf(ShareId, Text1[0].Split('$')[2]), 3].Text) + 1).ToString(); Text1[0] = ""; }
                else if (Text1[0].Split('$')[1] == "notlike") { pole[Array.IndexOf(ShareId, Text1[0].Split('$')[2]), 3].Text = (Int32.Parse(pole[Array.IndexOf(ShareId, Text1[0].Split('$')[2]), 3].Text) - 1).ToString(); Text1[0] = ""; }
                else if (Text1[0].Split('$')[1] == "poop") { pole[Array.IndexOf(ShareId, Text1[0].Split('$')[2]), 4].Text = (Int32.Parse(pole[Array.IndexOf(ShareId, Text1[0].Split('$')[2]), 4].Text) + 1).ToString(); Text1[0] = ""; }
                else if (Text1[0].Split('$')[1] == "notpoop") { pole[Array.IndexOf(ShareId, Text1[0].Split('$')[2]), 4].Text = (Int32.Parse(pole[Array.IndexOf(ShareId, Text1[0].Split('$')[2]), 4].Text) - 1).ToString(); Text1[0] = ""; }
            }
            //MessageBox.Show((Array.IndexOf(ShareId, Text1[0].Split('$')[2])).ToString());
            /*if (Text1[0].Split('$')[1] == "like")
            {
                MessageBox.Show((Array.IndexOf(ShareId, Text1[0].Split('$')[2])).ToString());
                //MessageBox.Show(Text1[0].Split('$')[2]);
            }*/
        }
        private void buttonSend_Click(object sender, EventArgs e) {
            ws.Send("new$" + Login.Username + "$" + Login.Password + "$" + textBox1.Text);
            textBox1.Text = "";
        }
        private void buttonPrevious_Click(object sender, EventArgs e) {
            if (poc > 1) {
                for (int i = 0; i < 5; i++) { ws.OnMessage -= Ws_OnMessage; }
                --poc;
                ws.Send("req$" + poc);
                ws.OnMessage += Ws_OnMessage;
            }
        }
        private void buttonNext_Click(object sender, EventArgs e) {
            for (int i = 0; i < 5; i++) { ws.OnMessage -= Ws_OnMessage; }
            ++poc;
            ws.Send("req$" + poc);
            ws.OnMessage += Ws_OnMessage;
        }
        private void ReactSnd(object sender, EventArgs e) {
            if ((sender as PictureBox).ImageLocation == @"../../Heart.png") {
                ws.Send("setlike$" + Login.Username + "$" + Login.Password + "$" + ShareId[Int32.Parse((sender as PictureBox).Name[(sender as PictureBox).Name.Length - 1].ToString())]);
            }
            else if ((sender as PictureBox).ImageLocation == @"../../Poop.png") {
                ws.Send("setpoop$" + Login.Username + "$" + Login.Password + "$" + ShareId[Int32.Parse((sender as PictureBox).Name[(sender as PictureBox).Name.Length - 1].ToString())]);
            }
            else { }
        }
        private void PoopSnd(object sender, EventArgs e) {
            MessageBox.Show("Poop");
        }
        private void CommentSnd(object sender, EventArgs e) {
            MessageBox.Show("Comment");
        }
    }
}
