using MonoTouch.Foundation;
using MonoTouch.UIKit;
using PclControl;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

namespace XamarinPclControlBug.iOS
{
  [Register("AppDelegate")]
  public partial class AppDelegate :
      FormsApplicationDelegate 
  {
    public override bool FinishedLaunching(UIApplication app, NSDictionary options)
    {
      var b = new MyButton();
      Forms.Init();

      LoadApplication(new App()); 

      return base.FinishedLaunching(app, options);
    }
  }
}
