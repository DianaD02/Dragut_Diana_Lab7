using Dragut_Hanc_Mobil;
using Dragut_Hanc_Mobil.Models;

namespace Dragut_Hanc_Mobil;

public partial class ListPage : ContentPage
{
    
    public ListPage()
    {
        InitializeComponent();
    }
    async void OnSaveButtonClicked(object sender, EventArgs e)
    {
        var slist = (ShopList)BindingContext;
        slist.Date = DateTime.UtcNow;

        Shop selectedShop = (ShopPicker.SelectedItem as Shop);
        slist.ShopID = selectedShop.ID;

        await App.Databse.SaveShopListAsync(slist);
        await Navigation.PopAsync();
    }

    async void OnDeleteButtonClicked(object sender, EventArgs e)
    {
        var slist = (ShopList)BindingContext;
        await App.Databse.DeleteShopListAsync(slist);
        await Navigation.PopAsync();
        ;
    }

    async void OnChooseButtonClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new ProductPage((ShopList)
       this.BindingContext)
        {
            BindingContext = new Product()
        });

    }



    protected override async void OnAppearing()
    {
        base.OnAppearing();

        var items = await App.Databse.GetShopsAsync();
        ShopPicker.ItemsSource = items;
        ShopPicker.ItemDisplayBinding = new Binding("ShopDetails");

        var shopl = (ShopList)BindingContext;

        listView.ItemsSource = await App.Databse.GetListProductsAsync(shopl.ID);
        base.OnAppearing();

       

    }

   
}


