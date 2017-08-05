namespace C17_Ex01_Gal_203628763_Guy_308121383
{
    partial class FacebookMainForm
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
            this.TabControl = new System.Windows.Forms.TabControl();
            this.LoginTab = new System.Windows.Forms.TabPage();
            this.buttonLogIn = new System.Windows.Forms.Button();
            this.FacebookTab = new System.Windows.Forms.TabPage();
            this.buttonSubmitPost = new System.Windows.Forms.Button();
            this.textBoxPost = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.pictureBoxProfile = new System.Windows.Forms.PictureBox();
            this.FavoritesTab = new System.Windows.Forms.TabPage();
            this.TodoTab = new System.Windows.Forms.TabPage();
            this.TabControl.SuspendLayout();
            this.LoginTab.SuspendLayout();
            this.FacebookTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfile)).BeginInit();
            this.SuspendLayout();
            // 
            // TabControl
            // 
            this.TabControl.Controls.Add(this.LoginTab);
            this.TabControl.Controls.Add(this.FacebookTab);
            this.TabControl.Controls.Add(this.FavoritesTab);
            this.TabControl.Controls.Add(this.TodoTab);
            this.TabControl.Location = new System.Drawing.Point(3, 0);
            this.TabControl.Name = "TabControl";
            this.TabControl.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TabControl.SelectedIndex = 0;
            this.TabControl.Size = new System.Drawing.Size(871, 390);
            this.TabControl.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.TabControl.TabIndex = 0;
            // 
            // LoginTab
            // 
            this.LoginTab.AccessibleName = "LoginTab";
            this.LoginTab.BackColor = System.Drawing.Color.WhiteSmoke;
            this.LoginTab.Controls.Add(this.buttonLogIn);
            this.LoginTab.Location = new System.Drawing.Point(4, 22);
            this.LoginTab.Name = "LoginTab";
            this.LoginTab.Padding = new System.Windows.Forms.Padding(3);
            this.LoginTab.Size = new System.Drawing.Size(863, 364);
            this.LoginTab.TabIndex = 0;
            this.LoginTab.Text = "Login";
            // 
            // buttonLogIn
            // 
            this.buttonLogIn.Location = new System.Drawing.Point(340, 141);
            this.buttonLogIn.Name = "buttonLogIn";
            this.buttonLogIn.Size = new System.Drawing.Size(219, 110);
            this.buttonLogIn.TabIndex = 0;
            this.buttonLogIn.Text = "Login";
            this.buttonLogIn.UseVisualStyleBackColor = true;
            this.buttonLogIn.Click += new System.EventHandler(this.buttonLogIn_Click);
            // 
            // FacebookTab
            // 
            this.FacebookTab.AccessibleName = "Facebook";
            this.FacebookTab.Controls.Add(this.buttonSubmitPost);
            this.FacebookTab.Controls.Add(this.textBoxPost);
            this.FacebookTab.Controls.Add(this.labelName);
            this.FacebookTab.Controls.Add(this.pictureBoxProfile);
            this.FacebookTab.Location = new System.Drawing.Point(4, 22);
            this.FacebookTab.Name = "FacebookTab";
            this.FacebookTab.Padding = new System.Windows.Forms.Padding(3);
            this.FacebookTab.Size = new System.Drawing.Size(863, 364);
            this.FacebookTab.TabIndex = 1;
            this.FacebookTab.Text = "Facebook";
            this.FacebookTab.UseVisualStyleBackColor = true;
            // 
            // buttonSubmitPost
            // 
            this.buttonSubmitPost.Location = new System.Drawing.Point(379, 53);
            this.buttonSubmitPost.Name = "buttonSubmitPost";
            this.buttonSubmitPost.Size = new System.Drawing.Size(75, 23);
            this.buttonSubmitPost.TabIndex = 3;
            this.buttonSubmitPost.Text = "Post!";
            this.buttonSubmitPost.UseVisualStyleBackColor = true;
            // 
            // textBoxPost
            // 
            this.textBoxPost.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPost.Location = new System.Drawing.Point(104, 53);
            this.textBoxPost.Name = "textBoxPost";
            this.textBoxPost.Size = new System.Drawing.Size(255, 23);
            this.textBoxPost.TabIndex = 2;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.Location = new System.Drawing.Point(100, 13);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(119, 20);
            this.labelName.TabIndex = 1;
            this.labelName.Text = "First Last name";
            // 
            // pictureBoxProfile
            // 
            this.pictureBoxProfile.Location = new System.Drawing.Point(18, 7);
            this.pictureBoxProfile.Name = "pictureBoxProfile";
            this.pictureBoxProfile.Size = new System.Drawing.Size(66, 69);
            this.pictureBoxProfile.TabIndex = 0;
            this.pictureBoxProfile.TabStop = false;
            // 
            // FavoritesTab
            // 
            this.FavoritesTab.AccessibleName = "FavoritesTab";
            this.FavoritesTab.Location = new System.Drawing.Point(4, 22);
            this.FavoritesTab.Name = "FavoritesTab";
            this.FavoritesTab.Padding = new System.Windows.Forms.Padding(3);
            this.FavoritesTab.Size = new System.Drawing.Size(863, 364);
            this.FavoritesTab.TabIndex = 2;
            this.FavoritesTab.Text = "Favorites";
            this.FavoritesTab.UseVisualStyleBackColor = true;
            // 
            // TodoTab
            // 
            this.TodoTab.AccessibleName = "TodoTab";
            this.TodoTab.Location = new System.Drawing.Point(4, 22);
            this.TodoTab.Name = "TodoTab";
            this.TodoTab.Size = new System.Drawing.Size(863, 364);
            this.TodoTab.TabIndex = 3;
            this.TodoTab.Text = "TODO";
            this.TodoTab.UseVisualStyleBackColor = true;
            // 
            // FacebookMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(875, 388);
            this.Controls.Add(this.TabControl);
            this.Name = "FacebookMainForm";
            this.Text = "FacebookMainForm";
            this.TabControl.ResumeLayout(false);
            this.LoginTab.ResumeLayout(false);
            this.FacebookTab.ResumeLayout(false);
            this.FacebookTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfile)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl TabControl;
        private System.Windows.Forms.TabPage LoginTab;
        private System.Windows.Forms.TabPage FacebookTab;
        private System.Windows.Forms.TabPage FavoritesTab;
        private System.Windows.Forms.TabPage TodoTab;
        private System.Windows.Forms.Button buttonLogIn;
        private System.Windows.Forms.Button buttonSubmitPost;
        private System.Windows.Forms.TextBox textBoxPost;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.PictureBox pictureBoxProfile;
    }
}