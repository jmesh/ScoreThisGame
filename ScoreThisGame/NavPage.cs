using System;

using Xamarin.Forms;

namespace ScoreThisGame
{
	public class NavPage : ContentPage
	{
		public NavPage ()
		{
			Content = new StackLayout { 
				Children = {
					new Label { Text = "Hello ContentPage" }
				}
			};
		}
	}
}


