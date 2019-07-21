namespace Kades_Discord_Changer
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.gamerClose = new System.Windows.Forms.Button();
            this.gamerMiniReal = new System.Windows.Forms.Button();
            this.discordTextBox1 = new Kades_Discord_Changer.DiscordTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.gamerClose);
            this.panel1.Controls.Add(this.gamerMiniReal);
            this.panel1.Location = new System.Drawing.Point(-2, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(653, 20);
            this.panel1.TabIndex = 1;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DragForm_MouseDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(170)))), ((int)(((byte)(181)))));
            this.label1.Location = new System.Drawing.Point(3, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "KadesDiscordChanger";
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DragForm_MouseDown);
            // 
            // gamerClose
            // 
            this.gamerClose.BackgroundImage = global::Kades_Discord_Changer.Properties.Resources.x;
            this.gamerClose.FlatAppearance.BorderSize = 0;
            this.gamerClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gamerClose.ForeColor = System.Drawing.Color.White;
            this.gamerClose.Location = new System.Drawing.Point(623, 0);
            this.gamerClose.Name = "gamerClose";
            this.gamerClose.Size = new System.Drawing.Size(19, 20);
            this.gamerClose.TabIndex = 1;
            this.gamerClose.UseVisualStyleBackColor = true;
            this.gamerClose.Click += new System.EventHandler(this.GamerClose_Click);
            // 
            // gamerMiniReal
            // 
            this.gamerMiniReal.BackgroundImage = global::Kades_Discord_Changer.Properties.Resources.mini;
            this.gamerMiniReal.FlatAppearance.BorderSize = 0;
            this.gamerMiniReal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gamerMiniReal.ForeColor = System.Drawing.Color.White;
            this.gamerMiniReal.Location = new System.Drawing.Point(598, 0);
            this.gamerMiniReal.Name = "gamerMiniReal";
            this.gamerMiniReal.Size = new System.Drawing.Size(19, 20);
            this.gamerMiniReal.TabIndex = 3;
            this.gamerMiniReal.UseVisualStyleBackColor = true;
            this.gamerMiniReal.Click += new System.EventHandler(this.GamerMiniReal_Click);
            // 
            // discordTextBox1
            // 
            this.discordTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(47)))), ((int)(((byte)(51)))));
            this.discordTextBox1.Location = new System.Drawing.Point(78, 46);
            this.discordTextBox1.Name = "discordTextBox1";
            this.discordTextBox1.Size = new System.Drawing.Size(511, 43);
            this.discordTextBox1.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(137)))), ((int)(((byte)(218)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(238, 129);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(179, 38);
            this.button1.TabIndex = 10;
            this.button1.Text = "Start Changing!";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(47)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(646, 210);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.discordTextBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "【﻿Ｋａｄｅｓ　Ｄｉｓｃｏｒｄ　Ｃｈａｎｇｅｒ】";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button gamerClose;
        private System.Windows.Forms.Button gamerMiniReal;
        private System.Windows.Forms.Label label1;
        private DiscordTextBox discordTextBox1;
        private System.Windows.Forms.Button button1;
    }
}

