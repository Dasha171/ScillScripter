﻿using ScillScripter.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace ScillScripter.Views
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