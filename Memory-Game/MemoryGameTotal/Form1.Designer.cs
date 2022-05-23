
namespace MemoryGameTotal
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
            this.panelSideMenu = new System.Windows.Forms.Panel();
            this.btnexit = new System.Windows.Forms.Button();
            this.btninfo = new System.Windows.Forms.Button();
            this.pnlOyunMenu = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.btnGames = new System.Windows.Forms.Button();
            this.home = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.logobox = new System.Windows.Forms.PictureBox();
            this.pnlJokerForm = new System.Windows.Forms.Panel();
            this.panelSideMenu.SuspendLayout();
            this.pnlOyunMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logobox)).BeginInit();
            this.SuspendLayout();
            // 
            // panelSideMenu
            // 
            this.panelSideMenu.AutoScroll = true;
            this.panelSideMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(67)))), ((int)(((byte)(54)))));
            this.panelSideMenu.Controls.Add(this.btnexit);
            this.panelSideMenu.Controls.Add(this.btninfo);
            this.panelSideMenu.Controls.Add(this.pnlOyunMenu);
            this.panelSideMenu.Controls.Add(this.btnGames);
            this.panelSideMenu.Controls.Add(this.home);
            this.panelSideMenu.Controls.Add(this.panelLogo);
            this.panelSideMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSideMenu.Location = new System.Drawing.Point(0, 0);
            this.panelSideMenu.Name = "panelSideMenu";
            this.panelSideMenu.Size = new System.Drawing.Size(150, 561);
            this.panelSideMenu.TabIndex = 1;
            // 
            // btnexit
            // 
            this.btnexit.BackgroundImage = global::MemoryGameTotal.Properties.Resources.exitlogo;
            this.btnexit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnexit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnexit.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnexit.FlatAppearance.BorderSize = 0;
            this.btnexit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnexit.ForeColor = System.Drawing.Color.LightGray;
            this.btnexit.Location = new System.Drawing.Point(0, 398);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(150, 51);
            this.btnexit.TabIndex = 4;
            this.btnexit.UseVisualStyleBackColor = true;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // btninfo
            // 
            this.btninfo.BackgroundImage = global::MemoryGameTotal.Properties.Resources.noyunlogo;
            this.btninfo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btninfo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btninfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.btninfo.FlatAppearance.BorderSize = 0;
            this.btninfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btninfo.ForeColor = System.Drawing.Color.LightGray;
            this.btninfo.Location = new System.Drawing.Point(0, 348);
            this.btninfo.Name = "btninfo";
            this.btninfo.Size = new System.Drawing.Size(150, 50);
            this.btninfo.TabIndex = 3;
            this.btninfo.UseVisualStyleBackColor = true;
            this.btninfo.Click += new System.EventHandler(this.btninfo_Click);
            // 
            // pnlOyunMenu
            // 
            this.pnlOyunMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.pnlOyunMenu.Controls.Add(this.button4);
            this.pnlOyunMenu.Controls.Add(this.button5);
            this.pnlOyunMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlOyunMenu.Location = new System.Drawing.Point(0, 291);
            this.pnlOyunMenu.Name = "pnlOyunMenu";
            this.pnlOyunMenu.Size = new System.Drawing.Size(150, 57);
            this.pnlOyunMenu.TabIndex = 2;
            // 
            // button4
            // 
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.Dock = System.Windows.Forms.DockStyle.Top;
            this.button4.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.ForeColor = System.Drawing.Color.LightGray;
            this.button4.Location = new System.Drawing.Point(0, 27);
            this.button4.Name = "button4";
            this.button4.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.button4.Size = new System.Drawing.Size(150, 29);
            this.button4.TabIndex = 7;
            this.button4.Text = "Sayı Tahmin";
            this.button4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button5.Dock = System.Windows.Forms.DockStyle.Top;
            this.button5.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.ForeColor = System.Drawing.Color.LightGray;
            this.button5.Location = new System.Drawing.Point(0, 0);
            this.button5.Name = "button5";
            this.button5.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.button5.Size = new System.Drawing.Size(150, 27);
            this.button5.TabIndex = 6;
            this.button5.Text = "Kart Eşleştirme";
            this.button5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // btnGames
            // 
            this.btnGames.BackgroundImage = global::MemoryGameTotal.Properties.Resources.Oyunlaricon4;
            this.btnGames.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGames.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGames.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnGames.FlatAppearance.BorderSize = 0;
            this.btnGames.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGames.ForeColor = System.Drawing.Color.LightGray;
            this.btnGames.Location = new System.Drawing.Point(0, 241);
            this.btnGames.Name = "btnGames";
            this.btnGames.Size = new System.Drawing.Size(150, 50);
            this.btnGames.TabIndex = 0;
            this.btnGames.UseVisualStyleBackColor = true;
            this.btnGames.Click += new System.EventHandler(this.btnGames_Click);
            // 
            // home
            // 
            this.home.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(67)))), ((int)(((byte)(54)))));
            this.home.BackgroundImage = global::MemoryGameTotal.Properties.Resources.homeicon2_removebg_preview;
            this.home.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.home.Cursor = System.Windows.Forms.Cursors.Hand;
            this.home.Dock = System.Windows.Forms.DockStyle.Top;
            this.home.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.home.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(67)))), ((int)(((byte)(54)))));
            this.home.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.home.Location = new System.Drawing.Point(0, 198);
            this.home.Name = "home";
            this.home.Size = new System.Drawing.Size(150, 43);
            this.home.TabIndex = 0;
            this.home.UseVisualStyleBackColor = false;
            this.home.Click += new System.EventHandler(this.home_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.panelLogo.Controls.Add(this.logobox);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(150, 198);
            this.panelLogo.TabIndex = 2;
            // 
            // logobox
            // 
            this.logobox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.logobox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.logobox.BackgroundImage = global::MemoryGameTotal.Properties.Resources.LOGO_removebg;
            this.logobox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.logobox.Location = new System.Drawing.Point(0, 23);
            this.logobox.Name = "logobox";
            this.logobox.Size = new System.Drawing.Size(150, 150);
            this.logobox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logobox.TabIndex = 0;
            this.logobox.TabStop = false;
            // 
            // pnlJokerForm
            // 
            this.pnlJokerForm.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlJokerForm.Location = new System.Drawing.Point(147, 0);
            this.pnlJokerForm.Name = "pnlJokerForm";
            this.pnlJokerForm.Size = new System.Drawing.Size(837, 561);
            this.pnlJokerForm.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.pnlJokerForm);
            this.Controls.Add(this.panelSideMenu);
            this.Name = "Form1";
            this.Text = "Memory Games";
            this.panelSideMenu.ResumeLayout(false);
            this.pnlOyunMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.logobox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelSideMenu;
        private System.Windows.Forms.Panel pnlOyunMenu;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button btnGames;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.Button btninfo;
        private System.Windows.Forms.PictureBox logobox;
        private System.Windows.Forms.Panel pnlJokerForm;
        private System.Windows.Forms.Button home;
    }
}

