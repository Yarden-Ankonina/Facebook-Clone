using System;

namespace BasicFacebookFeatures.User_Interface
{
    public partial class FormMain
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
            System.Windows.Forms.Label postTypeLabel;
            System.Windows.Forms.Label linkLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.button_Posts = new System.Windows.Forms.Button();
            this.button_Photos = new System.Windows.Forms.Button();
            this.buttonFriends = new System.Windows.Forms.Button();
            this.labelAbout = new System.Windows.Forms.Label();
            this.listBoxIntro = new System.Windows.Forms.ListBox();
            this.buttonAddBio = new System.Windows.Forms.Button();
            this.labelUserName = new System.Windows.Forms.Label();
            this.labelFriendsCount = new System.Windows.Forms.Label();
            this.labelMyPet = new System.Windows.Forms.Label();
            this.panelPost = new System.Windows.Forms.Panel();
            this.linkLinkLabel = new System.Windows.Forms.LinkLabel();
            this.postAdapterWinFormsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.postTypeLabel1 = new System.Windows.Forms.Label();
            this.descreptionListBox = new System.Windows.Forms.ListBox();
            this.descreptionListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pictureBoxPostPicture = new System.Windows.Forms.PictureBox();
            this.labelPostDate = new System.Windows.Forms.Label();
            this.labelPostUserName = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelPostiLkesAmount = new System.Windows.Forms.Label();
            this.buttonPostLike = new System.Windows.Forms.Button();
            this.buttonPet = new System.Windows.Forms.PictureBox();
            this.buttonLogout = new System.Windows.Forms.PictureBox();
            this.facebookIcon = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBoxProfile = new System.Windows.Forms.PictureBox();
            this.pictureBoxCover = new System.Windows.Forms.PictureBox();
            this.backgroundLower = new System.Windows.Forms.PictureBox();
            this.buttonNextPost = new System.Windows.Forms.PictureBox();
            this.buttonPrevPost = new System.Windows.Forms.PictureBox();
            this.pictureBoxLine = new System.Windows.Forms.PictureBox();
            this.listBoxFriends = new System.Windows.Forms.ListBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.labelFriends = new System.Windows.Forms.Label();
            this.buttonFetchAllData = new System.Windows.Forms.Button();
            this.buttonLikedPages = new System.Windows.Forms.Button();
            this.pictureBoxTimer = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.labelLikedPages = new System.Windows.Forms.Label();
            this.listBoxLikedPages = new System.Windows.Forms.ListBox();
            this.sortAscendingButton = new System.Windows.Forms.Button();
            this.sortPictureAscending = new System.Windows.Forms.Button();
            this.sortDescendingButton = new System.Windows.Forms.Button();
            this.sortPictureDescending = new System.Windows.Forms.Button();
            this.panelPictureBox = new System.Windows.Forms.Panel();
            this.buttonNotification = new System.Windows.Forms.Button();
            this.pictureBoxDeleteNotifications = new System.Windows.Forms.PictureBox();
            postTypeLabel = new System.Windows.Forms.Label();
            linkLabel = new System.Windows.Forms.Label();
            this.panelPost.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.postAdapterWinFormsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.descreptionListBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPostPicture)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.buttonPet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonLogout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.facebookIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCover)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.backgroundLower)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonNextPost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonPrevPost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLine)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTimer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDeleteNotifications)).BeginInit();
            this.SuspendLayout();
            // 
            // postTypeLabel
            // 
            postTypeLabel.AutoSize = true;
            postTypeLabel.Location = new System.Drawing.Point(185, 92);
            postTypeLabel.Name = "postTypeLabel";
            postTypeLabel.Size = new System.Drawing.Size(76, 17);
            postTypeLabel.TabIndex = 11;
            postTypeLabel.Text = "Post Type:";
            // 
            // linkLabel
            // 
            linkLabel.AutoSize = true;
            linkLabel.Location = new System.Drawing.Point(188, 134);
            linkLabel.Name = "linkLabel";
            linkLabel.Size = new System.Drawing.Size(38, 17);
            linkLabel.TabIndex = 12;
            linkLabel.Text = "Link:";
            // 
            // button_Posts
            // 
            this.button_Posts.BackColor = System.Drawing.Color.LightSkyBlue;
            this.button_Posts.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Posts.Enabled = false;
            this.button_Posts.FlatAppearance.BorderSize = 0;
            this.button_Posts.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(250)))));
            this.button_Posts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Posts.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Posts.Location = new System.Drawing.Point(27, 298);
            this.button_Posts.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_Posts.Name = "button_Posts";
            this.button_Posts.Size = new System.Drawing.Size(131, 43);
            this.button_Posts.TabIndex = 60;
            this.button_Posts.Text = "Posts";
            this.button_Posts.UseVisualStyleBackColor = false;
            this.button_Posts.Click += new System.EventHandler(this.Posts_Click);
            // 
            // button_Photos
            // 
            this.button_Photos.BackColor = System.Drawing.Color.LightSkyBlue;
            this.button_Photos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Photos.Enabled = false;
            this.button_Photos.FlatAppearance.BorderSize = 0;
            this.button_Photos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(250)))));
            this.button_Photos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Photos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Photos.Location = new System.Drawing.Point(177, 298);
            this.button_Photos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_Photos.Name = "button_Photos";
            this.button_Photos.Size = new System.Drawing.Size(131, 43);
            this.button_Photos.TabIndex = 61;
            this.button_Photos.Text = "Photos";
            this.button_Photos.UseVisualStyleBackColor = false;
            this.button_Photos.Click += new System.EventHandler(this.button_Photos_Click);
            // 
            // buttonFriends
            // 
            this.buttonFriends.BackColor = System.Drawing.Color.LightSkyBlue;
            this.buttonFriends.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonFriends.Enabled = false;
            this.buttonFriends.FlatAppearance.BorderSize = 0;
            this.buttonFriends.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(250)))));
            this.buttonFriends.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFriends.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFriends.Location = new System.Drawing.Point(327, 298);
            this.buttonFriends.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonFriends.Name = "buttonFriends";
            this.buttonFriends.Size = new System.Drawing.Size(131, 43);
            this.buttonFriends.TabIndex = 62;
            this.buttonFriends.Text = "Friends";
            this.buttonFriends.UseVisualStyleBackColor = false;
            this.buttonFriends.Click += new System.EventHandler(this.buttonFriends_Click);
            // 
            // labelAbout
            // 
            this.labelAbout.AutoSize = true;
            this.labelAbout.BackColor = System.Drawing.Color.AliceBlue;
            this.labelAbout.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAbout.Location = new System.Drawing.Point(131, 425);
            this.labelAbout.Name = "labelAbout";
            this.labelAbout.Size = new System.Drawing.Size(100, 36);
            this.labelAbout.TabIndex = 65;
            this.labelAbout.Text = "About";
            // 
            // listBoxIntro
            // 
            this.listBoxIntro.BackColor = System.Drawing.Color.AliceBlue;
            this.listBoxIntro.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBoxIntro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxIntro.FormattingEnabled = true;
            this.listBoxIntro.ItemHeight = 18;
            this.listBoxIntro.Location = new System.Drawing.Point(39, 463);
            this.listBoxIntro.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBoxIntro.Name = "listBoxIntro";
            this.listBoxIntro.ScrollAlwaysVisible = true;
            this.listBoxIntro.Size = new System.Drawing.Size(291, 90);
            this.listBoxIntro.TabIndex = 66;
            // 
            // buttonAddBio
            // 
            this.buttonAddBio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAddBio.Location = new System.Drawing.Point(100, 562);
            this.buttonAddBio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonAddBio.Name = "buttonAddBio";
            this.buttonAddBio.Size = new System.Drawing.Size(169, 34);
            this.buttonAddBio.TabIndex = 67;
            this.buttonAddBio.Text = "Add Bio";
            this.buttonAddBio.UseVisualStyleBackColor = true;
            this.buttonAddBio.Click += new System.EventHandler(this.buttonAddBio_Click);
            // 
            // labelUserName
            // 
            this.labelUserName.AutoSize = true;
            this.labelUserName.BackColor = System.Drawing.Color.White;
            this.labelUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUserName.Location = new System.Drawing.Point(155, 94);
            this.labelUserName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelUserName.Name = "labelUserName";
            this.labelUserName.Size = new System.Drawing.Size(227, 48);
            this.labelUserName.TabIndex = 69;
            this.labelUserName.Text = "UserName";
            // 
            // labelFriendsCount
            // 
            this.labelFriendsCount.AutoSize = true;
            this.labelFriendsCount.BackColor = System.Drawing.Color.White;
            this.labelFriendsCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFriendsCount.Location = new System.Drawing.Point(171, 149);
            this.labelFriendsCount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelFriendsCount.Name = "labelFriendsCount";
            this.labelFriendsCount.Size = new System.Drawing.Size(104, 18);
            this.labelFriendsCount.TabIndex = 78;
            this.labelFriendsCount.Text = "friendsCount";
            // 
            // labelMyPet
            // 
            this.labelMyPet.AutoSize = true;
            this.labelMyPet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMyPet.Location = new System.Drawing.Point(227, 213);
            this.labelMyPet.Name = "labelMyPet";
            this.labelMyPet.Size = new System.Drawing.Size(60, 18);
            this.labelMyPet.TabIndex = 80;
            this.labelMyPet.Text = "My Pet";
            // 
            // panelPost
            // 
            this.panelPost.BackColor = System.Drawing.Color.White;
            this.panelPost.Controls.Add(linkLabel);
            this.panelPost.Controls.Add(this.linkLinkLabel);
            this.panelPost.Controls.Add(postTypeLabel);
            this.panelPost.Controls.Add(this.postTypeLabel1);
            this.panelPost.Controls.Add(this.descreptionListBox);
            this.panelPost.Controls.Add(this.pictureBoxPostPicture);
            this.panelPost.Controls.Add(this.labelPostDate);
            this.panelPost.Controls.Add(this.labelPostUserName);
            this.panelPost.Location = new System.Drawing.Point(412, 412);
            this.panelPost.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelPost.Name = "panelPost";
            this.panelPost.Size = new System.Drawing.Size(549, 407);
            this.panelPost.TabIndex = 81;
            // 
            // linkLinkLabel
            // 
            this.linkLinkLabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.postAdapterWinFormsBindingSource, "Link", true));
            this.linkLinkLabel.Location = new System.Drawing.Point(232, 134);
            this.linkLinkLabel.Name = "linkLinkLabel";
            this.linkLinkLabel.Size = new System.Drawing.Size(280, 23);
            this.linkLinkLabel.TabIndex = 13;
            this.linkLinkLabel.TabStop = true;
            this.linkLinkLabel.Text = "Link";
            this.linkLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLinkLabel_LinkClicked);
            // 
            // postAdapterWinFormsBindingSource
            // 
            this.postAdapterWinFormsBindingSource.DataSource = typeof(BasicFacebookFeatures.Adapters.PostAdapterWinForms);
            // 
            // postTypeLabel1
            // 
            this.postTypeLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.postAdapterWinFormsBindingSource, "PostType", true));
            this.postTypeLabel1.Location = new System.Drawing.Point(269, 92);
            this.postTypeLabel1.Name = "postTypeLabel1";
            this.postTypeLabel1.Size = new System.Drawing.Size(131, 23);
            this.postTypeLabel1.TabIndex = 12;
            this.postTypeLabel1.Text = "Type";
            // 
            // descreptionListBox
            // 
            this.descreptionListBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.postAdapterWinFormsBindingSource, "Descreption", true));
            this.descreptionListBox.DataSource = this.descreptionListBindingSource;
            this.descreptionListBox.FormattingEnabled = true;
            this.descreptionListBox.ItemHeight = 16;
            this.descreptionListBox.Location = new System.Drawing.Point(23, 238);
            this.descreptionListBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.descreptionListBox.Name = "descreptionListBox";
            this.descreptionListBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.descreptionListBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.descreptionListBox.Size = new System.Drawing.Size(505, 148);
            this.descreptionListBox.TabIndex = 10;
            // 
            // descreptionListBindingSource
            // 
            this.descreptionListBindingSource.DataMember = "DescreptionList";
            this.descreptionListBindingSource.DataSource = this.postAdapterWinFormsBindingSource;
            // 
            // pictureBoxPostPicture
            // 
            this.pictureBoxPostPicture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxPostPicture.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.postAdapterWinFormsBindingSource, "PostImage.Image", true));
            this.pictureBoxPostPicture.Location = new System.Drawing.Point(23, 41);
            this.pictureBoxPostPicture.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBoxPostPicture.Name = "pictureBoxPostPicture";
            this.pictureBoxPostPicture.Size = new System.Drawing.Size(137, 128);
            this.pictureBoxPostPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxPostPicture.TabIndex = 6;
            this.pictureBoxPostPicture.TabStop = false;
            // 
            // labelPostDate
            // 
            this.labelPostDate.AutoSize = true;
            this.labelPostDate.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.postAdapterWinFormsBindingSource, "UpdateTime", true));
            this.labelPostDate.Location = new System.Drawing.Point(183, 41);
            this.labelPostDate.Name = "labelPostDate";
            this.labelPostDate.Size = new System.Drawing.Size(70, 17);
            this.labelPostDate.TabIndex = 3;
            this.labelPostDate.Text = "Post Date";
            // 
            // labelPostUserName
            // 
            this.labelPostUserName.AutoSize = true;
            this.labelPostUserName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.postAdapterWinFormsBindingSource, "UserName", true));
            this.labelPostUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPostUserName.Location = new System.Drawing.Point(20, 12);
            this.labelPostUserName.Name = "labelPostUserName";
            this.labelPostUserName.Size = new System.Drawing.Size(125, 18);
            this.labelPostUserName.TabIndex = 1;
            this.labelPostUserName.Text = "Post Username";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.labelPostiLkesAmount);
            this.panel1.Controls.Add(this.buttonPostLike);
            this.panel1.Location = new System.Drawing.Point(415, 586);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(544, 52);
            this.panel1.TabIndex = 4;
            // 
            // labelPostiLkesAmount
            // 
            this.labelPostiLkesAmount.AutoSize = true;
            this.labelPostiLkesAmount.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.postAdapterWinFormsBindingSource, "LikeCount", true));
            this.labelPostiLkesAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPostiLkesAmount.ForeColor = System.Drawing.Color.DodgerBlue;
            this.labelPostiLkesAmount.Location = new System.Drawing.Point(195, 21);
            this.labelPostiLkesAmount.Name = "labelPostiLkesAmount";
            this.labelPostiLkesAmount.Size = new System.Drawing.Size(17, 17);
            this.labelPostiLkesAmount.TabIndex = 10;
            this.labelPostiLkesAmount.Text = "0";
            // 
            // buttonPostLike
            // 
            this.buttonPostLike.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonPostLike.FlatAppearance.BorderSize = 0;
            this.buttonPostLike.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPostLike.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPostLike.Location = new System.Drawing.Point(272, 2);
            this.buttonPostLike.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonPostLike.Name = "buttonPostLike";
            this.buttonPostLike.Size = new System.Drawing.Size(71, 50);
            this.buttonPostLike.TabIndex = 9;
            this.buttonPostLike.Text = "👍 Like";
            this.buttonPostLike.UseVisualStyleBackColor = true;
            this.buttonPostLike.Click += new System.EventHandler(this.buttonPostLike_Click);
            // 
            // buttonPet
            // 
            this.buttonPet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonPet.Location = new System.Drawing.Point(127, 182);
            this.buttonPet.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonPet.Name = "buttonPet";
            this.buttonPet.Size = new System.Drawing.Size(84, 78);
            this.buttonPet.TabIndex = 79;
            this.buttonPet.TabStop = false;
            this.buttonPet.WaitOnLoad = true;
            this.buttonPet.Click += new System.EventHandler(this.buttonPet_Click);
            // 
            // buttonLogout
            // 
            this.buttonLogout.BackColor = System.Drawing.Color.Gray;
            this.buttonLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonLogout.Location = new System.Drawing.Point(1465, 12);
            this.buttonLogout.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(43, 41);
            this.buttonLogout.TabIndex = 76;
            this.buttonLogout.TabStop = false;
            this.buttonLogout.WaitOnLoad = true;
            this.buttonLogout.Click += new System.EventHandler(this.logoutLogo_Click);
            // 
            // facebookIcon
            // 
            this.facebookIcon.BackColor = System.Drawing.Color.White;
            this.facebookIcon.Location = new System.Drawing.Point(12, 12);
            this.facebookIcon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.facebookIcon.Name = "facebookIcon";
            this.facebookIcon.Size = new System.Drawing.Size(57, 55);
            this.facebookIcon.TabIndex = 75;
            this.facebookIcon.TabStop = false;
            this.facebookIcon.WaitOnLoad = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.AliceBlue;
            this.pictureBox1.Location = new System.Drawing.Point(27, 412);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(321, 210);
            this.pictureBox1.TabIndex = 64;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBoxProfile
            // 
            this.pictureBoxProfile.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxProfile.Location = new System.Drawing.Point(13, 94);
            this.pictureBoxProfile.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBoxProfile.Name = "pictureBoxProfile";
            this.pictureBoxProfile.Size = new System.Drawing.Size(133, 126);
            this.pictureBoxProfile.TabIndex = 55;
            this.pictureBoxProfile.TabStop = false;
            // 
            // pictureBoxCover
            // 
            this.pictureBoxCover.BackColor = System.Drawing.Color.White;
            this.pictureBoxCover.Location = new System.Drawing.Point(-8, -26);
            this.pictureBoxCover.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBoxCover.Name = "pictureBoxCover";
            this.pictureBoxCover.Size = new System.Drawing.Size(1649, 208);
            this.pictureBoxCover.TabIndex = 58;
            this.pictureBoxCover.TabStop = false;
            // 
            // backgroundLower
            // 
            this.backgroundLower.BackColor = System.Drawing.Color.Gainsboro;
            this.backgroundLower.Cursor = System.Windows.Forms.Cursors.Default;
            this.backgroundLower.Location = new System.Drawing.Point(-8, 380);
            this.backgroundLower.Margin = new System.Windows.Forms.Padding(4);
            this.backgroundLower.Name = "backgroundLower";
            this.backgroundLower.Size = new System.Drawing.Size(1649, 745);
            this.backgroundLower.TabIndex = 77;
            this.backgroundLower.TabStop = false;
            // 
            // buttonNextPost
            // 
            this.buttonNextPost.BackColor = System.Drawing.Color.Gainsboro;
            this.buttonNextPost.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonNextPost.Enabled = false;
            this.buttonNextPost.Location = new System.Drawing.Point(967, 586);
            this.buttonNextPost.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonNextPost.Name = "buttonNextPost";
            this.buttonNextPost.Size = new System.Drawing.Size(39, 50);
            this.buttonNextPost.TabIndex = 85;
            this.buttonNextPost.TabStop = false;
            this.buttonNextPost.WaitOnLoad = true;
            this.buttonNextPost.Click += new System.EventHandler(this.buttonNextPost_Click);
            // 
            // buttonPrevPost
            // 
            this.buttonPrevPost.BackColor = System.Drawing.Color.Gainsboro;
            this.buttonPrevPost.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonPrevPost.Enabled = false;
            this.buttonPrevPost.Location = new System.Drawing.Point(365, 588);
            this.buttonPrevPost.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonPrevPost.Name = "buttonPrevPost";
            this.buttonPrevPost.Size = new System.Drawing.Size(39, 50);
            this.buttonPrevPost.TabIndex = 86;
            this.buttonPrevPost.TabStop = false;
            this.buttonPrevPost.WaitOnLoad = true;
            this.buttonPrevPost.Click += new System.EventHandler(this.buttonPrevPost_Click);
            // 
            // pictureBoxLine
            // 
            this.pictureBoxLine.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxLine.BackColor = System.Drawing.Color.LightSkyBlue;
            this.pictureBoxLine.Location = new System.Drawing.Point(-237, -321);
            this.pictureBoxLine.Margin = new System.Windows.Forms.Padding(5);
            this.pictureBoxLine.Name = "pictureBoxLine";
            this.pictureBoxLine.Size = new System.Drawing.Size(2311, 12);
            this.pictureBoxLine.TabIndex = 87;
            this.pictureBoxLine.TabStop = false;
            // 
            // listBoxFriends
            // 
            this.listBoxFriends.BackColor = System.Drawing.Color.AliceBlue;
            this.listBoxFriends.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBoxFriends.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxFriends.FormattingEnabled = true;
            this.listBoxFriends.ItemHeight = 18;
            this.listBoxFriends.Location = new System.Drawing.Point(1057, 762);
            this.listBoxFriends.Margin = new System.Windows.Forms.Padding(4);
            this.listBoxFriends.Name = "listBoxFriends";
            this.listBoxFriends.Size = new System.Drawing.Size(281, 36);
            this.listBoxFriends.TabIndex = 88;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.AliceBlue;
            this.pictureBox3.Location = new System.Drawing.Point(1036, 709);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(319, 108);
            this.pictureBox3.TabIndex = 89;
            this.pictureBox3.TabStop = false;
            // 
            // labelFriends
            // 
            this.labelFriends.AutoSize = true;
            this.labelFriends.BackColor = System.Drawing.Color.AliceBlue;
            this.labelFriends.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFriends.Location = new System.Drawing.Point(1089, 720);
            this.labelFriends.Name = "labelFriends";
            this.labelFriends.Size = new System.Drawing.Size(182, 36);
            this.labelFriends.TabIndex = 90;
            this.labelFriends.Text = "Friends List";
            // 
            // buttonFetchAllData
            // 
            this.buttonFetchAllData.BackColor = System.Drawing.Color.LightSkyBlue;
            this.buttonFetchAllData.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonFetchAllData.Enabled = false;
            this.buttonFetchAllData.FlatAppearance.BorderSize = 0;
            this.buttonFetchAllData.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(250)))));
            this.buttonFetchAllData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFetchAllData.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFetchAllData.Location = new System.Drawing.Point(627, 298);
            this.buttonFetchAllData.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonFetchAllData.Name = "buttonFetchAllData";
            this.buttonFetchAllData.Size = new System.Drawing.Size(131, 43);
            this.buttonFetchAllData.TabIndex = 91;
            this.buttonFetchAllData.Text = "All";
            this.buttonFetchAllData.UseVisualStyleBackColor = false;
            this.buttonFetchAllData.Click += new System.EventHandler(this.buttonFetchAllData_Click);
            // 
            // buttonLikedPages
            // 
            this.buttonLikedPages.BackColor = System.Drawing.Color.LightSkyBlue;
            this.buttonLikedPages.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonLikedPages.Enabled = false;
            this.buttonLikedPages.FlatAppearance.BorderSize = 0;
            this.buttonLikedPages.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(250)))));
            this.buttonLikedPages.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLikedPages.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLikedPages.Location = new System.Drawing.Point(477, 298);
            this.buttonLikedPages.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonLikedPages.Name = "buttonLikedPages";
            this.buttonLikedPages.Size = new System.Drawing.Size(131, 43);
            this.buttonLikedPages.TabIndex = 92;
            this.buttonLikedPages.Text = "Liked Pages";
            this.buttonLikedPages.UseVisualStyleBackColor = false;
            this.buttonLikedPages.Click += new System.EventHandler(this.buttonEvents_Click);
            // 
            // pictureBoxTimer
            // 
            this.pictureBoxTimer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxTimer.Location = new System.Drawing.Point(1429, 279);
            this.pictureBoxTimer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBoxTimer.Name = "pictureBoxTimer";
            this.pictureBoxTimer.Size = new System.Drawing.Size(77, 78);
            this.pictureBoxTimer.TabIndex = 93;
            this.pictureBoxTimer.TabStop = false;
            this.pictureBoxTimer.Click += new System.EventHandler(this.pictureBoxTimer_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.AliceBlue;
            this.pictureBox2.Location = new System.Drawing.Point(27, 641);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(321, 193);
            this.pictureBox2.TabIndex = 94;
            this.pictureBox2.TabStop = false;
            // 
            // labelLikedPages
            // 
            this.labelLikedPages.AutoSize = true;
            this.labelLikedPages.BackColor = System.Drawing.Color.AliceBlue;
            this.labelLikedPages.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLikedPages.Location = new System.Drawing.Point(77, 650);
            this.labelLikedPages.Name = "labelLikedPages";
            this.labelLikedPages.Size = new System.Drawing.Size(190, 36);
            this.labelLikedPages.TabIndex = 95;
            this.labelLikedPages.Text = "Liked Pages";
            // 
            // listBoxLikedPages
            // 
            this.listBoxLikedPages.BackColor = System.Drawing.Color.AliceBlue;
            this.listBoxLikedPages.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBoxLikedPages.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxLikedPages.FormattingEnabled = true;
            this.listBoxLikedPages.ItemHeight = 18;
            this.listBoxLikedPages.Location = new System.Drawing.Point(39, 690);
            this.listBoxLikedPages.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBoxLikedPages.Name = "listBoxLikedPages";
            this.listBoxLikedPages.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.listBoxLikedPages.ScrollAlwaysVisible = true;
            this.listBoxLikedPages.Size = new System.Drawing.Size(291, 90);
            this.listBoxLikedPages.TabIndex = 96;
            // 
            // sortAscendingButton
            // 
            this.sortAscendingButton.Enabled = false;
            this.sortAscendingButton.Location = new System.Drawing.Point(41, 789);
            this.sortAscendingButton.Margin = new System.Windows.Forms.Padding(4);
            this.sortAscendingButton.Name = "sortAscendingButton";
            this.sortAscendingButton.Size = new System.Drawing.Size(116, 28);
            this.sortAscendingButton.TabIndex = 97;
            this.sortAscendingButton.Text = "Sort Ascending";
            this.sortAscendingButton.UseVisualStyleBackColor = true;
            this.sortAscendingButton.Click += new System.EventHandler(this.sortAscendingButton_Click);
            // 
            // sortPictureAscending
            // 
            this.sortPictureAscending.Enabled = false;
            this.sortPictureAscending.Location = new System.Drawing.Point(1021, 657);
            this.sortPictureAscending.Margin = new System.Windows.Forms.Padding(4);
            this.sortPictureAscending.Name = "sortPictureAscending";
            this.sortPictureAscending.Size = new System.Drawing.Size(212, 28);
            this.sortPictureAscending.TabIndex = 98;
            this.sortPictureAscending.Text = "Sort Picture Ascending Date";
            this.sortPictureAscending.UseVisualStyleBackColor = true;
            this.sortPictureAscending.Click += new System.EventHandler(this.sortPictureAscending_Click);
            // 
            // sortDescendingButton
            // 
            this.sortDescendingButton.Enabled = false;
            this.sortDescendingButton.Location = new System.Drawing.Point(192, 789);
            this.sortDescendingButton.Margin = new System.Windows.Forms.Padding(4);
            this.sortDescendingButton.Name = "sortDescendingButton";
            this.sortDescendingButton.Size = new System.Drawing.Size(137, 28);
            this.sortDescendingButton.TabIndex = 99;
            this.sortDescendingButton.Text = "Sort Descending";
            this.sortDescendingButton.UseVisualStyleBackColor = true;
            this.sortDescendingButton.Click += new System.EventHandler(this.sortDescendingButton_Click);
            // 
            // sortPictureDescending
            // 
            this.sortPictureDescending.Enabled = false;
            this.sortPictureDescending.Location = new System.Drawing.Point(1275, 658);
            this.sortPictureDescending.Margin = new System.Windows.Forms.Padding(4);
            this.sortPictureDescending.Name = "sortPictureDescending";
            this.sortPictureDescending.Size = new System.Drawing.Size(212, 28);
            this.sortPictureDescending.TabIndex = 100;
            this.sortPictureDescending.Text = "Sort Picture Descending Date";
            this.sortPictureDescending.UseVisualStyleBackColor = true;
            this.sortPictureDescending.Click += new System.EventHandler(this.sortPictureDescending_Click);
            // 
            // panelPictureBox
            // 
            this.panelPictureBox.BackColor = System.Drawing.Color.AliceBlue;
            this.panelPictureBox.Location = new System.Drawing.Point(1020, 412);
            this.panelPictureBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelPictureBox.Name = "panelPictureBox";
            this.panelPictureBox.Size = new System.Drawing.Size(467, 240);
            this.panelPictureBox.TabIndex = 101;
            // 
            // buttonNotification
            // 
            this.buttonNotification.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.buttonNotification.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonNotification.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNotification.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.buttonNotification.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonNotification.Location = new System.Drawing.Point(1207, 1);
            this.buttonNotification.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonNotification.Name = "buttonNotification";
            this.buttonNotification.Size = new System.Drawing.Size(175, 41);
            this.buttonNotification.TabIndex = 104;
            this.buttonNotification.Text = "Notifications";
            this.buttonNotification.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.buttonNotification.UseVisualStyleBackColor = true;
            this.buttonNotification.Click += new System.EventHandler(this.buttonNotification_Click);
            // 
            // pictureBoxDeleteNotifications
            // 
            this.pictureBoxDeleteNotifications.BackColor = System.Drawing.Color.White;
            this.pictureBoxDeleteNotifications.Location = new System.Drawing.Point(1465, 82);
            this.pictureBoxDeleteNotifications.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBoxDeleteNotifications.Name = "pictureBoxDeleteNotifications";
            this.pictureBoxDeleteNotifications.Size = new System.Drawing.Size(49, 46);
            this.pictureBoxDeleteNotifications.TabIndex = 105;
            this.pictureBoxDeleteNotifications.TabStop = false;
            this.pictureBoxDeleteNotifications.Click += new System.EventHandler(this.pictureBoxDeleteNotifications_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScrollMargin = new System.Drawing.Size(15, 0);
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(1656, 844);
            this.Controls.Add(this.pictureBoxDeleteNotifications);
            this.Controls.Add(this.buttonNotification);
            this.Controls.Add(this.panelPictureBox);
            this.Controls.Add(this.sortPictureDescending);
            this.Controls.Add(this.sortDescendingButton);
            this.Controls.Add(this.sortPictureAscending);
            this.Controls.Add(this.sortAscendingButton);
            this.Controls.Add(this.listBoxLikedPages);
            this.Controls.Add(this.labelLikedPages);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBoxTimer);
            this.Controls.Add(this.buttonLikedPages);
            this.Controls.Add(this.buttonFetchAllData);
            this.Controls.Add(this.listBoxFriends);
            this.Controls.Add(this.labelFriends);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.buttonPrevPost);
            this.Controls.Add(this.buttonNextPost);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelPost);
            this.Controls.Add(this.labelMyPet);
            this.Controls.Add(this.buttonPet);
            this.Controls.Add(this.labelFriendsCount);
            this.Controls.Add(this.buttonLogout);
            this.Controls.Add(this.facebookIcon);
            this.Controls.Add(this.labelUserName);
            this.Controls.Add(this.buttonAddBio);
            this.Controls.Add(this.listBoxIntro);
            this.Controls.Add(this.labelAbout);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonFriends);
            this.Controls.Add(this.button_Photos);
            this.Controls.Add(this.button_Posts);
            this.Controls.Add(this.pictureBoxProfile);
            this.Controls.Add(this.pictureBoxCover);
            this.Controls.Add(this.backgroundLower);
            this.Controls.Add(this.pictureBoxLine);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Facebook App";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.SizeChanged += new System.EventHandler(this.formMainSizeChanged);
            this.panelPost.ResumeLayout(false);
            this.panelPost.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.postAdapterWinFormsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.descreptionListBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPostPicture)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.buttonPet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonLogout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.facebookIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCover)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.backgroundLower)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonNextPost)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonPrevPost)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLine)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTimer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDeleteNotifications)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

		#endregion
        private System.Windows.Forms.PictureBox pictureBoxProfile;
        private System.Windows.Forms.Button button_Posts;
        private System.Windows.Forms.Button button_Photos;
        private System.Windows.Forms.Button buttonFriends;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelAbout;
        private System.Windows.Forms.ListBox listBoxIntro;
        private System.Windows.Forms.Button buttonAddBio;
        private System.Windows.Forms.Label labelUserName;
        private System.Windows.Forms.PictureBox facebookIcon;
        private System.Windows.Forms.PictureBox pictureBoxCover;
        private System.Windows.Forms.PictureBox buttonLogout;
        private System.Windows.Forms.PictureBox backgroundLower;
        private System.Windows.Forms.Label labelFriendsCount;
        private System.Windows.Forms.PictureBox buttonPet;
        private System.Windows.Forms.Label labelMyPet;
        private System.Windows.Forms.Panel panelPost;
        private System.Windows.Forms.Label labelPostUserName;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelPostDate;
        private System.Windows.Forms.Button buttonPostLike;
        private System.Windows.Forms.Label labelPostiLkesAmount;
        private System.Windows.Forms.PictureBox buttonNextPost;
        private System.Windows.Forms.PictureBox buttonPrevPost;
        private System.Windows.Forms.PictureBox pictureBoxLine;
        private System.Windows.Forms.PictureBox pictureBoxPostPicture;
        private System.Windows.Forms.ListBox listBoxFriends;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label labelFriends;
        private System.Windows.Forms.Button buttonFetchAllData;
        private System.Windows.Forms.Button buttonLikedPages;
        private System.Windows.Forms.PictureBox pictureBoxTimer;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label labelLikedPages;
        private System.Windows.Forms.ListBox listBoxLikedPages;
        private System.Windows.Forms.BindingSource postAdapterWinFormsBindingSource;
        private System.Windows.Forms.ListBox descreptionListBox;
        private System.Windows.Forms.BindingSource descreptionListBindingSource;
        private System.Windows.Forms.LinkLabel linkLinkLabel;
        private System.Windows.Forms.Label postTypeLabel1;
        private System.Windows.Forms.Button sortAscendingButton;
        private System.Windows.Forms.Button sortPictureAscending;
        private System.Windows.Forms.Button sortDescendingButton;
        private System.Windows.Forms.Button sortPictureDescending;
        private System.Windows.Forms.Panel panelPictureBox;
        private System.Windows.Forms.Button buttonNotification;
        private System.Windows.Forms.PictureBox pictureBoxDeleteNotifications;
    }
}