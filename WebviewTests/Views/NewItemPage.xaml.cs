using System;
using System.Collections.Generic;
using System.ComponentModel;
using WebviewTests.Models;
using WebviewTests.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace WebviewTests.Views
{
    public partial class NewItemPage : ContentPage
    {
        public Item Item { get; set; }

        public NewItemPage()
        {
            InitializeComponent();
            BindingContext = new NewItemViewModel();
        }
    }
}