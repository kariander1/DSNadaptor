namespace DSNadaptor
{
    partial class PopupImage
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
            this.panel_toolbar = new System.Windows.Forms.Panel();
            this.label_title = new System.Windows.Forms.Label();
            this.button_quit = new System.Windows.Forms.Button();
            this.panel_lower = new System.Windows.Forms.Panel();
            this.button_yes = new System.Windows.Forms.Button();
            this.button_no = new System.Windows.Forms.Button();
            this.pictureBox_image = new System.Windows.Forms.PictureBox();
            this.panel_toolbar.SuspendLayout();
            this.panel_lower.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_image)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_toolbar
            // 
            this.panel_toolbar.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel_toolbar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_toolbar.Controls.Add(this.label_title);
            this.panel_toolbar.Controls.Add(this.button_quit);
            this.panel_toolbar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_toolbar.Location = new System.Drawing.Point(0, 0);
            this.panel_toolbar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel_toolbar.Name = "panel_toolbar";
            this.panel_toolbar.Size = new System.Drawing.Size(503, 48);
            this.panel_toolbar.TabIndex = 1;
            this.panel_toolbar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel_toolbar_MouseDown);
            // 
            // label_title
            // 
            this.label_title.AutoSize = true;
            this.label_title.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_title.Location = new System.Drawing.Point(11, 8);
            this.label_title.Name = "label_title";
            this.label_title.Size = new System.Drawing.Size(47, 24);
            this.label_title.TabIndex = 4;
            this.label_title.Text = "Title";
            this.label_title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button_quit
            // 
            this.button_quit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_quit.Dock = System.Windows.Forms.DockStyle.Right;
            this.button_quit.FlatAppearance.BorderSize = 0;
            this.button_quit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_quit.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_quit.Image = global::DSNadaptor.Properties.Resources._11586_200;
            this.button_quit.Location = new System.Drawing.Point(458, 0);
            this.button_quit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_quit.Name = "button_quit";
            this.button_quit.Size = new System.Drawing.Size(43, 46);
            this.button_quit.TabIndex = 3;
            this.button_quit.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button_quit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button_quit.UseVisualStyleBackColor = true;
            this.button_quit.Click += new System.EventHandler(this.button_quit_Click);
            // 
            // panel_lower
            // 
            this.panel_lower.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel_lower.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_lower.Controls.Add(this.button_yes);
            this.panel_lower.Controls.Add(this.button_no);
            this.panel_lower.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_lower.Location = new System.Drawing.Point(0, 238);
            this.panel_lower.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel_lower.Name = "panel_lower";
            this.panel_lower.Size = new System.Drawing.Size(503, 30);
            this.panel_lower.TabIndex = 3;
            // 
            // button_yes
            // 
            this.button_yes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_yes.FlatAppearance.BorderSize = 0;
            this.button_yes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_yes.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_yes.Image = global::DSNadaptor.Properties.Resources.Yes_icon;
            this.button_yes.Location = new System.Drawing.Point(198, 0);
            this.button_yes.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_yes.Name = "button_yes";
            this.button_yes.Size = new System.Drawing.Size(43, 28);
            this.button_yes.TabIndex = 4;
            this.button_yes.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button_yes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button_yes.UseVisualStyleBackColor = true;
            this.button_yes.Visible = false;
            this.button_yes.Click += new System.EventHandler(this.button_yes_Click);
            // 
            // button_no
            // 
            this.button_no.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_no.FlatAppearance.BorderSize = 0;
            this.button_no.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_no.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_no.Image = global::DSNadaptor.Properties.Resources._11586_200;
            this.button_no.Location = new System.Drawing.Point(281, 1);
            this.button_no.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_no.Name = "button_no";
            this.button_no.Size = new System.Drawing.Size(43, 28);
            this.button_no.TabIndex = 3;
            this.button_no.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button_no.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button_no.UseVisualStyleBackColor = true;
            this.button_no.Visible = false;
            this.button_no.Click += new System.EventHandler(this.button_quit_Click);
            // 
            // pictureBox_image
            // 
            this.pictureBox_image.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox_image.Location = new System.Drawing.Point(0, 48);
            this.pictureBox_image.Name = "pictureBox_image";
            this.pictureBox_image.Size = new System.Drawing.Size(503, 190);
            this.pictureBox_image.TabIndex = 4;
            this.pictureBox_image.TabStop = false;
            // 
            // PopupImage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(503, 268);
            this.Controls.Add(this.pictureBox_image);
            this.Controls.Add(this.panel_lower);
            this.Controls.Add(this.panel_toolbar);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "PopupImage";
            this.Opacity = 0D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Popup";
            this.panel_toolbar.ResumeLayout(false);
            this.panel_toolbar.PerformLayout();
            this.panel_lower.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_image)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_toolbar;
        private System.Windows.Forms.Label label_title;
        private System.Windows.Forms.Button button_quit;
        private System.Windows.Forms.Panel panel_lower;
        private System.Windows.Forms.Button button_yes;
        private System.Windows.Forms.Button button_no;
        private System.Windows.Forms.PictureBox pictureBox_image;
    }
}