using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kades_Discord_Changer
{
    public partial class DiscordTextBox : UserControl
    {
        public string Text { get; set;}

        public TextBox textBox { get; set; }

        public DiscordTextBox()
        {
            InitializeComponent();

            Text = "";

            textBox1.Text = "";

            CheckForIllegalCrossThreadCalls = false;

            textBox = textBox1;
        }

        private void TextBox1_TextChanged(object sender, EventArgs e) => Text = textBox1.Text;
    }
}
