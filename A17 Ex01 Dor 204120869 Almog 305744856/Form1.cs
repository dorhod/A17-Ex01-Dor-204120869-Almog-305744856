using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Facebook;
using FacebookWrapper;
using FacebookWrapper.ObjectModel;
using System.Collections;

namespace A17_Ex01_Dor_204120869_Almog_305744856
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        User m_LoggedInUser;
        FacebookObjectCollection<Group> m_GroupsList;

        private void loginToUser()
        {
            LoginResult result = FacebookService.Login("596174253921671",
                "public_profile",
                "user_education_history",
                "user_birthday",
                "user_actions.video",
                "user_actions.news",
                "user_actions.music",
                "user_actions.fitness",
                "user_actions.books",
                "user_about_me",
                "user_friends",
                "publish_actions",
                "user_events",
                "user_games_activity",
                "user_hometown",
                "user_likes",
                "user_location",
                "user_managed_groups",
                "user_photos",
                "user_posts",
                "user_relationships",
                "user_relationship_details",
                "user_religion_politics",
                "user_tagged_places",
                "user_videos",
                "user_website",
                "user_work_history",
                "read_custom_friendlists",
                "read_page_mailboxes",
                "manage_pages",
                "publish_pages",
                "publish_actions",
                "rsvp_event"
                );


            if (!string.IsNullOrEmpty(result.AccessToken))
            {
                m_LoggedInUser = result.LoggedInUser;
                fetchUserInfo();
            }
            else
            {
                MessageBox.Show(result.ErrorMessage);
            }
        }

        private void fetchUserInfo()
        {
            picture_smallPictureBox.LoadAsync(m_LoggedInUser.PictureNormalURL);
            m_GroupsList = m_LoggedInUser.Groups;

            foreach (Group group in m_GroupsList)
            {
                EventsListBox.Items.Add(group);
               // group.Name;
            }
            
        }

        private void button_Login_Click(object sender, EventArgs e)
        {
            loginToUser();
        }

        private void picture_smallPictureBox_Click(object sender, EventArgs e)
        {

        }
    }
}
