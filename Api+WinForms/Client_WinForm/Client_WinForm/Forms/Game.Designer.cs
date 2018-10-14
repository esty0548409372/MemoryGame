namespace Client_WinForm.Forms
{
    partial class Game
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
            this.helloLBL = new System.Windows.Forms.Label();
            this.crntLBL = new System.Windows.Forms.Label();
            this.currentTurnLBL = new System.Windows.Forms.Label();
            this.userNameLBL = new System.Windows.Forms.Label();
            this.cardsGroupBox = new System.Windows.Forms.GroupBox();
            this.card18 = new System.Windows.Forms.Button();
            this.card17 = new System.Windows.Forms.Button();
            this.card16 = new System.Windows.Forms.Button();
            this.card15 = new System.Windows.Forms.Button();
            this.card14 = new System.Windows.Forms.Button();
            this.card13 = new System.Windows.Forms.Button();
            this.card12 = new System.Windows.Forms.Button();
            this.card11 = new System.Windows.Forms.Button();
            this.card10 = new System.Windows.Forms.Button();
            this.card9 = new System.Windows.Forms.Button();
            this.card8 = new System.Windows.Forms.Button();
            this.card7 = new System.Windows.Forms.Button();
            this.card6 = new System.Windows.Forms.Button();
            this.card5 = new System.Windows.Forms.Button();
            this.card4 = new System.Windows.Forms.Button();
            this.card3 = new System.Windows.Forms.Button();
            this.card2 = new System.Windows.Forms.Button();
            this.card1 = new System.Windows.Forms.Button();
            this.getAllCardsTMR = new System.Windows.Forms.Timer(this.components);
            this.scoreLBL = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cardsGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // helloLBL
            // 
            this.helloLBL.AutoSize = true;
            this.helloLBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.helloLBL.Location = new System.Drawing.Point(325, 47);
            this.helloLBL.Name = "helloLBL";
            this.helloLBL.Size = new System.Drawing.Size(163, 39);
            this.helloLBL.TabIndex = 0;
            this.helloLBL.Text = "Hello To: ";
            // 
            // crntLBL
            // 
            this.crntLBL.AutoSize = true;
            this.crntLBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.crntLBL.Location = new System.Drawing.Point(680, 109);
            this.crntLBL.Name = "crntLBL";
            this.crntLBL.Size = new System.Drawing.Size(129, 25);
            this.crntLBL.TabIndex = 0;
            this.crntLBL.Text = "Current Turn:";
            // 
            // currentTurnLBL
            // 
            this.currentTurnLBL.AutoSize = true;
            this.currentTurnLBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.currentTurnLBL.Location = new System.Drawing.Point(815, 113);
            this.currentTurnLBL.Name = "currentTurnLBL";
            this.currentTurnLBL.Size = new System.Drawing.Size(65, 20);
            this.currentTurnLBL.TabIndex = 0;
            this.currentTurnLBL.Text = "any one";
            // 
            // userNameLBL
            // 
            this.userNameLBL.AutoSize = true;
            this.userNameLBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.userNameLBL.Location = new System.Drawing.Point(495, 57);
            this.userNameLBL.Name = "userNameLBL";
            this.userNameLBL.Size = new System.Drawing.Size(140, 29);
            this.userNameLBL.TabIndex = 1;
            this.userNameLBL.Text = "current user";
            // 
            // cardsGroupBox
            // 
            this.cardsGroupBox.Controls.Add(this.card18);
            this.cardsGroupBox.Controls.Add(this.card17);
            this.cardsGroupBox.Controls.Add(this.card16);
            this.cardsGroupBox.Controls.Add(this.card15);
            this.cardsGroupBox.Controls.Add(this.card14);
            this.cardsGroupBox.Controls.Add(this.card13);
            this.cardsGroupBox.Controls.Add(this.card12);
            this.cardsGroupBox.Controls.Add(this.card11);
            this.cardsGroupBox.Controls.Add(this.card10);
            this.cardsGroupBox.Controls.Add(this.card9);
            this.cardsGroupBox.Controls.Add(this.card8);
            this.cardsGroupBox.Controls.Add(this.card7);
            this.cardsGroupBox.Controls.Add(this.card6);
            this.cardsGroupBox.Controls.Add(this.card5);
            this.cardsGroupBox.Controls.Add(this.card4);
            this.cardsGroupBox.Controls.Add(this.card3);
            this.cardsGroupBox.Controls.Add(this.card2);
            this.cardsGroupBox.Controls.Add(this.card1);
            this.cardsGroupBox.Location = new System.Drawing.Point(121, 174);
            this.cardsGroupBox.Name = "cardsGroupBox";
            this.cardsGroupBox.Size = new System.Drawing.Size(774, 337);
            this.cardsGroupBox.TabIndex = 2;
            this.cardsGroupBox.TabStop = false;
            // 
            // card18
            // 
            this.card18.Location = new System.Drawing.Point(627, 226);
            this.card18.Name = "card18";
            this.card18.Size = new System.Drawing.Size(93, 83);
            this.card18.TabIndex = 0;
            this.card18.Text = "?";
            this.card18.UseVisualStyleBackColor = true;
            this.card18.Click += new System.EventHandler(this.card_Click);
            // 
            // card17
            // 
            this.card17.Location = new System.Drawing.Point(503, 227);
            this.card17.Name = "card17";
            this.card17.Size = new System.Drawing.Size(93, 83);
            this.card17.TabIndex = 0;
            this.card17.Text = "?";
            this.card17.UseVisualStyleBackColor = true;
            this.card17.Click += new System.EventHandler(this.card_Click);
            // 
            // card16
            // 
            this.card16.Location = new System.Drawing.Point(379, 227);
            this.card16.Name = "card16";
            this.card16.Size = new System.Drawing.Size(93, 83);
            this.card16.TabIndex = 0;
            this.card16.Text = "?";
            this.card16.UseVisualStyleBackColor = true;
            this.card16.Click += new System.EventHandler(this.card_Click);
            // 
            // card15
            // 
            this.card15.Location = new System.Drawing.Point(258, 227);
            this.card15.Name = "card15";
            this.card15.Size = new System.Drawing.Size(93, 83);
            this.card15.TabIndex = 0;
            this.card15.Text = "?";
            this.card15.UseVisualStyleBackColor = true;
            this.card15.Click += new System.EventHandler(this.card_Click);
            // 
            // card14
            // 
            this.card14.Location = new System.Drawing.Point(138, 227);
            this.card14.Name = "card14";
            this.card14.Size = new System.Drawing.Size(93, 83);
            this.card14.TabIndex = 0;
            this.card14.Text = "?";
            this.card14.UseVisualStyleBackColor = true;
            this.card14.Click += new System.EventHandler(this.card_Click);
            // 
            // card13
            // 
            this.card13.Location = new System.Drawing.Point(20, 227);
            this.card13.Name = "card13";
            this.card13.Size = new System.Drawing.Size(93, 83);
            this.card13.TabIndex = 0;
            this.card13.Text = "?";
            this.card13.UseVisualStyleBackColor = true;
            this.card13.Click += new System.EventHandler(this.card_Click);
            // 
            // card12
            // 
            this.card12.Location = new System.Drawing.Point(627, 121);
            this.card12.Name = "card12";
            this.card12.Size = new System.Drawing.Size(93, 83);
            this.card12.TabIndex = 0;
            this.card12.Text = "?";
            this.card12.UseVisualStyleBackColor = true;
            this.card12.Click += new System.EventHandler(this.card_Click);
            // 
            // card11
            // 
            this.card11.Location = new System.Drawing.Point(503, 122);
            this.card11.Name = "card11";
            this.card11.Size = new System.Drawing.Size(93, 83);
            this.card11.TabIndex = 0;
            this.card11.Text = "?";
            this.card11.UseVisualStyleBackColor = true;
            this.card11.Click += new System.EventHandler(this.card_Click);
            // 
            // card10
            // 
            this.card10.Location = new System.Drawing.Point(379, 122);
            this.card10.Name = "card10";
            this.card10.Size = new System.Drawing.Size(93, 83);
            this.card10.TabIndex = 0;
            this.card10.Text = "?";
            this.card10.UseVisualStyleBackColor = true;
            this.card10.Click += new System.EventHandler(this.card_Click);
            // 
            // card9
            // 
            this.card9.Location = new System.Drawing.Point(258, 122);
            this.card9.Name = "card9";
            this.card9.Size = new System.Drawing.Size(93, 83);
            this.card9.TabIndex = 0;
            this.card9.Text = "?";
            this.card9.UseVisualStyleBackColor = true;
            this.card9.Click += new System.EventHandler(this.card_Click);
            // 
            // card8
            // 
            this.card8.Location = new System.Drawing.Point(138, 122);
            this.card8.Name = "card8";
            this.card8.Size = new System.Drawing.Size(93, 83);
            this.card8.TabIndex = 0;
            this.card8.Text = "?";
            this.card8.UseVisualStyleBackColor = true;
            this.card8.Click += new System.EventHandler(this.card_Click);
            // 
            // card7
            // 
            this.card7.Location = new System.Drawing.Point(20, 122);
            this.card7.Name = "card7";
            this.card7.Size = new System.Drawing.Size(93, 83);
            this.card7.TabIndex = 0;
            this.card7.Text = "?";
            this.card7.UseVisualStyleBackColor = true;
            this.card7.Click += new System.EventHandler(this.card_Click);
            // 
            // card6
            // 
            this.card6.Location = new System.Drawing.Point(627, 19);
            this.card6.Name = "card6";
            this.card6.Size = new System.Drawing.Size(93, 83);
            this.card6.TabIndex = 0;
            this.card6.Text = "?";
            this.card6.UseVisualStyleBackColor = true;
            this.card6.Click += new System.EventHandler(this.card_Click);
            // 
            // card5
            // 
            this.card5.Location = new System.Drawing.Point(503, 20);
            this.card5.Name = "card5";
            this.card5.Size = new System.Drawing.Size(93, 83);
            this.card5.TabIndex = 0;
            this.card5.Text = "?";
            this.card5.UseVisualStyleBackColor = true;
            this.card5.Click += new System.EventHandler(this.card_Click);
            // 
            // card4
            // 
            this.card4.Location = new System.Drawing.Point(379, 20);
            this.card4.Name = "card4";
            this.card4.Size = new System.Drawing.Size(93, 83);
            this.card4.TabIndex = 0;
            this.card4.Text = "?";
            this.card4.UseVisualStyleBackColor = true;
            this.card4.Click += new System.EventHandler(this.card_Click);
            // 
            // card3
            // 
            this.card3.Location = new System.Drawing.Point(258, 20);
            this.card3.Name = "card3";
            this.card3.Size = new System.Drawing.Size(93, 83);
            this.card3.TabIndex = 0;
            this.card3.Text = "?";
            this.card3.UseVisualStyleBackColor = true;
            this.card3.Click += new System.EventHandler(this.card_Click);
            // 
            // card2
            // 
            this.card2.Location = new System.Drawing.Point(138, 20);
            this.card2.Name = "card2";
            this.card2.Size = new System.Drawing.Size(93, 83);
            this.card2.TabIndex = 0;
            this.card2.Text = "?";
            this.card2.UseVisualStyleBackColor = true;
            this.card2.Click += new System.EventHandler(this.card_Click);
            // 
            // card1
            // 
            this.card1.Location = new System.Drawing.Point(20, 20);
            this.card1.Name = "card1";
            this.card1.Size = new System.Drawing.Size(93, 83);
            this.card1.TabIndex = 0;
            this.card1.Text = "?";
            this.card1.UseVisualStyleBackColor = true;
            this.card1.Click += new System.EventHandler(this.card_Click);
            // 
            // getAllCardsTMR
            // 
            this.getAllCardsTMR.Enabled = true;
            this.getAllCardsTMR.Interval = 500;
            this.getAllCardsTMR.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // scoreLBL
            // 
            this.scoreLBL.AutoSize = true;
            this.scoreLBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.scoreLBL.Location = new System.Drawing.Point(38, 37);
            this.scoreLBL.Name = "scoreLBL";
            this.scoreLBL.Size = new System.Drawing.Size(112, 25);
            this.scoreLBL.TabIndex = 3;
            this.scoreLBL.Text = "Your score:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(156, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "label1";
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1029, 532);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.scoreLBL);
            this.Controls.Add(this.cardsGroupBox);
            this.Controls.Add(this.userNameLBL);
            this.Controls.Add(this.currentTurnLBL);
            this.Controls.Add(this.crntLBL);
            this.Controls.Add(this.helloLBL);
            this.Name = "Game";
            this.Text = " ";
            this.cardsGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label helloLBL;
        private System.Windows.Forms.Label crntLBL;
        private System.Windows.Forms.Label currentTurnLBL;
        private System.Windows.Forms.Label userNameLBL;
        private System.Windows.Forms.GroupBox cardsGroupBox;
        private System.Windows.Forms.Button card18;
        private System.Windows.Forms.Button card17;
        private System.Windows.Forms.Button card16;
        private System.Windows.Forms.Button card15;
        private System.Windows.Forms.Button card14;
        private System.Windows.Forms.Button card13;
        private System.Windows.Forms.Button card12;
        private System.Windows.Forms.Button card11;
        private System.Windows.Forms.Button card10;
        private System.Windows.Forms.Button card9;
        private System.Windows.Forms.Button card8;
        private System.Windows.Forms.Button card7;
        private System.Windows.Forms.Button card6;
        private System.Windows.Forms.Button card5;
        private System.Windows.Forms.Button card4;
        private System.Windows.Forms.Button card3;
        private System.Windows.Forms.Button card2;
        private System.Windows.Forms.Button card1;
        private System.Windows.Forms.Timer getAllCardsTMR;
        private System.Windows.Forms.Label scoreLBL;
        private System.Windows.Forms.Label label1;
    }
}