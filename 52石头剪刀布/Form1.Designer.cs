
namespace _52石头剪刀布
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
            this.P1 = new System.Windows.Forms.Label();
            this.P2 = new System.Windows.Forms.Label();
            this.P3 = new System.Windows.Forms.Label();
            this.lblPlayer = new System.Windows.Forms.Label();
            this.lblCpu = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.btnStorn = new System.Windows.Forms.Button();
            this.btnCut = new System.Windows.Forms.Button();
            this.btnBu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // P1
            // 
            this.P1.AutoSize = true;
            this.P1.Location = new System.Drawing.Point(167, 220);
            this.P1.Name = "P1";
            this.P1.Size = new System.Drawing.Size(82, 24);
            this.P1.TabIndex = 0;
            this.P1.Text = "玩家出：";
            // 
            // P2
            // 
            this.P2.AutoSize = true;
            this.P2.Location = new System.Drawing.Point(622, 220);
            this.P2.Name = "P2";
            this.P2.Size = new System.Drawing.Size(82, 24);
            this.P2.TabIndex = 1;
            this.P2.Text = "电脑出：";
            // 
            // P3
            // 
            this.P3.AutoSize = true;
            this.P3.Location = new System.Drawing.Point(404, 477);
            this.P3.Name = "P3";
            this.P3.Size = new System.Drawing.Size(64, 24);
            this.P3.TabIndex = 2;
            this.P3.Text = "裁判：";
            // 
            // lblPlayer
            // 
            this.lblPlayer.AutoSize = true;
            this.lblPlayer.Location = new System.Drawing.Point(278, 220);
            this.lblPlayer.Name = "lblPlayer";
            this.lblPlayer.Size = new System.Drawing.Size(63, 24);
            this.lblPlayer.TabIndex = 3;
            this.lblPlayer.Text = "label4";
            // 
            // lblCpu
            // 
            this.lblCpu.AutoSize = true;
            this.lblCpu.Location = new System.Drawing.Point(725, 220);
            this.lblCpu.Name = "lblCpu";
            this.lblCpu.Size = new System.Drawing.Size(63, 24);
            this.lblCpu.TabIndex = 4;
            this.lblCpu.Text = "label5";
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(474, 477);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(63, 24);
            this.lblResult.TabIndex = 5;
            this.lblResult.Text = "label6";
            // 
            // btnStorn
            // 
            this.btnStorn.Location = new System.Drawing.Point(221, 605);
            this.btnStorn.Name = "btnStorn";
            this.btnStorn.Size = new System.Drawing.Size(120, 65);
            this.btnStorn.TabIndex = 6;
            this.btnStorn.Text = "石头";
            this.btnStorn.UseVisualStyleBackColor = true;
            this.btnStorn.Click += new System.EventHandler(this.btnStorn_Click);
            // 
            // btnCut
            // 
            this.btnCut.Location = new System.Drawing.Point(467, 605);
            this.btnCut.Name = "btnCut";
            this.btnCut.Size = new System.Drawing.Size(120, 65);
            this.btnCut.TabIndex = 7;
            this.btnCut.Text = "剪刀";
            this.btnCut.UseVisualStyleBackColor = true;
            this.btnCut.Click += new System.EventHandler(this.btnCut_Click);
            // 
            // btnBu
            // 
            this.btnBu.Location = new System.Drawing.Point(725, 605);
            this.btnBu.Name = "btnBu";
            this.btnBu.Size = new System.Drawing.Size(120, 65);
            this.btnBu.TabIndex = 8;
            this.btnBu.Text = "布";
            this.btnBu.UseVisualStyleBackColor = true;
            this.btnBu.Click += new System.EventHandler(this.btnBu_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1115, 778);
            this.Controls.Add(this.btnBu);
            this.Controls.Add(this.btnCut);
            this.Controls.Add(this.btnStorn);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.lblCpu);
            this.Controls.Add(this.lblPlayer);
            this.Controls.Add(this.P3);
            this.Controls.Add(this.P2);
            this.Controls.Add(this.P1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label P1;
        private System.Windows.Forms.Label P2;
        private System.Windows.Forms.Label P3;
        private System.Windows.Forms.Label lblPlayer;
        private System.Windows.Forms.Label lblCpu;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Button btnStorn;
        private System.Windows.Forms.Button btnCut;
        private System.Windows.Forms.Button btnBu;
    }
}

