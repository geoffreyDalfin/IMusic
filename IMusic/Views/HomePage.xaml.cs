using System;
using System.Collections.Generic;
using IMusic.ViewModels;
using Xamarin.Forms;

namespace IMusic.Views
{
	public partial class HomePage : ContentPage
	{
public HomePage(MusicViewModel sourceMusical)
		{
			InitializeComponent();
            this.BindingContext = sourceMusical;
		}
	}
}
