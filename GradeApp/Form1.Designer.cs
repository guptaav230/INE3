namespace GradeApp
{
    partial class LetterGradefrm
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
            this.lblNumber = new System.Windows.Forms.Label();
            this.lblGradeLetter = new System.Windows.Forms.Label();
            this.numberGradeTb = new System.Windows.Forms.TextBox();
            this.letterGradeTb = new System.Windows.Forms.TextBox();
            this.calculateBtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNumber
            // 
            this.lblNumber.AutoSize = true;
            this.lblNumber.Location = new System.Drawing.Point(34, 34);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(76, 13);
            this.lblNumber.TabIndex = 0;
            this.lblNumber.Text = "Number Grade";
            // 
            // lblGradeLetter
            // 
            this.lblGradeLetter.AutoSize = true;
            this.lblGradeLetter.Location = new System.Drawing.Point(37, 78);
            this.lblGradeLetter.Name = "lblGradeLetter";
            this.lblGradeLetter.Size = new System.Drawing.Size(66, 13);
            this.lblGradeLetter.TabIndex = 1;
            this.lblGradeLetter.Text = "Letter Grade";
            // 
            // numberGradeTb
            // 
            this.numberGradeTb.Location = new System.Drawing.Point(153, 34);
            this.numberGradeTb.Name = "numberGradeTb";
            this.numberGradeTb.Size = new System.Drawing.Size(100, 20);
            this.numberGradeTb.TabIndex = 2;
            this.numberGradeTb.KeyDown += new System.Windows.Forms.KeyEventHandler(this.numberGradeTb_KeyDown);
            // 
            // letterGradeTb
            // 
            this.letterGradeTb.Enabled = false;
            this.letterGradeTb.Location = new System.Drawing.Point(153, 70);
            this.letterGradeTb.Name = "letterGradeTb";
            this.letterGradeTb.Size = new System.Drawing.Size(100, 20);
            this.letterGradeTb.TabIndex = 3;
            // 
            // calculateBtn
            // 
            this.calculateBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.calculateBtn.Location = new System.Drawing.Point(35, 133);
            this.calculateBtn.Name = "calculateBtn";
            this.calculateBtn.Size = new System.Drawing.Size(75, 23);
            this.calculateBtn.TabIndex = 4;
            this.calculateBtn.Text = "&Calculate";
            this.calculateBtn.UseVisualStyleBackColor = true;
            this.calculateBtn.Click += new System.EventHandler(this.calculateBtn_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.exitBtn.Location = new System.Drawing.Point(178, 133);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(75, 23);
            this.exitBtn.TabIndex = 5;
            this.exitBtn.Text = "E&xit";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // LetterGradefrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.calculateBtn);
            this.Controls.Add(this.letterGradeTb);
            this.Controls.Add(this.numberGradeTb);
            this.Controls.Add(this.lblGradeLetter);
            this.Controls.Add(this.lblNumber);
            this.Name = "LetterGradefrm";
            this.Text = "Calculate Letter Grade";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNumber;
        private System.Windows.Forms.Label lblGradeLetter;
        private System.Windows.Forms.TextBox numberGradeTb;
        private System.Windows.Forms.TextBox letterGradeTb;
        private System.Windows.Forms.Button calculateBtn;
        private System.Windows.Forms.Button exitBtn;
    }
}

