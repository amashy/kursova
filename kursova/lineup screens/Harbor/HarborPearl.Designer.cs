namespace kursova.menus
{
    partial class HarborPearl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HarborPearl));
            this.HarborPearlBBut = new System.Windows.Forms.Button();
            this.HarborPearlBLab = new System.Windows.Forms.Label();
            this.HarborPearlABut = new System.Windows.Forms.Button();
            this.HarborPearlALab = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.close_icon = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // HarborPearlBBut
            // 
            this.HarborPearlBBut.BackColor = System.Drawing.Color.Black;
            resources.ApplyResources(this.HarborPearlBBut, "HarborPearlBBut");
            this.HarborPearlBBut.ForeColor = System.Drawing.Color.White;
            this.HarborPearlBBut.Name = "HarborPearlBBut";
            this.HarborPearlBBut.UseVisualStyleBackColor = false;
            this.HarborPearlBBut.Click += new System.EventHandler(this.HarborPearlBBut_Click);
            // 
            // HarborPearlBLab
            // 
            this.HarborPearlBLab.BackColor = System.Drawing.Color.Black;
            this.HarborPearlBLab.Cursor = System.Windows.Forms.Cursors.Default;
            resources.ApplyResources(this.HarborPearlBLab, "HarborPearlBLab");
            this.HarborPearlBLab.ForeColor = System.Drawing.Color.White;
            this.HarborPearlBLab.Name = "HarborPearlBLab";
            this.HarborPearlBLab.Click += new System.EventHandler(this.HarborPearlBLab_Click);
            // 
            // HarborPearlABut
            // 
            this.HarborPearlABut.BackColor = System.Drawing.Color.Black;
            resources.ApplyResources(this.HarborPearlABut, "HarborPearlABut");
            this.HarborPearlABut.ForeColor = System.Drawing.Color.White;
            this.HarborPearlABut.Name = "HarborPearlABut";
            this.HarborPearlABut.UseVisualStyleBackColor = false;
            this.HarborPearlABut.Click += new System.EventHandler(this.HarborPearlABut_Click);
            // 
            // HarborPearlALab
            // 
            this.HarborPearlALab.BackColor = System.Drawing.Color.Black;
            this.HarborPearlALab.Cursor = System.Windows.Forms.Cursors.Default;
            resources.ApplyResources(this.HarborPearlALab, "HarborPearlALab");
            this.HarborPearlALab.ForeColor = System.Drawing.Color.White;
            this.HarborPearlALab.Name = "HarborPearlALab";
            this.HarborPearlALab.Click += new System.EventHandler(this.HarborPearlALab_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Gray;
            this.label2.Image = global::kursova.Properties.Resources.peral_map;
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // close_icon
            // 
            this.close_icon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(67)))), ((int)(((byte)(87)))));
            resources.ApplyResources(this.close_icon, "close_icon");
            this.close_icon.ForeColor = System.Drawing.Color.Black;
            this.close_icon.Name = "close_icon";
            this.close_icon.Click += new System.EventHandler(this.close_icon_Click);
            // 
            // HarborPearl
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackgroundImage = global::kursova.Properties.Resources.background;
            this.Controls.Add(this.close_icon);
            this.Controls.Add(this.HarborPearlBBut);
            this.Controls.Add(this.HarborPearlBLab);
            this.Controls.Add(this.HarborPearlABut);
            this.Controls.Add(this.HarborPearlALab);
            this.Controls.Add(this.label2);
            this.Name = "HarborPearl";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button HarborPearlBBut;
        private System.Windows.Forms.Label HarborPearlBLab;
        private System.Windows.Forms.Button HarborPearlABut;
        private System.Windows.Forms.Label HarborPearlALab;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label close_icon;
    }
}