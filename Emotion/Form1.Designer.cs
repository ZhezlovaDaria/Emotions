namespace Emotion
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.imageBox1 = new Emgu.CV.UI.ImageBox();
            this.timerOb = new System.Windows.Forms.Timer(this.components);
            this.NeturalT = new System.Windows.Forms.Timer(this.components);
            this.HappyT = new System.Windows.Forms.Timer(this.components);
            this.SadT = new System.Windows.Forms.Timer(this.components);
            this.WinkT = new System.Windows.Forms.Timer(this.components);
            this.SleepT = new System.Windows.Forms.Timer(this.components);
            this.NetPB = new System.Windows.Forms.PictureBox();
            this.HapPB = new System.Windows.Forms.PictureBox();
            this.SadPB = new System.Windows.Forms.PictureBox();
            this.WinkPB = new System.Windows.Forms.PictureBox();
            this.SleepPB = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Strelka = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NetPB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HapPB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SadPB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WinkPB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SleepPB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Strelka)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(267, 498);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 55);
            this.button1.TabIndex = 0;
            this.button1.Text = "Start";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // imageBox1
            // 
            this.imageBox1.Location = new System.Drawing.Point(12, 12);
            this.imageBox1.Name = "imageBox1";
            this.imageBox1.Size = new System.Drawing.Size(640, 480);
            this.imageBox1.TabIndex = 2;
            this.imageBox1.TabStop = false;
            // 
            // timerOb
            // 
            this.timerOb.Interval = 1000;
            this.timerOb.Tick += new System.EventHandler(this.timerOb_Tick);
            // 
            // NeturalT
            // 
            this.NeturalT.Interval = 900;
            this.NeturalT.Tick += new System.EventHandler(this.NeturalT_Tick);
            // 
            // HappyT
            // 
            this.HappyT.Interval = 900;
            this.HappyT.Tick += new System.EventHandler(this.HappyT_Tick);
            // 
            // SadT
            // 
            this.SadT.Interval = 900;
            this.SadT.Tick += new System.EventHandler(this.SadT_Tick);
            // 
            // WinkT
            // 
            this.WinkT.Interval = 900;
            this.WinkT.Tick += new System.EventHandler(this.WinkT_Tick);
            // 
            // SleepT
            // 
            this.SleepT.Interval = 900;
            this.SleepT.Tick += new System.EventHandler(this.SleepT_Tick);
            // 
            // NetPB
            // 
            this.NetPB.Image = ((System.Drawing.Image)(resources.GetObject("NetPB.Image")));
            this.NetPB.Location = new System.Drawing.Point(659, 12);
            this.NetPB.Name = "NetPB";
            this.NetPB.Size = new System.Drawing.Size(65, 65);
            this.NetPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.NetPB.TabIndex = 3;
            this.NetPB.TabStop = false;
            // 
            // HapPB
            // 
            this.HapPB.Image = ((System.Drawing.Image)(resources.GetObject("HapPB.Image")));
            this.HapPB.Location = new System.Drawing.Point(753, 12);
            this.HapPB.Name = "HapPB";
            this.HapPB.Size = new System.Drawing.Size(65, 65);
            this.HapPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.HapPB.TabIndex = 4;
            this.HapPB.TabStop = false;
            // 
            // SadPB
            // 
            this.SadPB.Image = ((System.Drawing.Image)(resources.GetObject("SadPB.Image")));
            this.SadPB.Location = new System.Drawing.Point(659, 107);
            this.SadPB.Name = "SadPB";
            this.SadPB.Size = new System.Drawing.Size(65, 65);
            this.SadPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.SadPB.TabIndex = 5;
            this.SadPB.TabStop = false;
            // 
            // WinkPB
            // 
            this.WinkPB.Image = ((System.Drawing.Image)(resources.GetObject("WinkPB.Image")));
            this.WinkPB.Location = new System.Drawing.Point(753, 107);
            this.WinkPB.Name = "WinkPB";
            this.WinkPB.Size = new System.Drawing.Size(65, 65);
            this.WinkPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.WinkPB.TabIndex = 6;
            this.WinkPB.TabStop = false;
            // 
            // SleepPB
            // 
            this.SleepPB.Image = ((System.Drawing.Image)(resources.GetObject("SleepPB.Image")));
            this.SleepPB.Location = new System.Drawing.Point(659, 201);
            this.SleepPB.Name = "SleepPB";
            this.SleepPB.Size = new System.Drawing.Size(65, 65);
            this.SleepPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.SleepPB.TabIndex = 7;
            this.SleepPB.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(682, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(778, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(682, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(13, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(778, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(13, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(682, 269);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(13, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(778, 242);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(13, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(741, 218);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Общее время:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(658, 285);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(53, 268);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // Strelka
            // 
            this.Strelka.BackColor = System.Drawing.Color.Transparent;
            this.Strelka.Image = ((System.Drawing.Image)(resources.GetObject("Strelka.Image")));
            this.Strelka.Location = new System.Drawing.Point(717, 394);
            this.Strelka.Name = "Strelka";
            this.Strelka.Size = new System.Drawing.Size(62, 50);
            this.Strelka.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Strelka.TabIndex = 16;
            this.Strelka.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(830, 561);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Strelka);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SleepPB);
            this.Controls.Add(this.WinkPB);
            this.Controls.Add(this.SadPB);
            this.Controls.Add(this.HapPB);
            this.Controls.Add(this.NetPB);
            this.Controls.Add(this.imageBox1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.imageBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NetPB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HapPB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SadPB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WinkPB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SleepPB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Strelka)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private Emgu.CV.UI.ImageBox imageBox1;
        private System.Windows.Forms.Timer timerOb;
        private System.Windows.Forms.Timer NeturalT;
        private System.Windows.Forms.Timer HappyT;
        private System.Windows.Forms.Timer SadT;
        private System.Windows.Forms.Timer WinkT;
        private System.Windows.Forms.Timer SleepT;
        private System.Windows.Forms.PictureBox NetPB;
        private System.Windows.Forms.PictureBox HapPB;
        private System.Windows.Forms.PictureBox SadPB;
        private System.Windows.Forms.PictureBox WinkPB;
        private System.Windows.Forms.PictureBox SleepPB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox Strelka;
    }
}

