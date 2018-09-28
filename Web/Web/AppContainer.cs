using System;
using EasyTabs;

namespace Web
{
    public partial class AppContainer : TitleBarTabs
    {
        public AppContainer()
        {
            InitializeComponent();
            AeroPeekEnabled = true;
            TabRenderer = new ChromeTabRenderer(this);
        }

        public override TitleBarTab CreateTab()
        {
            return new TitleBarTab(this)
            {
                Content = new Form1
                {
                    Text = "New tab"
                }
            };
        }

        private void AppContainer_Load(object sender, EventArgs e)
        {
        }
    }
}
