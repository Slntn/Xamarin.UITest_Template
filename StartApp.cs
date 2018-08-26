using System;
using Xamarin.UITest;

namespace MLXTestFramework
{
    static class StartApp
    {
        //set your APKPath here
        const string ApkPath = "C:\\Path\\app.apk";
        const string AppPath = "C:\\Path\\app.ipa";

        static IApp app;
        public static IApp App
        {
            get
            {
                if (app == null)
                    throw new NullReferenceException("'AppManager.App' not set. Call 'AppManager.StartApp()' before trying to access it.");
                return app;
            }
        }

        static Platform? platform;
        public static Platform Platform
        {
            get
            {
                if (platform == null)
                    throw new NullReferenceException("'AppManager.Platform' not set.");
                return platform.Value;
            }

            set
            {
                platform = value;
            }
        }

        public static void StartPlatform()
        {
            if (Platform == Platform.Android)
            {
                app = ConfigureApp
                            .Android
                            .EnableLocalScreenshots()
                            .ApkFile(ApkPath)
                            .StartApp();
            }

            if (Platform == Platform.iOS)
            {
                app = ConfigureApp
                    .iOS
                    .AppBundle(AppPath)
                    .StartApp();
            }
        }
    }
}
