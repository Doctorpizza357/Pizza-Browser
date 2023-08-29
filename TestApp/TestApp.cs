using CefSharp;
using CefSharp.WinForms;
using EasyTabs;

namespace TestApp
{
    public partial class TestApp : TitleBarTabs
    {
        public TestApp()
        {
            //removed Initialize that used to cause crashes
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
                    // title given to the "new tab" page when you click the + button, or with keyboard shortcut when added
                    Text = "New Tab"
                }
            };
        }
    }
}
