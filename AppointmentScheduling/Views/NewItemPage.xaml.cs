using System;
using System.Collections.Generic;
using System.ComponentModel;
using AppointmentScheduling.Models;
using AppointmentScheduling.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppointmentScheduling.Views
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