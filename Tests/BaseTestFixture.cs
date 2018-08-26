using NUnit.Framework;
using Xamarin.UITest;

namespace MLXTestFramework
{
    [TestFixture(Platform.Android)]
    [TestFixture(Platform.iOS)]
    public abstract class BaseTestFixture
    {
        protected IApp app => StartApp.App;
        protected bool OnAndroid => StartApp.Platform == Platform.Android;
        protected bool OniOS => StartApp.Platform == Platform.iOS;

        protected BaseTestFixture(Platform platform)
        {
            StartApp.Platform = platform;
        }

        [SetUp]
        public virtual void BeforeEachTest()
        {
            StartApp.StartPlatform();
        }
    }
}
