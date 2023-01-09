using System;
using Dragut_Hanc_Mobil.Data;
using System.IO;

namespace Dragut_Hanc_Mobil;

public partial class App : Application
{
    static ShoppingListDatabase database;
    public static ShoppingListDatabase Databse
    {
        get
        {
            if (database == null)
            {
                database = new ShoppingListDatabase(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "ShoppingList.db3"));
            }
            return database;
        }
    }

    public App()
    {
        InitializeComponent();

        MainPage = new AppShell();
    }
}