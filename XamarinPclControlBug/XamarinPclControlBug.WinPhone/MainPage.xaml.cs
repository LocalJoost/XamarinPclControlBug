using Microsoft.Phone.Controls;
using Xamarin.Forms;
using Xamarin.Forms.Platform.WinPhone;

namespace XamarinPclControlBug.WinPhone
{

  public partial class MainPage : FormsApplicationPage // superclass new in 1.3
  {
    public MainPage()
    {
      InitializeComponent();
      SupportedOrientations = SupportedPageOrientation.PortraitOrLandscape;

      Forms.Init();
      LoadApplication(new XamarinPclControlBug.App()); // new in 1.3
    }
  }
}
