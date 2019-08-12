namespace RussianRouletteGame
{
    partial class Game
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
            this.rbHead = new System.Windows.Forms.RadioButton();
            this.btnSpin = new System.Windows.Forms.Button();
            this.rbAway = new System.Windows.Forms.RadioButton();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnFire = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.pb6 = new System.Windows.Forms.PictureBox();
            this.pb5 = new System.Windows.Forms.PictureBox();
            this.pb4 = new System.Windows.Forms.PictureBox();
            this.pb3 = new System.Windows.Forms.PictureBox();
            this.pb2 = new System.Windows.Forms.PictureBox();
            this.pb1 = new System.Windows.Forms.PictureBox();
            this.pbMan = new System.Windows.Forms.PictureBox();
            this.pbPistol = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPistol)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.rbHead);
            this.panel1.Controls.Add(this.btnSpin);
            this.panel1.Controls.Add(this.rbAway);
            this.panel1.Controls.Add(this.btnLoad);
            this.panel1.Location = new System.Drawing.Point(354, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(129, 155);
            this.panel1.TabIndex = 0;
            // 
            // rbHead
            // 
            this.rbHead.AutoSize = true;
            this.rbHead.Location = new System.Drawing.Point(18, 115);
            this.rbHead.Name = "rbHead";
            this.rbHead.Size = new System.Drawing.Size(90, 17);
            this.rbHead.TabIndex = 12;
            this.rbHead.TabStop = true;
            this.rbHead.Text = "Point at Head";
            this.rbHead.UseVisualStyleBackColor = true;
            this.rbHead.CheckedChanged += new System.EventHandler(this.rbHead_CheckedChanged);
            // 
            // btnSpin
            // 
            this.btnSpin.Location = new System.Drawing.Point(13, 43);
            this.btnSpin.Name = "btnSpin";
            this.btnSpin.Size = new System.Drawing.Size(99, 30);
            this.btnSpin.TabIndex = 8;
            this.btnSpin.Text = "Spin chamber";
            this.btnSpin.UseVisualStyleBackColor = true;
            this.btnSpin.Click += new System.EventHandler(this.btnSpin_Click);
            // 
            // rbAway
            // 
            this.rbAway.AutoSize = true;
            this.rbAway.Location = new System.Drawing.Point(18, 92);
            this.rbAway.Name = "rbAway";
            this.rbAway.Size = new System.Drawing.Size(78, 17);
            this.rbAway.TabIndex = 12;
            this.rbAway.TabStop = true;
            this.rbAway.Text = "Point Away";
            this.rbAway.UseVisualStyleBackColor = true;
            this.rbAway.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(13, 6);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(99, 31);
            this.btnLoad.TabIndex = 7;
            this.btnLoad.Text = "Load Bullet";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnFire
            // 
            this.btnFire.BackColor = System.Drawing.Color.DarkRed;
            this.btnFire.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFire.Location = new System.Drawing.Point(12, 285);
            this.btnFire.Name = "btnFire";
            this.btnFire.Size = new System.Drawing.Size(471, 86);
            this.btnFire.TabIndex = 3;
            this.btnFire.Text = "FIRE!";
            this.btnFire.UseVisualStyleBackColor = false;
            this.btnFire.Click += new System.EventHandler(this.btnFire_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(12, 377);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(471, 38);
            this.btnExit.TabIndex = 10;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // pb6
            // 
            this.pb6.Image = global::RussianRouletteGame.Properties.Resources.PNGPIX_COM_Bullet_PNG_Transparent_Image_1;
            this.pb6.Location = new System.Drawing.Point(432, 170);
            this.pb6.Name = "pb6";
            this.pb6.Size = new System.Drawing.Size(51, 109);
            this.pb6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb6.TabIndex = 11;
            this.pb6.TabStop = false;
            // 
            // pb5
            // 
            this.pb5.Image = global::RussianRouletteGame.Properties.Resources.PNGPIX_COM_Bullet_PNG_Transparent_Image_1;
            this.pb5.Location = new System.Drawing.Point(354, 170);
            this.pb5.Name = "pb5";
            this.pb5.Size = new System.Drawing.Size(51, 109);
            this.pb5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb5.TabIndex = 10;
            this.pb5.TabStop = false;
            // 
            // pb4
            // 
            this.pb4.Image = global::RussianRouletteGame.Properties.Resources.PNGPIX_COM_Bullet_PNG_Transparent_Image_1;
            this.pb4.Location = new System.Drawing.Point(270, 170);
            this.pb4.Name = "pb4";
            this.pb4.Size = new System.Drawing.Size(51, 109);
            this.pb4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb4.TabIndex = 9;
            this.pb4.TabStop = false;
            // 
            // pb3
            // 
            this.pb3.Image = global::RussianRouletteGame.Properties.Resources.PNGPIX_COM_Bullet_PNG_Transparent_Image_1;
            this.pb3.Location = new System.Drawing.Point(180, 170);
            this.pb3.Name = "pb3";
            this.pb3.Size = new System.Drawing.Size(51, 109);
            this.pb3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb3.TabIndex = 8;
            this.pb3.TabStop = false;
            // 
            // pb2
            // 
            this.pb2.Image = global::RussianRouletteGame.Properties.Resources.PNGPIX_COM_Bullet_PNG_Transparent_Image_1;
            this.pb2.Location = new System.Drawing.Point(93, 170);
            this.pb2.Name = "pb2";
            this.pb2.Size = new System.Drawing.Size(51, 109);
            this.pb2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb2.TabIndex = 7;
            this.pb2.TabStop = false;
            // 
            // pb1
            // 
            this.pb1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pb1.Image = global::RussianRouletteGame.Properties.Resources.PNGPIX_COM_Bullet_PNG_Transparent_Image_1;
            this.pb1.Location = new System.Drawing.Point(12, 170);
            this.pb1.Name = "pb1";
            this.pb1.Size = new System.Drawing.Size(51, 109);
            this.pb1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb1.TabIndex = 6;
            this.pb1.TabStop = false;
            // 
            // pbMan
            // 
            this.pbMan.BackColor = System.Drawing.Color.Transparent;
            this.pbMan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbMan.Image = global::RussianRouletteGame.Properties.Resources.man;
            this.pbMan.Location = new System.Drawing.Point(12, 12);
            this.pbMan.Name = "pbMan";
            this.pbMan.Size = new System.Drawing.Size(183, 140);
            this.pbMan.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbMan.TabIndex = 5;
            this.pbMan.TabStop = false;
            // 
            // pbPistol
            // 
            this.pbPistol.Image = global::RussianRouletteGame.Properties.Resources.pistol;
            this.pbPistol.Location = new System.Drawing.Point(217, 12);
            this.pbPistol.Name = "pbPistol";
            this.pbPistol.Size = new System.Drawing.Size(120, 87);
            this.pbPistol.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPistol.TabIndex = 4;
            this.pbPistol.TabStop = false;
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(495, 427);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.pb6);
            this.Controls.Add(this.pb5);
            this.Controls.Add(this.pb4);
            this.Controls.Add(this.pb3);
            this.Controls.Add(this.pb2);
            this.Controls.Add(this.pb1);
            this.Controls.Add(this.pbMan);
            this.Controls.Add(this.pbPistol);
            this.Controls.Add(this.btnFire);
            this.Controls.Add(this.panel1);
            this.Name = "Game";
            this.Text = " Russian Roulette";
            this.Load += new System.EventHandler(this.Game_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPistol)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnFire;
        private System.Windows.Forms.PictureBox pbPistol;
        private System.Windows.Forms.Button btnSpin;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.PictureBox pbMan;
        private System.Windows.Forms.PictureBox pb1;
        private System.Windows.Forms.PictureBox pb2;
        private System.Windows.Forms.PictureBox pb3;
        private System.Windows.Forms.PictureBox pb4;
        private System.Windows.Forms.PictureBox pb5;
        private System.Windows.Forms.PictureBox pb6;
        private System.Windows.Forms.RadioButton rbHead;
        private System.Windows.Forms.RadioButton rbAway;
        private System.Windows.Forms.Button btnExit;
    }
}

