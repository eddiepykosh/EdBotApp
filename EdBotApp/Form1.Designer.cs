namespace EdBotApp
{
    partial class Form1
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
            this.lblMain = new System.Windows.Forms.Label();
            this.btnSend = new System.Windows.Forms.Button();
            this.txtEntry = new System.Windows.Forms.TextBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblMessageContent = new System.Windows.Forms.Label();
            this.lblChannel = new System.Windows.Forms.Label();
            this.txtChannel = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblMain
            // 
            this.lblMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblMain.Location = new System.Drawing.Point(150, 9);
            this.lblMain.Name = "lblMain";
            this.lblMain.Size = new System.Drawing.Size(265, 74);
            this.lblMain.TabIndex = 0;
            this.lblMain.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(150, 247);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(75, 23);
            this.btnSend.TabIndex = 1;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // txtEntry
            // 
            this.txtEntry.Location = new System.Drawing.Point(150, 189);
            this.txtEntry.Name = "txtEntry";
            this.txtEntry.Size = new System.Drawing.Size(260, 20);
            this.txtEntry.TabIndex = 2;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(335, 247);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblMessageContent
            // 
            this.lblMessageContent.AutoSize = true;
            this.lblMessageContent.Location = new System.Drawing.Point(4, 192);
            this.lblMessageContent.Name = "lblMessageContent";
            this.lblMessageContent.Size = new System.Drawing.Size(131, 13);
            this.lblMessageContent.TabIndex = 4;
            this.lblMessageContent.Text = "What do you want to say?";
            // 
            // lblChannel
            // 
            this.lblChannel.AutoSize = true;
            this.lblChannel.Location = new System.Drawing.Point(4, 131);
            this.lblChannel.Name = "lblChannel";
            this.lblChannel.Size = new System.Drawing.Size(134, 13);
            this.lblChannel.TabIndex = 5;
            this.lblChannel.Text = "What Discord Channel ID?";
            // 
            // txtChannel
            // 
            this.txtChannel.Location = new System.Drawing.Point(150, 128);
            this.txtChannel.Name = "txtChannel";
            this.txtChannel.Size = new System.Drawing.Size(260, 20);
            this.txtChannel.TabIndex = 6;
            this.txtChannel.Text = "888985857657307168";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 282);
            this.Controls.Add(this.txtChannel);
            this.Controls.Add(this.lblChannel);
            this.Controls.Add(this.lblMessageContent);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.txtEntry);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.lblMain);
            this.Name = "Form1";
            this.Text = "EdBot.exe";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMain;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.TextBox txtEntry;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblMessageContent;
        private System.Windows.Forms.Label lblChannel;
        private System.Windows.Forms.TextBox txtChannel;
    }
}

