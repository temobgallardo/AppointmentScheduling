using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppointmentScheduling.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppointmentScheduling.Views
{
  [XamlCompilation(XamlCompilationOptions.Compile)]
  public partial class LoginPage : ContentPage
  {
    public LoginPage()
    {
      InitializeComponent();
      this.BindingContext = new LoginViewModel();
    }
  }
}