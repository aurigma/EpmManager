namespace EpmManager
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.websiteListView = new System.Windows.Forms.ListView();
            this.Website = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Value = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.imageListIcons = new System.Windows.Forms.ImageList(this.components);
            this.websiteToolStrip = new System.Windows.Forms.ToolStrip();
            this.richTextBoxInstructions = new System.Windows.Forms.RichTextBox();
            this.toolStripButtonEpmOff = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonEpmOn = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonReset = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonRefresh = new System.Windows.Forms.ToolStripButton();
            this.websiteToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // websiteListView
            // 
            this.websiteListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Website,
            this.Value});
            this.websiteListView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.websiteListView.FullRowSelect = true;
            this.websiteListView.Location = new System.Drawing.Point(0, 364);
            this.websiteListView.Name = "websiteListView";
            this.websiteListView.Size = new System.Drawing.Size(652, 149);
            this.websiteListView.SmallImageList = this.imageListIcons;
            this.websiteListView.TabIndex = 1;
            this.websiteListView.UseCompatibleStateImageBehavior = false;
            this.websiteListView.View = System.Windows.Forms.View.Details;
            this.websiteListView.SelectedIndexChanged += new System.EventHandler(this.websiteListView_SelectedIndexChanged);
            // 
            // Website
            // 
            this.Website.Text = "Website name";
            this.Website.Width = 262;
            // 
            // Value
            // 
            this.Value.Text = "Value";
            this.Value.Width = 206;
            // 
            // imageListIcons
            // 
            this.imageListIcons.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageListIcons.ImageSize = new System.Drawing.Size(16, 16);
            this.imageListIcons.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // websiteToolStrip
            // 
            this.websiteToolStrip.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.websiteToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonEpmOff,
            this.toolStripButtonEpmOn,
            this.toolStripButtonReset,
            this.toolStripButtonRefresh});
            this.websiteToolStrip.Location = new System.Drawing.Point(0, 339);
            this.websiteToolStrip.Name = "websiteToolStrip";
            this.websiteToolStrip.Size = new System.Drawing.Size(652, 25);
            this.websiteToolStrip.TabIndex = 2;
            this.websiteToolStrip.Text = "toolStrip1";
            // 
            // richTextBoxInstructions
            // 
            this.richTextBoxInstructions.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBoxInstructions.Location = new System.Drawing.Point(0, 0);
            this.richTextBoxInstructions.Name = "richTextBoxInstructions";
            this.richTextBoxInstructions.ReadOnly = true;
            this.richTextBoxInstructions.Size = new System.Drawing.Size(652, 336);
            this.richTextBoxInstructions.TabIndex = 3;
            this.richTextBoxInstructions.Text = "";
            // 
            // toolStripButtonEpmOff
            // 
            this.toolStripButtonEpmOff.Image = global::EpmManager.Properties.Resources.thumbs_up_16;
            this.toolStripButtonEpmOff.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonEpmOff.Name = "toolStripButtonEpmOff";
            this.toolStripButtonEpmOff.Size = new System.Drawing.Size(89, 22);
            this.toolStripButtonEpmOff.Text = "Turn EPM off";
            this.toolStripButtonEpmOff.Click += new System.EventHandler(this.toolStripButtonEpmOff_Click);
            // 
            // toolStripButtonEpmOn
            // 
            this.toolStripButtonEpmOn.Image = global::EpmManager.Properties.Resources.thumbs_up2_16;
            this.toolStripButtonEpmOn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonEpmOn.Name = "toolStripButtonEpmOn";
            this.toolStripButtonEpmOn.Size = new System.Drawing.Size(87, 22);
            this.toolStripButtonEpmOn.Text = "Turn EPM on";
            this.toolStripButtonEpmOn.Click += new System.EventHandler(this.toolStripButtonEpmOn_Click);
            // 
            // toolStripButtonReset
            // 
            this.toolStripButtonReset.Image = global::EpmManager.Properties.Resources.IE_16;
            this.toolStripButtonReset.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonReset.Name = "toolStripButtonReset";
            this.toolStripButtonReset.Size = new System.Drawing.Size(126, 22);
            this.toolStripButtonReset.Text = "Have IE to ask again";
            this.toolStripButtonReset.Click += new System.EventHandler(this.toolStripButtonReset_Click);
            // 
            // toolStripButtonRefresh
            // 
            this.toolStripButtonRefresh.Image = global::EpmManager.Properties.Resources.loop_16;
            this.toolStripButtonRefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonRefresh.Name = "toolStripButtonRefresh";
            this.toolStripButtonRefresh.Size = new System.Drawing.Size(65, 22);
            this.toolStripButtonRefresh.Text = "Refresh";
            this.toolStripButtonRefresh.Click += new System.EventHandler(this.toolStripButtonRefresh_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(652, 513);
            this.Controls.Add(this.richTextBoxInstructions);
            this.Controls.Add(this.websiteToolStrip);
            this.Controls.Add(this.websiteListView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "IE EPM Manager";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.websiteToolStrip.ResumeLayout(false);
            this.websiteToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView websiteListView;
        private System.Windows.Forms.ColumnHeader Website;
        private System.Windows.Forms.ColumnHeader Value;
        private System.Windows.Forms.ToolStrip websiteToolStrip;
        private System.Windows.Forms.ToolStripButton toolStripButtonEpmOff;
        private System.Windows.Forms.ToolStripButton toolStripButtonEpmOn;
        private System.Windows.Forms.ToolStripButton toolStripButtonReset;
        private System.Windows.Forms.ToolStripButton toolStripButtonRefresh;
        private System.Windows.Forms.ImageList imageListIcons;
        private System.Windows.Forms.RichTextBox richTextBoxInstructions;

    }
}

