using NUnit.Framework;
using Xamarin.UITest;
using Xamarin.UITest.POPSample.Framework.Pages.MainPages;

namespace MLXTestFramework.Tests
{

    public class TestExample : BaseTestFixture
    {
        public TestExample(Platform platform) : base(platform)
        {
        }


        [Test]
        public void LoginEmpty()
        {
            new FirstPage().TapBtn();
        }

    }
}
