using Dragut_Diana_Lab7.Models;

namespace Dragut_Diana_Lab7;

public partial class ListEntryPage : ContentPage
{
	public ListEntryPage()
	{
		InitializeComponent();
	}

 protected override async void OnAppearing()
	{
		base.OnAppearing();
		listView.ItemsSource = await App.Databse.GetShopListsAsync();
	}

async void OnShopListAddedClicked(object sender, EventArgs e)
	{
		await Navigation.PushAsync(new ListPage
		{
			BindingContext = new ShopList()
		});
	}

async void OnListViewItemSelected(object sender, SelectedItemChangedEventArgs e)
	{
		if(e.SelectedItem !=null)
		{
			await Navigation.PushAsync(new ListPage
			{
				BindingContext = e.SelectedItem as ShopList
			});
		}
	}
}