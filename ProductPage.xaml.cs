using Dragut_Hanc_Mobil.Models;

namespace Dragut_Hanc_Mobil;

public partial class ProductPage : ContentPage
{
    ShopList sl;
	public ProductPage(ShopList slist)
	{
		InitializeComponent();
        sl= slist;
	}
    async void OnSaveButtonClicked(object sender, EventArgs e)
    {
        var product = (Product)BindingContext;
        await App.Databse.SaveProductAsync(product);
        listView.ItemsSource = await App.Databse.GetProductsAsync();
    }
    async void OnDeleteButtonClicked(object sender, EventArgs e)
    {
        var product = (Product)BindingContext;
        await App.Databse.DeleteProductAsync(product);
        listView.ItemsSource = await App.Databse.GetProductsAsync();
    }
    async void OnAddButtonClicked(object sender, EventArgs e)
    {
        Product p;
        if (listView.SelectedItem != null)
        {
            p = listView.SelectedItem as Product;
            var lp = new ListProduct()
            {
                ShopListID = sl.ID,
                ProductID = p.ID
            };
            await App.Databse.SaveListProductAsync(lp);
            p.ListProducts = new List<ListProduct> { lp };
            await Navigation.PopAsync();
        }
    }
    protected override async void OnAppearing()
    {
        base.OnAppearing();
        listView.ItemsSource = await App.Databse.GetProductsAsync();
    }
}