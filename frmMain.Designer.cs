using System;

namespace CHAT_P2P
{
    partial class frmMain
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtIPC1 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtMSG = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.btnConnect = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtIPC2 = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbMSG = new System.Windows.Forms.ListBox();
            this.btnVideoCall = new System.Windows.Forms.Button();
            this.btnGuiFile = new System.Windows.Forms.Button();
            this.btnNhanFile = new System.Windows.Forms.Button();
            this.txtPortC1 = new System.Windows.Forms.TextBox();
            this.txtPortC2 = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "IP";
            // 
            // txtIPC1
            // 
            this.txtIPC1.Location = new System.Drawing.Point(68, 26);
            this.txtIPC1.Name = "txtIPC1";
            this.txtIPC1.Size = new System.Drawing.Size(154, 20);
            this.txtIPC1.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtIPC1);
            this.groupBox1.Location = new System.Drawing.Point(35, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(237, 68);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Client 1";
            // 
            // txtMSG
            // 
            this.txtMSG.Location = new System.Drawing.Point(12, 428);
            this.txtMSG.Name = "txtMSG";
            this.txtMSG.Size = new System.Drawing.Size(721, 20);
            this.txtMSG.TabIndex = 1;
            this.txtMSG.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMSG_KeyPress);
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(771, 418);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(75, 38);
            this.btnSend.TabIndex = 4;
            this.btnSend.Text = "GỬI";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(603, 18);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(107, 45);
            this.btnConnect.TabIndex = 4;
            this.btnConnect.Text = "KẾT NỐI";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "IP";
            // 
            // txtIPC2
            // 
            this.txtIPC2.Location = new System.Drawing.Point(68, 22);
            this.txtIPC2.Name = "txtIPC2";
            this.txtIPC2.Size = new System.Drawing.Size(154, 20);
            this.txtIPC2.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtIPC2);
            this.groupBox2.Location = new System.Drawing.Point(327, 21);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(237, 68);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Client 2";
            // 
            // lbMSG
            // 
            this.lbMSG.FormattingEnabled = true;
            this.lbMSG.Location = new System.Drawing.Point(12, 138);
            this.lbMSG.Name = "lbMSG";
            this.lbMSG.Size = new System.Drawing.Size(834, 264);
            this.lbMSG.TabIndex = 6;
            // 
            // btnVideoCall
            // 
            this.btnVideoCall.Location = new System.Drawing.Point(603, 65);
            this.btnVideoCall.Name = "btnVideoCall";
            this.btnVideoCall.Size = new System.Drawing.Size(107, 51);
            this.btnVideoCall.TabIndex = 7;
            this.btnVideoCall.Text = "VIDEO CALL";
            this.btnVideoCall.UseVisualStyleBackColor = true;
            this.btnVideoCall.Click += new System.EventHandler(this.btnVideoCall_Click);
            // 
            // btnGuiFile
            // 
            this.btnGuiFile.Location = new System.Drawing.Point(716, 18);
            this.btnGuiFile.Name = "btnGuiFile";
            this.btnGuiFile.Size = new System.Drawing.Size(107, 45);
            this.btnGuiFile.TabIndex = 4;
            this.btnGuiFile.Text = "GỬI FILE";
            this.btnGuiFile.UseVisualStyleBackColor = true;
            this.btnGuiFile.Click += new System.EventHandler(this.btnGuiFile_Click);
            // 
            // btnNhanFile
            // 
            this.btnNhanFile.Location = new System.Drawing.Point(716, 65);
            this.btnNhanFile.Name = "btnNhanFile";
            this.btnNhanFile.Size = new System.Drawing.Size(107, 51);
            this.btnNhanFile.TabIndex = 7;
            this.btnNhanFile.Text = "NHẬN FILE";
            this.btnNhanFile.UseVisualStyleBackColor = true;
            this.btnNhanFile.Click += new System.EventHandler(this.btnNhanFile_Click);
            // 
            // txtPortC1
            // 
            this.txtPortC1.Location = new System.Drawing.Point(122, 95);
            this.txtPortC1.Name = "txtPortC1";
            this.txtPortC1.Size = new System.Drawing.Size(70, 20);
            this.txtPortC1.TabIndex = 8;
            // 
            // txtPortC2
            // 
            this.txtPortC2.Location = new System.Drawing.Point(424, 96);
            this.txtPortC2.Name = "txtPortC2";
            this.txtPortC2.Size = new System.Drawing.Size(70, 20);
            this.txtPortC2.TabIndex = 9;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(862, 488);
            this.Controls.Add(this.txtPortC2);
            this.Controls.Add(this.txtPortC1);
            this.Controls.Add(this.btnNhanFile);
            this.Controls.Add(this.btnVideoCall);
            this.Controls.Add(this.lbMSG);
            this.Controls.Add(this.btnGuiFile);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtMSG);
            this.Name = "frmMain";
            this.Text = "P2P CHAT VIA LAN";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIPC1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtMSG;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox txtIPC2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox lbMSG;
        private System.Windows.Forms.Button btnVideoCall;
        private System.Windows.Forms.Button btnGuiFile;
        private System.Windows.Forms.Button btnNhanFile;
        private System.Windows.Forms.TextBox txtPortC1;
        private System.Windows.Forms.TextBox txtPortC2;
    }
}

