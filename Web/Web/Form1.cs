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
using CefSharp.WinForms;
using CefSharp;


namespace Web
{
    public partial class Form1 : Form
    {
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
            Button[] btn_search = { back, forward, reload,close,add };
            design.search_btn_style(btn_search, this);
            addPage();
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
            addPage();
        }
        protected void addPage() {
            TabPage tab = new TabPage();
            ChromiumWebBrowser wb = new ChromiumWebBrowser("www.google.com")
            {
                Dock = DockStyle.Fill,
            };
            tabControl1.Controls.Add(tab);
            tab.Controls.Add(wb);
            wb.AddressChanged += adressChanged;
            wb.TitleChanged += onWebTitleChanged;
            tabControl1.SelectedIndex = tabControl1.TabCount - 1;
        }
        public void onWebTitleChanged(object hendler, TitleChangedEventArgs e) {
            BeginInvoke((Action)(()=> {
                String title = e.Title;
                tabControl1.SelectedTab.Text = "| " + title+" |";
            }));
        }
        public void adressChanged(object hendler, AddressChangedEventArgs e)
        {
            BeginInvoke((Action)(() =>
            {
                String url = e.Address;
                textBox1.Text = url ;
            }));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (tabControl1.TabCount != 0)
                ((ChromiumWebBrowser)tabControl1.SelectedTab.Controls[0]).Back();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (tabControl1.TabCount != 0)
                ((ChromiumWebBrowser)tabControl1.SelectedTab.Controls[0]).Forward();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (tabControl1.TabCount != 0)
                ((ChromiumWebBrowser)tabControl1.SelectedTab.Controls[0]).Reload();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int index = 0;
            if (tabControl1.TabCount != 0)
            {
                index = tabControl1.SelectedIndex;
                tabControl1.SelectedTab.Dispose();
            }
            if (tabControl1.TabCount != 0 && (index -1)>=0)
                tabControl1.SelectedIndex = index - 1;
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13) {
                if(textBox1.Text!=String.Empty)
                ((ChromiumWebBrowser)tabControl1.SelectedTab.Controls[0]).Load("www.google.com/search?q="+textBox1.Text);
            }
        }

        private void x(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void metroLink1_Click(object sender, EventArgs e)
        {
            metroContextMenu1.Show(metroLink1,-metroContextMenu1.Width+metroLink1.Width,metroLink1.Height);
        }

        private void textBox1_ButtonClick(object sender, EventArgs e)
        {
            if (textBox1.Text != String.Empty)
                ((ChromiumWebBrowser)tabControl1.SelectedTab.Controls[0]).Load("www.google.com/search?q=" + textBox1.Text);
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            clicked = true;
            eX = e.X;
            eY = e.Y;
        }

        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            design.search(textBox1,this);
        }
    }
}
