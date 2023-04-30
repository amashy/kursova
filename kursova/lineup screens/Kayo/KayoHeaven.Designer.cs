namespace kursova.lineup_screens.Kayo
{
    partial class KayoHeaven
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
            this.label2 = new System.Windows.Forms.Label();
            this.close_icon = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.KayoHeavenCLab = new System.Windows.Forms.Label();
            this.KayoHeavenCBut = new System.Windows.Forms.Button();
            this.back_arrow = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.back_arrow)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Gray;
            this.label2.Image = global::kursova.Properties.Resources.heaven_map;
            this.label2.Location = new System.Drawing.Point(-1, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(803, 253);
            this.label2.TabIndex = 29;
            // 
            // close_icon
            // 
            this.close_icon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(67)))), ((int)(((byte)(87)))));
            this.close_icon.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.close_icon.ForeColor = System.Drawing.Color.Black;
            this.close_icon.Location = new System.Drawing.Point(777, -1);
            this.close_icon.Name = "close_icon";
            this.close_icon.Size = new System.Drawing.Size(25, 25);
            this.close_icon.TabIndex = 30;
            this.close_icon.Text = "X";
            this.close_icon.Click += new System.EventHandler(this.close_icon_Click);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Black;
            this.label3.Cursor = System.Windows.Forms.Cursors.Default;
            this.label3.Font = new System.Drawing.Font("Impact", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(46, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(182, 125);
            this.label3.TabIndex = 25;
            this.label3.Text = "Точка А ";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label3.Click += new System.EventHandler(this.KayoHeavenALab_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Black;
            this.button2.Font = new System.Drawing.Font("Impact", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(44, 266);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(184, 42);
            this.button2.TabIndex = 26;
            this.button2.Text = "Перейти";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.KayoHeavenABut_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Cursor = System.Windows.Forms.Cursors.Default;
            this.label1.Font = new System.Drawing.Font("Impact", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(311, 138);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 125);
            this.label1.TabIndex = 27;
            this.label1.Text = "Точка Б";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.Font = new System.Drawing.Font("Impact", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(309, 266);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(184, 42);
            this.button1.TabIndex = 28;
            this.button1.Text = "Перейти";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // KayoHeavenCLab
            // 
            this.KayoHeavenCLab.BackColor = System.Drawing.Color.Black;
            this.KayoHeavenCLab.Cursor = System.Windows.Forms.Cursors.Default;
            this.KayoHeavenCLab.Font = new System.Drawing.Font("Impact", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KayoHeavenCLab.ForeColor = System.Drawing.Color.White;
            this.KayoHeavenCLab.Location = new System.Drawing.Point(570, 138);
            this.KayoHeavenCLab.Name = "KayoHeavenCLab";
            this.KayoHeavenCLab.Size = new System.Drawing.Size(182, 125);
            this.KayoHeavenCLab.TabIndex = 31;
            this.KayoHeavenCLab.Text = "Точка C";
            this.KayoHeavenCLab.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.KayoHeavenCLab.Click += new System.EventHandler(this.KayoHeavenCLab_Click);
            // 
            // KayoHeavenCBut
            // 
            this.KayoHeavenCBut.BackColor = System.Drawing.Color.Black;
            this.KayoHeavenCBut.Font = new System.Drawing.Font("Impact", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.KayoHeavenCBut.ForeColor = System.Drawing.Color.White;
            this.KayoHeavenCBut.Location = new System.Drawing.Point(568, 266);
            this.KayoHeavenCBut.Name = "KayoHeavenCBut";
            this.KayoHeavenCBut.Size = new System.Drawing.Size(184, 42);
            this.KayoHeavenCBut.TabIndex = 32;
            this.KayoHeavenCBut.Text = "Перейти";
            this.KayoHeavenCBut.UseVisualStyleBackColor = false;
            this.KayoHeavenCBut.Click += new System.EventHandler(this.KayoHeavenCBut_Click);
            // 
            // back_arrow
            // 
            this.back_arrow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(67)))), ((int)(((byte)(87)))));
            this.back_arrow.BackgroundImage = global::kursova.Properties.Resources.back_arrow;
            this.back_arrow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.back_arrow.Location = new System.Drawing.Point(2, 0);
            this.back_arrow.Name = "back_arrow";
            this.back_arrow.Size = new System.Drawing.Size(75, 56);
            this.back_arrow.TabIndex = 34;
            this.back_arrow.TabStop = false;
            this.back_arrow.Click += new System.EventHandler(this.back_arrow_Click);
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(67)))), ((int)(((byte)(87)))));
            this.label4.Dock = System.Windows.Forms.DockStyle.Top;
            this.label4.Font = new System.Drawing.Font("Impact", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(800, 56);
            this.label4.TabIndex = 33;
            this.label4.Text = "Оберіть точку";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // KayoHeaven
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::kursova.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.KayoHeavenCBut);
            this.Controls.Add(this.KayoHeavenCLab);
            this.Controls.Add(this.close_icon);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.back_arrow);
            this.Controls.Add(this.label4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "KayoHeaven";
            this.Text = "KayoHeaven";
            ((System.ComponentModel.ISupportInitialize)(this.back_arrow)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label close_icon;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label KayoHeavenCLab;
        private System.Windows.Forms.Button KayoHeavenCBut;
        private System.Windows.Forms.PictureBox back_arrow;
        private System.Windows.Forms.Label label4;
    }
}