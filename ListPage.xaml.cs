using Dragut_Diana_Lab7;
using Dragut_Diana_Lab7.Models;

namespace Dragut_Diana_Lab7;

public partial class ListPage : ContentPage
{
	public ListPage()
	{
		InitializeComponent();
	}
	async void OnSaveButtonClicked(object sender, EventArgs e)
	{
		var slist = (ShopList)BindingContext;
		slist.Date= DateTime.UtcNow;
		await App.Databse.SaveShopListAsync(slist);
		await Navigation.PopAsync();
	}

	async void OnDeleteButtonClicked(object sender, EventArgs e)
	{
		var slist = (ShopList)BindingContext;
		await App.Databse.DeleteShopListAsync(slist);
		await Navigation.PopAsync();
	}
}