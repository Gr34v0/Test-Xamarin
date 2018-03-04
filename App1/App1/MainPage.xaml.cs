using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App1
{
	public partial class MainPage : ContentPage
	{

        public MainPage()
		{
			InitializeComponent();
		}

        private async void HelloButton_OnClicked(object sender, EventArgs e)
        {
            var name = textNameEntry.Text;
            await DisplayAlert("Greetings", $"Hello {name}!", "Howdy");

        }

        private async void Page1_OnClicked(object sender, EventArgs e)
        {
            if ( textNameEntry.Text == "Test User" ) {
                await Navigation.PushAsync(new Page1());
            }
            else
            {
                await DisplayAlert("ERROR", $"Username not valid\n" + $"Try again with \"Test User\"", "Okay");
            }
          
        }
        

	}
}
