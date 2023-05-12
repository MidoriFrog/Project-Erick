namespace Proyecto_erick
{
    partial class sendcode
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnverify = new System.Windows.Forms.Button();
            this.btnsend = new System.Windows.Forms.Button();
            this.txtvercode = new System.Windows.Forms.TextBox();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(245)))), ((int)(((byte)(247)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnverify);
            this.panel1.Controls.Add(this.btnsend);
            this.panel1.Controls.Add(this.txtvercode);
            this.panel1.Controls.Add(this.txtemail);
            this.panel1.Location = new System.Drawing.Point(1, 63);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(727, 430);
            this.panel1.TabIndex = 0;
            // 
            // btnverify
            // 
            this.btnverify.Location = new System.Drawing.Point(308, 162);
            this.btnverify.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnverify.Name = "btnverify";
            this.btnverify.Size = new System.Drawing.Size(78, 29);
            this.btnverify.TabIndex = 3;
            this.btnverify.Text = "Verificar";
            this.btnverify.UseVisualStyleBackColor = true;
            // 
            // btnsend
            // 
            this.btnsend.Location = new System.Drawing.Point(308, 78);
            this.btnsend.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnsend.Name = "btnsend";
            this.btnsend.Size = new System.Drawing.Size(78, 28);
            this.btnsend.TabIndex = 2;
            this.btnsend.Text = "Enviar";
            this.btnsend.UseVisualStyleBackColor = true;
            this.btnsend.Click += new System.EventHandler(this.btnsend_Click);
            // 
            // txtvercode
            // 
            this.txtvercode.Location = new System.Drawing.Point(262, 110);
            this.txtvercode.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtvercode.Name = "txtvercode";
            this.txtvercode.Size = new System.Drawing.Size(146, 22);
            this.txtvercode.TabIndex = 1;
            // 
            // txtemail
            // 
            this.txtemail.Location = new System.Drawing.Point(245, 34);
            this.txtemail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(163, 22);
            this.txtemail.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(109, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Correo";
            // 
            // sendcode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(197)))), ((int)(((byte)(202)))));
            this.ClientSize = new System.Drawing.Size(670, 410);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "sendcode";
            this.Text = "sendcode";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnverify;
        private System.Windows.Forms.Button btnsend;
        private System.Windows.Forms.TextBox txtvercode;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.Label label1;
    }
}