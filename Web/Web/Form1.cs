using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Web.Classes;
using cef;
using CefSharp;
using CefSharp.WinForms;
using MahApps.Metro.Controls;
using MetroFramework.Controls;

namespace Web
{
    public partial class Form1 : Form
    {
        List<SiteInfo> history = new List<SiteInfo>();
        string defaultUrl = "www.google.com";
        public Form1()
        {
            InitializeComponent();

            this.SetStyle(ControlStyles.ResizeRedraw, true);
        }

        private void InjectJavascript()
        {

        }

        static Design design = new Design();
        private void Form1_Load(object sender, EventArgs e)
        {
            FormControl formControl = new FormControl(this);
            Button[] btn_search = { back, forward, reload, close, add };
            design.search_btn_style(btn_search, this);
            addPage(defaultUrl);
            tabControl1.Selected += tabSwitch;
        }

        private void close_win_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void maximize_win_Click(object sender, EventArgs e)
        {
            if (max == false)
            {
                max = true;
                h = this.Size.Height;
                w = this.Size.Width;
                this.WindowState = FormWindowState.Maximized;

            }
            else
            {
                this.WindowState = FormWindowState.Normal;
                this.Size = new Size(w, h);
                max = false;

            }
        }
        bool max = false;
        int h = 0, w = 0;
        private void hide_win_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }


        int eX, eY;
        bool clicked;

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (clicked)
            {
                this.Left = this.Left + e.X - eX;
                this.Top = this.Top + e.Y - eY;
            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            clicked = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            addPage(defaultUrl);
        }
        int index = 0;
        protected void addPage(string url)
        {
            TabPage tab = new TabPage() { Name = "siteTab" };
            ChromiumWebBrowser wb = new ChromiumWebBrowser(url)
            {
                Dock = DockStyle.Fill,
                Name = "web"
            };

            tabControl1.Controls.Add(tab);
            index = tabControl1.TabCount - 1;
            tab.Controls.Add(wb);
            wb.AddressChanged += adressChanged;
            wb.TitleChanged += onWebTitleChanged;
            tabControl1.SelectedIndex = tabControl1.TabCount - 1;
        }

        public void tabSwitch(object hendler, EventArgs e)
        {
            if (tabValidator())
                textBox1.Text = ((ChromiumWebBrowser)tabControl1.SelectedTab.Controls["web"]).Address;

            if (tabControl1.TabCount != 0 && tabControl1.SelectedTab.Name == "History")
            {
                textBox1.Text = "Settings";
            }
            //tabControl1.SelectedTab.Text = ((ChromiumWebBrowser)tabControl1.SelectedTab.Controls["web"])
            //MessageBox.Show("tab clicked");

        }

        public bool tabValidator()
        {
            List<bool> result = new List<bool>();
            if (tabControl1.TabCount == 0) return false;
            if (tabControl1.SelectedTab.Name == "History") result.Add(false);

            return !result.Contains(false);
        }

        public void onWebTitleChanged(object sender, TitleChangedEventArgs e)
        {
            BeginInvoke((Action)(() =>
            {
                string address = "";
                String title = "/ " + e.Title.ToString() + " \\";
                if (title.Length >= 25)
                {
                    title = title.Substring(0, 25) + "...\\";
                }
                if (tabControl1.SelectedTab.Name == "siteTab")
                {
                    tabControl1.SelectedTab.Text = title;
                    address = ((ChromiumWebBrowser)tabControl1.SelectedTab.Controls["web"]).Address;
                    history.Add(addToHistory(title, address));
                    var dist = history.GroupBy(x => new {x.url,x.date }).Select(x => x.Last()).ToList();
                    history = dist;
                }

                foreach (TabPage i in tabControl1.TabPages)
                {
                    if (i.Text == String.Empty)
                        i.Text = title;
                }

            }));

        }
        public SiteInfo addToHistory(string title, string url)
        {

            var time = DateTime.Now;
            string stime = time.ToString("hh:mm tt");
            string sdate = time.ToString("MM.dd.yyyy");
            SiteInfo obj = new SiteInfo(title, url, sdate, stime);
            string message = obj.title + "\n" + obj.url + "\n" + obj.date + "\n" + obj.time;
            //MessageBox.Show(message, "Added obj");
            return obj;
        }

