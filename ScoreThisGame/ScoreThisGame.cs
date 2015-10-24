using System;

using Xamarin.Forms;
using System.Collections.Generic;

namespace ScoreThisGame
{
	public class App : Application
	{
		public App ()
		{

			Picker gameSelect = new Picker {
				Title = "Game",
				VerticalOptions = LayoutOptions.CenterAndExpand
			};

			Button btnStartGame = new Button {
				Text = "Start Game",

				Font = Font.SystemFontOfSize (NamedSize.Large),
				BorderWidth = 1,
				HorizontalOptions = LayoutOptions.Center,
				VerticalOptions = LayoutOptions.CenterAndExpand
			};

			btnStartGame.Clicked += OnStartGameClicked;

			var games = new [] {
				new { value = "1", name = "Cricket"},
				new { value = "2", name = "301"},
				new { value = "3", name = "401"},
				new { value = "4", name = "501"},
			};

			foreach (var game in games) 
			{
				gameSelect.Items.Add (game.name);
			}


			// The root page of your application
			MainPage = new ContentPage {
				Content = new StackLayout {
					VerticalOptions = LayoutOptions.Center,
					Children = {
						new Label {
							XAlign = TextAlignment.Center,
							Text = "Please Select a game type below: ",
						},
						gameSelect,
						btnStartGame
					}
				}
			};
		}
			

		protected void OnStartGameClicked (object sender, EventArgs e)
		{
			
		}


		protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}

