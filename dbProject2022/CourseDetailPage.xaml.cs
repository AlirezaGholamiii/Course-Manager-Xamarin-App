using System;
using System.Collections.Generic;
using dbProject2022.Model;
using Xamarin.Forms;
using SQLite;

namespace dbProject2022
{
    public partial class CourseDetailPage : ContentPage
    {

        //Global variable to strore data
        Course selectedCourse = new Course();

        public CourseDetailPage()
        {
            InitializeComponent();
        }



        public CourseDetailPage(Course text)
        {
            InitializeComponent();

            selectedCourse = text;
            experienceEntary.Text = text.Experience;
        }

        void Button_Clicked(System.Object sender, System.EventArgs e)
        {

            //By using Using for creating connection we dont need to close the connection.
            using (SQLiteConnection conn = new SQLiteConnection(App.DatabaseLocation))
            {
                selectedCourse.Experience = experienceEntary.Text;

                conn.CreateTable<Course>();
                int row = conn.Update(selectedCourse);
                if (row > 0)
                {
                    DisplayAlert("Successfully Updated!","Data update","Ok");
                }
                else
                {
                    DisplayAlert("Failed!", "Error", "Ok");
                }
               
                
                

               
            }
        }

        void Button_Clicked_1(System.Object sender, System.EventArgs e)
        {

            //By using Using for creating connection we dont need to close the connection.
            using (SQLiteConnection conn = new SQLiteConnection(App.DatabaseLocation))
            {
                selectedCourse.Experience = experienceEntary.Text;

                conn.CreateTable<Course>();
                int row = conn.Delete(selectedCourse);
                if (row > 0)
                {
                    DisplayAlert("Successfully Deleted!", "Data Deletation", "Ok");
                }
                else
                {
                    DisplayAlert("Failed!", "Error", "Ok");
                }
             




            }
        }
    }
}
