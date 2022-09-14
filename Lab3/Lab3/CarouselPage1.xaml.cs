﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Lab3
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CarouselPage1 : CarouselPage
    {
        public CarouselPage1()
        {
            InitializeComponent();
            btnClose.Clicked += async (sender, e) =>
            {
                await Navigation.PopAsync();
            };
        }
    }
}