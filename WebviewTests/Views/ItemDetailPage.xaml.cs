using System.ComponentModel;
using WebviewTests.ViewModels;
using Xamarin.Forms;

namespace WebviewTests.Views
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