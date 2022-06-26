
namespace BasicFacebookFeatures.User_Interface
{
    partial class PetForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PetForm));
            this.buttonPetSubmit = new System.Windows.Forms.Button();
            this.buttonPetCancel = new System.Windows.Forms.Button();
            this.progressBarHappiness = new System.Windows.Forms.ProgressBar();
            this.labelPetHapinessBar = new System.Windows.Forms.Label();
            this.labelPetUserName = new System.Windows.Forms.Label();
            this.pictureBoxPetProfile = new System.Windows.Forms.PictureBox();
            this.buttonChoosePet = new System.Windows.Forms.Button();
            this.pictureBoxFeed = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPetProfile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFeed)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonPetSubmit
            // 
            this.buttonPetSubmit.BackColor = System.Drawing.Color.PaleGreen;
            this.buttonPetSubmit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonPetSubmit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.buttonPetSubmit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LimeGreen;
            this.buttonPetSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPetSubmit.Location = new System.Drawing.Point(196, 284);
            this.buttonPetSubmit.Margin = new System.Windows.Forms.Padding(2);
            this.buttonPetSubmit.Name = "buttonPetSubmit";
            this.buttonPetSubmit.Size = new System.Drawing.Size(75, 30);
            this.buttonPetSubmit.TabIndex = 0;
            this.buttonPetSubmit.Text = "Submit";
            this.buttonPetSubmit.UseVisualStyleBackColor = false;
            this.buttonPetSubmit.Click += new System.EventHandler(this.buttonPetOk_Click);
            // 
            // buttonPetCancel
            // 
            this.buttonPetCancel.BackColor = System.Drawing.Color.Coral;
            this.buttonPetCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonPetCancel.FlatAppearance.BorderColor = System.Drawing.Color.IndianRed;
            this.buttonPetCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.OrangeRed;
            this.buttonPetCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPetCancel.Location = new System.Drawing.Point(320, 284);
            this.buttonPetCancel.Margin = new System.Windows.Forms.Padding(2);
            this.buttonPetCancel.Name = "buttonPetCancel";
            this.buttonPetCancel.Size = new System.Drawing.Size(75, 30);
            this.buttonPetCancel.TabIndex = 1;
            this.buttonPetCancel.Text = "Cancel";
            this.buttonPetCancel.UseVisualStyleBackColor = false;
            this.buttonPetCancel.Click += new System.EventHandler(this.buttonPetCancel_Click);
            // 
            // progressBarHappiness
            // 
            this.progressBarHappiness.Location = new System.Drawing.Point(32, 88);
            this.progressBarHappiness.Margin = new System.Windows.Forms.Padding(2);
            this.progressBarHappiness.Name = "progressBarHappiness";
            this.progressBarHappiness.Size = new System.Drawing.Size(550, 36);
            this.progressBarHappiness.TabIndex = 2;
            this.progressBarHappiness.Value = 100;
            // 
            // labelPetHapinessBar
            // 
            this.labelPetHapinessBar.AutoSize = true;
            this.labelPetHapinessBar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPetHapinessBar.Location = new System.Drawing.Point(260, 62);
            this.labelPetHapinessBar.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelPetHapinessBar.Name = "labelPetHapinessBar";
            this.labelPetHapinessBar.Size = new System.Drawing.Size(83, 17);
            this.labelPetHapinessBar.TabIndex = 3;
            this.labelPetHapinessBar.Text = "Happiness :";
            // 
            // labelPetUserName
            // 
            this.labelPetUserName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelPetUserName.AutoSize = true;
            this.labelPetUserName.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelPetUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPetUserName.Location = new System.Drawing.Point(245, 24);
            this.labelPetUserName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelPetUserName.Name = "labelPetUserName";
            this.labelPetUserName.Size = new System.Drawing.Size(127, 20);
            this.labelPetUserName.TabIndex = 4;
            this.labelPetUserName.Text = "My Pet\'s Name";
            this.labelPetUserName.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.labelPetUserName.Click += new System.EventHandler(this.labelPetUserName_Click);
            // 
            // pictureBoxPetProfile
            // 
            this.pictureBoxPetProfile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxPetProfile.Location = new System.Drawing.Point(26, 15);
            this.pictureBoxPetProfile.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBoxPetProfile.Name = "pictureBoxPetProfile";
            this.pictureBoxPetProfile.Size = new System.Drawing.Size(62, 62);
            this.pictureBoxPetProfile.TabIndex = 5;
            this.pictureBoxPetProfile.TabStop = false;
            this.pictureBoxPetProfile.Click += new System.EventHandler(this.pictureBoxPetProfile_Click);
            // 
            // buttonChoosePet
            // 
            this.buttonChoosePet.Location = new System.Drawing.Point(26, 15);
            this.buttonChoosePet.Margin = new System.Windows.Forms.Padding(2);
            this.buttonChoosePet.Name = "buttonChoosePet";
            this.buttonChoosePet.Size = new System.Drawing.Size(62, 63);
            this.buttonChoosePet.TabIndex = 6;
            this.buttonChoosePet.Text = "Choose Pet";
            this.buttonChoosePet.UseVisualStyleBackColor = true;
            this.buttonChoosePet.Click += new System.EventHandler(this.buttonChoosePet_Click);
            // 
            // pictureBoxFeed
            // 
            this.pictureBoxFeed.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxFeed.Location = new System.Drawing.Point(196, 168);
            this.pictureBoxFeed.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBoxFeed.Name = "pictureBoxFeed";
            this.pictureBoxFeed.Size = new System.Drawing.Size(202, 84);
            this.pictureBoxFeed.TabIndex = 7;
            this.pictureBoxFeed.TabStop = false;
            this.pictureBoxFeed.Click += new System.EventHandler(this.pictureBoxFeed_Click);
            // 
            // PetForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.pictureBoxFeed);
            this.Controls.Add(this.buttonChoosePet);
            this.Controls.Add(this.pictureBoxPetProfile);
            this.Controls.Add(this.labelPetUserName);
            this.Controls.Add(this.labelPetHapinessBar);
            this.Controls.Add(this.progressBarHappiness);
            this.Controls.Add(this.buttonPetCancel);
            this.Controls.Add(this.buttonPetSubmit);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PetForm";
            this.Text = "Pet Form";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPetProfile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFeed)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonPetSubmit;
        private System.Windows.Forms.Button buttonPetCancel;
        private System.Windows.Forms.ProgressBar progressBarHappiness;
        private System.Windows.Forms.Label labelPetHapinessBar;
        private System.Windows.Forms.Label labelPetUserName;
        private System.Windows.Forms.PictureBox pictureBoxPetProfile;
        private System.Windows.Forms.Button buttonChoosePet;
        private System.Windows.Forms.PictureBox pictureBoxFeed;
    }
}