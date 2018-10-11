namespace Client_WinForm
{
    partial class ChoosingPartner
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
            this.components = new System.ComponentModel.Container();
            this.choosePartnerLBL = new System.Windows.Forms.Label();
            this.dataGridViwe_UsersList = new System.Windows.Forms.DataGridView();
            this.choosePartnerBTN = new System.Windows.Forms.Button();
            this.checkUserDetailsTMR = new System.Windows.Forms.Timer(this.components);
            this.UpdatePartners = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViwe_UsersList)).BeginInit();
            this.SuspendLayout();
            // 
            // choosePartnerLBL
            // 
            this.choosePartnerLBL.AutoSize = true;
            this.choosePartnerLBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.choosePartnerLBL.Location = new System.Drawing.Point(510, 101);
            this.choosePartnerLBL.Name = "choosePartnerLBL";
            this.choosePartnerLBL.Size = new System.Drawing.Size(247, 36);
            this.choosePartnerLBL.TabIndex = 0;
            this.choosePartnerLBL.Text = "Choose a Partner";
            // 
            // dataGridViwe_UsersList
            // 
            this.dataGridViwe_UsersList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViwe_UsersList.Location = new System.Drawing.Point(425, 169);
            this.dataGridViwe_UsersList.Name = "dataGridViwe_UsersList";
            this.dataGridViwe_UsersList.Size = new System.Drawing.Size(439, 185);
            this.dataGridViwe_UsersList.TabIndex = 1;
            // 
            // choosePartnerBTN
            // 
            this.choosePartnerBTN.Location = new System.Drawing.Point(537, 375);
            this.choosePartnerBTN.Name = "choosePartnerBTN";
            this.choosePartnerBTN.Size = new System.Drawing.Size(248, 48);
            this.choosePartnerBTN.TabIndex = 2;
            this.choosePartnerBTN.Text = "CHOOSE";
            this.choosePartnerBTN.UseVisualStyleBackColor = true;
            this.choosePartnerBTN.Click += new System.EventHandler(this.choosePartnerBTN_Click);
            // 
            // checkUserDetailsTMR
            // 
            this.checkUserDetailsTMR.Enabled = true;
            this.checkUserDetailsTMR.Interval = 1000;
            this.checkUserDetailsTMR.Tick += new System.EventHandler(this.checkUserDetailsTMR_Tick);
            // 
            // UpdatePartners
            // 
            this.UpdatePartners.Enabled = true;
            this.UpdatePartners.Interval = 1000;
            this.UpdatePartners.Tick += new System.EventHandler(this.UpdatePartners_Tick);
            // 
            // ChoosingPartner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1236, 584);
            this.Controls.Add(this.choosePartnerBTN);
            this.Controls.Add(this.dataGridViwe_UsersList);
            this.Controls.Add(this.choosePartnerLBL);
            this.Name = "ChoosingPartner";
            this.Text = "ChoosingPartner";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViwe_UsersList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label choosePartnerLBL;
        private System.Windows.Forms.DataGridView dataGridViwe_UsersList;
        private System.Windows.Forms.Button choosePartnerBTN;
        private System.Windows.Forms.Timer checkUserDetailsTMR;
        private System.Windows.Forms.Timer UpdatePartners;
    }
}