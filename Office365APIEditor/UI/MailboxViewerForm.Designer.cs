﻿namespace Office365APIEditor
{
    partial class MailboxViewerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MailboxViewerForm));
            this.treeView_Mailbox = new System.Windows.Forms.TreeView();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.dataGridView_FolderProps = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip_FolderTreeNode = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ToolStripMenuItem_OpenContentTable = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newSessionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeSessionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.windowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newMessageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.focusedInboxOverridesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newEditorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.accessTokenViewerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkForUpdatesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.versionInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newEventToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_FolderProps)).BeginInit();
            this.contextMenuStrip_FolderTreeNode.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // treeView_Mailbox
            // 
            this.treeView_Mailbox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView_Mailbox.Location = new System.Drawing.Point(0, 0);
            this.treeView_Mailbox.Name = "treeView_Mailbox";
            this.treeView_Mailbox.Size = new System.Drawing.Size(181, 429);
            this.treeView_Mailbox.TabIndex = 1;
            this.treeView_Mailbox.BeforeCollapse += new System.Windows.Forms.TreeViewCancelEventHandler(this.treeView_Mailbox_BeforeCollapse);
            this.treeView_Mailbox.BeforeExpand += new System.Windows.Forms.TreeViewCancelEventHandler(this.treeView_Mailbox_BeforeExpand);
            this.treeView_Mailbox.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView_Mailbox_AfterSelect);
            this.treeView_Mailbox.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeView_Mailbox_NodeMouseClick);
            this.treeView_Mailbox.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeView_Mailbox_NodeMouseDoubleClick);
            this.treeView_Mailbox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.treeView_Mailbox_MouseDown);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(0, 27);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.treeView_Mailbox);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dataGridView_FolderProps);
            this.splitContainer1.Size = new System.Drawing.Size(680, 429);
            this.splitContainer1.SplitterDistance = 181;
            this.splitContainer1.TabIndex = 2;
            // 
            // dataGridView_FolderProps
            // 
            this.dataGridView_FolderProps.AllowUserToAddRows = false;
            this.dataGridView_FolderProps.AllowUserToDeleteRows = false;
            this.dataGridView_FolderProps.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_FolderProps.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_FolderProps.Location = new System.Drawing.Point(0, 0);
            this.dataGridView_FolderProps.Name = "dataGridView_FolderProps";
            this.dataGridView_FolderProps.ReadOnly = true;
            this.dataGridView_FolderProps.Size = new System.Drawing.Size(495, 429);
            this.dataGridView_FolderProps.TabIndex = 0;
            // 
            // contextMenuStrip_FolderTreeNode
            // 
            this.contextMenuStrip_FolderTreeNode.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.contextMenuStrip_FolderTreeNode.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem_OpenContentTable});
            this.contextMenuStrip_FolderTreeNode.Name = "contextMenuStrip_FolderTreeNode";
            this.contextMenuStrip_FolderTreeNode.Size = new System.Drawing.Size(299, 40);
            // 
            // ToolStripMenuItem_OpenContentTable
            // 
            this.ToolStripMenuItem_OpenContentTable.Name = "ToolStripMenuItem_OpenContentTable";
            this.ToolStripMenuItem_OpenContentTable.Size = new System.Drawing.Size(298, 36);
            this.ToolStripMenuItem_OpenContentTable.Text = "Open content table";
            this.ToolStripMenuItem_OpenContentTable.Click += new System.EventHandler(this.ToolStripMenuItem_OpenContentTable_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.windowToolStripMenuItem,
            this.toolsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(680, 42);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newSessionToolStripMenuItem,
            this.closeSessionToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(64, 38);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // newSessionToolStripMenuItem
            // 
            this.newSessionToolStripMenuItem.Name = "newSessionToolStripMenuItem";
            this.newSessionToolStripMenuItem.Size = new System.Drawing.Size(264, 38);
            this.newSessionToolStripMenuItem.Text = "&New Session...";
            this.newSessionToolStripMenuItem.Click += new System.EventHandler(this.newSessionToolStripMenuItem_Click);
            // 
            // closeSessionToolStripMenuItem
            // 
            this.closeSessionToolStripMenuItem.Name = "closeSessionToolStripMenuItem";
            this.closeSessionToolStripMenuItem.Size = new System.Drawing.Size(264, 38);
            this.closeSessionToolStripMenuItem.Text = "&Close Session";
            this.closeSessionToolStripMenuItem.Click += new System.EventHandler(this.closeSessionToolStripMenuItem_Click);
            // 
            // windowToolStripMenuItem
            // 
            this.windowToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newMessageToolStripMenuItem,
            this.newEventToolStripMenuItem,
            this.focusedInboxOverridesToolStripMenuItem});
            this.windowToolStripMenuItem.Name = "windowToolStripMenuItem";
            this.windowToolStripMenuItem.Size = new System.Drawing.Size(114, 38);
            this.windowToolStripMenuItem.Text = "&Window";
            // 
            // newMessageToolStripMenuItem
            // 
            this.newMessageToolStripMenuItem.Name = "newMessageToolStripMenuItem";
            this.newMessageToolStripMenuItem.Size = new System.Drawing.Size(392, 38);
            this.newMessageToolStripMenuItem.Text = "New &Message...";
            this.newMessageToolStripMenuItem.Click += new System.EventHandler(this.NewMessageToolStripMenuItem_Click);
            // 
            // focusedInboxOverridesToolStripMenuItem
            // 
            this.focusedInboxOverridesToolStripMenuItem.Name = "focusedInboxOverridesToolStripMenuItem";
            this.focusedInboxOverridesToolStripMenuItem.Size = new System.Drawing.Size(392, 38);
            this.focusedInboxOverridesToolStripMenuItem.Text = "&Focused Inbox Overrides...";
            this.focusedInboxOverridesToolStripMenuItem.Click += new System.EventHandler(this.FocusedInboxOverridesToolStripMenuItem_Click);
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newEditorToolStripMenuItem,
            this.accessTokenViewerToolStripMenuItem});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(84, 38);
            this.toolsToolStripMenuItem.Text = "&Tools";
            // 
            // newEditorToolStripMenuItem
            // 
            this.newEditorToolStripMenuItem.Name = "newEditorToolStripMenuItem";
            this.newEditorToolStripMenuItem.Size = new System.Drawing.Size(362, 38);
            this.newEditorToolStripMenuItem.Text = "New &Editor...";
            this.newEditorToolStripMenuItem.Click += new System.EventHandler(this.newEditorToolStripMenuItem_Click);
            // 
            // accessTokenViewerToolStripMenuItem
            // 
            this.accessTokenViewerToolStripMenuItem.Name = "accessTokenViewerToolStripMenuItem";
            this.accessTokenViewerToolStripMenuItem.Size = new System.Drawing.Size(362, 38);
            this.accessTokenViewerToolStripMenuItem.Text = "&Generic Token Viewer...";
            this.accessTokenViewerToolStripMenuItem.Click += new System.EventHandler(this.accessTokenViewerToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.checkForUpdatesToolStripMenuItem,
            this.versionInformationToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(77, 38);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // checkForUpdatesToolStripMenuItem
            // 
            this.checkForUpdatesToolStripMenuItem.Name = "checkForUpdatesToolStripMenuItem";
            this.checkForUpdatesToolStripMenuItem.Size = new System.Drawing.Size(326, 38);
            this.checkForUpdatesToolStripMenuItem.Text = "&Check for updates...";
            this.checkForUpdatesToolStripMenuItem.Click += new System.EventHandler(this.checkForUpdatesToolStripMenuItem_Click);
            // 
            // versionInformationToolStripMenuItem
            // 
            this.versionInformationToolStripMenuItem.Name = "versionInformationToolStripMenuItem";
            this.versionInformationToolStripMenuItem.Size = new System.Drawing.Size(326, 38);
            this.versionInformationToolStripMenuItem.Text = "&Version Information";
            this.versionInformationToolStripMenuItem.Click += new System.EventHandler(this.versionInformationToolStripMenuItem_Click);
            // 
            // newEventToolStripMenuItem
            // 
            this.newEventToolStripMenuItem.Name = "newEventToolStripMenuItem";
            this.newEventToolStripMenuItem.Size = new System.Drawing.Size(392, 38);
            this.newEventToolStripMenuItem.Text = "New &Event...";
            this.newEventToolStripMenuItem.Click += new System.EventHandler(this.newEventToolStripMenuItem_Click);
            // 
            // MailboxViewerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 456);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MailboxViewerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Office365APIEditor - Mailbox Viewer";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MailboxViewerForm_FormClosing);
            this.Load += new System.EventHandler(this.MailboxViewerForm_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_FolderProps)).EndInit();
            this.contextMenuStrip_FolderTreeNode.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TreeView treeView_Mailbox;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView dataGridView_FolderProps;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip_FolderTreeNode;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_OpenContentTable;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newSessionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newEditorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeSessionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem accessTokenViewerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem windowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newMessageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem focusedInboxOverridesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem versionInformationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem checkForUpdatesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newEventToolStripMenuItem;
    }
}