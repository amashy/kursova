﻿namespace kursova.lineup_screens.Cypher
{
    partial class CypherIceb
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.close_icon = new System.Windows.Forms.Label();
            this.back_arrow = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.back_arrow)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Gray;
            this.label1.Font = new System.Drawing.Font("Impact", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(-1, 153);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(803, 126);
            this.label1.TabIndex = 34;
            this.label1.Text = "Інформація відсутня";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Gray;
            this.label2.Image = global::kursova.Properties.Resources.icebox_map;
            this.label2.Location = new System.Drawing.Point(-1, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(803, 253);
            this.label2.TabIndex = 33;
            // 
            // close_icon
            // 
            this.close_icon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(67)))), ((int)(((byte)(87)))));
            this.close_icon.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.close_icon.ForeColor = System.Drawing.Color.Black;
            this.close_icon.Location = new System.Drawing.Point(777, -1);
            this.close_icon.Name = "close_icon";
            this.close_icon.Size = new System.Drawing.Size(25, 25);
            this.close_icon.TabIndex = 35;
            this.close_icon.Text = "X";
            this.close_icon.Click += new System.EventHandler(this.close_icon_Click);
            // 
            // back_arrow
            // 
            this.back_arrow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(67)))), ((int)(((byte)(87)))));
            this.back_arrow.BackgroundImage = global::kursova.Properties.Resources.back_arrow;
            this.back_arrow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.back_arrow.Location = new System.Drawing.Point(2, 0);
            this.back_arrow.Name = "back_arrow";
            this.back_arrow.Size = new System.Drawing.Size(75, 56);
            this.back_arrow.TabIndex = 37;
            this.back_arrow.TabStop = false;
            this.back_arrow.Click += new System.EventHandler(this.back_arrow_Click);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(67)))), ((int)(((byte)(87)))));
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Font = new System.Drawing.Font("Impact", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(800, 56);
            this.label3.TabIndex = 36;
            this.label3.Text = "Оберіть точку";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CypherIceb
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::kursova.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.close_icon);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.back_arrow);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CypherIceb";
            this.Text = "CypherIceb";
            ((System.ComponentModel.ISupportInitialize)(this.back_arrow)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label close_icon;
        private System.Windows.Forms.PictureBox back_arrow;
        private System.Windows.Forms.Label label3;
    }
}