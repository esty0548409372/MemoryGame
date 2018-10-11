namespace Client_WinForm
{
    partial class Entrance
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
            this.headerSignInLBL = new System.Windows.Forms.Label();
            this.nameLBL = new System.Windows.Forms.Label();
            this.ageLBL = new System.Windows.Forms.Label();
            this.nameTXT = new System.Windows.Forms.TextBox();
            this.signInBTN = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.ageTXT = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // headerSignInLBL
            // 
            this.headerSignInLBL.AutoSize = true;
            this.headerSignInLBL.Location = new System.Drawing.Point(459, 66);
            this.headerSignInLBL.Name = "headerSignInLBL";
            this.headerSignInLBL.Size = new System.Drawing.Size(101, 13);
            this.headerSignInLBL.TabIndex = 0;
            this.headerSignInLBL.Text = "sign in to start game";
            // 
            // nameLBL
            // 
            this.nameLBL.AutoSize = true;
            this.nameLBL.Location = new System.Drawing.Point(377, 134);
            this.nameLBL.Name = "nameLBL";
            this.nameLBL.Size = new System.Drawing.Size(35, 13);
            this.nameLBL.TabIndex = 1;
            this.nameLBL.Text = "Name";
            // 
            // ageLBL
            // 
            this.ageLBL.AutoSize = true;
            this.ageLBL.Location = new System.Drawing.Point(377, 170);
            this.ageLBL.Name = "ageLBL";
            this.ageLBL.Size = new System.Drawing.Size(26, 13);
            this.ageLBL.TabIndex = 1;
            this.ageLBL.Text = "Age";
            // 
            // nameTXT
            // 
            this.nameTXT.Location = new System.Drawing.Point(426, 133);
            this.nameTXT.Name = "nameTXT";
            this.nameTXT.Size = new System.Drawing.Size(122, 20);
            this.nameTXT.TabIndex = 2;
            this.nameTXT.MouseLeave += new System.EventHandler(this.checkValidName);
            // 
            // signInBTN
            // 
            this.signInBTN.Location = new System.Drawing.Point(422, 253);
            this.signInBTN.Name = "signInBTN";
            this.signInBTN.Size = new System.Drawing.Size(137, 37);
            this.signInBTN.TabIndex = 4;
            this.signInBTN.Text = "Sign In";
            this.signInBTN.UseVisualStyleBackColor = true;
            this.signInBTN.Click += new System.EventHandler(this.signInBTN_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // ageTXT
            // 
            this.ageTXT.Location = new System.Drawing.Point(426, 170);
            this.ageTXT.Name = "ageTXT";
            this.ageTXT.Size = new System.Drawing.Size(122, 20);
            this.ageTXT.TabIndex = 5;
            this.ageTXT.MouseLeave += new System.EventHandler(this.checkValidAge);
            // 
            // Entrance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1304, 597);
            this.Controls.Add(this.ageTXT);
            this.Controls.Add(this.signInBTN);
            this.Controls.Add(this.nameTXT);
            this.Controls.Add(this.ageLBL);
            this.Controls.Add(this.nameLBL);
            this.Controls.Add(this.headerSignInLBL);
            this.Name = "Entrance";
            this.Text = "Entrance";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label headerSignInLBL;
        private System.Windows.Forms.Label nameLBL;
        private System.Windows.Forms.Label ageLBL;
        private System.Windows.Forms.TextBox nameTXT;
        private System.Windows.Forms.Button signInBTN;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.TextBox ageTXT;
    }
}

