﻿using System;
using Xamarin.Forms;
using XamarinAzureAD.Pages;

namespace MasterDetail
{
    public class RootPage : MasterDetailPage
    {
        private readonly MenuPage menuPage;

        public RootPage()
        {
            NavigationPage.SetHasNavigationBar(this, false);
            menuPage = new MenuPage();
            menuPage.Menu.ItemSelected += (sender, e) => NavigateTo(e.SelectedItem as MenuItem);
            Master = menuPage;
            Detail = new NavigationPage(new MainTabbedContainer());
        }

        private void NavigateTo(MenuItem menu)
        {
            if (menu == null)
                return;

            var displayPage = (Page) Activator.CreateInstance(menu.TargetType);
            Detail = new NavigationPage(displayPage);
            menuPage.Menu.SelectedItem = null;
            IsPresented = false;
        }
    }
}