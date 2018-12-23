namespace TravelPlannerApp
{
    partial class NorthSide
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
            this.RegionsN = new System.Windows.Forms.Label();
            this.groupBoxNE = new System.Windows.Forms.GroupBox();
            this.groupBoxNW = new System.Windows.Forms.GroupBox();
            this.groupBoxRRD = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.groupBoxNE.SuspendLayout();
            this.groupBoxNW.SuspendLayout();
            this.groupBoxRRD.SuspendLayout();
            this.SuspendLayout();
            // 
            // RegionsN
            // 
            this.RegionsN.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.RegionsN.Location = new System.Drawing.Point(12, 13);
            this.RegionsN.Name = "RegionsN";
            this.RegionsN.Size = new System.Drawing.Size(1176, 180);
            this.RegionsN.TabIndex = 0;
            this.RegionsN.Text = "North Side";
            this.RegionsN.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBoxNE
            // 
            this.groupBoxNE.Controls.Add(this.panel2);
            this.groupBoxNE.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBoxNE.Location = new System.Drawing.Point(22, 211);
            this.groupBoxNE.Name = "groupBoxNE";
            this.groupBoxNE.Size = new System.Drawing.Size(385, 469);
            this.groupBoxNE.TabIndex = 1;
            this.groupBoxNE.TabStop = false;
            this.groupBoxNE.Text = "Northeast";
            // 
            // groupBoxNW
            // 
            this.groupBoxNW.Controls.Add(this.panel1);
            this.groupBoxNW.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBoxNW.Location = new System.Drawing.Point(422, 211);
            this.groupBoxNW.Name = "groupBoxNW";
            this.groupBoxNW.Size = new System.Drawing.Size(380, 469);
            this.groupBoxNW.TabIndex = 2;
            this.groupBoxNW.TabStop = false;
            this.groupBoxNW.Text = "Northwest";
            // 
            // groupBoxRRD
            // 
            this.groupBoxRRD.Controls.Add(this.panel3);
            this.groupBoxRRD.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBoxRRD.Location = new System.Drawing.Point(808, 211);
            this.groupBoxRRD.Name = "groupBoxRRD";
            this.groupBoxRRD.Size = new System.Drawing.Size(380, 469);
            this.groupBoxRRD.TabIndex = 3;
            this.groupBoxRRD.TabStop = false;
            this.groupBoxRRD.Text = "Red River Delta";
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.panel1.Location = new System.Drawing.Point(7, 44);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(367, 419);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.panel2.Location = new System.Drawing.Point(7, 44);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(372, 419);
            this.panel2.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.AutoScroll = true;
            this.panel3.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.panel3.Location = new System.Drawing.Point(7, 44);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(367, 419);
            this.panel3.TabIndex = 0;
            // 
            // NorthSide
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.groupBoxRRD);
            this.Controls.Add(this.groupBoxNW);
            this.Controls.Add(this.groupBoxNE);
            this.Controls.Add(this.RegionsN);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "NorthSide";
            this.Text = "North";
            this.Load += new System.EventHandler(this.NorthSide_Load);
            this.groupBoxNE.ResumeLayout(false);
            this.groupBoxNW.ResumeLayout(false);
            this.groupBoxRRD.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label RegionsN;
        private System.Windows.Forms.GroupBox groupBoxNE;
        private System.Windows.Forms.GroupBox groupBoxNW;
        private System.Windows.Forms.GroupBox groupBoxRRD;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
    }
}