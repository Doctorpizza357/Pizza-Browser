using CefSharp;
using CefSharp.WinForms;
using EasyTabs;

namespace TestApp
{
    public partial class TestApp : TitleBarTabs
    {
        public TestApp()
        {
            //InitializeComponent();

            AeroPeekEnabled = true;
            TabRenderer = new ChromeTabRenderer(this);
            Icon = Resources.DefaultIcon;
        }

        static TestApp()
        {
            CefSettings cefSettings = new CefSettings();
            cefSettings.DisableGpuAcceleration();
            cefSettings.CachePath = "Cache";
            Cef.Initialize(cefSettings);
        }

        public override TitleBarTab CreateTab()
        {
            return new TitleBarTab(this)
            {
                Content = new TabWindow
                {
                    Text = "New Tab"
                }
            };
        }
    }
}
