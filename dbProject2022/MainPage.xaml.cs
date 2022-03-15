using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace dbProject2022
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        void loginBtn_Clicked(System.Object sender, System.EventArgs e)
        {

            Navigation.PushAsync(new HomePage());
        }
    }

    
}
