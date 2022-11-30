using System;
using Dragut_Diana_Lab7.Data;
using System.IO;

namespace Dragut_Diana_Lab7;

public partial class App : Application
{
    static ShoppingListDatabse database;
    public static ShoppingListDatabse Databse
    {
        get
        {
            if (database == null)
            {
                database = new ShoppingListDatabse(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "ShoppingList.db3"));
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