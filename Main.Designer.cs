namespace WindowsFormsApplication10
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.NonCopperbutton = new System.Windows.Forms.Button();
            this.Copperbutton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // NonCopperbutton
            // 
            this.NonCopperbutton.BackColor = System.Drawing.Color.ForestGreen;
            this.NonCopperbutton.Location = new System.Drawing.Point(193, 170);
            this.NonCopperbutton.Name = "NonCopperbutton";
            this.NonCopperbutton.Size = new System.Drawing.Size(175, 181);
            this.NonCopperbutton.TabIndex = 0;
            this.NonCopperbutton.Text = "NonCopper";
            this.NonCopperbutton.UseVisualStyleBackColor = false;
            this.NonCopperbutton.Click += new System.EventHandler(this.NonCopperbutton_Click);
            // 
            // Copperbutton
            // 
            this.Copperbutton.BackColor = System.Drawing.Color.DarkOrange;
            this.Copperbutton.Location = new System.Drawing.Point(452, 170);
            this.Copperbutton.Name = "Copperbutton";
            this.Copperbutton.Size = new System.Drawing.Size(175, 181);
            this.Copperbutton.TabIndex = 1;
            this.Copperbutton.Text = "Copper";
            this.Copperbutton.UseVisualStyleBackColor = false;
            this.Copperbutton.Click += new System.EventHandler(this.Copperbutton_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(50, 450);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Exit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.Location = new System.Drawing.Point(147, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(564, 46);
            this.label1.TabIndex = 5;
            this.label1.Text = "Choose Copper or NonCopper";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(457, 379);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(395, 113);
            this.pictureBox1.TabIndex = 66;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label2.Location = new System.Drawing.Point(654, 492);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(195, 17);
            this.label2.TabIndex = 67;
            this.label2.Text = "Developed by Danny Gusev®";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(866, 511);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Copperbutton);
            this.Controls.Add(this.NonCopperbutton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Main";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button NonCopperbutton;
        private System.Windows.Forms.Button Copperbutton;
        public System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
    }
}

