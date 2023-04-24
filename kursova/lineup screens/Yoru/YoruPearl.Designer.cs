namespace kursova.lineup_screens.Yoru
{
    partial class YoruPearl
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
            this.FadeAscBBut = new System.Windows.Forms.Button();
            this.FadeAscBLab = new System.Windows.Forms.Label();
            this.FadeAscABut = new System.Windows.Forms.Button();
            this.FadeAscALab = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.close_icon = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // FadeAscBBut
            // 
            this.FadeAscBBut.BackColor = System.Drawing.Color.Black;
            this.FadeAscBBut.Font = new System.Drawing.Font("Impact", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FadeAscBBut.ForeColor = System.Drawing.Color.White;
            this.FadeAscBBut.Location = new System.Drawing.Point(519, 266);
            this.FadeAscBBut.Name = "FadeAscBBut";
            this.FadeAscBBut.Size = new System.Drawing.Size(184, 42);
            this.FadeAscBBut.TabIndex = 28;
            this.FadeAscBBut.Text = "Перейти";
            this.FadeAscBBut.UseVisualStyleBackColor = false;
            this.FadeAscBBut.Click += new System.EventHandler(this.FadeAscBBut_Click);
            // 
            // FadeAscBLab
            // 
            this.FadeAscBLab.BackColor = System.Drawing.Color.Black;
            this.FadeAscBLab.Cursor = System.Windows.Forms.Cursors.Default;
            this.FadeAscBLab.Font = new System.Drawing.Font("Impact", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FadeAscBLab.ForeColor = System.Drawing.Color.White;
            this.FadeAscBLab.Location = new System.Drawing.Point(521, 138);
            this.FadeAscBLab.Name = "FadeAscBLab";
            this.FadeAscBLab.Size = new System.Drawing.Size(182, 125);
            this.FadeAscBLab.TabIndex = 27;
            this.FadeAscBLab.Text = "Точка Б";
            this.FadeAscBLab.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.FadeAscBLab.Click += new System.EventHandler(this.FadeAscBLab_Click);
            // 
            // FadeAscABut
            // 
            this.FadeAscABut.BackColor = System.Drawing.Color.Black;
            this.FadeAscABut.Font = new System.Drawing.Font("Impact", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FadeAscABut.ForeColor = System.Drawing.Color.White;
            this.FadeAscABut.Location = new System.Drawing.Point(131, 266);
            this.FadeAscABut.Name = "FadeAscABut";
            this.FadeAscABut.Size = new System.Drawing.Size(184, 42);
            this.FadeAscABut.TabIndex = 26;
            this.FadeAscABut.Text = "Перейти";
            this.FadeAscABut.UseVisualStyleBackColor = false;
            this.FadeAscABut.Click += new System.EventHandler(this.FadeAscABut_Click);
            // 
            // FadeAscALab
            // 
            this.FadeAscALab.BackColor = System.Drawing.Color.Black;
            this.FadeAscALab.Cursor = System.Windows.Forms.Cursors.Default;
            this.FadeAscALab.Font = new System.Drawing.Font("Impact", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FadeAscALab.ForeColor = System.Drawing.Color.White;
            this.FadeAscALab.Location = new System.Drawing.Point(133, 138);
            this.FadeAscALab.Name = "FadeAscALab";
            this.FadeAscALab.Size = new System.Drawing.Size(182, 125);
            this.FadeAscALab.TabIndex = 25;
            this.FadeAscALab.Text = "Точка А";
            this.FadeAscALab.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.FadeAscALab.Click += new System.EventHandler(this.FadeAscALab_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Gray;
            this.label2.Image = global::kursova.Properties.Resources.peral_map;
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
            this.close_icon.Location = new System.Drawing.Point(777, -2);
            this.close_icon.Name = "close_icon";
            this.close_icon.Size = new System.Drawing.Size(25, 25);
            this.close_icon.TabIndex = 35;
            this.close_icon.Text = "X";
            this.close_icon.Click += new System.EventHandler(this.close_icon_Click);
            // 
            // YoruPearl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::kursova.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.close_icon);
            this.Controls.Add(this.FadeAscBBut);
            this.Controls.Add(this.FadeAscBLab);
            this.Controls.Add(this.FadeAscABut);
            this.Controls.Add(this.FadeAscALab);
            this.Controls.Add(this.label2);
            this.Name = "YoruPearl";
            this.Text = "YoruPearl";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button FadeAscBBut;
        private System.Windows.Forms.Label FadeAscBLab;
        private System.Windows.Forms.Button FadeAscABut;
        private System.Windows.Forms.Label FadeAscALab;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label close_icon;
    }
}