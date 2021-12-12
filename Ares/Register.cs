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
    public partial class Register : Form {
        public Register() {
            InitializeComponent();
        }
        private void Register_FormClosed(object sender, FormClosedEventArgs e) {
            Application.Exit();
        }
        private void Register_Load(object sender, EventArgs e) {
            timerCheck.Start();
            ws.Connect();
        }
        WebSocket ws = new WebSocket("ws://194.15.112.30:5000");
        bool LoginSuc = false;
        private void buttonRegister_Click(object sender, EventArgs e) {
            bool LogInf = true;
            for (int i = 0; i < textBoxUsername.Text.Length; ++i) {
                if (textBoxUsername.Text[i] < 48 || textBoxUsername.Text[i] > 57 && textBoxUsername.Text[i] < 65 || textBoxUsername.Text[i] > 90 && textBoxUsername.Text[i] < 97 || textBoxUsername.Text[i] > 122) { LogInf = false; }
            }
            for (int i = 0; i < textBoxPassword1.Text.Length; ++i) {
                if ((textBoxPassword1.Text[i] < 48 || textBoxPassword1.Text[i] > 57 && textBoxPassword1.Text[i] < 65 || textBoxPassword1.Text[i] > 90 && textBoxPassword1.Text[i] < 97 || textBoxPassword1.Text[i] > 122) && (textBoxPassword1.Text[i] != '.' && textBoxPassword1.Text[i] != ',' && textBoxPassword1.Text[i] != '_' && textBoxPassword1.Text[i] != '-')) { LogInf = false; }
            }
            if (textBoxUsername.Text != "" && textBoxPassword1.Text != "" && textBoxUsername.Text != "Username:" && textBoxPassword1.Text != "Password:" && textBoxUsername.Text.Length <= 12 && textBoxPassword1.Text.Length <= 16 && LogInf) {
                if (textBoxPassword1.Text == textBoxPassword2.Text) {
                    ws.Send("reg$" + textBoxUsername.Text + "$" + textBoxPassword1.Text);
                    ws.OnMessage += Ws_OnMessage;
                }
                else { MessageBox.Show("Hesla nejsou stejná!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            }
            else { MessageBox.Show("Zadal jsi špatnou hodnotu!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        private void Ws_OnMessage(object sender, MessageEventArgs e) {
            if (e.Data == "suc") { LoginSuc = true; }
            else if (e.Data == "err") { MessageBox.Show("Tento uživatel již existuje!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            ws.OnMessage -= Ws_OnMessage;
        }
        private void timerCheck_Tick(object sender, EventArgs e) {
            if (LoginSuc) { 
                LoginSuc = false;
                this.Hide();
                MainMenu frame = new MainMenu();
                frame.Show();
            }
        }
        private void buttonBack_Click(object sender, EventArgs e) {
            this.Hide();
            Login frame = new Login();
            frame.Show();
        }
        private void textBoxUsername_Click(object sender, EventArgs e) {
            if (textBoxUsername.Text == "Username:") { textBoxUsername.Text = ""; }
        }
        private void textBoxPassword1_Click(object sender, EventArgs e) {
            if (textBoxPassword1.Text == "Password:") { textBoxPassword1.Text = ""; }
        }
        private void textBoxPassword2_Click(object sender, EventArgs e) {
            if (textBoxPassword2.Text == "Password:") { textBoxPassword2.Text = ""; }
        }
    }
}
