namespace BasicFacebookFeatures.User_Interface
{
    public partial class FormIntro
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
            this.checkBoxHometown = new System.Windows.Forms.CheckBox();
            this.textBoxHometown = new System.Windows.Forms.TextBox();
            this.textBoxMessage = new System.Windows.Forms.TextBox();
            this.checkBoxStudy = new System.Windows.Forms.CheckBox();
            this.textBoxStudy = new System.Windows.Forms.TextBox();
            this.buttonOK = new System.Windows.Forms.Button();
            this.checkBoxInterestedIn = new System.Windows.Forms.CheckBox();
            this.textBoxInterestedIn = new System.Windows.Forms.TextBox();
            this.checkBoxQuote = new System.Windows.Forms.CheckBox();
            this.textBoxQuote = new System.Windows.Forms.TextBox();
            this.checkBoxReligion = new System.Windows.Forms.CheckBox();
            this.textBoxReligion = new System.Windows.Forms.TextBox();
            this.checkBoxGender = new System.Windows.Forms.CheckBox();
            this.checkBoxEmail = new System.Windows.Forms.CheckBox();
            this.checkBoxBirthday = new System.Windows.Forms.CheckBox();
            this.textBoxGender = new System.Windows.Forms.TextBox();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.textBoxBirthday = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // checkBoxHometown
            // 
            this.checkBoxHometown.AutoSize = true;
            this.checkBoxHometown.Location = new System.Drawing.Point(12, 174);
            this.checkBoxHometown.Name = "checkBoxHometown";
            this.checkBoxHometown.Size = new System.Drawing.Size(83, 17);
            this.checkBoxHometown.TabIndex = 0;
            this.checkBoxHometown.Text = "Hometown: ";
            this.checkBoxHometown.UseVisualStyleBackColor = true;
            // 
            // textBoxHometown
            // 
            this.textBoxHometown.Location = new System.Drawing.Point(96, 172);
            this.textBoxHometown.Name = "textBoxHometown";
            this.textBoxHometown.Size = new System.Drawing.Size(194, 20);
            this.textBoxHometown.TabIndex = 1;
            this.textBoxHometown.Tag = string.Empty;
            // 
            // textBoxMessage
            // 
            this.textBoxMessage.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxMessage.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxMessage.ForeColor = System.Drawing.Color.SteelBlue;
            this.textBoxMessage.Location = new System.Drawing.Point(96, 12);
            this.textBoxMessage.Name = "textBoxMessage";
            this.textBoxMessage.Size = new System.Drawing.Size(105, 23);
            this.textBoxMessage.TabIndex = 2;
            this.textBoxMessage.Text = "Edit Intro:";
            // 
            // checkBoxStudy
            // 
            this.checkBoxStudy.AutoSize = true;
            this.checkBoxStudy.Location = new System.Drawing.Point(12, 213);
            this.checkBoxStudy.Name = "checkBoxStudy";
            this.checkBoxStudy.Size = new System.Drawing.Size(59, 17);
            this.checkBoxStudy.TabIndex = 3;
            this.checkBoxStudy.Text = "Study: ";
            this.checkBoxStudy.UseVisualStyleBackColor = true;
            // 
            // textBoxStudy
            // 
            this.textBoxStudy.Location = new System.Drawing.Point(96, 213);
            this.textBoxStudy.Name = "textBoxStudy";
            this.textBoxStudy.Size = new System.Drawing.Size(194, 20);
            this.textBoxStudy.TabIndex = 4;
            this.textBoxStudy.Tag = string.Empty;
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(221, 341);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(78, 33);
            this.buttonOK.TabIndex = 5;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // checkBoxInterestedIn
            // 
            this.checkBoxInterestedIn.AutoSize = true;
            this.checkBoxInterestedIn.Location = new System.Drawing.Point(12, 249);
            this.checkBoxInterestedIn.Name = "checkBoxInterestedIn";
            this.checkBoxInterestedIn.Size = new System.Drawing.Size(91, 17);
            this.checkBoxInterestedIn.TabIndex = 6;
            this.checkBoxInterestedIn.Text = "Interested In: ";
            this.checkBoxInterestedIn.UseVisualStyleBackColor = true;
            // 
            // textBoxInterestedIn
            // 
            this.textBoxInterestedIn.Location = new System.Drawing.Point(96, 249);
            this.textBoxInterestedIn.Name = "textBoxInterestedIn";
            this.textBoxInterestedIn.Size = new System.Drawing.Size(194, 20);
            this.textBoxInterestedIn.TabIndex = 7;
            this.textBoxInterestedIn.Tag = string.Empty;
            // 
            // checkBoxQuote
            // 
            this.checkBoxQuote.AutoSize = true;
            this.checkBoxQuote.Location = new System.Drawing.Point(12, 285);
            this.checkBoxQuote.Name = "checkBoxQuote";
            this.checkBoxQuote.Size = new System.Drawing.Size(61, 17);
            this.checkBoxQuote.TabIndex = 8;
            this.checkBoxQuote.Text = "Quote: ";
            this.checkBoxQuote.UseVisualStyleBackColor = true;
            // 
            // textBoxQuote
            // 
            this.textBoxQuote.Location = new System.Drawing.Point(96, 285);
            this.textBoxQuote.Name = "textBoxQuote";
            this.textBoxQuote.Size = new System.Drawing.Size(194, 20);
            this.textBoxQuote.TabIndex = 9;
            this.textBoxQuote.Tag = string.Empty;
            // 
            // checkBoxReligion
            // 
            this.checkBoxReligion.AutoSize = true;
            this.checkBoxReligion.Location = new System.Drawing.Point(12, 317);
            this.checkBoxReligion.Name = "checkBoxReligion";
            this.checkBoxReligion.Size = new System.Drawing.Size(70, 17);
            this.checkBoxReligion.TabIndex = 10;
            this.checkBoxReligion.Text = "Religion: ";
            this.checkBoxReligion.UseVisualStyleBackColor = true;
            // 
            // textBoxReligion
            // 
            this.textBoxReligion.Location = new System.Drawing.Point(96, 317);
            this.textBoxReligion.Name = "textBoxReligion";
            this.textBoxReligion.Size = new System.Drawing.Size(194, 20);
            this.textBoxReligion.TabIndex = 11;
            this.textBoxReligion.Tag = string.Empty;
            // 
            // checkBoxGender
            // 
            this.checkBoxGender.AutoSize = true;
            this.checkBoxGender.Location = new System.Drawing.Point(14, 63);
            this.checkBoxGender.Name = "checkBoxGender";
            this.checkBoxGender.Size = new System.Drawing.Size(67, 17);
            this.checkBoxGender.TabIndex = 12;
            this.checkBoxGender.Text = "Gender: ";
            this.checkBoxGender.UseVisualStyleBackColor = true;
            // 
            // checkBoxEmail
            // 
            this.checkBoxEmail.AutoSize = true;
            this.checkBoxEmail.Location = new System.Drawing.Point(14, 101);
            this.checkBoxEmail.Name = "checkBoxEmail";
            this.checkBoxEmail.Size = new System.Drawing.Size(57, 17);
            this.checkBoxEmail.TabIndex = 13;
            this.checkBoxEmail.Text = "Email: ";
            this.checkBoxEmail.UseVisualStyleBackColor = true;
            // 
            // checkBoxBirthday
            // 
            this.checkBoxBirthday.AutoSize = true;
            this.checkBoxBirthday.Location = new System.Drawing.Point(14, 135);
            this.checkBoxBirthday.Name = "checkBoxBirthday";
            this.checkBoxBirthday.Size = new System.Drawing.Size(70, 17);
            this.checkBoxBirthday.TabIndex = 14;
            this.checkBoxBirthday.Text = "Birthday: ";
            this.checkBoxBirthday.UseVisualStyleBackColor = true;
            // 
            // textBoxGender
            // 
            this.textBoxGender.Location = new System.Drawing.Point(96, 63);
            this.textBoxGender.Name = "textBoxGender";
            this.textBoxGender.Size = new System.Drawing.Size(194, 20);
            this.textBoxGender.TabIndex = 15;
            this.textBoxGender.Tag = string.Empty;
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(96, 101);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(194, 20);
            this.textBoxEmail.TabIndex = 16;
            this.textBoxEmail.Tag = string.Empty;
            // 
            // textBoxBirthday
            // 
            this.textBoxBirthday.Location = new System.Drawing.Point(96, 135);
            this.textBoxBirthday.Name = "textBoxBirthday";
            this.textBoxBirthday.Size = new System.Drawing.Size(194, 20);
            this.textBoxBirthday.TabIndex = 17;
            this.textBoxBirthday.Tag = string.Empty;
            // 
            // FormIntro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(309, 385);
            this.Controls.Add(this.textBoxBirthday);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.textBoxGender);
            this.Controls.Add(this.checkBoxBirthday);
            this.Controls.Add(this.checkBoxEmail);
            this.Controls.Add(this.checkBoxGender);
            this.Controls.Add(this.textBoxReligion);
            this.Controls.Add(this.checkBoxReligion);
            this.Controls.Add(this.textBoxQuote);
            this.Controls.Add(this.checkBoxQuote);
            this.Controls.Add(this.textBoxInterestedIn);
            this.Controls.Add(this.checkBoxInterestedIn);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.textBoxStudy);
            this.Controls.Add(this.checkBoxStudy);
            this.Controls.Add(this.textBoxMessage);
            this.Controls.Add(this.textBoxHometown);
            this.Controls.Add(this.checkBoxHometown);
            this.Name = "FormIntro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Info";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBoxHometown;
        private System.Windows.Forms.TextBox textBoxHometown;
        private System.Windows.Forms.TextBox textBoxMessage;
        private System.Windows.Forms.CheckBox checkBoxStudy;
        private System.Windows.Forms.TextBox textBoxStudy;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.CheckBox checkBoxInterestedIn;
        private System.Windows.Forms.TextBox textBoxInterestedIn;
        private System.Windows.Forms.CheckBox checkBoxQuote;
        private System.Windows.Forms.TextBox textBoxQuote;
        private System.Windows.Forms.CheckBox checkBoxReligion;
        private System.Windows.Forms.TextBox textBoxReligion;
        private System.Windows.Forms.CheckBox checkBoxGender;
        private System.Windows.Forms.CheckBox checkBoxEmail;
        private System.Windows.Forms.CheckBox checkBoxBirthday;
        private System.Windows.Forms.TextBox textBoxGender;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.TextBox textBoxBirthday;
    }
}