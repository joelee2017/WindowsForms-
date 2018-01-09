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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateForm));
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.PWMlabel = new System.Windows.Forms.Label();
            this.CreateGendertext = new System.Windows.Forms.TextBox();
            this.radioFemale = new System.Windows.Forms.RadioButton();
            this.radioMan = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.CreateLineIDtext = new System.Windows.Forms.TextBox();
            this.pbUserPhoto = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.CreateLastNametext = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.CreateFirstNametext = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.CreatePassWordtext = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CreateEmailtext = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.CreateNametext = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbUserPhoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(390, 386);
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
            this.button3.Location = new System.Drawing.Point(159, 386);
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
            this.button2.Location = new System.Drawing.Point(268, 386);
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
            this.PWMlabel.Location = new System.Drawing.Point(185, 132);
            this.PWMlabel.Name = "PWMlabel";
            this.PWMlabel.Size = new System.Drawing.Size(0, 22);
            this.PWMlabel.TabIndex = 34;
            // 
            // CreateGendertext
            // 
            this.CreateGendertext.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold);
            this.CreateGendertext.Location = new System.Drawing.Point(186, 307);
            this.CreateGendertext.Multiline = true;
            this.CreateGendertext.Name = "CreateGendertext";
            this.CreateGendertext.Size = new System.Drawing.Size(159, 31);
            this.CreateGendertext.TabIndex = 33;
            // 
            // radioFemale
            // 
            this.radioFemale.AutoSize = true;
            this.radioFemale.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold);
            this.radioFemale.Location = new System.Drawing.Point(88, 312);
            this.radioFemale.Name = "radioFemale";
            this.radioFemale.Size = new System.Drawing.Size(88, 26);
            this.radioFemale.TabIndex = 32;
            this.radioFemale.TabStop = true;
            this.radioFemale.Text = "Female";
            this.radioFemale.UseVisualStyleBackColor = true;
            this.radioFemale.CheckedChanged += new System.EventHandler(this.radioFemale_CheckedChanged_1);
            // 
            // radioMan
            // 
            this.radioMan.AutoSize = true;
            this.radioMan.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold);
            this.radioMan.Location = new System.Drawing.Point(24, 312);
            this.radioMan.Name = "radioMan";
            this.radioMan.Size = new System.Drawing.Size(58, 26);
            this.radioMan.TabIndex = 31;
            this.radioMan.TabStop = true;
            this.radioMan.Text = "Man";
            this.radioMan.UseVisualStyleBackColor = true;
            this.radioMan.CheckedChanged += new System.EventHandler(this.radioMan_CheckedChanged_1);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(30, 259);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 22);
            this.label6.TabIndex = 30;
            this.label6.Text = "LineID";
            // 
            // CreateLineIDtext
            // 
            this.CreateLineIDtext.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold);
            this.CreateLineIDtext.Location = new System.Drawing.Point(186, 256);
            this.CreateLineIDtext.Multiline = true;
            this.CreateLineIDtext.Name = "CreateLineIDtext";
            this.CreateLineIDtext.Size = new System.Drawing.Size(159, 31);
            this.CreateLineIDtext.TabIndex = 29;
            // 
            // pbUserPhoto
            // 
            this.pbUserPhoto.BackColor = System.Drawing.Color.Wheat;
            this.pbUserPhoto.Image = ((System.Drawing.Image)(resources.GetObject("pbUserPhoto.Image")));
            this.pbUserPhoto.Location = new System.Drawing.Point(377, 21);
            this.pbUserPhoto.Name = "pbUserPhoto";
            this.pbUserPhoto.Size = new System.Drawing.Size(217, 214);
            this.pbUserPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbUserPhoto.TabIndex = 28;
            this.pbUserPhoto.TabStop = false;
            this.pbUserPhoto.Click += new System.EventHandler(this.pbUserPhoto_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(30, 214);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 22);
            this.label4.TabIndex = 27;
            this.label4.Text = "LastName";
            // 
            // CreateLastNametext
            // 
            this.CreateLastNametext.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold);
            this.CreateLastNametext.Location = new System.Drawing.Point(186, 205);
            this.CreateLastNametext.Multiline = true;
            this.CreateLastNametext.Name = "CreateLastNametext";
            this.CreateLastNametext.Size = new System.Drawing.Size(159, 31);
            this.CreateLastNametext.TabIndex = 26;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(30, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 22);
            this.label3.TabIndex = 25;
            this.label3.Text = "FirstName";
            // 
            // CreateFirstNametext
            // 
            this.CreateFirstNametext.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold);
            this.CreateFirstNametext.Location = new System.Drawing.Point(186, 157);
            this.CreateFirstNametext.Multiline = true;
            this.CreateFirstNametext.Name = "CreateFirstNametext";
            this.CreateFirstNametext.Size = new System.Drawing.Size(159, 31);
            this.CreateFirstNametext.TabIndex = 24;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(30, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 22);
            this.label2.TabIndex = 23;
            this.label2.Text = "PassWord";
            // 
            // CreatePassWordtext
            // 
            this.CreatePassWordtext.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold);
            this.CreatePassWordtext.Location = new System.Drawing.Point(186, 110);
            this.CreatePassWordtext.MaxLength = 12;
            this.CreatePassWordtext.Multiline = true;
            this.CreatePassWordtext.Name = "CreatePassWordtext";
            this.CreatePassWordtext.PasswordChar = '*';
            this.CreatePassWordtext.Size = new System.Drawing.Size(159, 31);
            this.CreatePassWordtext.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 22);
            this.label1.TabIndex = 21;
            this.label1.Text = "Email";
            // 
            // CreateEmailtext
            // 
            this.CreateEmailtext.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold);
            this.CreateEmailtext.Location = new System.Drawing.Point(186, 64);
            this.CreateEmailtext.Multiline = true;
            this.CreateEmailtext.Name = "CreateEmailtext";
            this.CreateEmailtext.Size = new System.Drawing.Size(159, 31);
            this.CreateEmailtext.TabIndex = 20;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // CreateNametext
            // 
            this.CreateNametext.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold);
            this.CreateNametext.Location = new System.Drawing.Point(412, 250);
            this.CreateNametext.Multiline = true;
            this.CreateNametext.Name = "CreateNametext";
            this.CreateNametext.Size = new System.Drawing.Size(159, 31);
            this.CreateNametext.TabIndex = 35;
            // 
            // CreateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(614, 462);
            this.Controls.Add(this.CreateNametext);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.PWMlabel);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.CreateGendertext);
            this.Controls.Add(this.radioFemale);
            this.Controls.Add(this.radioMan);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.CreateLineIDtext);
            this.Controls.Add(this.pbUserPhoto);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.CreateLastNametext);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CreateFirstNametext);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CreatePassWordtext);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CreateEmailtext);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "CreateForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CreateForm";
            ((System.ComponentModel.ISupportInitialize)(this.pbUserPhoto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label PWMlabel;
        private System.Windows.Forms.TextBox CreateGendertext;
        private System.Windows.Forms.RadioButton radioFemale;
        private System.Windows.Forms.RadioButton radioMan;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox CreateLineIDtext;
        private System.Windows.Forms.PictureBox pbUserPhoto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox CreateLastNametext;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox CreateFirstNametext;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox CreatePassWordtext;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox CreateEmailtext;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.TextBox CreateNametext;
    }
}