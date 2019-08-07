namespace QuizMaster
{
    partial class frmQuizMaster
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
            this.gbAsk = new System.Windows.Forms.GroupBox();
            this.lblComputer1 = new System.Windows.Forms.Label();
            this.lblComputer2 = new System.Windows.Forms.Label();
            this.pcName1 = new System.Windows.Forms.TextBox();
            this.pcName2 = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.lbAnswers = new System.Windows.Forms.ListBox();
            this.ans = new System.Windows.Forms.TextBox();
            this.que = new System.Windows.Forms.TextBox();
            this.lblAns = new System.Windows.Forms.Label();
            this.lblQue = new System.Windows.Forms.Label();
            this.gbAsk.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbAsk
            // 
            this.gbAsk.Controls.Add(this.btnSend);
            this.gbAsk.Controls.Add(this.pcName2);
            this.gbAsk.Controls.Add(this.pcName1);
            this.gbAsk.Controls.Add(this.lblComputer2);
            this.gbAsk.Controls.Add(this.lblComputer1);
            this.gbAsk.Location = new System.Drawing.Point(12, 123);
            this.gbAsk.Name = "gbAsk";
            this.gbAsk.Size = new System.Drawing.Size(264, 173);
            this.gbAsk.TabIndex = 0;
            this.gbAsk.TabStop = false;
            this.gbAsk.Text = "Ask";
            // 
            // lblComputer1
            // 
            this.lblComputer1.AutoSize = true;
            this.lblComputer1.Location = new System.Drawing.Point(20, 34);
            this.lblComputer1.Name = "lblComputer1";
            this.lblComputer1.Size = new System.Drawing.Size(61, 13);
            this.lblComputer1.TabIndex = 0;
            this.lblComputer1.Text = "Computer 1";
            // 
            // lblComputer2
            // 
            this.lblComputer2.AutoSize = true;
            this.lblComputer2.Location = new System.Drawing.Point(20, 62);
            this.lblComputer2.Name = "lblComputer2";
            this.lblComputer2.Size = new System.Drawing.Size(61, 13);
            this.lblComputer2.TabIndex = 1;
            this.lblComputer2.Text = "Computer 2";
            // 
            // pcName1
            // 
            this.pcName1.Location = new System.Drawing.Point(89, 31);
            this.pcName1.Name = "pcName1";
            this.pcName1.Size = new System.Drawing.Size(149, 20);
            this.pcName1.TabIndex = 2;
            // 
            // pcName2
            // 
            this.pcName2.Location = new System.Drawing.Point(89, 59);
            this.pcName2.Name = "pcName2";
            this.pcName2.Size = new System.Drawing.Size(149, 20);
            this.pcName2.TabIndex = 3;
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(89, 118);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(75, 23);
            this.btnSend.TabIndex = 4;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // lbAnswers
            // 
            this.lbAnswers.FormattingEnabled = true;
            this.lbAnswers.Location = new System.Drawing.Point(292, 123);
            this.lbAnswers.Name = "lbAnswers";
            this.lbAnswers.Size = new System.Drawing.Size(202, 173);
            this.lbAnswers.TabIndex = 1;
            // 
            // ans
            // 
            this.ans.Location = new System.Drawing.Point(120, 58);
            this.ans.Name = "ans";
            this.ans.Size = new System.Drawing.Size(373, 20);
            this.ans.TabIndex = 7;
            // 
            // que
            // 
            this.que.Location = new System.Drawing.Point(120, 30);
            this.que.Name = "que";
            this.que.Size = new System.Drawing.Size(373, 20);
            this.que.TabIndex = 6;
            // 
            // lblAns
            // 
            this.lblAns.AutoSize = true;
            this.lblAns.Location = new System.Drawing.Point(32, 61);
            this.lblAns.Name = "lblAns";
            this.lblAns.Size = new System.Drawing.Size(73, 13);
            this.lblAns.TabIndex = 5;
            this.lblAns.Text = "Correct Aswer";
            // 
            // lblQue
            // 
            this.lblQue.AutoSize = true;
            this.lblQue.Location = new System.Drawing.Point(32, 33);
            this.lblQue.Name = "lblQue";
            this.lblQue.Size = new System.Drawing.Size(82, 13);
            this.lblQue.TabIndex = 4;
            this.lblQue.Text = "Post a Question";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 319);
            this.Controls.Add(this.ans);
            this.Controls.Add(this.que);
            this.Controls.Add(this.lblAns);
            this.Controls.Add(this.lblQue);
            this.Controls.Add(this.lbAnswers);
            this.Controls.Add(this.gbAsk);
            this.Name = "Form1";
            this.Text = "QuizMaster";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmQuizMaster_FormClosing);
            this.gbAsk.ResumeLayout(false);
            this.gbAsk.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbAsk;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.TextBox pcName2;
        private System.Windows.Forms.TextBox pcName1;
        private System.Windows.Forms.Label lblComputer2;
        private System.Windows.Forms.Label lblComputer1;
        private System.Windows.Forms.ListBox lbAnswers;
        private System.Windows.Forms.TextBox ans;
        private System.Windows.Forms.TextBox que;
        private System.Windows.Forms.Label lblAns;
        private System.Windows.Forms.Label lblQue;
    }
}

