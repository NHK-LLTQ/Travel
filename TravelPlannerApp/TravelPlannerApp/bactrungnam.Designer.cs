﻿namespace TravelPlannerApp
{
    partial class bactrungnam
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.btnbac = new System.Windows.Forms.Button();
            this.btntrung = new System.Windows.Forms.Button();
            this.btnnam = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::TravelPlannerApp.Properties.Resources.Lăng_Bác;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(1, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(258, 395);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::TravelPlannerApp.Properties.Resources.Cố_Đô_Huế;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(265, 1);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(274, 395);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = global::TravelPlannerApp.Properties.Resources.Nhà_Thờ_Đức_Bà;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Location = new System.Drawing.Point(545, 1);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(254, 395);
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            // 
            // btnbac
            // 
            this.btnbac.BackColor = System.Drawing.Color.Lime;
            this.btnbac.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnbac.Location = new System.Drawing.Point(51, 409);
            this.btnbac.Name = "btnbac";
            this.btnbac.Size = new System.Drawing.Size(132, 34);
            this.btnbac.TabIndex = 1;
            this.btnbac.Text = "Miền Bắc";
            this.btnbac.UseVisualStyleBackColor = false;
            this.btnbac.Click += new System.EventHandler(this.btnbac_Click);
            // 
            // btntrung
            // 
            this.btntrung.BackColor = System.Drawing.Color.Lime;
            this.btntrung.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btntrung.Location = new System.Drawing.Point(328, 409);
            this.btntrung.Name = "btntrung";
            this.btntrung.Size = new System.Drawing.Size(136, 34);
            this.btntrung.TabIndex = 4;
            this.btntrung.Text = "Miền Trung";
            this.btntrung.UseVisualStyleBackColor = false;
            this.btntrung.Click += new System.EventHandler(this.btntrung_Click);
            // 
            // btnnam
            // 
            this.btnnam.BackColor = System.Drawing.Color.Lime;
            this.btnnam.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnnam.Location = new System.Drawing.Point(625, 409);
            this.btnnam.Name = "btnnam";
            this.btnnam.Size = new System.Drawing.Size(125, 34);
            this.btnnam.TabIndex = 5;
            this.btnnam.Text = "Miền Nam";
            this.btnnam.UseVisualStyleBackColor = false;
            this.btnnam.Click += new System.EventHandler(this.btnnam_Click);
            // 
            // bactrungnam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnnam);
            this.Controls.Add(this.btntrung);
            this.Controls.Add(this.btnbac);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "bactrungnam";
            this.Text = "bactrungnam";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button btnbac;
        private System.Windows.Forms.Button btntrung;
        private System.Windows.Forms.Button btnnam;
    }
}