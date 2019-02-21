namespace quickcharmap
{
    partial class form
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
            this.charmap = new System.Windows.Forms.ListView();
            this.charname = new System.Windows.Forms.Label();
            this.x = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // charmap
            // 
            this.charmap.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.charmap.Alignment = System.Windows.Forms.ListViewAlignment.SnapToGrid;
            this.charmap.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.charmap.Cursor = System.Windows.Forms.Cursors.Default;
            this.charmap.Dock = System.Windows.Forms.DockStyle.Top;
            this.charmap.Font = new System.Drawing.Font("MS Gothic", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.charmap.FullRowSelect = true;
            this.charmap.GridLines = true;
            this.charmap.Location = new System.Drawing.Point(0, 0);
            this.charmap.MultiSelect = false;
            this.charmap.Name = "charmap";
            this.charmap.Size = new System.Drawing.Size(449, 488);
            this.charmap.TabIndex = 0;
            this.charmap.TileSize = new System.Drawing.Size(64, 64);
            this.charmap.UseCompatibleStateImageBehavior = false;
            this.charmap.ItemMouseHover += new System.Windows.Forms.ListViewItemMouseHoverEventHandler(this.hoveritem);
            this.charmap.Click += new System.EventHandler(this.click);
            this.charmap.MouseMove += new System.Windows.Forms.MouseEventHandler(this.movedmouse);
            this.charmap.MouseUp += new System.Windows.Forms.MouseEventHandler(this.selectchar);
            // 
            // charname
            // 
            this.charname.AutoSize = true;
            this.charname.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.charname.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.charname.Font = new System.Drawing.Font("MS Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.charname.Location = new System.Drawing.Point(0, 491);
            this.charname.Name = "charname";
            this.charname.Size = new System.Drawing.Size(252, 21);
            this.charname.TabIndex = 1;
            this.charname.Text = "No character selected!";
            // 
            // x
            // 
            this.x.BackColor = System.Drawing.SystemColors.Control;
            this.x.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.x.Location = new System.Drawing.Point(0, 0);
            this.x.Name = "x";
            this.x.Size = new System.Drawing.Size(23, 23);
            this.x.TabIndex = 2;
            this.x.Text = "X";
            this.x.UseVisualStyleBackColor = false;
            this.x.Click += new System.EventHandler(this.x_Click);
            // 
            // form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(449, 512);
            this.Controls.Add(this.x);
            this.Controls.Add(this.charname);
            this.Controls.Add(this.charmap);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quick-Select";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView charmap;
        private System.Windows.Forms.Button x;
        private System.Windows.Forms.Label charname;
    }
}

