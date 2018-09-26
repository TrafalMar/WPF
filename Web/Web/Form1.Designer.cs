namespace Web
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.hide_win = new System.Windows.Forms.Button();
            this.maximize_win = new System.Windows.Forms.Button();
            this.close_win = new System.Windows.Forms.Button();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.search = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.refresh = new System.Windows.Forms.Button();
            this.forward = new System.Windows.Forms.Button();
            this.back = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel1.Controls.Add(this.hide_win);
            this.panel1.Controls.Add(this.maximize_win);
            this.panel1.Controls.Add(this.close_win);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(949, 40);
            this.panel1.TabIndex = 2;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // hide_win
            // 
            this.hide_win.FlatAppearance.BorderSize = 0;
            this.hide_win.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.hide_win.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.hide_win.Location = new System.Drawing.Point(793, 0);
            this.hide_win.Name = "hide_win";
            this.hide_win.Size = new System.Drawing.Size(53, 37);
            this.hide_win.TabIndex = 3;
            this.hide_win.Text = "—";
            this.hide_win.UseVisualStyleBackColor = true;
            this.hide_win.Click += new System.EventHandler(this.hide_win_Click);
            // 
            // maximize_win
            // 
            this.maximize_win.FlatAppearance.BorderSize = 0;
            this.maximize_win.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.maximize_win.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.maximize_win.Location = new System.Drawing.Point(845, 0);
            this.maximize_win.Name = "maximize_win";
            this.maximize_win.Size = new System.Drawing.Size(53, 37);
            this.maximize_win.TabIndex = 2;
            this.maximize_win.Text = "[]]";
            this.maximize_win.UseVisualStyleBackColor = true;
            this.maximize_win.Click += new System.EventHandler(this.maximize_win_Click);
            // 
            // close_win
            // 
            this.close_win.FlatAppearance.BorderSize = 0;
            this.close_win.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.close_win.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.close_win.Location = new System.Drawing.Point(895, 0);
            this.close_win.Name = "close_win";
            this.close_win.Size = new System.Drawing.Size(53, 37);
            this.close_win.TabIndex = 1;
            this.close_win.Text = "X";
            this.close_win.UseVisualStyleBackColor = true;
            this.close_win.Click += new System.EventHandler(this.close_win_Click);
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.Location = new System.Drawing.Point(0, 112);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.ScriptErrorsSuppressed = true;
            this.webBrowser1.Size = new System.Drawing.Size(949, 423);
            this.webBrowser1.TabIndex = 1;
            this.webBrowser1.Url = new System.Uri("https://www.daniweb.com/programming/software-development/threads/277731/problem-i" +
        "n-displaying-html-pages-with-images-in-webbrowser-control", System.UriKind.Absolute);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.refresh);
            this.panel2.Controls.Add(this.forward);
            this.panel2.Controls.Add(this.back);
            this.panel2.Controls.Add(this.panel6);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 40);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.panel2.Size = new System.Drawing.Size(949, 38);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel7);
            this.panel3.Controls.Add(this.panel2);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.panel1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(949, 112);
            this.panel3.TabIndex = 3;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 111);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(949, 1);
            this.panel4.TabIndex = 4;
            // 
            // search
            // 
            this.search.BackColor = System.Drawing.Color.WhiteSmoke;
            this.search.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.search.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.search.Location = new System.Drawing.Point(4, 4);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(553, 26);
            this.search.TabIndex = 7;
            this.search.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.search_KeyPress);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.search);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(185, 3);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(764, 32);
            this.panel5.TabIndex = 7;
            // 
            // panel6
            // 
            this.panel6.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel6.Location = new System.Drawing.Point(0, 3);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(26, 32);
            this.panel6.TabIndex = 8;
            // 
            // panel7
            // 
            this.panel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel7.Location = new System.Drawing.Point(0, 78);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(949, 31);
            this.panel7.TabIndex = 5;
            // 
            // refresh
            // 
            this.refresh.BackgroundImage = global::Web.Properties.Resources.refresh;
            this.refresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.refresh.Dock = System.Windows.Forms.DockStyle.Left;
            this.refresh.FlatAppearance.BorderSize = 0;
            this.refresh.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.refresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.refresh.Location = new System.Drawing.Point(132, 3);
            this.refresh.Name = "refresh";
            this.refresh.Size = new System.Drawing.Size(53, 32);
            this.refresh.TabIndex = 6;
            this.refresh.UseVisualStyleBackColor = true;
            this.refresh.Click += new System.EventHandler(this.refresh_Click);
            // 
            // forward
            // 
            this.forward.BackgroundImage = global::Web.Properties.Resources.forward;
            this.forward.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.forward.Dock = System.Windows.Forms.DockStyle.Left;
            this.forward.FlatAppearance.BorderSize = 0;
            this.forward.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.forward.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.forward.Location = new System.Drawing.Point(79, 3);
            this.forward.Name = "forward";
            this.forward.Size = new System.Drawing.Size(53, 32);
            this.forward.TabIndex = 5;
            this.forward.UseVisualStyleBackColor = true;
            this.forward.Click += new System.EventHandler(this.forward_Click);
            // 
            // back
            // 
            this.back.BackgroundImage = global::Web.Properties.Resources.back;
            this.back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.back.Dock = System.Windows.Forms.DockStyle.Left;
            this.back.FlatAppearance.BorderSize = 0;
            this.back.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.back.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.back.Location = new System.Drawing.Point(26, 3);
            this.back.Margin = new System.Windows.Forms.Padding(3, 30, 3, 3);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(53, 32);
            this.back.TabIndex = 4;
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(949, 535);
            this.ControlBox = false;
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.SizeChanged += new System.EventHandler(this.Form1_SizeChanged);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button close_win;
        private System.Windows.Forms.Button hide_win;
        private System.Windows.Forms.Button maximize_win;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button refresh;
        private System.Windows.Forms.Button forward;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox search;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
    }
}