        public void adressChanged(object hendler, AddressChangedEventArgs e)
        {
            BeginInvoke((Action)(() =>
            {
                String url = e.Address;
                if (tabControl1.SelectedTab.Name == "siteTab")
                    textBox1.Text = url;
            }));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (tabValidator())
                ((ChromiumWebBrowser)tabControl1.SelectedTab.Controls[0]).Back();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (tabValidator())
                ((ChromiumWebBrowser)tabControl1.SelectedTab.Controls[0]).Forward();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (tabValidator())
                ((ChromiumWebBrowser)tabControl1.SelectedTab.Controls[0]).Reload();
            if (tabControl1.TabCount != 0 && tabControl1.SelectedTab.Name == "History")
            {
                tabControl1.SelectedTab.Refresh();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int index = 0;
            if (tabControl1.TabCount != 0)
            {
                index = tabControl1.SelectedIndex;
                tabControl1.SelectedTab.Dispose();
            }
            if (tabValidator() && (index - 1) >= 0)
                tabControl1.SelectedIndex = index - 1;
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                if (tabValidator())
                    ((ChromiumWebBrowser)tabControl1.SelectedTab.Controls[0]).Load("www.google.com/search?q=" + textBox1.Text);
            }
        }

        private void x(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void metroLink1_Click(object sender, EventArgs e)
        {
            metroContextMenu1.Show(metroLink1, -metroContextMenu1.Width + metroLink1.Width, metroLink1.Height);
        }

        private void textBox1_ButtonClick(object sender, EventArgs e)
        {
            if (tabValidator())
                ((ChromiumWebBrowser)tabControl1.SelectedTab.Controls[0]).Load("www.google.com/search?q=" + textBox1.Text);
        }

        private void historyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (TabPage i in tabControl1.TabPages) {
                if (i.Name == "History") i.Dispose();
            }

            TabPage settings = new TabPage()
            {
                Name = "History",
                Text = "/♣ History ♣\\",
            };
            Panel background = new Panel
            {
                Dock = DockStyle.Fill,
                BackColor = Color.White
            };
            TableLayoutPanel table = new TableLayoutPanel()
            {
                RowCount = 2,
                ColumnCount = 4,
                Dock = DockStyle.Fill,
                BackColor = Color.Aqua,
            };
            table.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20));
            table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50));
            table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15));
            table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15));

            table.Controls.Add(new MetroLabel() {
                Text = "Title",
                TextAlign = ContentAlignment.MiddleCenter,
                Dock = DockStyle.Fill
            }, 0, 0);
            table.Controls.Add(new MetroLabel() {
                Text = "Url",
                TextAlign = ContentAlignment.MiddleCenter,
                Dock = DockStyle.Fill,
                Margin = Padding.Empty
            }, 1, 0);
            table.Controls.Add(new MetroLabel() {
                Text = "Date",
                TextAlign = ContentAlignment.MiddleCenter,
                Dock = DockStyle.Fill
            }, 2, 0);
            table.Controls.Add(new MetroLabel() {
                Text = "Time",
                TextAlign = ContentAlignment.MiddleCenter,
                Dock = DockStyle.Fill
            }, 3, 0);

            List<SiteInfo> reverse = new List<SiteInfo>(history);
            reverse.Reverse();
            foreach (SiteInfo i in reverse) {
                table.RowCount += 1;
                table.Controls.Add(new MetroLabel()
                {
                    Text = i.title,
                    TextAlign = ContentAlignment.MiddleCenter,
                    Dock = DockStyle.Fill
                });
                MetroLink link = new MetroLink()
                {
                    Text = i.url,
                    TextAlign = ContentAlignment.MiddleCenter,
                    Dock = DockStyle.Fill,
                    Margin = Padding.Empty,
                    Cursor = Cursors.Hand,
                    Name = "siteLink"
                };
                link.MouseDown += linkClick;
                table.Controls.Add(link);
                
                table.Controls.Add(new MetroLabel()
                {
                    Text = i.date,
                    TextAlign = ContentAlignment.MiddleCenter,
                    Dock = DockStyle.Fill,
                });
                table.Controls.Add(new MetroLabel()
                {
                    Text = i.time,
                    TextAlign = ContentAlignment.MiddleCenter,
                    Dock = DockStyle.Fill
                });
            }

            

            background.Controls.Add(table);

            settings.Controls.Add(background);

            tabControl1.Controls.Add(settings);

            tabControl1.SelectedTab = tabControl1.TabPages["History"];
        }

        protected void linkClick(object sender, MouseEventArgs e)
        {
            addPage((sender as MetroLink).Text);
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            clicked = true;
            eX = e.X;
            eY = e.Y;
        }

        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            design.search(textBox1, this);
        }
    }
}
