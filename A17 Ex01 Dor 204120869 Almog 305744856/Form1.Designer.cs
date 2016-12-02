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
            this.button_Login = new System.Windows.Forms.Button();
            this.picture_smallPictureBox = new System.Windows.Forms.PictureBox();
            this.EventsListBox = new System.Windows.Forms.CheckedListBox();
            ((System.ComponentModel.ISupportInitialize)(this.picture_smallPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // button_Login
            // 
            this.button_Login.Location = new System.Drawing.Point(663, 39);
            this.button_Login.Name = "button_Login";
            this.button_Login.Size = new System.Drawing.Size(141, 74);
            this.button_Login.TabIndex = 0;
            this.button_Login.Text = "Login";
            this.button_Login.UseVisualStyleBackColor = true;
            this.button_Login.Click += new System.EventHandler(this.button_Login_Click);
            // 
            // picture_smallPictureBox
            // 
            this.picture_smallPictureBox.Location = new System.Drawing.Point(615, 143);
            this.picture_smallPictureBox.Name = "picture_smallPictureBox";
            this.picture_smallPictureBox.Size = new System.Drawing.Size(218, 181);
            this.picture_smallPictureBox.TabIndex = 1;
            this.picture_smallPictureBox.TabStop = false;
            this.picture_smallPictureBox.Click += new System.EventHandler(this.picture_smallPictureBox_Click);
            // 
            // EventsListBox
            // 
            this.EventsListBox.FormattingEnabled = true;
            this.EventsListBox.Location = new System.Drawing.Point(12, 39);
            this.EventsListBox.Name = "EventsListBox";
            this.EventsListBox.Size = new System.Drawing.Size(426, 420);
            this.EventsListBox.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(912, 581);
            this.Controls.Add(this.EventsListBox);
            this.Controls.Add(this.picture_smallPictureBox);
            this.Controls.Add(this.button_Login);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.picture_smallPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_Login;
        private System.Windows.Forms.PictureBox picture_smallPictureBox;
        private System.Windows.Forms.CheckedListBox EventsListBox;
    }
}

