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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.textBox1 = new MetroFramework.Controls.MetroTextBox();
            this.metroLink1 = new MetroFramework.Controls.MetroLink();
            this.back = new System.Windows.Forms.Button();
            this.forward = new System.Windows.Forms.Button();
            this.close = new System.Windows.Forms.Button();
            this.reload = new System.Windows.Forms.Button();
            this.add = new System.Windows.Forms.Button();
            this.metroContextMenu1 = new MetroFramework.Controls.MetroContextMenu(this.components);
            this.preferencesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.historyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.panel3.SuspendLayout();
            this.metroContextMenu1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 54);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(939, 1);
            this.panel4.TabIndex = 4;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.textBox1);
            this.panel3.Controls.Add(this.metroLink1);
            this.panel3.Controls.Add(this.back);
            this.panel3.Controls.Add(this.forward);
            this.panel3.Controls.Add(this.close);
            this.panel3.Controls.Add(this.reload);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.add);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.panel3.Size = new System.Drawing.Size(949, 55);
            this.panel3.TabIndex = 3;
            // 
            // textBox1
            // 
            // 
            // 
            // 
            this.textBox1.CustomButton.BackColor = System.Drawing.Color.White;
            this.textBox1.CustomButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.textBox1.CustomButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.CustomButton.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            this.textBox1.CustomButton.Location = new System.Drawing.Point(439, 1);
            this.textBox1.CustomButton.Margin = new System.Windows.Forms.Padding(0);
            this.textBox1.CustomButton.Name = "";
            this.textBox1.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.textBox1.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.textBox1.CustomButton.TabIndex = 1;
            this.textBox1.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.textBox1.CustomButton.UseSelectable = true;
            this.textBox1.CustomButton.UseVisualStyleBackColor = false;
            this.textBox1.DisplayIcon = true;
            this.textBox1.Icon = ((System.Drawing.Image)(resources.GetObject("textBox1.Icon")));
            this.textBox1.Lines = new string[0];
            this.textBox1.Location = new System.Drawing.Point(274, 9);
            this.textBox1.MaxLength = 32767;
            this.textBox1.Name = "textBox1";
            this.textBox1.PasswordChar = '\0';
            this.textBox1.PromptText = "Search";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textBox1.SelectedText = "";
            this.textBox1.SelectionLength = 0;
            this.textBox1.SelectionStart = 0;
            this.textBox1.ShortcutsEnabled = true;
            this.textBox1.ShowButton = true;
            this.textBox1.ShowClearButton = true;
            this.textBox1.Size = new System.Drawing.Size(467, 29);
            this.textBox1.Style = MetroFramework.MetroColorStyle.Orange;
            this.textBox1.TabIndex = 10;
            this.textBox1.Theme = MetroFramework.MetroThemeStyle.Light;
            this.textBox1.UseSelectable = true;
            this.textBox1.WaterMark = "Search";
            this.textBox1.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.textBox1.WaterMarkFont = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.ButtonClick += new MetroFramework.Controls.MetroTextBox.ButClick(this.textBox1_ButtonClick);
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // metroLink1
            // 
            this.metroLink1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("metroLink1.BackgroundImage")));
            this.metroLink1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.metroLink1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.metroLink1.Dock = System.Windows.Forms.DockStyle.Right;
            this.metroLink1.Location = new System.Drawing.Point(908, 0);
            this.metroLink1.Name = "metroLink1";
            this.metroLink1.Size = new System.Drawing.Size(31, 54);
            this.metroLink1.TabIndex = 9;
            this.metroLink1.UseSelectable = true;
            this.metroLink1.Click += new System.EventHandler(this.metroLink1_Click);
            // 
            // back
            // 
            this.back.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("back.BackgroundImage")));
            this.back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.back.FlatAppearance.BorderSize = 0;
            this.back.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.back.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.back.Location = new System.Drawing.Point(4, 7);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(40, 34);
            this.back.TabIndex = 4;
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.button2_Click);
            // 
            // forward
            // 
            this.forward.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("forward.BackgroundImage")));
            this.forward.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.forward.FlatAppearance.BorderSize = 0;
            this.forward.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.forward.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.forward.Location = new System.Drawing.Point(43, 7);
            this.forward.Name = "forward";
            this.forward.Size = new System.Drawing.Size(45, 34);
            this.forward.TabIndex = 5;
            this.forward.UseVisualStyleBackColor = true;
            this.forward.Click += new System.EventHandler(this.button3_Click);
            // 
            // close
            // 
            this.close.FlatAppearance.BorderSize = 0;
            this.close.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.close.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.close.Location = new System.Drawing.Point(128, 7);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(72, 34);
            this.close.TabIndex = 7;
            this.close.Text = "Close";
            this.close.UseVisualStyleBackColor = true;
            this.close.Click += new System.EventHandler(this.button5_Click);
            // 
            // reload
            // 
            this.reload.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("reload.BackgroundImage")));
            this.reload.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.reload.FlatAppearance.BorderSize = 0;
            this.reload.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.reload.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.reload.Location = new System.Drawing.Point(87, 7);
            this.reload.Name = "reload";
            this.reload.Size = new System.Drawing.Size(42, 34);
            this.reload.TabIndex = 6;
            this.reload.UseVisualStyleBackColor = true;
            this.reload.Click += new System.EventHandler(this.button4_Click);
            // 
            // add
            // 
            this.add.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("add.BackgroundImage")));
            this.add.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.add.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.add.FlatAppearance.BorderSize = 0;
            this.add.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.add.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.add.Location = new System.Drawing.Point(199, 7);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(54, 34);
            this.add.TabIndex = 4;
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.button1_Click);
            // 
            // metroContextMenu1
            // 
            this.metroContextMenu1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.metroContextMenu1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.preferencesToolStripMenuItem,
            this.historyToolStripMenuItem,
            this.toolStripMenuItem1,
            this.exitToolStripMenuItem});
            this.metroContextMenu1.Name = "metroContextMenu1";
            this.metroContextMenu1.Size = new System.Drawing.Size(184, 100);
            // 
            // preferencesToolStripMenuItem
            // 
            this.preferencesToolStripMenuItem.Name = "preferencesToolStripMenuItem";
            this.preferencesToolStripMenuItem.Size = new System.Drawing.Size(183, 30);
            this.preferencesToolStripMenuItem.Text = "Preferences";
            // 
            // historyToolStripMenuItem
            // 
            this.historyToolStripMenuItem.Name = "historyToolStripMenuItem";
            this.historyToolStripMenuItem.Size = new System.Drawing.Size(183, 30);
            this.historyToolStripMenuItem.Text = "History";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(180, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(183, 30);
            this.exitToolStripMenuItem.Text = "E&xit";
            // 
            // tabControl1
            // 
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.ItemSize = new System.Drawing.Size(0, 29);
            this.tabControl1.Location = new System.Drawing.Point(0, 55);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.Size = new System.Drawing.Size(949, 480);
            this.tabControl1.Style = MetroFramework.MetroColorStyle.Orange;
            this.tabControl1.TabIndex = 6;
            this.tabControl1.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tabControl1.UseSelectable = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(949, 535);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(600, 200);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.SizeChanged += new System.EventHandler(this.Form1_SizeChanged);
            this.panel3.ResumeLayout(false);
            this.metroContextMenu1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button close;
        private System.Windows.Forms.Button forward;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Button reload;
        private MetroFramework.Controls.MetroLink metroLink1;
        private MetroFramework.Controls.MetroContextMenu metroContextMenu1;
        private System.Windows.Forms.ToolStripMenuItem preferencesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem historyToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private MetroFramework.Controls.MetroTabControl tabControl1;
        private MetroFramework.Controls.MetroTextBox textBox1;
    }
}

