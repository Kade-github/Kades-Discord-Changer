using Discord;
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
    public partial class Changer : Form
    {
        DiscordSocketClient client { get; set; }
        Hypesquad hs = Hypesquad.None;

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

        public Changer(DiscordSocketClient c)
        {
            InitializeComponent();
            client = c;
            discordTextBox1.textBox.Text = c.User.Username;
            discordTextBox2.textBox.Text = c.User.Email;
            switch (c.User.Nitro)
            {
                case NitroType.Classic:
                    pictureBox2.BackgroundImage = Properties.Resources.Nitro;
                    break;
                case NitroType.Nitro:
                    pictureBox2.BackgroundImage = Properties.Resources.Nitro;
                    pictureBox3.BackgroundImage = Properties.Resources.NitroBoost;
                    break;
                default:
                    textBox1.ReadOnly = true;
                    break;
            }
            pictureBox1.Image = c.User.GetAvatar();
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            string discrm = "0000";
            // Very messy but honestly i dont care.
            if (c.User.Discriminator >= 1)
            {
                if (c.User.Discriminator >= 9)
                {
                    if (c.User.Discriminator >= 99)
                    {
                        if (c.User.Discriminator >= 999)
                        {
                            discrm = c.User.Discriminator.ToString();
                        }
                        else
                            discrm = "0" + c.User.Discriminator;
                    }
                    else
                        discrm = "00" + c.User.Discriminator;
                }
                else
                    discrm = "000" + c.User.Discriminator;
            }
            textBox1.Text = discrm;
            discordTextBox3.textBox.UseSystemPasswordChar = true;
        }

        private void GamerClose_Click(object sender, EventArgs e) => Application.Exit();

        private void GamerMiniReal_Click(object sender, EventArgs e) => WindowState = FormWindowState.Minimized;

        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                UserSettings set = new UserSettings();
                set.Discriminator = uint.Parse(textBox1.Text);
                set.Email = discordTextBox2.Text;
                set.Avatar = pictureBox1.Image;
                set.Username = discordTextBox1.Text;
                set.Password = discordTextBox3.Text;
                client.User.ChangeProfile(set);
                client.User.SetHypesquad(hs);
                MessageBox.Show("Saved!", "Kades Discord Changer");
            }
            catch (Exception ee)
            {
                MessageBox.Show("Failed to save! Exception: " + ee.Message, "Kades Discord Changer");
            }
        }

        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            hs = Hypesquad.Brilliance;
        }

        private void CheckBox2_CheckedChanged(object sender, EventArgs e)
        {
            checkBox1.Checked = false;
            checkBox3.Checked = false;
            hs = Hypesquad.Bravery;
        }

        private void CheckBox3_CheckedChanged(object sender, EventArgs e)
        {
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            hs = Hypesquad.Balance;
        }
    }
}
