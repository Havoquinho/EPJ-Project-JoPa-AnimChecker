using Failed_retry.ViewModels;
using Failed_retry.Views;
using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace Failed_retry
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(ItemDetailPage), typeof(ItemDetailPage));
            Routing.RegisterRoute(nameof(NewItemPage), typeof(NewItemPage));
        }

    }
}
