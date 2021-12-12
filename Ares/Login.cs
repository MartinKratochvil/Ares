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
    public partial class Login : Form {
        public Login() {
            InitializeComponent();
        }
        private void Login_FormClosed(object sender, FormClosedEventArgs e) {
            Application.Exit();
        }
        private void Login_Load(object sender, EventArgs e) {
            timerCheck.Start();
            ws.Connect();
        }
        public static string Username, Password;
        WebSocket ws = new WebSocket("ws://194.15.112.30:5000");
        bool LoginSuc = false;
        private void buttonLogin_Click(object sender, EventArgs e) {
            if (textBoxUsername.Text != "" && textBoxPassword.Text != "" && !textBoxUsername.Text.Contains("$") && !textBoxPassword.Text.Contains("$")) {
                ws.Send("log$" + textBoxUsername.Text + "$" + textBoxPassword.Text);
                ws.OnMessage += Ws_OnMessage;
            }
            else { MessageBox.Show("Zadal jsi špatnou hodnotu!!"); }
        }
        /*private void button1_Click(object sender, EventArgs e) {
            WebSocket ws = new WebSocket("ws://194.15.112.30:5000");
            ws.Connect();
            ws.Send(textBox1.Text);
            ws.Send("ahoj");
            ws.Send("necum na me");

            WebSocket ws = new WebSocket("ws://194.15.112.30:5000");
            ws.OnMessage += Ws_OnMessage;
            ws.Connect();
            ws.Send("Pokus!");
        }*/
        private void Ws_OnMessage(object sender, MessageEventArgs e) {
            if (e.Data == "suc") { LoginSuc = true; }
            else if (e.Data == "err") { MessageBox.Show("Vole zadal jsi spatne udaje"); }
            else { Application.Exit(); }
            ws.OnMessage -= Ws_OnMessage;
        }
        private void buttonRegister_Click(object sender, EventArgs e) {
            this.Hide();
            Register frame = new Register();
            frame.Show();
        }
        private void timerCheck_Tick(object sender, EventArgs e) {
            if (LoginSuc) {
                LoginSuc = false;
                Username = textBoxUsername.Text;
                Password = textBoxPassword.Text;
                this.Hide();
                MainMenu frame = new MainMenu();
                frame.Show();
            }
        }
    }
}
