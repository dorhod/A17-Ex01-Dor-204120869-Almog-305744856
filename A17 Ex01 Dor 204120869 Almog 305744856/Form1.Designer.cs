namespace A17_Ex01_Dor_204120869_Almog_305744856
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button_Login = new System.Windows.Forms.Button();
            this.UserImageList = new System.Windows.Forms.ImageList(this.components);
            this.ImageListView = new System.Windows.Forms.ListView();
            this.UserTagedWithList = new System.Windows.Forms.CheckedListBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.picture_smallPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_smallPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // button_Login
            // 
            this.button_Login.BackgroundImage = global::A17_Ex01_Dor_204120869_Almog_305744856.Properties.Resources.Top;
            this.button_Login.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_Login.Font = new System.Drawing.Font("Segoe Script", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Login.ForeColor = System.Drawing.SystemColors.Control;
            this.button_Login.Location = new System.Drawing.Point(2, 63);
            this.button_Login.Name = "button_Login";
            this.button_Login.Size = new System.Drawing.Size(171, 71);
            this.button_Login.TabIndex = 0;
            this.button_Login.Text = "Login";
            this.button_Login.UseVisualStyleBackColor = true;
            this.button_Login.Click += new System.EventHandler(this.button_Login_Click);
            // 
            // UserImageList
            // 
            this.UserImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("UserImageList.ImageStream")));
            this.UserImageList.TransparentColor = System.Drawing.Color.Violet;
            this.UserImageList.Images.SetKeyName(0, "stock-photo-paris-jun-qatar-airways-airbus-a-xwb-cockpit-qatar-airways-is-the-fir" +
        "st-user-of-the-290172134.jpg");
            // 
            // ImageListView
            // 
            this.ImageListView.Location = new System.Drawing.Point(548, 168);
            this.ImageListView.Name = "ImageListView";
            this.ImageListView.Size = new System.Drawing.Size(1056, 784);
            this.ImageListView.TabIndex = 2;
            this.ImageListView.UseCompatibleStateImageBehavior = false;
            // 
            // UserTagedWithList
            // 
            this.UserTagedWithList.BackColor = System.Drawing.SystemColors.Menu;
            this.UserTagedWithList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.UserTagedWithList.FormattingEnabled = true;
            this.UserTagedWithList.Location = new System.Drawing.Point(30, 168);
            this.UserTagedWithList.Name = "UserTagedWithList";
            this.UserTagedWithList.Size = new System.Drawing.Size(298, 780);
            this.UserTagedWithList.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::A17_Ex01_Dor_204120869_Almog_305744856.Properties.Resources.Top;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(12, 33);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1592, 48);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // picture_smallPictureBox
            // 
            this.picture_smallPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picture_smallPictureBox.Location = new System.Drawing.Point(1453, 17);
            this.picture_smallPictureBox.Name = "picture_smallPictureBox";
            this.picture_smallPictureBox.Size = new System.Drawing.Size(137, 117);
            this.picture_smallPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picture_smallPictureBox.TabIndex = 1;
            this.picture_smallPictureBox.TabStop = false;
            this.picture_smallPictureBox.Click += new System.EventHandler(this.picture_smallPictureBox_Click);
            // 
            // Form1
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1616, 1020);
            this.Controls.Add(this.UserTagedWithList);
            this.Controls.Add(this.ImageListView);
            this.Controls.Add(this.picture_smallPictureBox);
            this.Controls.Add(this.button_Login);
            this.Controls.Add(this.pictureBox1);
            this.DataBindings.Add(new System.Windows.Forms.Binding("Location", global::A17_Ex01_Dor_204120869_Almog_305744856.Properties.Settings.Default, "top", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.Location = global::A17_Ex01_Dor_204120869_Almog_305744856.Properties.Settings.Default.top;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture_smallPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_Login;
        private System.Windows.Forms.PictureBox picture_smallPictureBox;
        private System.Windows.Forms.ImageList UserImageList;
        private System.Windows.Forms.ListView ImageListView;
        private System.Windows.Forms.CheckedListBox UserTagedWithList;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

