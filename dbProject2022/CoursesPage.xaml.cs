using System;
using System.Collections.Generic;
using SQLite;
using dbProject2022.Model;

using Xamarin.Forms;

namespace dbProject2022
{
    public partial class CoursesPage : ContentPage
    {
        public CoursesPage()
        {
            InitializeComponent();


            //we should save in db here
            Course course = new Course()
            {
                //Experience = experienceEntry.Text
            };


        }


        protected override void OnAppearing()
        {
            base.OnAppearing();


            //By using Using for creating connection we dont need to close the connection.
            using (SQLiteConnection conn = new SQLiteConnection(App.DatabaseLocation))
            {
                conn.CreateTable<Course>();

                //this will check the table and return iteams as a list
                var courses = conn.Table<Course>().ToList();

                courseListView.ItemsSource = courses;
            }

        }


        void courseListView_ItemSelected(System.Object sender, Xamarin.Forms.SelectedItemChangedEventArgs e)
        {
            var selectedCourse = courseListView.SelectedItem as Course;

            if(selectedCourse != null)
            {
                Navigation.PushAsync(new CourseDetailPage(selectedCourse));
            }
            
        }

    }
}
