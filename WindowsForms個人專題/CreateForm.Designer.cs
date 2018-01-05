namespace WindowsForms個人專題
{
    partial class CreateForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateForm));
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.PWMlabel = new System.Windows.Forms.Label();
            this.Gendertext = new System.Windows.Forms.TextBox();
            this.radioFemale = new System.Windows.Forms.RadioButton();
            this.radioMan = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.LineIDtext = new System.Windows.Forms.TextBox();
            this.UserPhoto = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.LastNametext = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.FirstNametext = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.PassWordtext = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Emailtext = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.UserPhoto)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(386, 312);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 39);
            this.button1.TabIndex = 5;
            this.button1.Text = "return";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(155, 312);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(90, 39);
            this.button3.TabIndex = 4;
            this.button3.Text = "Create";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(264, 312);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(90, 39);
            this.button2.TabIndex = 3;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // PWMlabel
            // 
            this.PWMlabel.AutoSize = true;
            this.PWMlabel.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PWMlabel.ForeColor = System.Drawing.Color.Red;
            this.PWMlabel.Location = new System.Drawing.Point(178, 80);
            this.PWMlabel.Name = "PWMlabel";
            this.PWMlabel.Size = new System.Drawing.Size(0, 22);
            this.PWMlabel.TabIndex = 34;
            // 
            // Gendertext
            // 
            this.Gendertext.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold);
            this.Gendertext.Location = new System.Drawing.Point(179, 255);
            this.Gendertext.Multiline = true;
            this.Gendertext.Name = "Gendertext";
            this.Gendertext.Size = new System.Drawing.Size(159, 31);
            this.Gendertext.TabIndex = 33;
            // 
            // radioFemale
            // 
            this.radioFemale.AutoSize = true;
            this.radioFemale.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold);
            this.radioFemale.Location = new System.Drawing.Point(81, 260);
            this.radioFemale.Name = "radioFemale";
            this.radioFemale.Size = new System.Drawing.Size(88, 26);
            this.radioFemale.TabIndex = 32;
            this.radioFemale.TabStop = true;
            this.radioFemale.Text = "Female";
            this.radioFemale.UseVisualStyleBackColor = true;
            // 
            // radioMan
            // 
            this.radioMan.AutoSize = true;
            this.radioMan.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold);
            this.radioMan.Location = new System.Drawing.Point(17, 260);
            this.radioMan.Name = "radioMan";
            this.radioMan.Size = new System.Drawing.Size(58, 26);
            this.radioMan.TabIndex = 31;
            this.radioMan.TabStop = true;
            this.radioMan.Text = "Man";
            this.radioMan.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(23, 207);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 22);
            this.label6.TabIndex = 30;
            this.label6.Text = "LineID";
            // 
            // LineIDtext
            // 
            this.LineIDtext.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold);
            this.LineIDtext.Location = new System.Drawing.Point(179, 204);
            this.LineIDtext.Multiline = true;
            this.LineIDtext.Name = "LineIDtext";
            this.LineIDtext.Size = new System.Drawing.Size(159, 31);
            this.LineIDtext.TabIndex = 29;
            // 
            // UserPhoto
            // 
            this.UserPhoto.BackColor = System.Drawing.Color.Wheat;
            this.UserPhoto.Image = ((System.Drawing.Image)(resources.GetObject("UserPhoto.Image")));
            this.UserPhoto.Location = new System.Drawing.Point(377, 21);
            this.UserPhoto.Name = "UserPhoto";
            this.UserPhoto.Size = new System.Drawing.Size(217, 214);
            this.UserPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.UserPhoto.TabIndex = 28;
            this.UserPhoto.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(23, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 22);
            this.label4.TabIndex = 27;
            this.label4.Text = "LastName";
            // 
            // LastNametext
            // 
            this.LastNametext.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold);
            this.LastNametext.Location = new System.Drawing.Point(179, 153);
            this.LastNametext.Multiline = true;
            this.LastNametext.Name = "LastNametext";
            this.LastNametext.Size = new System.Drawing.Size(159, 31);
            this.LastNametext.TabIndex = 26;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(23, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 22);
            this.label3.TabIndex = 25;
            this.label3.Text = "FirstName";
            // 
            // FirstNametext
            // 
            this.FirstNametext.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold);
            this.FirstNametext.Location = new System.Drawing.Point(179, 105);
            this.FirstNametext.Multiline = true;
            this.FirstNametext.Name = "FirstNametext";
            this.FirstNametext.Size = new System.Drawing.Size(159, 31);
            this.FirstNametext.TabIndex = 24;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 22);
            this.label2.TabIndex = 23;
            this.label2.Text = "PassWord";
            // 
            // PassWordtext
            // 
            this.PassWordtext.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold);
            this.PassWordtext.Location = new System.Drawing.Point(179, 58);
            this.PassWordtext.MaxLength = 12;
            this.PassWordtext.Multiline = true;
            this.PassWordtext.Name = "PassWordtext";
            this.PassWordtext.PasswordChar = '*';
            this.PassWordtext.Size = new System.Drawing.Size(159, 31);
            this.PassWordtext.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 22);
            this.label1.TabIndex = 21;
            this.label1.Text = "Email";
            // 
            // Emailtext
            // 
            this.Emailtext.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold);
            this.Emailtext.Location = new System.Drawing.Point(179, 12);
            this.Emailtext.Multiline = true;
            this.Emailtext.Name = "Emailtext";
            this.Emailtext.Size = new System.Drawing.Size(159, 31);
            this.Emailtext.TabIndex = 20;
            // 
            // CreateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(621, 379);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.PWMlabel);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Gendertext);
            this.Controls.Add(this.radioFemale);
            this.Controls.Add(this.radioMan);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.LineIDtext);
            this.Controls.Add(this.UserPhoto);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.LastNametext);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.FirstNametext);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.PassWordtext);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Emailtext);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "CreateForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CreateForm";
            ((System.ComponentModel.ISupportInitialize)(this.UserPhoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label PWMlabel;
        private System.Windows.Forms.TextBox Gendertext;
        private System.Windows.Forms.RadioButton radioFemale;
        private System.Windows.Forms.RadioButton radioMan;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox LineIDtext;
        private System.Windows.Forms.PictureBox UserPhoto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox LastNametext;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox FirstNametext;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox PassWordtext;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Emailtext;
    }
}