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
            if (webBrowser1.Url!=null)
            {
                HtmlElement head = webBrowser1.Document.GetElementsByTagName("head")[0];
                HtmlElement script = webBrowser1.Document.CreateElement("script");
                
            }
        }

        static Design design = new Design();
        private void Form1_Load(object sender, EventArgs e)
        {
            FormControl formControl = new FormControl(this);
            Button[] btn_menu = { close_win, maximize_win, hide_win };
            Button[] btn_search = { back, forward, refresh };
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

        private void refresh_Click(object sender, EventArgs e)
        {
            webBrowser1.Refresh();
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

        private void back_Click(object sender, EventArgs e)
        {
            webBrowser1.GoBack();
        }

        private void forward_Click(object sender, EventArgs e)
        {
            webBrowser1.GoForward();
        }

        private void search_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13) {
                webBrowser1.Navigate("https://www.google.com.ua/search?q=" + search.Text);
            }
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
            search.Width = panel5.Width-250;
        }
    }
}
