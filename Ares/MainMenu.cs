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
        Label[,] pole = new Label[5, 6];
        int index1 = 0, poc = 1;
        string[] Text1 = new string[5];
        WebSocket ws = new WebSocket("ws://194.15.112.30:5000");
        private void MainMenu_Load(object sender, EventArgs e) {
            timerCheck.Start();
            for (int i = 0; i < 5; i++) {
                for (int j = 0; j < 6; j++) {
                    pole[i, j] = new Label {
                        Name = "label" + i + j,
                        Location = new Point(100 * j, 50 * i),
                        Size = new Size(100, 30),
                        Text = "lol" + i + j,
                        BackColor = Color.LightBlue
                    };
                    this.Controls.Add(pole[i, j]);
                }
            }
            ws.Connect();
            ws.Send("req$1");
            ws.OnMessage += Ws_OnMessage;
        }
        private void Ws_OnMessage(object sender, MessageEventArgs e) {
            if (index1 < 5) {
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
