namespace simpleRPGv22
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.imgLogo = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlCreator = new System.Windows.Forms.Panel();
            this.lblInt = new System.Windows.Forms.Label();
            this.lblStr = new System.Windows.Forms.Label();
            this.lblDex = new System.Windows.Forms.Label();
            this.lblHp = new System.Windows.Forms.Label();
            this.lblMp = new System.Windows.Forms.Label();
            this.imgStr = new System.Windows.Forms.PictureBox();
            this.imgDex = new System.Windows.Forms.PictureBox();
            this.imgInt = new System.Windows.Forms.PictureBox();
            this.imgMp = new System.Windows.Forms.PictureBox();
            this.imgHP = new System.Windows.Forms.PictureBox();
            this.imgChooseString = new System.Windows.Forms.PictureBox();
            this.btnArrowRight = new System.Windows.Forms.Button();
            this.btnArrowLeft = new System.Windows.Forms.Button();
            this.imgAvatarWarrior = new System.Windows.Forms.PictureBox();
            this.imgAvatarMage = new System.Windows.Forms.PictureBox();
            this.imgTransbox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlCreator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgStr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgDex)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgInt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgMp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgHP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgChooseString)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgAvatarWarrior)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgAvatarMage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgTransbox)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Yu Gothic Light", 36F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblTitle.Image = ((System.Drawing.Image)(resources.GetObject("lblTitle.Image")));
            this.lblTitle.Location = new System.Drawing.Point(244, -22);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(0, 61);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblTitle.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnStart
            // 
            this.btnStart.AccessibleRole = System.Windows.Forms.AccessibleRole.Pane;
            this.btnStart.BackColor = System.Drawing.Color.Transparent;
            this.btnStart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnStart.CausesValidation = false;
            this.btnStart.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btnStart.FlatAppearance.BorderSize = 0;
            this.btnStart.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnStart.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStart.Location = new System.Drawing.Point(306, 240);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(270, 75);
            this.btnStart.TabIndex = 1;
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            this.btnStart.MouseEnter += new System.EventHandler(this.btnStart_MouseEnter);
            this.btnStart.MouseLeave += new System.EventHandler(this.btnStart_MouseLeave);
            // 
            // btnExit
            // 
            this.btnExit.AccessibleRole = System.Windows.Forms.AccessibleRole.Pane;
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.ForeColor = System.Drawing.Color.Transparent;
            this.btnExit.Location = new System.Drawing.Point(306, 404);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(270, 67);
            this.btnExit.TabIndex = 2;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnQuit_click);
            this.btnExit.MouseEnter += new System.EventHandler(this.btnExit_MouseEnter);
            this.btnExit.MouseLeave += new System.EventHandler(this.btnExit_MouseLeave);
            // 
            // imgLogo
            // 
            this.imgLogo.BackColor = System.Drawing.Color.Transparent;
            this.imgLogo.Image = global::simpleRPGv22.Properties.Resources.logo_weii;
            this.imgLogo.Location = new System.Drawing.Point(820, 12);
            this.imgLogo.Name = "imgLogo";
            this.imgLogo.Size = new System.Drawing.Size(107, 140);
            this.imgLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.imgLogo.TabIndex = 3;
            this.imgLogo.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(185, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(561, 204);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // pnlCreator
            // 
            this.pnlCreator.BackgroundImage = global::simpleRPGv22.Properties.Resources.thumb_1920_478555;
            this.pnlCreator.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlCreator.Controls.Add(this.imgTransbox);
            this.pnlCreator.Controls.Add(this.lblInt);
            this.pnlCreator.Controls.Add(this.lblStr);
            this.pnlCreator.Controls.Add(this.lblDex);
            this.pnlCreator.Controls.Add(this.lblHp);
            this.pnlCreator.Controls.Add(this.imgStr);
            this.pnlCreator.Controls.Add(this.imgDex);
            this.pnlCreator.Controls.Add(this.imgInt);
            this.pnlCreator.Controls.Add(this.imgMp);
            this.pnlCreator.Controls.Add(this.imgHP);
            this.pnlCreator.Controls.Add(this.imgChooseString);
            this.pnlCreator.Controls.Add(this.btnArrowRight);
            this.pnlCreator.Controls.Add(this.btnArrowLeft);
            this.pnlCreator.Controls.Add(this.imgAvatarWarrior);
            this.pnlCreator.Controls.Add(this.imgAvatarMage);
            this.pnlCreator.Controls.Add(this.lblMp);
            this.pnlCreator.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCreator.Location = new System.Drawing.Point(0, 0);
            this.pnlCreator.Name = "pnlCreator";
            this.pnlCreator.Size = new System.Drawing.Size(939, 662);
            this.pnlCreator.TabIndex = 5;
            this.pnlCreator.Visible = false;
            this.pnlCreator.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlCreator_Paint);
            // 
            // lblInt
            // 
            this.lblInt.BackColor = System.Drawing.Color.Transparent;
            this.lblInt.Font = new System.Drawing.Font("Niagara Solid", 36F, System.Drawing.FontStyle.Bold);
            this.lblInt.Location = new System.Drawing.Point(745, 527);
            this.lblInt.Name = "lblInt";
            this.lblInt.Size = new System.Drawing.Size(93, 51);
            this.lblInt.TabIndex = 14;
            // 
            // lblStr
            // 
            this.lblStr.BackColor = System.Drawing.Color.Transparent;
            this.lblStr.Font = new System.Drawing.Font("Niagara Solid", 36F, System.Drawing.FontStyle.Bold);
            this.lblStr.Location = new System.Drawing.Point(425, 527);
            this.lblStr.Name = "lblStr";
            this.lblStr.Size = new System.Drawing.Size(91, 51);
            this.lblStr.TabIndex = 13;
            // 
            // lblDex
            // 
            this.lblDex.BackColor = System.Drawing.Color.Transparent;
            this.lblDex.Font = new System.Drawing.Font("Niagara Solid", 36F, System.Drawing.FontStyle.Bold);
            this.lblDex.Location = new System.Drawing.Point(585, 527);
            this.lblDex.Name = "lblDex";
            this.lblDex.Size = new System.Drawing.Size(93, 51);
            this.lblDex.TabIndex = 12;
            // 
            // lblHp
            // 
            this.lblHp.BackColor = System.Drawing.Color.Transparent;
            this.lblHp.Font = new System.Drawing.Font("Niagara Solid", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHp.Location = new System.Drawing.Point(102, 527);
            this.lblHp.Name = "lblHp";
            this.lblHp.Size = new System.Drawing.Size(100, 51);
            this.lblHp.TabIndex = 11;
            this.lblHp.Paint += new System.Windows.Forms.PaintEventHandler(this.lblHp_Paint);
            // 
            // lblMp
            // 
            this.lblMp.BackColor = System.Drawing.Color.Transparent;
            this.lblMp.Font = new System.Drawing.Font("Niagara Solid", 36F, System.Drawing.FontStyle.Bold);
            this.lblMp.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblMp.Location = new System.Drawing.Point(260, 527);
            this.lblMp.Name = "lblMp";
            this.lblMp.Size = new System.Drawing.Size(95, 51);
            this.lblMp.TabIndex = 10;
            this.lblMp.TextChanged += new System.EventHandler(this.lblMp_TextChanged);
            // 
            // imgStr
            // 
            this.imgStr.BackColor = System.Drawing.Color.Transparent;
            this.imgStr.Image = global::simpleRPGv22.Properties.Resources.imgStr;
            this.imgStr.Location = new System.Drawing.Point(419, 464);
            this.imgStr.Name = "imgStr";
            this.imgStr.Size = new System.Drawing.Size(100, 50);
            this.imgStr.TabIndex = 7;
            this.imgStr.TabStop = false;
            // 
            // imgDex
            // 
            this.imgDex.BackColor = System.Drawing.Color.Transparent;
            this.imgDex.Image = global::simpleRPGv22.Properties.Resources.imgDex;
            this.imgDex.Location = new System.Drawing.Point(582, 464);
            this.imgDex.Name = "imgDex";
            this.imgDex.Size = new System.Drawing.Size(100, 50);
            this.imgDex.TabIndex = 6;
            this.imgDex.TabStop = false;
            // 
            // imgInt
            // 
            this.imgInt.BackColor = System.Drawing.Color.Transparent;
            this.imgInt.Image = global::simpleRPGv22.Properties.Resources.imgInt;
            this.imgInt.Location = new System.Drawing.Point(741, 464);
            this.imgInt.Name = "imgInt";
            this.imgInt.Size = new System.Drawing.Size(100, 50);
            this.imgInt.TabIndex = 5;
            this.imgInt.TabStop = false;
            // 
            // imgMp
            // 
            this.imgMp.BackColor = System.Drawing.Color.Transparent;
            this.imgMp.Image = global::simpleRPGv22.Properties.Resources.imgMp;
            this.imgMp.Location = new System.Drawing.Point(255, 464);
            this.imgMp.Name = "imgMp";
            this.imgMp.Size = new System.Drawing.Size(100, 50);
            this.imgMp.TabIndex = 4;
            this.imgMp.TabStop = false;
            // 
            // imgHP
            // 
            this.imgHP.BackColor = System.Drawing.Color.Transparent;
            this.imgHP.Image = global::simpleRPGv22.Properties.Resources.imgHP;
            this.imgHP.Location = new System.Drawing.Point(102, 464);
            this.imgHP.Name = "imgHP";
            this.imgHP.Size = new System.Drawing.Size(100, 50);
            this.imgHP.TabIndex = 3;
            this.imgHP.TabStop = false;
            this.imgHP.Click += new System.EventHandler(this.imgHP_Click);
            // 
            // imgChooseString
            // 
            this.imgChooseString.BackColor = System.Drawing.Color.Transparent;
            this.imgChooseString.Image = global::simpleRPGv22.Properties.Resources.charCreatorString_good;
            this.imgChooseString.Location = new System.Drawing.Point(102, 12);
            this.imgChooseString.Name = "imgChooseString";
            this.imgChooseString.Size = new System.Drawing.Size(739, 84);
            this.imgChooseString.TabIndex = 2;
            this.imgChooseString.TabStop = false;
            // 
            // btnArrowRight
            // 
            this.btnArrowRight.BackColor = System.Drawing.Color.Transparent;
            this.btnArrowRight.FlatAppearance.BorderSize = 0;
            this.btnArrowRight.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnArrowRight.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnArrowRight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnArrowRight.Image = global::simpleRPGv22.Properties.Resources.imgChooseArrowRight;
            this.btnArrowRight.Location = new System.Drawing.Point(666, 375);
            this.btnArrowRight.Name = "btnArrowRight";
            this.btnArrowRight.Size = new System.Drawing.Size(80, 47);
            this.btnArrowRight.TabIndex = 1;
            this.btnArrowRight.UseVisualStyleBackColor = false;
            this.btnArrowRight.Click += new System.EventHandler(this.btnArrowRight_Click);
            this.btnArrowRight.MouseEnter += new System.EventHandler(this.btnArrowRight_MouseEnter);
            this.btnArrowRight.MouseLeave += new System.EventHandler(this.btnArrowRight_MouseLeave);
            // 
            // btnArrowLeft
            // 
            this.btnArrowLeft.BackColor = System.Drawing.Color.Transparent;
            this.btnArrowLeft.FlatAppearance.BorderSize = 0;
            this.btnArrowLeft.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnArrowLeft.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnArrowLeft.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnArrowLeft.Image = global::simpleRPGv22.Properties.Resources.imgChooseArrow;
            this.btnArrowLeft.Location = new System.Drawing.Point(164, 375);
            this.btnArrowLeft.Name = "btnArrowLeft";
            this.btnArrowLeft.Size = new System.Drawing.Size(80, 47);
            this.btnArrowLeft.TabIndex = 0;
            this.btnArrowLeft.UseVisualStyleBackColor = false;
            this.btnArrowLeft.Click += new System.EventHandler(this.btnArrowLeft_Click);
            this.btnArrowLeft.MouseEnter += new System.EventHandler(this.btnArrowLeft_MouseEnter);
            this.btnArrowLeft.MouseLeave += new System.EventHandler(this.btnArrowLeft_MouseLeave);
            // 
            // imgAvatarWarrior
            // 
            this.imgAvatarWarrior.BackColor = System.Drawing.Color.Transparent;
            this.imgAvatarWarrior.Image = global::simpleRPGv22.Properties.Resources.imgWorriorAvatar;
            this.imgAvatarWarrior.Location = new System.Drawing.Point(394, 276);
            this.imgAvatarWarrior.Name = "imgAvatarWarrior";
            this.imgAvatarWarrior.Size = new System.Drawing.Size(150, 168);
            this.imgAvatarWarrior.TabIndex = 8;
            this.imgAvatarWarrior.TabStop = false;
            // 
            // imgAvatarMage
            // 
            this.imgAvatarMage.BackColor = System.Drawing.Color.Transparent;
            this.imgAvatarMage.Image = global::simpleRPGv22.Properties.Resources.imgMageAvatar;
            this.imgAvatarMage.Location = new System.Drawing.Point(394, 276);
            this.imgAvatarMage.Name = "imgAvatarMage";
            this.imgAvatarMage.Size = new System.Drawing.Size(150, 168);
            this.imgAvatarMage.TabIndex = 9;
            this.imgAvatarMage.TabStop = false;
            this.imgAvatarMage.Visible = false;
            // 
            // imgTransbox
            // 
            this.imgTransbox.BackColor = System.Drawing.Color.Transparent;
            this.imgTransbox.Location = new System.Drawing.Point(144, 144);
            this.imgTransbox.Name = "imgTransbox";
            this.imgTransbox.Size = new System.Drawing.Size(100, 60);
            this.imgTransbox.TabIndex = 15;
            this.imgTransbox.TabStop = false;
            // 
            // Form1
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = global::simpleRPGv22.Properties.Resources.thumb_1920_478555;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(939, 662);
            this.Controls.Add(this.pnlCreator);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.imgLogo);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.lblTitle);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlCreator.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imgStr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgDex)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgInt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgMp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgHP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgChooseString)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgAvatarWarrior)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgAvatarMage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgTransbox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.PictureBox imgLogo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel pnlCreator;
        private System.Windows.Forms.Button btnArrowRight;
        private System.Windows.Forms.Button btnArrowLeft;
        private System.Windows.Forms.PictureBox imgChooseString;
        private System.Windows.Forms.PictureBox imgHP;
        private System.Windows.Forms.PictureBox imgStr;
        private System.Windows.Forms.PictureBox imgDex;
        private System.Windows.Forms.PictureBox imgInt;
        private System.Windows.Forms.PictureBox imgMp;
        private System.Windows.Forms.PictureBox imgAvatarMage;
        private System.Windows.Forms.PictureBox imgAvatarWarrior;
        private System.Windows.Forms.Label lblInt;
        private System.Windows.Forms.Label lblStr;
        private System.Windows.Forms.Label lblDex;
        private System.Windows.Forms.Label lblHp;
        private System.Windows.Forms.Label lblMp;
        private System.Windows.Forms.PictureBox imgTransbox;
    }
}

