using Xamarin.UITest;
using Query = System.Func<Xamarin.UITest.Queries.AppQuery, Xamarin.UITest.Queries.AppQuery>;

namespace MLXTestFramework.Framework.Pages
{
    public abstract class BasePage
    {
        protected IApp app => StartApp.App;
        protected bool OnAndroid => StartApp.Platform == Platform.Android;
        protected bool OniOS => StartApp.Platform == Platform.iOS;

        readonly Query btnBack;
        readonly Query btnOption;
        readonly System.Func<string, string, Query> elementMarkedAndText;
        readonly System.Func<string, string, Query> elementByIdAndText;
        readonly System.Func<string, string, Query> elementByClassAndText;


        protected BasePage()
        {
            btnBack = x => x.Id("Back");
            btnOption = x => x.Id("Option");
            elementMarkedAndText = (val, text) => x => x.Marked(val).Text(text);
            elementByIdAndText = (id, text) => x => x.Id(id).Text(text);
            elementByClassAndText = (className, text) => x => x.Class(className).Text(text);
        }

    }
}
