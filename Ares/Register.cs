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
            Login frame = new Login();
            frame.Show();
        }
        private void Register_Load(object sender, EventArgs e) {
            ws.Connect();
        }
        WebSocket ws = new WebSocket("ws://194.15.112.30:5000");
        private void buttonRegister_Click(object sender, EventArgs e) {
            if (textBoxUsername.Text != "" && textBoxPassword1.Text != "" && !textBoxUsername.Text.Contains("$") && !textBoxPassword1.Text.Contains("$")) {
                if (textBoxPassword1.Text == textBoxPassword2.Text) {
                    ws.Send("reg$" + textBoxUsername.Text + "$" + textBoxPassword1.Text);
                    ws.OnMessage += Ws_OnMessage;
                }
                else { MessageBox.Show("Hesla nejsou stejná!!"); }
            }
            else { MessageBox.Show("Zadal jsi špatnou hodnotu!!"); }
        }
        private void Ws_OnMessage(object sender, MessageEventArgs e) {
            MessageBox.Show("Recivived from server: " + e.Data);
        }
        private void textBoxUsername_Click(object sender, EventArgs e) {
            if (textBoxUsername.Text == "Username") { textBoxUsername.Text = ""; }
        }
        private void textBoxPassword1_Click(object sender, EventArgs e) {
            if (textBoxPassword1.Text == "Password") { textBoxPassword1.Text = ""; }
        }
        private void textBoxPassword2_Click(object sender, EventArgs e) {
            if (textBoxPassword2.Text == "Password") { textBoxPassword2.Text = ""; }
        }
    }
}
