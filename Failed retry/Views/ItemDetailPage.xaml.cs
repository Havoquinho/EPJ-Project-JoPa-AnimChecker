using Failed_retry.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace Failed_retry.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}