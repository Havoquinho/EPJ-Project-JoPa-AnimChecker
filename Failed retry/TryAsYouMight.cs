using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace AnimeChecklistApp
{
    public partial class MainPage : ContentPage
    {
        List<string> animeList = new List<string>();
        Entry animeEntry;
        Button addButton;
        Button removeButton;
        ListView animeListView;

        public MainPage()
        {
            animeEntry = new Entry
            {
                Placeholder = "Enter Anime Title",
                HorizontalOptions = LayoutOptions.FillAndExpand
            };

            addButton = new Button
            {
                Text = "Add Anime",
                HorizontalOptions = LayoutOptions.FillAndExpand
            };

            addButton.Clicked += AddAnime;

            removeButton = new Button
            {
                Text = "Remove Anime",
                HorizontalOptions = LayoutOptions.FillAndExpand
            };

            removeButton.Clicked += RemoveAnime;

            animeListView = new ListView
            {
                ItemsSource = animeList,
                HorizontalOptions = LayoutOptions.FillAndExpand,
                VerticalOptions = LayoutOptions.FillAndExpand
            };

            Content = new StackLayout
            {
                Children =
                {
                    animeEntry,
                    addButton,
                    removeButton,
                    animeListView
                }
            };
        }

        private void AddAnime(object sender, EventArgs e)
        {
            string animeTitle = animeEntry.Text;
            if (!string.IsNullOrEmpty(animeTitle))
            {
                animeList.Add(animeTitle);
                animeListView.ItemsSource = null;
                animeListView.ItemsSource = animeList;
                animeEntry.Text = "";
            }
        }

        private void RemoveAnime(object sender, EventArgs e)
        {
            if (animeListView.SelectedItem != null)
            {
                string selectedAnime = animeListView.SelectedItem.ToString();
                animeList.Remove(selectedAnime);
                animeListView.ItemsSource = null;
                animeListView.ItemsSource = animeList;
            }
        }
    }
}
