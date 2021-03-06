﻿using System;
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
    //Hii Almog I want to upload this to your computer
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        User m_LoggedInUser;
        List<Photo> m_photoList = new List<Photo>();
        List<User> m_PhotosTagsWith = new List<User>();
        List<Photo> m_25photosList;
        List<Photo> m_photosByUser;

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
            // m_photoList = m_LoggedInUser.PhotosTaggedIn;

            fetchAlltaggedPictures();

        }

        private void fetchAlltaggedPictures()
        {
            PicturesColleciton picture = m_LoggedInUser.Pictures;

            foreach (Album album in m_LoggedInUser.Albums)
            {
                addPhotos(album.Photos);
            }

            addPhotos(m_LoggedInUser.PhotosTaggedIn);

            m_25photosList = new List<Photo>();

            for (int i = 1; i < 5; i++)
            {
                m_25photosList.Add(m_photoList[i]);

            }

            showPhotos(m_25photosList);

        }

        private void showPhotos(List<Photo> photolist)
        {
            foreach (Photo photo in photolist)
            {
                UserImageList.Images.Add(photo.ImageNormal);
            }

            ImageListView.View = View.LargeIcon;
            ImageListView.LargeImageList = UserImageList;

            for (int j = 0; j < this.UserImageList.Images.Count; j++)
            {
                ListViewItem item = new ListViewItem();
                item.ImageIndex = j;
                this.ImageListView.Items.Add(item);
            }  
        }

        private void addPhotos(FacebookObjectCollection<Photo> photos)
        {
            foreach (Photo photo in photos)
            {
                m_photoList.Add(photo);
                FacebookObjectCollection<PhotoTag> photoTags = photo.Tags;
                if (photo.Tags != null)
                {
                    foreach (PhotoTag photoTag in photoTags)
                    {
                        if (!m_PhotosTagsWith.Contains(photoTag.User))
                        {
                            m_PhotosTagsWith.Add(photoTag.User);
                            UserTagedWithList.Items.Add(photoTag.User.Name);
                        }
                    }
                }
            }
        }

        private void button_Login_Click(object sender, EventArgs e)
        {
            if(m_LoggedInUser == null)
            {
                loginToUser();
                button_Login.Text = "Logout";
            }
            else
            {
                m_LoggedInUser = null;
                button_Login.Text = "Login";
            }
        }

        private void picture_smallPictureBox_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void UserTagedWithList_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void SeachPhotos_Click(object sender, EventArgs e)
        {
            m_photosByUser = new List<Photo>(); 
            ImageListView.Clear();
            UserImageList.Dispose();
            foreach (Photo photo in m_photoList)
            {
                FacebookObjectCollection<PhotoTag> photoTags = photo.Tags;
                if (photo.Tags != null & !m_photosByUser.Contains(photo))
                {
                    foreach (PhotoTag photoTag in photoTags)
                    {
                        if (UserTagedWithList.CheckedItems.Contains(photoTag.User.Name))
                        {
                            m_photosByUser.Add(photo);
                        }
                    }
                }
            }
            showPhotos(m_photosByUser);
        }
    }
}
