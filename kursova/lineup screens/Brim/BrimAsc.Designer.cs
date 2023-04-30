namespace kursova
{
    partial class BrimAsc
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
            this.BrimAscBBut = new System.Windows.Forms.Button();
            this.BrimAscBLab = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.BrimAscA = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.close_icon = new System.Windows.Forms.Label();
            this.back_arrow = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.back_arrow)).BeginInit();
            this.SuspendLayout();
            // 
            // BrimAscBBut
            // 
            this.BrimAscBBut.BackColor = System.Drawing.Color.Black;
            this.BrimAscBBut.Font = new System.Drawing.Font("Impact", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BrimAscBBut.ForeColor = System.Drawing.Color.White;
            this.BrimAscBBut.Location = new System.Drawing.Point(517, 258);
            this.BrimAscBBut.Name = "BrimAscBBut";
            this.BrimAscBBut.Size = new System.Drawing.Size(184, 42);
            this.BrimAscBBut.TabIndex = 11;
            this.BrimAscBBut.Text = "Перейти";
            this.BrimAscBBut.UseVisualStyleBackColor = false;
            this.BrimAscBBut.Click += new System.EventHandler(this.BrimAscBBut_Click);
            // 
            // BrimAscBLab
            // 
            this.BrimAscBLab.BackColor = System.Drawing.Color.Black;
            this.BrimAscBLab.Cursor = System.Windows.Forms.Cursors.Default;
            this.BrimAscBLab.Font = new System.Drawing.Font("Impact", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BrimAscBLab.ForeColor = System.Drawing.Color.White;
            this.BrimAscBLab.Location = new System.Drawing.Point(519, 130);
            this.BrimAscBLab.Name = "BrimAscBLab";
            this.BrimAscBLab.Size = new System.Drawing.Size(182, 125);
            this.BrimAscBLab.TabIndex = 10;
            this.BrimAscBLab.Text = "Точка Б";
            this.BrimAscBLab.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BrimAscBLab.Click += new System.EventHandler(this.BrimAscBLab_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.Font = new System.Drawing.Font("Impact", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(129, 258);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(184, 42);
            this.button1.TabIndex = 9;
            this.button1.Text = "Перейти";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // BrimAscA
            // 
            this.BrimAscA.BackColor = System.Drawing.Color.Black;
            this.BrimAscA.Cursor = System.Windows.Forms.Cursors.Default;
            this.BrimAscA.Font = new System.Drawing.Font("Impact", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BrimAscA.ForeColor = System.Drawing.Color.White;
            this.BrimAscA.Location = new System.Drawing.Point(131, 130);
            this.BrimAscA.Name = "BrimAscA";
            this.BrimAscA.Size = new System.Drawing.Size(182, 125);
            this.BrimAscA.TabIndex = 8;
            this.BrimAscA.Text = "Точка А";
            this.BrimAscA.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BrimAscA.Click += new System.EventHandler(this.BrimAscA_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Gray;
            this.label2.Image = global::kursova.Properties.Resources.ascent_map;
            this.label2.Location = new System.Drawing.Point(-3, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(803, 253);
            this.label2.TabIndex = 14;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // close_icon
            // 
            this.close_icon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(67)))), ((int)(((byte)(87)))));
            this.close_icon.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.close_icon.ForeColor = System.Drawing.Color.Black;
            this.close_icon.Location = new System.Drawing.Point(775, -1);
            this.close_icon.Name = "close_icon";
            this.close_icon.Size = new System.Drawing.Size(25, 25);
            this.close_icon.TabIndex = 15;
            this.close_icon.Text = "X";
            this.close_icon.Click += new System.EventHandler(this.close_icon_Click);
            // 
            // back_arrow
            // 
            this.back_arrow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(67)))), ((int)(((byte)(87)))));
            this.back_arrow.BackgroundImage = global::kursova.Properties.Resources.back_arrow;
            this.back_arrow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.back_arrow.Location = new System.Drawing.Point(0, 0);
            this.back_arrow.Name = "back_arrow";
            this.back_arrow.Size = new System.Drawing.Size(75, 56);
            this.back_arrow.TabIndex = 19;
            this.back_arrow.TabStop = false;
            this.back_arrow.WaitOnLoad = true;
            this.back_arrow.Click += new System.EventHandler(this.back_arrow_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(67)))), ((int)(((byte)(87)))));
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Impact", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(798, 56);
            this.label1.TabIndex = 18;
            this.label1.Text = "Оберіть точку";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BrimAsc
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackgroundImage = global::kursova.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(798, 418);
            this.Controls.Add(this.close_icon);
            this.Controls.Add(this.BrimAscBBut);
            this.Controls.Add(this.BrimAscBLab);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BrimAscA);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.back_arrow);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BrimAsc";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "BrimAsc";
            ((System.ComponentModel.ISupportInitialize)(this.back_arrow)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BrimAscBBut;
        private System.Windows.Forms.Label BrimAscBLab;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label BrimAscA;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label close_icon;
        private System.Windows.Forms.PictureBox back_arrow;
        private System.Windows.Forms.Label label1;
    }
}