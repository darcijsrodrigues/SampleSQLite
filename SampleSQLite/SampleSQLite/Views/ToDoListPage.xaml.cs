﻿using System;
using System.Collections.Generic;
using System.Diagnostics;


using Xamarin.Forms;

namespace SampleSQLite.Views
{
	public partial class ToDoListPage : ContentPage
	{
		public ToDoListPage()
		{
			InitializeComponent();
		}

		protected override async void OnAppearing()
		{
			base.OnAppearing();

			((App)App.Current).ResumeAtTodoId = -1;
			listView.ItemsSource = await App.Database.GetItemsAsync();
		}

		async void OnItemAdded(object sender, EventArgs e)
		{
			await Navigation.PushAsync(new TodoItemPage
			{
				BindingContext = new TodoItem()
			});
		}

		async void OnListItemSelected(object sender, SelectedItemChangedEventArgs e)
		{
			//((App)App.Current).ResumeAtTodoId = (e.SelectedItem as TodoItem).ID;
			//Debug.WriteLine("setting ResumeAtTodoId = " + (e.SelectedItem as TodoItem).ID);

			await Navigation.PushAsync(new TodoItemPage
			{
				BindingContext = e.SelectedItem as TodoItem
			});
		}
	}
}
