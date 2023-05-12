namespace Proyecto_erick
{
    partial class resetpass
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnreset = new System.Windows.Forms.Button();
            this.txtconfimpass = new System.Windows.Forms.TextBox();
            this.txtresetpass = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(197)))), ((int)(((byte)(202)))));
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnreset);
            this.panel1.Controls.Add(this.txtconfimpass);
            this.panel1.Controls.Add(this.txtresetpass);
            this.panel1.Location = new System.Drawing.Point(-1, 50);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(608, 376);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(66, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "confirma el codigo  :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(62, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Introduce el codigo  :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnreset
            // 
            this.btnreset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(175)))), ((int)(((byte)(186)))));
            this.btnreset.FlatAppearance.BorderSize = 0;
            this.btnreset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnreset.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnreset.Location = new System.Drawing.Point(239, 161);
            this.btnreset.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnreset.Name = "btnreset";
            this.btnreset.Size = new System.Drawing.Size(236, 29);
            this.btnreset.TabIndex = 3;
            this.btnreset.Text = "Reset Password";
            this.btnreset.UseVisualStyleBackColor = false;
            this.btnreset.Click += new System.EventHandler(this.btnreset_Click);
            // 
            // txtconfimpass
            // 
            this.txtconfimpass.Location = new System.Drawing.Point(239, 110);
            this.txtconfimpass.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtconfimpass.Name = "txtconfimpass";
            this.txtconfimpass.Size = new System.Drawing.Size(236, 22);
            this.txtconfimpass.TabIndex = 1;
            this.txtconfimpass.TextChanged += new System.EventHandler(this.txtconfimpass_TextChanged);
            // 
            // txtresetpass
            // 
            this.txtresetpass.Location = new System.Drawing.Point(239, 41);
            this.txtresetpass.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtresetpass.Name = "txtresetpass";
            this.txtresetpass.Size = new System.Drawing.Size(236, 22);
            this.txtresetpass.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::Proyecto_erick.Properties.Resources.close;
            this.button1.Location = new System.Drawing.Point(570, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(25, 25);
            this.button1.TabIndex = 2;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // resetpass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(197)))), ((int)(((byte)(202)))));
            this.ClientSize = new System.Drawing.Size(607, 314);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "resetpass";
            this.Text = "resetpass";
            this.Load += new System.EventHandler(this.resetpass_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnreset;
        private System.Windows.Forms.TextBox txtconfimpass;
        private System.Windows.Forms.TextBox txtresetpass;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}