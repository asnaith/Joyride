﻿using Joyride.Android.Tests.SampleApp.ApiDemo.Screens;
using Joyride.Platforms.Android;

namespace Joyride.Android.Tests.SampleApp.ApiDemo
{
    public class ApiDemoApp : AndroidMobileApplication
    {
        public override string Identifier
        {
            get { return "io.appium.android.apis"; }
        }

        public override void Launch()
        {
            base.Launch();
            CurrentScreen = ScreenFactory.CreateScreen<MainScreen>();
        }

        public override void Close()
        {
            base.Close();
            CurrentScreen = ScreenFactory.CreateScreen<NullApiDemoScreen>();
        }
    }
}
