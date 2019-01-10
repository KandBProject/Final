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
            this.lblHome = new System.Windows.Forms.Label();
            this.lblAway = new System.Windows.Forms.Label();
            this.lblBall = new System.Windows.Forms.Label();
            this.lblHomeValue = new System.Windows.Forms.Label();
            this.lblAwayValue = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblOutValue = new System.Windows.Forms.Label();
            this.lblStrikeValue = new System.Windows.Forms.Label();
            this.lblBallValue = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblInningValue = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(511, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(277, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "How Much Power Would You Like to Hit With?";
            // 
            // btnLow
            // 
            this.btnLow.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnLow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLow.Location = new System.Drawing.Point(514, 54);
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
            this.btnMedium.Location = new System.Drawing.Point(616, 54);
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
            this.btnHigh.Location = new System.Drawing.Point(713, 54);
            this.btnHigh.Name = "btnHigh";
            this.btnHigh.Size = new System.Drawing.Size(75, 23);
            this.btnHigh.TabIndex = 3;
            this.btnHigh.Text = "High";
            this.btnHigh.UseVisualStyleBackColor = false;
            this.btnHigh.Click += new System.EventHandler(this.btnHigh_Click);
            // 
            // lblHome
            // 
            this.lblHome.AutoSize = true;
            this.lblHome.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblHome.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHome.Location = new System.Drawing.Point(12, 16);
            this.lblHome.Name = "lblHome";
            this.lblHome.Size = new System.Drawing.Size(152, 22);
            this.lblHome.TabIndex = 5;
            this.lblHome.Text = "Home Team Score :";
            // 
            // lblAway
            // 
            this.lblAway.AutoSize = true;
            this.lblAway.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblAway.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblAway.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAway.Location = new System.Drawing.Point(13, 55);
            this.lblAway.Name = "lblAway";
            this.lblAway.Size = new System.Drawing.Size(151, 22);
            this.lblAway.TabIndex = 6;
            this.lblAway.Text = "Away Team Score : ";
            // 
            // lblBall
            // 
            this.lblBall.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblBall.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblBall.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBall.Location = new System.Drawing.Point(9, 93);
            this.lblBall.Name = "lblBall";
            this.lblBall.Size = new System.Drawing.Size(52, 22);
            this.lblBall.TabIndex = 9;
            this.lblBall.Text = "Balls :";
            // 
            // lblHomeValue
            // 
            this.lblHomeValue.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblHomeValue.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblHomeValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHomeValue.Location = new System.Drawing.Point(173, 16);
            this.lblHomeValue.Name = "lblHomeValue";
            this.lblHomeValue.Size = new System.Drawing.Size(35, 22);
            this.lblHomeValue.TabIndex = 10;
            // 
            // lblAwayValue
            // 
            this.lblAwayValue.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblAwayValue.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblAwayValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAwayValue.Location = new System.Drawing.Point(173, 57);
            this.lblAwayValue.Name = "lblAwayValue";
            this.lblAwayValue.Size = new System.Drawing.Size(35, 22);
            this.lblAwayValue.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(156, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 22);
            this.label3.TabIndex = 12;
            this.label3.Text = "Outs:";
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(85, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 22);
            this.label4.TabIndex = 13;
            this.label4.Text = "Strikes:";
            // 
            // lblOutValue
            // 
            this.lblOutValue.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblOutValue.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblOutValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOutValue.Location = new System.Drawing.Point(156, 128);
            this.lblOutValue.Name = "lblOutValue";
            this.lblOutValue.Size = new System.Drawing.Size(35, 22);
            this.lblOutValue.TabIndex = 14;
            // 
            // lblStrikeValue
            // 
            this.lblStrikeValue.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblStrikeValue.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblStrikeValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStrikeValue.Location = new System.Drawing.Point(85, 128);
            this.lblStrikeValue.Name = "lblStrikeValue";
            this.lblStrikeValue.Size = new System.Drawing.Size(35, 22);
            this.lblStrikeValue.TabIndex = 15;
            // 
            // lblBallValue
            // 
            this.lblBallValue.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblBallValue.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblBallValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBallValue.Location = new System.Drawing.Point(9, 128);
            this.lblBallValue.Name = "lblBallValue";
            this.lblBallValue.Size = new System.Drawing.Size(35, 22);
            this.lblBallValue.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(277, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 22);
            this.label2.TabIndex = 17;
            this.label2.Text = "Inning:";
            // 
            // lblInningValue
            // 
            this.lblInningValue.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblInningValue.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblInningValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInningValue.Location = new System.Drawing.Point(335, 16);
            this.lblInningValue.Name = "lblInningValue";
            this.lblInningValue.Size = new System.Drawing.Size(35, 22);
            this.lblInningValue.TabIndex = 18;
            // 
            // HittingView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblInningValue);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblBallValue);
            this.Controls.Add(this.lblStrikeValue);
            this.Controls.Add(this.lblOutValue);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblAwayValue);
            this.Controls.Add(this.lblHomeValue);
            this.Controls.Add(this.lblBall);
            this.Controls.Add(this.lblAway);
            this.Controls.Add(this.lblHome);
            this.Controls.Add(this.btnHigh);
            this.Controls.Add(this.btnMedium);
            this.Controls.Add(this.btnLow);
            this.Controls.Add(this.label1);
            this.Name = "HittingView";
            this.Text = "Hitting";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLow;
        private System.Windows.Forms.Button btnMedium;
        private System.Windows.Forms.Button btnHigh;
        private System.Windows.Forms.Label lblHome;
        private System.Windows.Forms.Label lblAway;
        private System.Windows.Forms.Label lblBall;
        private System.Windows.Forms.Label lblHomeValue;
        private System.Windows.Forms.Label lblAwayValue;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblOutValue;
        private System.Windows.Forms.Label lblStrikeValue;
        private System.Windows.Forms.Label lblBallValue;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblInningValue;
    }
}

