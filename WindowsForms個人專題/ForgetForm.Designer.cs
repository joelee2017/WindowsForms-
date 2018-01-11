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
            this.label2 = new System.Windows.Forms.Label();
            this.forgetlineidtext = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.forgetemiltext = new System.Windows.Forms.TextBox();
            this.btnreturn = new System.Windows.Forms.Button();
            this.btnCHeck = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.forgetlnewpasswordtext = new System.Windows.Forms.TextBox();
            this.forgetlcheckpasswordtext = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnPassWoardModify = new System.Windows.Forms.Button();
            this.SuspendLayout();
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
            // forgetlineidtext
            // 
            this.forgetlineidtext.Location = new System.Drawing.Point(186, 86);
            this.forgetlineidtext.Multiline = true;
            this.forgetlineidtext.Name = "forgetlineidtext";
            this.forgetlineidtext.Size = new System.Drawing.Size(191, 31);
            this.forgetlineidtext.TabIndex = 5;
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
            // forgetemiltext
            // 
            this.forgetemiltext.Location = new System.Drawing.Point(186, 32);
            this.forgetemiltext.Multiline = true;
            this.forgetemiltext.Name = "forgetemiltext";
            this.forgetemiltext.Size = new System.Drawing.Size(191, 31);
            this.forgetemiltext.TabIndex = 3;
            // 
            // btnreturn
            // 
            this.btnreturn.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnreturn.Location = new System.Drawing.Point(305, 268);
            this.btnreturn.Name = "btnreturn";
            this.btnreturn.Size = new System.Drawing.Size(90, 39);
            this.btnreturn.TabIndex = 9;
            this.btnreturn.Text = "return";
            this.btnreturn.UseVisualStyleBackColor = true;
            this.btnreturn.Click += new System.EventHandler(this.btnreturn_Click);
            // 
            // btnCHeck
            // 
            this.btnCHeck.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCHeck.Location = new System.Drawing.Point(12, 268);
            this.btnCHeck.Name = "btnCHeck";
            this.btnCHeck.Size = new System.Drawing.Size(90, 39);
            this.btnCHeck.TabIndex = 8;
            this.btnCHeck.Text = "Check";
            this.btnCHeck.UseVisualStyleBackColor = true;
            this.btnCHeck.Click += new System.EventHandler(this.btnForget_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(209, 268);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(90, 39);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // forgetlnewpasswordtext
            // 
            this.forgetlnewpasswordtext.Enabled = false;
            this.forgetlnewpasswordtext.Location = new System.Drawing.Point(186, 134);
            this.forgetlnewpasswordtext.Multiline = true;
            this.forgetlnewpasswordtext.Name = "forgetlnewpasswordtext";
            this.forgetlnewpasswordtext.PasswordChar = '*';
            this.forgetlnewpasswordtext.Size = new System.Drawing.Size(191, 31);
            this.forgetlnewpasswordtext.TabIndex = 10;
            // 
            // forgetlcheckpasswordtext
            // 
            this.forgetlcheckpasswordtext.Enabled = false;
            this.forgetlcheckpasswordtext.Location = new System.Drawing.Point(186, 190);
            this.forgetlcheckpasswordtext.Multiline = true;
            this.forgetlcheckpasswordtext.Name = "forgetlcheckpasswordtext";
            this.forgetlcheckpasswordtext.PasswordChar = '*';
            this.forgetlcheckpasswordtext.Size = new System.Drawing.Size(191, 31);
            this.forgetlcheckpasswordtext.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(52, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 22);
            this.label3.TabIndex = 12;
            this.label3.Text = "NewPassWord";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(32, 190);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(140, 22);
            this.label4.TabIndex = 13;
            this.label4.Text = "CheckPassWord";
            // 
            // btnPassWoardModify
            // 
            this.btnPassWoardModify.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPassWoardModify.Location = new System.Drawing.Point(113, 268);
            this.btnPassWoardModify.Name = "btnPassWoardModify";
            this.btnPassWoardModify.Size = new System.Drawing.Size(90, 39);
            this.btnPassWoardModify.TabIndex = 14;
            this.btnPassWoardModify.Text = "Push";
            this.btnPassWoardModify.UseVisualStyleBackColor = true;
            this.btnPassWoardModify.Click += new System.EventHandler(this.btnPassWoardModify_Click);
            // 
            // ForgetForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(407, 384);
            this.Controls.Add(this.btnPassWoardModify);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.forgetlcheckpasswordtext);
            this.Controls.Add(this.forgetlnewpasswordtext);
            this.Controls.Add(this.btnreturn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCHeck);
            this.Controls.Add(this.forgetemiltext);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.forgetlineidtext);
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
        private System.Windows.Forms.TextBox forgetlineidtext;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox forgetemiltext;
        private System.Windows.Forms.Button btnCHeck;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnreturn;
        private System.Windows.Forms.TextBox forgetlnewpasswordtext;
        private System.Windows.Forms.TextBox forgetlcheckpasswordtext;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnPassWoardModify;
    }
}