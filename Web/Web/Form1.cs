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
            Button[] btn_menu = { close_win, maximize_win, hide_win };
            Button[] btn_search = { button2, button3, button4,button5,button1 };
            design.search_btn_style(btn_search, this);
            design.menu_btn_style(btn_menu, this);

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
            TabPage tab = new TabPage();
            WebBrowser wb = new WebBrowser();
            wb.Dock = DockStyle.Fill;
            wb.Navigate("www.google.com");
            wb.ScriptErrorsSuppressed = true;
            tabControl1.Controls.Add(tab);
            tab.Controls.Add(wb);
            wb.DocumentCompleted += new WebBrowserDocumentCompletedEventHandler(siteTitle);
            wb.ProgressChanged += new WebBrowserProgressChangedEventHandler(setProgress);
            tabControl1.SelectedIndex = tabControl1.TabCount - 1;

        }
        public void setProgress(object hendler, WebBrowserProgressChangedEventArgs e) {
            toolStripProgressBar1.Maximum = (int)e.MaximumProgress;
            if(e.CurrentProgress>=0)toolStripProgressBar1.Value = (int)e.CurrentProgress;
        }
        public void siteTitle(object hendler, WebBrowserDocumentCompletedEventArgs e)
        {

            String title = ((WebBrowser)tabControl1.SelectedTab.Controls[0]).DocumentTitle;
            if (title.Length >= 18)
                tabControl1.SelectedTab.Text = title.Substring(0, 18) + "...";
            else
            {
                tabControl1.SelectedTab.Text = title;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ((WebBrowser)tabControl1.SelectedTab.Controls[0]).GoBack();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ((WebBrowser)tabControl1.SelectedTab.Controls[0]).GoForward();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ((WebBrowser)tabControl1.SelectedTab.Controls[0]).Refresh();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab.Dispose();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13) {
                if(textBox1.Text!=String.Empty)
                ((WebBrowser)tabControl1.SelectedTab.Controls[0]).Navigate("www.google.com/search?q="+textBox1.Text);
            }
        }

        private void x(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            clicked = true;
            eX = e.X;
            eY = e.Y;
        }

        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            Button[] btn = { close_win, maximize_win, hide_win };
            design.menu_btn_style(btn, this);
        }
    }
}
