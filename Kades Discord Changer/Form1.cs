using Discord.Gateway;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kades_Discord_Changer
{
    public partial class Form1 : Form
    {
        private void AddDrag(Control Control) { Control.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DragForm_MouseDown); }
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        private void DragForm_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
                // Checks if Y = 0, if so maximize the form
                if (this.Location.Y == 0) { this.WindowState = FormWindowState.Maximized; }
            }
        }

        public DiscordSocketClient client { get; set; }

        public Form1()
        {
            InitializeComponent();

            discordTextBox1.textBox.Text = "Enter your discord token to start.";

            discordTextBox1.textBox.TextChanged += disChanged;

            discordTextBox1.textBox.KeyDown += disKeyDown;
        }

        private void disKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    client = new DiscordSocketClient();
                    client.Login(discordTextBox1.Text);
                    new Changer(client).Show();
                    Hide();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Failed to login! Exception: " + ex.Message,"Kades Discord Changer");
                }
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
            if (e.Control && e.KeyCode == Keys.A)
            {
                if (sender != null)
                    ((TextBox)sender).SelectAll();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void disChanged(object sender, EventArgs e) => discordTextBox1.textBox.UseSystemPasswordChar = true;

        private void GamerClose_Click(object sender, EventArgs e) => Close();

        private void GamerMiniReal_Click(object sender, EventArgs e) => WindowState = FormWindowState.Minimized;

        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                client = new DiscordSocketClient();
                client.Login(discordTextBox1.Text);
                new Changer(client).Show();
                Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to login! Exception: " + ex.Message, "Kades Discord Changer");
            }
        }
    }
}
