namespace Invaders
{
    partial class Invaders
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Invaders));
            this.labelAantalSteden = new System.Windows.Forms.Label();
            this.labelInvaderLevens = new System.Windows.Forms.Label();
            this.groupBoxInstellingen = new System.Windows.Forms.GroupBox();
            this.numericUpDownInvaderSnelheid = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownInvaderLevens = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownAantalSteden = new System.Windows.Forms.NumericUpDown();
            this.buttonStart = new System.Windows.Forms.Button();
            this.labelInvaderSnelheid = new System.Windows.Forms.Label();
            this.groupBoxSpelStatus = new System.Windows.Forms.GroupBox();
            this.labelAantalStedenValue = new System.Windows.Forms.Label();
            this.labelAantalInvadersValue = new System.Windows.Forms.Label();
            this.labelAantalStedenSpelstatus = new System.Windows.Forms.Label();
            this.labelAantalInvaders = new System.Windows.Forms.Label();
            this.groupBoxInvaders = new System.Windows.Forms.GroupBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBoxInstellingen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownInvaderSnelheid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownInvaderLevens)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAantalSteden)).BeginInit();
            this.groupBoxSpelStatus.SuspendLayout();
            this.groupBoxInvaders.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelAantalSteden
            // 
            this.labelAantalSteden.AutoSize = true;
            this.labelAantalSteden.Location = new System.Drawing.Point(15, 53);
            this.labelAantalSteden.Name = "labelAantalSteden";
            this.labelAantalSteden.Size = new System.Drawing.Size(97, 17);
            this.labelAantalSteden.TabIndex = 0;
            this.labelAantalSteden.Text = "Aantal Steden";
            // 
            // labelInvaderLevens
            // 
            this.labelInvaderLevens.AutoSize = true;
            this.labelInvaderLevens.Location = new System.Drawing.Point(15, 83);
            this.labelInvaderLevens.Name = "labelInvaderLevens";
            this.labelInvaderLevens.Size = new System.Drawing.Size(101, 17);
            this.labelInvaderLevens.TabIndex = 1;
            this.labelInvaderLevens.Text = "Invader-levens";
            // 
            // groupBoxInstellingen
            // 
            this.groupBoxInstellingen.Controls.Add(this.numericUpDownInvaderSnelheid);
            this.groupBoxInstellingen.Controls.Add(this.numericUpDownInvaderLevens);
            this.groupBoxInstellingen.Controls.Add(this.numericUpDownAantalSteden);
            this.groupBoxInstellingen.Controls.Add(this.buttonStart);
            this.groupBoxInstellingen.Controls.Add(this.labelInvaderSnelheid);
            this.groupBoxInstellingen.Controls.Add(this.labelAantalSteden);
            this.groupBoxInstellingen.Controls.Add(this.labelInvaderLevens);
            this.groupBoxInstellingen.Location = new System.Drawing.Point(709, 40);
            this.groupBoxInstellingen.Name = "groupBoxInstellingen";
            this.groupBoxInstellingen.Size = new System.Drawing.Size(380, 177);
            this.groupBoxInstellingen.TabIndex = 2;
            this.groupBoxInstellingen.TabStop = false;
            this.groupBoxInstellingen.Text = "Instellingen";
            // 
            // numericUpDownInvaderSnelheid
            // 
            this.numericUpDownInvaderSnelheid.Location = new System.Drawing.Point(155, 111);
            this.numericUpDownInvaderSnelheid.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownInvaderSnelheid.Name = "numericUpDownInvaderSnelheid";
            this.numericUpDownInvaderSnelheid.Size = new System.Drawing.Size(69, 22);
            this.numericUpDownInvaderSnelheid.TabIndex = 6;
            this.numericUpDownInvaderSnelheid.Value = new decimal(new int[] {
            15,
            0,
            0,
            0});
            // 
            // numericUpDownInvaderLevens
            // 
            this.numericUpDownInvaderLevens.Location = new System.Drawing.Point(155, 81);
            this.numericUpDownInvaderLevens.Name = "numericUpDownInvaderLevens";
            this.numericUpDownInvaderLevens.Size = new System.Drawing.Size(69, 22);
            this.numericUpDownInvaderLevens.TabIndex = 5;
            this.numericUpDownInvaderLevens.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // numericUpDownAantalSteden
            // 
            this.numericUpDownAantalSteden.Location = new System.Drawing.Point(156, 51);
            this.numericUpDownAantalSteden.Name = "numericUpDownAantalSteden";
            this.numericUpDownAantalSteden.Size = new System.Drawing.Size(69, 22);
            this.numericUpDownAantalSteden.TabIndex = 4;
            this.numericUpDownAantalSteden.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(263, 51);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(99, 83);
            this.buttonStart.TabIndex = 3;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // labelInvaderSnelheid
            // 
            this.labelInvaderSnelheid.AutoSize = true;
            this.labelInvaderSnelheid.Location = new System.Drawing.Point(15, 113);
            this.labelInvaderSnelheid.Name = "labelInvaderSnelheid";
            this.labelInvaderSnelheid.Size = new System.Drawing.Size(113, 17);
            this.labelInvaderSnelheid.TabIndex = 2;
            this.labelInvaderSnelheid.Text = "Invader-snelheid";
            // 
            // groupBoxSpelStatus
            // 
            this.groupBoxSpelStatus.Controls.Add(this.labelAantalStedenValue);
            this.groupBoxSpelStatus.Controls.Add(this.labelAantalInvadersValue);
            this.groupBoxSpelStatus.Controls.Add(this.labelAantalStedenSpelstatus);
            this.groupBoxSpelStatus.Controls.Add(this.labelAantalInvaders);
            this.groupBoxSpelStatus.Location = new System.Drawing.Point(709, 259);
            this.groupBoxSpelStatus.Name = "groupBoxSpelStatus";
            this.groupBoxSpelStatus.Size = new System.Drawing.Size(380, 154);
            this.groupBoxSpelStatus.TabIndex = 3;
            this.groupBoxSpelStatus.TabStop = false;
            this.groupBoxSpelStatus.Text = "Spelstatus";
            // 
            // labelAantalStedenValue
            // 
            this.labelAantalStedenValue.AutoSize = true;
            this.labelAantalStedenValue.Location = new System.Drawing.Point(179, 88);
            this.labelAantalStedenValue.Name = "labelAantalStedenValue";
            this.labelAantalStedenValue.Size = new System.Drawing.Size(16, 17);
            this.labelAantalStedenValue.TabIndex = 3;
            this.labelAantalStedenValue.Text = "1";
            // 
            // labelAantalInvadersValue
            // 
            this.labelAantalInvadersValue.AutoSize = true;
            this.labelAantalInvadersValue.Location = new System.Drawing.Point(179, 46);
            this.labelAantalInvadersValue.Name = "labelAantalInvadersValue";
            this.labelAantalInvadersValue.Size = new System.Drawing.Size(16, 17);
            this.labelAantalInvadersValue.TabIndex = 2;
            this.labelAantalInvadersValue.Text = "6";
            // 
            // labelAantalStedenSpelstatus
            // 
            this.labelAantalStedenSpelstatus.AutoSize = true;
            this.labelAantalStedenSpelstatus.Location = new System.Drawing.Point(15, 88);
            this.labelAantalStedenSpelstatus.Name = "labelAantalStedenSpelstatus";
            this.labelAantalStedenSpelstatus.Size = new System.Drawing.Size(101, 17);
            this.labelAantalStedenSpelstatus.TabIndex = 1;
            this.labelAantalStedenSpelstatus.Text = "Aantal Steden:";
            // 
            // labelAantalInvaders
            // 
            this.labelAantalInvaders.AutoSize = true;
            this.labelAantalInvaders.Location = new System.Drawing.Point(15, 46);
            this.labelAantalInvaders.Name = "labelAantalInvaders";
            this.labelAantalInvaders.Size = new System.Drawing.Size(110, 17);
            this.labelAantalInvaders.TabIndex = 0;
            this.labelAantalInvaders.Text = "Aantal Invaders:";
            // 
            // groupBoxInvaders
            // 
            this.groupBoxInvaders.Controls.Add(this.pictureBox6);
            this.groupBoxInvaders.Controls.Add(this.pictureBox5);
            this.groupBoxInvaders.Controls.Add(this.pictureBox4);
            this.groupBoxInvaders.Controls.Add(this.pictureBox3);
            this.groupBoxInvaders.Controls.Add(this.pictureBox2);
            this.groupBoxInvaders.Controls.Add(this.pictureBox1);
            this.groupBoxInvaders.Location = new System.Drawing.Point(30, 29);
            this.groupBoxInvaders.Name = "groupBoxInvaders";
            this.groupBoxInvaders.Size = new System.Drawing.Size(651, 399);
            this.groupBoxInvaders.TabIndex = 10;
            this.groupBoxInvaders.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(573, 11);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(59, 50);
            this.pictureBox6.TabIndex = 5;
            this.pictureBox6.TabStop = false;
            this.pictureBox6.Click += new System.EventHandler(this.pictureBox6_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(461, 11);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(69, 50);
            this.pictureBox5.TabIndex = 4;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Click += new System.EventHandler(this.pictureBox5_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(354, 11);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(65, 50);
            this.pictureBox4.TabIndex = 3;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(240, 11);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(65, 50);
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(126, 11);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(65, 50);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(6, 11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(67, 50);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Invaders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1152, 448);
            this.Controls.Add(this.groupBoxInvaders);
            this.Controls.Add(this.groupBoxSpelStatus);
            this.Controls.Add(this.groupBoxInstellingen);
            this.Name = "Invaders";
            this.Text = "Invaders";
            this.Load += new System.EventHandler(this.Invaders_Load);
            this.groupBoxInstellingen.ResumeLayout(false);
            this.groupBoxInstellingen.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownInvaderSnelheid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownInvaderLevens)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAantalSteden)).EndInit();
            this.groupBoxSpelStatus.ResumeLayout(false);
            this.groupBoxSpelStatus.PerformLayout();
            this.groupBoxInvaders.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelAantalSteden;
        private System.Windows.Forms.Label labelInvaderLevens;
        private System.Windows.Forms.GroupBox groupBoxInstellingen;
        private System.Windows.Forms.NumericUpDown numericUpDownInvaderSnelheid;
        private System.Windows.Forms.NumericUpDown numericUpDownInvaderLevens;
        private System.Windows.Forms.NumericUpDown numericUpDownAantalSteden;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Label labelInvaderSnelheid;
        private System.Windows.Forms.GroupBox groupBoxSpelStatus;
        private System.Windows.Forms.Label labelAantalStedenValue;
        private System.Windows.Forms.Label labelAantalInvadersValue;
        private System.Windows.Forms.Label labelAantalStedenSpelstatus;
        private System.Windows.Forms.Label labelAantalInvaders;
        private System.Windows.Forms.GroupBox groupBoxInvaders;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
    }
}

