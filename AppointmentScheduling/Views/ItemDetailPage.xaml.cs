using System.ComponentModel;
using AppointmentScheduling.ViewModels;
using Xamarin.Forms;

namespace AppointmentScheduling.Views
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