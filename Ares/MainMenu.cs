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
        int index1 = 0, poc = 1;
        string[] Text1 = new string[5];
        WebSocket ws = new WebSocket("ws://194.15.112.30:5000");
        private void MainMenu_Load(object sender, EventArgs e) {
            timerCheck.Start();
            for (int i = 0; i < 5; i++) {
                pole[i, 0] = new Label {
                    Name = "label" + i + 0,
                    Location = new Point(120, 120 * i + 15),
                    Size = new Size(120, 25),
                    Font = new Font("Microsoft YaHei", 14, FontStyle.Regular),
                    Text = "lol" + i + 0,
                    BackColor = Color.LightBlue
                };
                this.Controls.Add(pole[i, 0]);
                pole[i, 1] = new Label {
                    Name = "label" + i + 1,
                    Location = new Point(130, 120 * i + 40),
                    Size = new Size(500, 60),
                    Text = "lol" + i + 1,
                    BackColor = Color.LightBlue
                };
                this.Controls.Add(pole[i, 1]);
                pole[i, 2] = new Label {
                    Name = "label" + i + 2,
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
                    BackColor = Color.LightBlue
                };
                this.Controls.Add(pole[i, 5]);
            }
            ws.Connect();
            ws.Send("req$1");
            ws.OnMessage += Ws_OnMessage;
        }
        private void Ws_OnMessage(object sender, MessageEventArgs e) {
            if (index1 < 5 && e.Data.StartsWith("snd")) {
                Text1[index1] = e.Data;
                ++index1;
            }
        }
        private void timerCheck_Tick(object sender, EventArgs e) {
            if (index1 >= 5) {
                for (int i = 0; i < 5; ++i) {
                    for (int j = 0; j < 6; ++j) {
                        pole[i, j].Text = Text1[i].Split('$')[j + 2];
                    }
                }
                index1 = 0;
            }
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
    }
}
