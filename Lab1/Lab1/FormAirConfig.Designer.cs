namespace Lab1
{
    partial class FormAirConfig
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
            this.pictureBoxAir = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelAirBus = new System.Windows.Forms.Label();
            this.labelAir = new System.Windows.Forms.Label();
            this.panelAir = new System.Windows.Forms.Panel();
            this.labelDopColor = new System.Windows.Forms.Label();
            this.labelBaseColor = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panelOrange = new System.Windows.Forms.Panel();
            this.panelGray = new System.Windows.Forms.Panel();
            this.panelYellow = new System.Windows.Forms.Panel();
            this.panelRed = new System.Windows.Forms.Panel();
            this.panelBlue = new System.Windows.Forms.Panel();
            this.panelGreen = new System.Windows.Forms.Panel();
            this.panelWhite = new System.Windows.Forms.Panel();
            this.panelBlack = new System.Windows.Forms.Panel();
            this.buttonAddAir = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAir)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panelAir.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBoxAir
            // 
            this.pictureBoxAir.Location = new System.Drawing.Point(48, 27);
            this.pictureBoxAir.Name = "pictureBoxAir";
            this.pictureBoxAir.Size = new System.Drawing.Size(215, 179);
            this.pictureBoxAir.TabIndex = 0;
            this.pictureBoxAir.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelAirBus);
            this.groupBox1.Controls.Add(this.labelAir);
            this.groupBox1.Location = new System.Drawing.Point(63, 39);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(196, 179);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Тип корпуса";
            // 
            // labelAirBus
            // 
            this.labelAirBus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelAirBus.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelAirBus.Location = new System.Drawing.Point(18, 106);
            this.labelAirBus.Name = "labelAirBus";
            this.labelAirBus.Size = new System.Drawing.Size(165, 48);
            this.labelAirBus.TabIndex = 1;
            this.labelAirBus.Text = "Аэробус";
            this.labelAirBus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelAirBus.MouseDown += new System.Windows.Forms.MouseEventHandler(this.labelAirBus_MouseDown);
            // 
            // labelAir
            // 
            this.labelAir.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelAir.Location = new System.Drawing.Point(18, 37);
            this.labelAir.Name = "labelAir";
            this.labelAir.Size = new System.Drawing.Size(165, 45);
            this.labelAir.TabIndex = 0;
            this.labelAir.Text = "Обычный самолёт";
            this.labelAir.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelAir.MouseDown += new System.Windows.Forms.MouseEventHandler(this.labelAir_MouseDown);
            // 
            // panelAir
            // 
            this.panelAir.AllowDrop = true;
            this.panelAir.Controls.Add(this.labelDopColor);
            this.panelAir.Controls.Add(this.labelBaseColor);
            this.panelAir.Controls.Add(this.pictureBoxAir);
            this.panelAir.Location = new System.Drawing.Point(295, 39);
            this.panelAir.Name = "panelAir";
            this.panelAir.Size = new System.Drawing.Size(315, 336);
            this.panelAir.TabIndex = 2;
            this.panelAir.DragDrop += new System.Windows.Forms.DragEventHandler(this.panelAir_DragDrop);
            this.panelAir.DragEnter += new System.Windows.Forms.DragEventHandler(this.panelAir_DragEnter);
            // 
            // labelDopColor
            // 
            this.labelDopColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelDopColor.Location = new System.Drawing.Point(48, 271);
            this.labelDopColor.Name = "labelDopColor";
            this.labelDopColor.Size = new System.Drawing.Size(215, 50);
            this.labelDopColor.TabIndex = 2;
            this.labelDopColor.Text = "Доп.цвет";
            this.labelDopColor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelDopColor.DragDrop += new System.Windows.Forms.DragEventHandler(this.labelDopColor_DragDrop);
            // 
            // labelBaseColor
            // 
            this.labelBaseColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelBaseColor.Location = new System.Drawing.Point(48, 209);
            this.labelBaseColor.Name = "labelBaseColor";
            this.labelBaseColor.Size = new System.Drawing.Size(215, 47);
            this.labelBaseColor.TabIndex = 1;
            this.labelBaseColor.Text = "Основной цвет";
            this.labelBaseColor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelBaseColor.DragDrop += new System.Windows.Forms.DragEventHandler(this.labelBaseColor_DragDrop);
            this.labelBaseColor.DragEnter += new System.Windows.Forms.DragEventHandler(this.labelBaseColor_DragEnter);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.panelOrange);
            this.groupBox2.Controls.Add(this.panelGray);
            this.groupBox2.Controls.Add(this.panelYellow);
            this.groupBox2.Controls.Add(this.panelRed);
            this.groupBox2.Controls.Add(this.panelBlue);
            this.groupBox2.Controls.Add(this.panelGreen);
            this.groupBox2.Controls.Add(this.panelWhite);
            this.groupBox2.Controls.Add(this.panelBlack);
            this.groupBox2.Location = new System.Drawing.Point(635, 113);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(134, 203);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Цвета";
            // 
            // panelOrange
            // 
            this.panelOrange.BackColor = System.Drawing.Color.Orange;
            this.panelOrange.Location = new System.Drawing.Point(80, 160);
            this.panelOrange.Name = "panelOrange";
            this.panelOrange.Size = new System.Drawing.Size(37, 27);
            this.panelOrange.TabIndex = 4;
            this.panelOrange.Paint += new System.Windows.Forms.PaintEventHandler(this.panel8_Paint);
            // 
            // panelGray
            // 
            this.panelGray.BackColor = System.Drawing.Color.Gray;
            this.panelGray.Location = new System.Drawing.Point(16, 160);
            this.panelGray.Name = "panelGray";
            this.panelGray.Size = new System.Drawing.Size(38, 27);
            this.panelGray.TabIndex = 3;
            this.panelGray.Paint += new System.Windows.Forms.PaintEventHandler(this.panel7_Paint);
            // 
            // panelYellow
            // 
            this.panelYellow.BackColor = System.Drawing.Color.Yellow;
            this.panelYellow.Location = new System.Drawing.Point(80, 118);
            this.panelYellow.Name = "panelYellow";
            this.panelYellow.Size = new System.Drawing.Size(37, 32);
            this.panelYellow.TabIndex = 2;
            this.panelYellow.Paint += new System.Windows.Forms.PaintEventHandler(this.panel6_Paint);
            // 
            // panelRed
            // 
            this.panelRed.BackColor = System.Drawing.Color.Red;
            this.panelRed.Location = new System.Drawing.Point(16, 118);
            this.panelRed.Name = "panelRed";
            this.panelRed.Size = new System.Drawing.Size(38, 30);
            this.panelRed.TabIndex = 1;
            this.panelRed.Paint += new System.Windows.Forms.PaintEventHandler(this.panel5_Paint);
            // 
            // panelBlue
            // 
            this.panelBlue.BackColor = System.Drawing.Color.Blue;
            this.panelBlue.Location = new System.Drawing.Point(80, 73);
            this.panelBlue.Name = "panelBlue";
            this.panelBlue.Size = new System.Drawing.Size(37, 30);
            this.panelBlue.TabIndex = 1;
            this.panelBlue.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // panelGreen
            // 
            this.panelGreen.BackColor = System.Drawing.Color.Green;
            this.panelGreen.Location = new System.Drawing.Point(16, 73);
            this.panelGreen.Name = "panelGreen";
            this.panelGreen.Size = new System.Drawing.Size(38, 30);
            this.panelGreen.TabIndex = 1;
            this.panelGreen.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // panelWhite
            // 
            this.panelWhite.BackColor = System.Drawing.Color.White;
            this.panelWhite.Location = new System.Drawing.Point(80, 32);
            this.panelWhite.Name = "panelWhite";
            this.panelWhite.Size = new System.Drawing.Size(37, 30);
            this.panelWhite.TabIndex = 1;
            this.panelWhite.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // panelBlack
            // 
            this.panelBlack.BackColor = System.Drawing.Color.Black;
            this.panelBlack.Location = new System.Drawing.Point(16, 32);
            this.panelBlack.Name = "panelBlack";
            this.panelBlack.Size = new System.Drawing.Size(38, 30);
            this.panelBlack.TabIndex = 0;
            this.panelBlack.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // buttonAddAir
            // 
            this.buttonAddAir.Location = new System.Drawing.Point(89, 256);
            this.buttonAddAir.Name = "buttonAddAir";
            this.buttonAddAir.Size = new System.Drawing.Size(118, 44);
            this.buttonAddAir.TabIndex = 4;
            this.buttonAddAir.Text = "Добавить";
            this.buttonAddAir.UseVisualStyleBackColor = true;
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(89, 330);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(118, 44);
            this.buttonCancel.TabIndex = 5;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // FormAirConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonAddAir);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.panelAir);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormAirConfig";
            this.Text = "FormAirConfig";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAir)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.panelAir.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxAir;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelAirBus;
        private System.Windows.Forms.Label labelAir;
        private System.Windows.Forms.Panel panelAir;
        private System.Windows.Forms.Label labelDopColor;
        private System.Windows.Forms.Label labelBaseColor;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Panel panelOrange;
        private System.Windows.Forms.Panel panelGray;
        private System.Windows.Forms.Panel panelYellow;
        private System.Windows.Forms.Panel panelRed;
        private System.Windows.Forms.Panel panelBlue;
        private System.Windows.Forms.Panel panelGreen;
        private System.Windows.Forms.Panel panelWhite;
        private System.Windows.Forms.Panel panelBlack;
        private System.Windows.Forms.Button buttonAddAir;
        private System.Windows.Forms.Button buttonCancel;
    }
}