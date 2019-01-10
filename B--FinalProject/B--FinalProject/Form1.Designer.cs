namespace B__FinalProject
{
    partial class HittingView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HittingView));
            this.label1 = new System.Windows.Forms.Label();
            this.btnLow = new System.Windows.Forms.Button();
            this.btnMedium = new System.Windows.Forms.Button();
            this.btnHigh = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(511, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(277, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "How Much Power Would You Like to Hit With?";
            // 
            // btnLow
            // 
            this.btnLow.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnLow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLow.Location = new System.Drawing.Point(514, 86);
            this.btnLow.Name = "btnLow";
            this.btnLow.Size = new System.Drawing.Size(75, 23);
            this.btnLow.TabIndex = 1;
            this.btnLow.Text = "Low";
            this.btnLow.UseVisualStyleBackColor = false;
            this.btnLow.Click += new System.EventHandler(this.btnLow_Click);
            // 
            // btnMedium
            // 
            this.btnMedium.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnMedium.Location = new System.Drawing.Point(616, 86);
            this.btnMedium.Name = "btnMedium";
            this.btnMedium.Size = new System.Drawing.Size(75, 23);
            this.btnMedium.TabIndex = 2;
            this.btnMedium.Text = "Medium";
            this.btnMedium.UseVisualStyleBackColor = false;
            this.btnMedium.Click += new System.EventHandler(this.btnMedium_Click);
            // 
            // btnHigh
            // 
            this.btnHigh.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnHigh.Location = new System.Drawing.Point(713, 86);
            this.btnHigh.Name = "btnHigh";
            this.btnHigh.Size = new System.Drawing.Size(75, 23);
            this.btnHigh.TabIndex = 3;
            this.btnHigh.Text = "High";
            this.btnHigh.UseVisualStyleBackColor = false;
            this.btnHigh.Click += new System.EventHandler(this.btnHigh_Click);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(153, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 28);
            this.label2.TabIndex = 4;
            this.label2.Text = "Outs :   0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Home Team Score :   0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(153, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Away Team Score :   0";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(208, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 28);
            this.label5.TabIndex = 7;
            this.label5.Text = "Inning :   1";
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(80, 31);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 28);
            this.label6.TabIndex = 8;
            this.label6.Text = "Strikes :   0";
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(22, 31);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 28);
            this.label7.TabIndex = 9;
            this.label7.Text = "Balls :    0";
            // 
            // HittingView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnHigh);
            this.Controls.Add(this.btnMedium);
            this.Controls.Add(this.btnLow);
            this.Controls.Add(this.label1);
            this.Name = "HittingView";
            this.Text = "Hitting";
            this.Load += new System.EventHandler(this.HittingView_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLow;
        private System.Windows.Forms.Button btnMedium;
        private System.Windows.Forms.Button btnHigh;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}

