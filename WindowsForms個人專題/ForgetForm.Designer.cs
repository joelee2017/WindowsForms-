namespace WindowsForms個人專題
{
    partial class ForgetForm
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
            this.labelpassword = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textlineid = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textemail = new System.Windows.Forms.TextBox();
            this.btnreturn = new System.Windows.Forms.Button();
            this.btnForget = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelpassword
            // 
            this.labelpassword.AutoSize = true;
            this.labelpassword.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelpassword.Location = new System.Drawing.Point(162, 147);
            this.labelpassword.Name = "labelpassword";
            this.labelpassword.Size = new System.Drawing.Size(90, 22);
            this.labelpassword.TabIndex = 7;
            this.labelpassword.Text = "Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(52, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 22);
            this.label2.TabIndex = 6;
            this.label2.Text = "LINEID";
            // 
            // textlineid
            // 
            this.textlineid.Location = new System.Drawing.Point(186, 86);
            this.textlineid.Multiline = true;
            this.textlineid.Name = "textlineid";
            this.textlineid.Size = new System.Drawing.Size(191, 31);
            this.textlineid.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 22);
            this.label1.TabIndex = 4;
            this.label1.Text = "Account(Email)";
            // 
            // textemail
            // 
            this.textemail.Location = new System.Drawing.Point(186, 32);
            this.textemail.Multiline = true;
            this.textemail.Name = "textemail";
            this.textemail.Size = new System.Drawing.Size(191, 31);
            this.textemail.TabIndex = 3;
            // 
            // btnreturn
            // 
            this.btnreturn.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnreturn.Location = new System.Drawing.Point(260, 196);
            this.btnreturn.Name = "btnreturn";
            this.btnreturn.Size = new System.Drawing.Size(90, 39);
            this.btnreturn.TabIndex = 9;
            this.btnreturn.Text = "return";
            this.btnreturn.UseVisualStyleBackColor = true;
            this.btnreturn.Click += new System.EventHandler(this.btnreturn_Click);
            // 
            // btnForget
            // 
            this.btnForget.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnForget.Location = new System.Drawing.Point(64, 196);
            this.btnForget.Name = "btnForget";
            this.btnForget.Size = new System.Drawing.Size(90, 39);
            this.btnForget.TabIndex = 8;
            this.btnForget.Text = "Forget";
            this.btnForget.UseVisualStyleBackColor = true;
            this.btnForget.Click += new System.EventHandler(this.btnForget_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(162, 196);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(90, 39);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // ForgetForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(404, 276);
            this.Controls.Add(this.btnreturn);
            this.Controls.Add(this.labelpassword);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnForget);
            this.Controls.Add(this.textemail);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.textlineid);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ForgetForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ForgetForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textlineid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textemail;
        private System.Windows.Forms.Button btnForget;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnreturn;
        private System.Windows.Forms.Label labelpassword;
    }
}