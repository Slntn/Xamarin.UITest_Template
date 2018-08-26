using MLXTestFramework.Framework.Pages;
using Query = System.Func<Xamarin.UITest.Queries.AppQuery, Xamarin.UITest.Queries.AppQuery>;

namespace Xamarin.UITest.POPSample.Framework.Pages.MainPages
{
    class FirstPage : BasePage
    {

        Query btn = x => x.Id("Button").Text("Tap me!");

        public BasePage TapBtn(){
            app.Tap(btn);
            return this;
        }
    }
}
