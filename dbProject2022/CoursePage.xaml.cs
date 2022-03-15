using System;
using System.Collections.Generic;
using SQLite;
using dbProject2022.Model;

using Xamarin.Forms;

namespace dbProject2022
{
    public partial class CoursePage : ContentPage
    {
        public CoursePage()
        {
            InitializeComponent();
        }

        void ToolbarItem_Clicked(System.Object sender, System.EventArgs e)
        {

            //we should save in db here
            Course course = new Course()
            {
                Experience = experienceEntry.Text
            };


            //By using Using for creating connection we dont need to close the connection.
            using (SQLiteConnection conn = new SQLiteConnection(App.DatabaseLocation))
            {
                conn.CreateTable<Course>();
                int row = conn.Insert(course);


                if (row > 0)
                {
                    DisplayAlert("Success", "Data is added", "Ok");
                }
                else
                {
                    DisplayAlert("Faild", "Data is not added", "Ok");
                }
                
                //conn.Close();
            }
        }
    }
}
