namespace AdminTool
{
    partial class MainForm
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
            System.Windows.Forms.Button btnSendToAllClients;
            this.lstClients = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.lblMessage = new System.Windows.Forms.Label();
            this.btnSendToSelectedClient = new System.Windows.Forms.Button();
            this.lblUrgency = new System.Windows.Forms.Label();
            this.cmbUrgency = new System.Windows.Forms.ComboBox();
            btnSendToAllClients = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstClients
            // 
            this.lstClients.FormattingEnabled = true;
            this.lstClients.Location = new System.Drawing.Point(12, 25);
            this.lstClients.Name = "lstClients";
            this.lstClients.Size = new System.Drawing.Size(530, 95);
            this.lstClients.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Registered Client Applications";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(467, 126);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnRefresh.TabIndex = 2;
            this.btnRefresh.Text = "Refresh List";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnSendToAllClients
            // 
            btnSendToAllClients.Location = new System.Drawing.Point(307, 126);
            btnSendToAllClients.Name = "btnSendToAllClients";
            btnSendToAllClients.Size = new System.Drawing.Size(122, 23);
            btnSendToAllClients.TabIndex = 3;
            btnSendToAllClients.Text = "Send to all clients";
            btnSendToAllClients.UseVisualStyleBackColor = true;
            btnSendToAllClients.Click += new System.EventHandler(this.btnSendToAllClients_Click);
            // 
            // txtMessage
            // 
            this.txtMessage.Location = new System.Drawing.Point(103, 128);
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(198, 20);
            this.txtMessage.TabIndex = 4;
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Location = new System.Drawing.Point(9, 131);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(88, 13);
            this.lblMessage.TabIndex = 5;
            this.lblMessage.Text = "Message to send";
            // 
            // btnSendToSelectedClient
            // 
            this.btnSendToSelectedClient.Location = new System.Drawing.Point(307, 155);
            this.btnSendToSelectedClient.Name = "btnSendToSelectedClient";
            this.btnSendToSelectedClient.Size = new System.Drawing.Size(122, 35);
            this.btnSendToSelectedClient.TabIndex = 6;
            this.btnSendToSelectedClient.Text = "Send to selected client";
            this.btnSendToSelectedClient.UseVisualStyleBackColor = true;
            this.btnSendToSelectedClient.Click += new System.EventHandler(this.btnSendToSelectedClient_Click);
            // 
            // lblUrgency
            // 
            this.lblUrgency.AutoSize = true;
            this.lblUrgency.Location = new System.Drawing.Point(9, 166);
            this.lblUrgency.Name = "lblUrgency";
            this.lblUrgency.Size = new System.Drawing.Size(47, 13);
            this.lblUrgency.TabIndex = 7;
            this.lblUrgency.Text = "Urgency";
            // 
            // cmbUrgency
            // 
            this.cmbUrgency.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUrgency.FormattingEnabled = true;
            this.cmbUrgency.Location = new System.Drawing.Point(103, 163);
            this.cmbUrgency.Name = "cmbUrgency";
            this.cmbUrgency.Size = new System.Drawing.Size(121, 21);
            this.cmbUrgency.TabIndex = 8;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 205);
            this.Controls.Add(this.cmbUrgency);
            this.Controls.Add(this.lblUrgency);
            this.Controls.Add(this.btnSendToSelectedClient);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.txtMessage);
            this.Controls.Add(btnSendToAllClients);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstClients);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.Text = "Admin Tool";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstClients;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Button btnSendToSelectedClient;
        private System.Windows.Forms.Label lblUrgency;
        private System.Windows.Forms.ComboBox cmbUrgency;
    }
}

