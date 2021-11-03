
namespace Nandeesh
{
    partial class appbody
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.login_timer = new System.Windows.Forms.Timer(this.components);
            this.slidingpanel_timer = new System.Windows.Forms.Timer(this.components);
            this.sliding_panel = new System.Windows.Forms.Panel();
            this.contentpanel = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.logout_button = new System.Windows.Forms.Button();
            this.about_button = new System.Windows.Forms.Button();
            this.account_button = new System.Windows.Forms.Button();
            this.student_button = new System.Windows.Forms.Button();
            this.grade_button = new System.Windows.Forms.Button();
            this.settings_button = new System.Windows.Forms.Button();
            this.sliding_button = new System.Windows.Forms.Button();
            this.minimize_button = new System.Windows.Forms.Button();
            this.close_button = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.sliding_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Azure;
            this.panel1.Controls.Add(this.minimize_button);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.close_button);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1259, 33);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // login_timer
            // 
            this.login_timer.Interval = 40;
            this.login_timer.Tick += new System.EventHandler(this.login_timer_Tick);
            // 
            // slidingpanel_timer
            // 
            this.slidingpanel_timer.Interval = 50;
            this.slidingpanel_timer.Tick += new System.EventHandler(this.slidingpanel_timer_Tick);
            // 
            // sliding_panel
            // 
            this.sliding_panel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.sliding_panel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.sliding_panel.Controls.Add(this.logout_button);
            this.sliding_panel.Controls.Add(this.about_button);
            this.sliding_panel.Controls.Add(this.account_button);
            this.sliding_panel.Controls.Add(this.student_button);
            this.sliding_panel.Controls.Add(this.grade_button);
            this.sliding_panel.Controls.Add(this.settings_button);
            this.sliding_panel.Controls.Add(this.sliding_button);
            this.sliding_panel.Dock = System.Windows.Forms.DockStyle.Right;
            this.sliding_panel.Location = new System.Drawing.Point(1069, 33);
            this.sliding_panel.Name = "sliding_panel";
            this.sliding_panel.Size = new System.Drawing.Size(190, 695);
            this.sliding_panel.TabIndex = 1;
            this.sliding_panel.Paint += new System.Windows.Forms.PaintEventHandler(this.sliding_panel_Paint);
            // 
            // contentpanel
            // 
            this.contentpanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contentpanel.Location = new System.Drawing.Point(0, 33);
            this.contentpanel.Name = "contentpanel";
            this.contentpanel.Size = new System.Drawing.Size(1069, 695);
            this.contentpanel.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Right;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = global::Nandeesh.Properties.Resources.maximize2;
            this.button1.Location = new System.Drawing.Point(1199, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(30, 33);
            this.button1.TabIndex = 4;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_3);
            // 
            // logout_button
            // 
            this.logout_button.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.logout_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.logout_button.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.logout_button.Image = global::Nandeesh.Properties.Resources._31;
            this.logout_button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.logout_button.Location = new System.Drawing.Point(0, 448);
            this.logout_button.Name = "logout_button";
            this.logout_button.Size = new System.Drawing.Size(194, 78);
            this.logout_button.TabIndex = 2;
            this.logout_button.Text = "LOGOUT";
            this.logout_button.UseVisualStyleBackColor = false;
            this.logout_button.Click += new System.EventHandler(this.button1_Click);
            // 
            // about_button
            // 
            this.about_button.BackColor = System.Drawing.Color.Transparent;
            this.about_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.about_button.ForeColor = System.Drawing.Color.Black;
            this.about_button.Image = global::Nandeesh.Properties.Resources.about__1_;
            this.about_button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.about_button.Location = new System.Drawing.Point(0, 376);
            this.about_button.Name = "about_button";
            this.about_button.Size = new System.Drawing.Size(194, 78);
            this.about_button.TabIndex = 5;
            this.about_button.Text = "ABOUT";
            this.about_button.UseVisualStyleBackColor = false;
            this.about_button.Click += new System.EventHandler(this.about_button_Click);
            // 
            // account_button
            // 
            this.account_button.BackColor = System.Drawing.Color.Transparent;
            this.account_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.account_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.account_button.Image = global::Nandeesh.Properties.Resources.acc1;
            this.account_button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.account_button.Location = new System.Drawing.Point(0, 227);
            this.account_button.Name = "account_button";
            this.account_button.Size = new System.Drawing.Size(194, 78);
            this.account_button.TabIndex = 2;
            this.account_button.Text = "ACCOUNT";
            this.account_button.UseVisualStyleBackColor = false;
            this.account_button.Click += new System.EventHandler(this.account_button_Click);
            // 
            // student_button
            // 
            this.student_button.BackColor = System.Drawing.Color.Transparent;
            this.student_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.student_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.student_button.Image = global::Nandeesh.Properties.Resources.student;
            this.student_button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.student_button.Location = new System.Drawing.Point(0, 78);
            this.student_button.Name = "student_button";
            this.student_button.Size = new System.Drawing.Size(194, 78);
            this.student_button.TabIndex = 3;
            this.student_button.Text = "STUDENT";
            this.student_button.UseVisualStyleBackColor = false;
            this.student_button.Click += new System.EventHandler(this.student_button_Click);
            // 
            // grade_button
            // 
            this.grade_button.BackColor = System.Drawing.Color.Transparent;
            this.grade_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.grade_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.grade_button.Image = global::Nandeesh.Properties.Resources.marks2;
            this.grade_button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.grade_button.Location = new System.Drawing.Point(0, 152);
            this.grade_button.Name = "grade_button";
            this.grade_button.Size = new System.Drawing.Size(194, 78);
            this.grade_button.TabIndex = 1;
            this.grade_button.Text = "GRADE";
            this.grade_button.UseVisualStyleBackColor = false;
            this.grade_button.Click += new System.EventHandler(this.grade_button_Click);
            // 
            // settings_button
            // 
            this.settings_button.BackColor = System.Drawing.Color.Transparent;
            this.settings_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.settings_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.settings_button.ForeColor = System.Drawing.Color.Black;
            this.settings_button.Image = global::Nandeesh.Properties.Resources.set;
            this.settings_button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.settings_button.Location = new System.Drawing.Point(0, 302);
            this.settings_button.Name = "settings_button";
            this.settings_button.Size = new System.Drawing.Size(194, 78);
            this.settings_button.TabIndex = 4;
            this.settings_button.Text = "SETTINGS";
            this.settings_button.UseVisualStyleBackColor = false;
            this.settings_button.Click += new System.EventHandler(this.settings_button_Click);
            // 
            // sliding_button
            // 
            this.sliding_button.BackColor = System.Drawing.Color.Transparent;
            this.sliding_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.sliding_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.sliding_button.Image = global::Nandeesh.Properties.Resources.double_chevron2;
            this.sliding_button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.sliding_button.Location = new System.Drawing.Point(0, 0);
            this.sliding_button.Name = "sliding_button";
            this.sliding_button.Size = new System.Drawing.Size(194, 78);
            this.sliding_button.TabIndex = 0;
            this.sliding_button.UseVisualStyleBackColor = false;
            this.sliding_button.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // minimize_button
            // 
            this.minimize_button.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.minimize_button.Dock = System.Windows.Forms.DockStyle.Right;
            this.minimize_button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.minimize_button.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.minimize_button.Image = global::Nandeesh.Properties.Resources._41;
            this.minimize_button.Location = new System.Drawing.Point(1169, 0);
            this.minimize_button.Name = "minimize_button";
            this.minimize_button.Size = new System.Drawing.Size(30, 33);
            this.minimize_button.TabIndex = 3;
            this.minimize_button.UseVisualStyleBackColor = false;
            this.minimize_button.Click += new System.EventHandler(this.button2_Click);
            // 
            // close_button
            // 
            this.close_button.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.close_button.Dock = System.Windows.Forms.DockStyle.Right;
            this.close_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.close_button.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.close_button.Image = global::Nandeesh.Properties.Resources.Untitled5;
            this.close_button.Location = new System.Drawing.Point(1229, 0);
            this.close_button.Name = "close_button";
            this.close_button.Size = new System.Drawing.Size(30, 33);
            this.close_button.TabIndex = 1;
            this.close_button.UseVisualStyleBackColor = false;
            this.close_button.Click += new System.EventHandler(this.close_button_Click);
            // 
            // appbody
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1259, 728);
            this.Controls.Add(this.contentpanel);
            this.Controls.Add(this.sliding_panel);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "appbody";
            this.Text = "appbody";
            this.Load += new System.EventHandler(this.appbody_Load);
            this.panel1.ResumeLayout(false);
            this.sliding_panel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button logout_button;
        private System.Windows.Forms.Button minimize_button;
        private System.Windows.Forms.Button close_button;
        private System.Windows.Forms.Timer login_timer;
        private System.Windows.Forms.Panel sliding_panel;
        private System.Windows.Forms.Button sliding_button;
        private System.Windows.Forms.Timer slidingpanel_timer;
        private System.Windows.Forms.Button about_button;
        private System.Windows.Forms.Button settings_button;
        private System.Windows.Forms.Button student_button;
        private System.Windows.Forms.Button account_button;
        private System.Windows.Forms.Button grade_button;
        private System.Windows.Forms.Panel contentpanel;
        private System.Windows.Forms.Button button1;
    }
}