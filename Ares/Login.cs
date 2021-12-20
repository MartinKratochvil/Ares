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
        public static string Username, Password;
        WebSocket ws = new WebSocket("ws://194.15.112.30:5000");
        bool LoginSuc = false;
        private void Login_Load(object sender, EventArgs e) {
            //timerCheck.Start();
            ws.Connect();
        }
        private void Ws_OnMessage(object sender, MessageEventArgs e) {
            if (e.Data == "suc") { LoginSuc = true; }
            else if (e.Data == "err") { MessageBox.Show("Zadal jsi špatné přihlašovací údaje!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            else { Application.Exit(); }
            ws.OnMessage -= Ws_OnMessage;            
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
        private void buttonLogin_Click(object sender, EventArgs e) {
            bool LogInf = true;
            for (int i = 0; i < textBoxUsername.Text.Length; ++i) {
                if (textBoxUsername.Text[i] < 48 || textBoxUsername.Text[i] > 57 && textBoxUsername.Text[i] < 65 || textBoxUsername.Text[i] > 90 && textBoxUsername.Text[i] < 97 || textBoxUsername.Text[i] > 122) { LogInf = false; }
            }
            for (int i = 0; i < textBoxPassword.Text.Length; ++i) {
                if ((textBoxPassword.Text[i] < 48 || textBoxPassword.Text[i] > 57 && textBoxPassword.Text[i] < 65 || textBoxPassword.Text[i] > 90 && textBoxPassword.Text[i] < 97 || textBoxPassword.Text[i] > 122) && (textBoxPassword.Text[i] != '.' && textBoxPassword.Text[i] != ',' && textBoxPassword.Text[i] != '_' && textBoxPassword.Text[i] != '-')) { LogInf = false; }
            }
            if (textBoxUsername.Text != "" && textBoxPassword.Text != "" && textBoxUsername.Text != "Username:" && textBoxPassword.Text != "Password:" && textBoxUsername.Text.Length <= 12 && textBoxPassword.Text.Length <= 16 && LogInf) {
                ws.Send("log$" + textBoxUsername.Text + "$" + textBoxPassword.Text);
                ws.OnMessage += Ws_OnMessage;
            }
            else { MessageBox.Show("Zadal jsi špatnou hodnotu!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        private void buttonRegister_Click(object sender, EventArgs e) {
            this.Hide();
            Register frame = new Register();
            frame.Show();
        }
        private void textBoxUsername_Click(object sender, EventArgs e) {
            if (textBoxUsername.Text == "Username:") { textBoxUsername.Text = ""; }
        }
        private void textBoxPassword_Click(object sender, EventArgs e) {
            if (textBoxPassword.Text == "Password:") { textBoxPassword.Text = ""; }
        }
    }
}
