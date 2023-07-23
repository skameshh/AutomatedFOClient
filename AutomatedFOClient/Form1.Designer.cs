
namespace AutomatedFOClient
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnSend = new System.Windows.Forms.Button();
            this.txtConfNumber = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.chkPartReceived = new System.Windows.Forms.CheckBox();
            this.chkPartProcStarted = new System.Windows.Forms.CheckBox();
            this.chkPartProcEnd = new System.Windows.Forms.CheckBox();
            this.chkPartQCDone = new System.Windows.Forms.CheckBox();
            this.chkPartSentDelv = new System.Windows.Forms.CheckBox();
            this.lblMsg = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSend
            // 
            this.btnSend.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSend.Location = new System.Drawing.Point(138, 362);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(173, 54);
            this.btnSend.TabIndex = 0;
            this.btnSend.Text = "Submit";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // txtConfNumber
            // 
            this.txtConfNumber.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtConfNumber.Location = new System.Drawing.Point(154, 58);
            this.txtConfNumber.Name = "txtConfNumber";
            this.txtConfNumber.Size = new System.Drawing.Size(211, 34);
            this.txtConfNumber.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(154, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(237, 28);
            this.label1.TabIndex = 2;
            this.label1.Text = "Confirmation Number : ";
            // 
            // chkPartReceived
            // 
            this.chkPartReceived.AutoSize = true;
            this.chkPartReceived.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.chkPartReceived.Location = new System.Drawing.Point(154, 110);
            this.chkPartReceived.Name = "chkPartReceived";
            this.chkPartReceived.Size = new System.Drawing.Size(165, 32);
            this.chkPartReceived.TabIndex = 4;
            this.chkPartReceived.Text = "Part Received";
            this.chkPartReceived.UseVisualStyleBackColor = true;
            // 
            // chkPartProcStarted
            // 
            this.chkPartProcStarted.AutoSize = true;
            this.chkPartProcStarted.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.chkPartProcStarted.Location = new System.Drawing.Point(154, 156);
            this.chkPartProcStarted.Name = "chkPartProcStarted";
            this.chkPartProcStarted.Size = new System.Drawing.Size(181, 32);
            this.chkPartProcStarted.TabIndex = 5;
            this.chkPartProcStarted.Text = "Process Started";
            this.chkPartProcStarted.UseVisualStyleBackColor = true;
            this.chkPartProcStarted.CheckedChanged += new System.EventHandler(this.chkPartProcStarted_CheckedChanged);
            // 
            // chkPartProcEnd
            // 
            this.chkPartProcEnd.AutoSize = true;
            this.chkPartProcEnd.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.chkPartProcEnd.Location = new System.Drawing.Point(154, 201);
            this.chkPartProcEnd.Name = "chkPartProcEnd";
            this.chkPartProcEnd.Size = new System.Drawing.Size(153, 32);
            this.chkPartProcEnd.TabIndex = 6;
            this.chkPartProcEnd.Text = "Process END";
            this.chkPartProcEnd.UseVisualStyleBackColor = true;
            this.chkPartProcEnd.CheckedChanged += new System.EventHandler(this.chkPartProcEnd_CheckedChanged);
            // 
            // chkPartQCDone
            // 
            this.chkPartQCDone.AutoSize = true;
            this.chkPartQCDone.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.chkPartQCDone.Location = new System.Drawing.Point(154, 245);
            this.chkPartQCDone.Name = "chkPartQCDone";
            this.chkPartQCDone.Size = new System.Drawing.Size(117, 32);
            this.chkPartQCDone.TabIndex = 7;
            this.chkPartQCDone.Text = "QC Done";
            this.chkPartQCDone.UseVisualStyleBackColor = true;
            this.chkPartQCDone.CheckedChanged += new System.EventHandler(this.chkPartQCDone_CheckedChanged);
            // 
            // chkPartSentDelv
            // 
            this.chkPartSentDelv.AutoSize = true;
            this.chkPartSentDelv.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.chkPartSentDelv.Location = new System.Drawing.Point(154, 293);
            this.chkPartSentDelv.Name = "chkPartSentDelv";
            this.chkPartSentDelv.Size = new System.Drawing.Size(196, 32);
            this.chkPartSentDelv.TabIndex = 8;
            this.chkPartSentDelv.Text = "Sent for Delivery";
            this.chkPartSentDelv.UseVisualStyleBackColor = true;
            this.chkPartSentDelv.CheckedChanged += new System.EventHandler(this.chkPartSentDelv_CheckedChanged);
            // 
            // lblMsg
            // 
            this.lblMsg.AutoSize = true;
            this.lblMsg.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMsg.Location = new System.Drawing.Point(147, 449);
            this.lblMsg.Name = "lblMsg";
            this.lblMsg.Size = new System.Drawing.Size(39, 20);
            this.lblMsg.TabIndex = 9;
            this.lblMsg.Text = "Msg";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 508);
            this.Controls.Add(this.lblMsg);
            this.Controls.Add(this.chkPartSentDelv);
            this.Controls.Add(this.chkPartQCDone);
            this.Controls.Add(this.chkPartProcEnd);
            this.Controls.Add(this.chkPartProcStarted);
            this.Controls.Add(this.chkPartReceived);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtConfNumber);
            this.Controls.Add(this.btnSend);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Halliburton FO Status";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.TextBox txtConfNumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chkPartReceived;
        private System.Windows.Forms.CheckBox chkPartProcStarted;
        private System.Windows.Forms.CheckBox chkPartProcEnd;
        private System.Windows.Forms.CheckBox chkPartQCDone;
        private System.Windows.Forms.CheckBox chkPartSentDelv;
        private System.Windows.Forms.Label lblMsg;
    }
}

