
namespace _62Server
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnListening = new System.Windows.Forms.Button();
            this.txtMsg = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.txtFileaddress = new System.Windows.Forms.TextBox();
            this.btnChoose = new System.Windows.Forms.Button();
            this.btnSend = new System.Windows.Forms.Button();
            this.btnEnter = new System.Windows.Forms.Button();
            this.btnShake = new System.Windows.Forms.Button();
            this.txtLog = new System.Windows.Forms.TextBox();
            this.cboIP = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnListening
            // 
            this.btnListening.Location = new System.Drawing.Point(614, 107);
            this.btnListening.Name = "btnListening";
            this.btnListening.Size = new System.Drawing.Size(118, 48);
            this.btnListening.TabIndex = 0;
            this.btnListening.Text = "开始监听";
            this.btnListening.UseVisualStyleBackColor = true;
            this.btnListening.Click += new System.EventHandler(this.btnListening_Click);
            // 
            // txtMsg
            // 
            this.txtMsg.Location = new System.Drawing.Point(69, 522);
            this.txtMsg.Multiline = true;
            this.txtMsg.Name = "txtMsg";
            this.txtMsg.Size = new System.Drawing.Size(1010, 260);
            this.txtMsg.TabIndex = 10;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(69, 113);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(304, 38);
            this.txtAddress.TabIndex = 3;
            this.txtAddress.Text = "192.168.31.181";
            // 
            // txtPort
            // 
            this.txtPort.Location = new System.Drawing.Point(401, 113);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(157, 38);
            this.txtPort.TabIndex = 4;
            this.txtPort.Text = "60000";
            // 
            // txtFileaddress
            // 
            this.txtFileaddress.Location = new System.Drawing.Point(69, 819);
            this.txtFileaddress.Name = "txtFileaddress";
            this.txtFileaddress.Size = new System.Drawing.Size(729, 38);
            this.txtFileaddress.TabIndex = 5;
            // 
            // btnChoose
            // 
            this.btnChoose.Location = new System.Drawing.Point(843, 819);
            this.btnChoose.Name = "btnChoose";
            this.btnChoose.Size = new System.Drawing.Size(95, 37);
            this.btnChoose.TabIndex = 6;
            this.btnChoose.Text = "选择";
            this.btnChoose.UseVisualStyleBackColor = true;
            this.btnChoose.Click += new System.EventHandler(this.btnChoose_Click);
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(960, 819);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(119, 37);
            this.btnSend.TabIndex = 7;
            this.btnSend.Text = "发送文件";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // btnEnter
            // 
            this.btnEnter.Location = new System.Drawing.Point(1115, 522);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(138, 110);
            this.btnEnter.TabIndex = 8;
            this.btnEnter.Text = "发送";
            this.btnEnter.UseVisualStyleBackColor = true;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // btnShake
            // 
            this.btnShake.Location = new System.Drawing.Point(1115, 674);
            this.btnShake.Name = "btnShake";
            this.btnShake.Size = new System.Drawing.Size(138, 108);
            this.btnShake.TabIndex = 9;
            this.btnShake.Text = "震动";
            this.btnShake.UseVisualStyleBackColor = true;
            this.btnShake.Click += new System.EventHandler(this.btnShake_Click);
            // 
            // txtLog
            // 
            this.txtLog.Location = new System.Drawing.Point(69, 210);
            this.txtLog.Multiline = true;
            this.txtLog.Name = "txtLog";
            this.txtLog.Size = new System.Drawing.Size(1010, 260);
            this.txtLog.TabIndex = 11;
            // 
            // cboIP
            // 
            this.cboIP.FormattingEnabled = true;
            this.cboIP.Location = new System.Drawing.Point(776, 116);
            this.cboIP.Name = "cboIP";
            this.cboIP.Size = new System.Drawing.Size(303, 39);
            this.cboIP.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1284, 941);
            this.Controls.Add(this.cboIP);
            this.Controls.Add(this.txtLog);
            this.Controls.Add(this.btnShake);
            this.Controls.Add(this.btnEnter);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.btnChoose);
            this.Controls.Add(this.txtFileaddress);
            this.Controls.Add(this.txtPort);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtMsg);
            this.Controls.Add(this.btnListening);
            this.Name = "Form1";
            this.Text = "QQ1.0服务端";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnListening;
        private System.Windows.Forms.TextBox txtMsg;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.TextBox txtFileaddress;
        private System.Windows.Forms.Button btnChoose;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Button btnEnter;
        private System.Windows.Forms.Button btnShake;
        private System.Windows.Forms.TextBox txtLog;
        private System.Windows.Forms.ComboBox cboIP;
    }
}

