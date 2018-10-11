namespace Client_WinForm.Forms
{
    partial class HavingPartner
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
            this.havingPartnerGroupGB = new System.Windows.Forms.GroupBox();
            this.partnerAgeValLBL = new System.Windows.Forms.Label();
            this.partnerNameValLBL = new System.Windows.Forms.Label();
            this.partnerAgeLBL = new System.Windows.Forms.Label();
            this.partnerNameLBL = new System.Windows.Forms.Label();
            this.havingPartnerLBL = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.startGameBTN = new System.Windows.Forms.Button();
            this.havingPartnerGroupGB.SuspendLayout();
            this.SuspendLayout();
            // 
            // havingPartnerGroupGB
            // 
            this.havingPartnerGroupGB.Controls.Add(this.startGameBTN);
            this.havingPartnerGroupGB.Controls.Add(this.partnerAgeValLBL);
            this.havingPartnerGroupGB.Controls.Add(this.partnerNameValLBL);
            this.havingPartnerGroupGB.Controls.Add(this.partnerAgeLBL);
            this.havingPartnerGroupGB.Controls.Add(this.partnerNameLBL);
            this.havingPartnerGroupGB.Controls.Add(this.havingPartnerLBL);
            this.havingPartnerGroupGB.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.havingPartnerGroupGB.Location = new System.Drawing.Point(311, 84);
            this.havingPartnerGroupGB.Name = "havingPartnerGroupGB";
            this.havingPartnerGroupGB.Size = new System.Drawing.Size(434, 235);
            this.havingPartnerGroupGB.TabIndex = 0;
            this.havingPartnerGroupGB.TabStop = false;
            // 
            // partnerAgeValLBL
            // 
            this.partnerAgeValLBL.AutoSize = true;
            this.partnerAgeValLBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.partnerAgeValLBL.Location = new System.Drawing.Point(240, 142);
            this.partnerAgeValLBL.Name = "partnerAgeValLBL";
            this.partnerAgeValLBL.Size = new System.Drawing.Size(147, 22);
            this.partnerAgeValLBL.TabIndex = 1;
            this.partnerAgeValLBL.Text = "Your Partner age";
            // 
            // partnerNameValLBL
            // 
            this.partnerNameValLBL.AutoSize = true;
            this.partnerNameValLBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.partnerNameValLBL.Location = new System.Drawing.Point(240, 99);
            this.partnerNameValLBL.Name = "partnerNameValLBL";
            this.partnerNameValLBL.Size = new System.Drawing.Size(110, 22);
            this.partnerNameValLBL.TabIndex = 1;
            this.partnerNameValLBL.Text = "Your partner";
            // 
            // partnerAgeLBL
            // 
            this.partnerAgeLBL.AutoSize = true;
            this.partnerAgeLBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.partnerAgeLBL.Location = new System.Drawing.Point(60, 134);
            this.partnerAgeLBL.Name = "partnerAgeLBL";
            this.partnerAgeLBL.Size = new System.Drawing.Size(153, 30);
            this.partnerAgeLBL.TabIndex = 1;
            this.partnerAgeLBL.Text = "Partner age:";
            // 
            // partnerNameLBL
            // 
            this.partnerNameLBL.AutoSize = true;
            this.partnerNameLBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.partnerNameLBL.Location = new System.Drawing.Point(59, 91);
            this.partnerNameLBL.Name = "partnerNameLBL";
            this.partnerNameLBL.Size = new System.Drawing.Size(175, 30);
            this.partnerNameLBL.TabIndex = 1;
            this.partnerNameLBL.Text = "Partner name:";
            // 
            // havingPartnerLBL
            // 
            this.havingPartnerLBL.AutoSize = true;
            this.havingPartnerLBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.havingPartnerLBL.Location = new System.Drawing.Point(56, 26);
            this.havingPartnerLBL.Name = "havingPartnerLBL";
            this.havingPartnerLBL.Size = new System.Drawing.Size(340, 39);
            this.havingPartnerLBL.TabIndex = 0;
            this.havingPartnerLBL.Text = "You have a partner!!!!";
            // 
            // startGameBTN
            // 
            this.startGameBTN.BackColor = System.Drawing.SystemColors.HotTrack;
            this.startGameBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.startGameBTN.Location = new System.Drawing.Point(148, 183);
            this.startGameBTN.Name = "startGameBTN";
            this.startGameBTN.Size = new System.Drawing.Size(173, 46);
            this.startGameBTN.TabIndex = 2;
            this.startGameBTN.Text = "Start game";
            this.startGameBTN.UseVisualStyleBackColor = false;
            this.startGameBTN.Click += new System.EventHandler(this.startGameBTN_Click);
            // 
            // HavingPartner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(954, 519);
            this.Controls.Add(this.havingPartnerGroupGB);
            this.Name = "HavingPartner";
            this.Text = "havingPartner";
            this.Load += new System.EventHandler(this.HavingPartner_Load);
            this.havingPartnerGroupGB.ResumeLayout(false);
            this.havingPartnerGroupGB.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox havingPartnerGroupGB;
        private System.Windows.Forms.Label havingPartnerLBL;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label partnerAgeValLBL;
        private System.Windows.Forms.Label partnerNameValLBL;
        private System.Windows.Forms.Label partnerAgeLBL;
        private System.Windows.Forms.Label partnerNameLBL;
        private System.Windows.Forms.Button startGameBTN;
    }
}