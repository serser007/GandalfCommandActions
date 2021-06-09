
namespace WinCommandActions
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.actionListBox = new System.Windows.Forms.ListBox();
            this.addActionButton = new System.Windows.Forms.Button();
            this.removeActionButton = new System.Windows.Forms.Button();
            this.titleTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.commandTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.fileNameLabel = new System.Windows.Forms.Label();
            this.browseFileButton = new System.Windows.Forms.Button();
            this.actionEditPanel = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.listBoxPanel = new System.Windows.Forms.Panel();
            this.browseFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.actionEditPanel.SuspendLayout();
            this.listBoxPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // actionListBox
            // 
            this.actionListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.actionListBox.FormattingEnabled = true;
            this.actionListBox.Location = new System.Drawing.Point(0, 0);
            this.actionListBox.Name = "actionListBox";
            this.actionListBox.Size = new System.Drawing.Size(230, 316);
            this.actionListBox.TabIndex = 0;
            this.actionListBox.SelectedIndexChanged += new System.EventHandler(this.actionListBox_SelectedIndexChanged);
            // 
            // addActionButton
            // 
            this.addActionButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.addActionButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addActionButton.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.addActionButton.Location = new System.Drawing.Point(151, 321);
            this.addActionButton.Name = "addActionButton";
            this.addActionButton.Size = new System.Drawing.Size(36, 35);
            this.addActionButton.TabIndex = 1;
            this.addActionButton.Text = "+";
            this.addActionButton.UseVisualStyleBackColor = true;
            this.addActionButton.Click += new System.EventHandler(this.addActionButton_Click);
            // 
            // removeActionButton
            // 
            this.removeActionButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.removeActionButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removeActionButton.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.removeActionButton.Location = new System.Drawing.Point(0, 321);
            this.removeActionButton.Name = "removeActionButton";
            this.removeActionButton.Size = new System.Drawing.Size(38, 35);
            this.removeActionButton.TabIndex = 2;
            this.removeActionButton.Text = "-";
            this.removeActionButton.UseVisualStyleBackColor = true;
            this.removeActionButton.Click += new System.EventHandler(this.removeActionButton_Click);
            // 
            // titleTextBox
            // 
            this.titleTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.titleTextBox.Location = new System.Drawing.Point(60, 3);
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new System.Drawing.Size(337, 20);
            this.titleTextBox.TabIndex = 3;
            this.titleTextBox.TextChanged += new System.EventHandler(this.titleTextBox_TextChanged);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Title";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // commandTextBox
            // 
            this.commandTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.commandTextBox.Location = new System.Drawing.Point(60, 24);
            this.commandTextBox.Name = "commandTextBox";
            this.commandTextBox.Size = new System.Drawing.Size(337, 20);
            this.commandTextBox.TabIndex = 5;
            this.commandTextBox.TextChanged += new System.EventHandler(this.commandTextBox_TextChanged);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(3, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Command";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // fileNameLabel
            // 
            this.fileNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fileNameLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.fileNameLabel.Location = new System.Drawing.Point(60, 47);
            this.fileNameLabel.Name = "fileNameLabel";
            this.fileNameLabel.Size = new System.Drawing.Size(262, 20);
            this.fileNameLabel.TabIndex = 7;
            this.fileNameLabel.Text = "...";
            this.fileNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.fileNameLabel.TextChanged += new System.EventHandler(this.fileNameLabel_TextChanged);
            // 
            // browseFileButton
            // 
            this.browseFileButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.browseFileButton.Location = new System.Drawing.Point(320, 44);
            this.browseFileButton.Name = "browseFileButton";
            this.browseFileButton.Size = new System.Drawing.Size(74, 23);
            this.browseFileButton.TabIndex = 8;
            this.browseFileButton.Text = "browse";
            this.browseFileButton.UseVisualStyleBackColor = true;
            this.browseFileButton.Click += new System.EventHandler(this.browseFileButton_Click);
            // 
            // actionEditPanel
            // 
            this.actionEditPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.actionEditPanel.Controls.Add(this.label3);
            this.actionEditPanel.Controls.Add(this.fileNameLabel);
            this.actionEditPanel.Controls.Add(this.label1);
            this.actionEditPanel.Controls.Add(this.label2);
            this.actionEditPanel.Controls.Add(this.titleTextBox);
            this.actionEditPanel.Controls.Add(this.browseFileButton);
            this.actionEditPanel.Controls.Add(this.commandTextBox);
            this.actionEditPanel.Location = new System.Drawing.Point(187, 0);
            this.actionEditPanel.Name = "actionEditPanel";
            this.actionEditPanel.Size = new System.Drawing.Size(396, 317);
            this.actionEditPanel.TabIndex = 9;
            this.actionEditPanel.Visible = false;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(3, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "File";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // listBoxPanel
            // 
            this.listBoxPanel.Controls.Add(this.actionListBox);
            this.listBoxPanel.Controls.Add(this.addActionButton);
            this.listBoxPanel.Controls.Add(this.removeActionButton);
            this.listBoxPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.listBoxPanel.Location = new System.Drawing.Point(0, 0);
            this.listBoxPanel.Name = "listBoxPanel";
            this.listBoxPanel.Size = new System.Drawing.Size(187, 356);
            this.listBoxPanel.TabIndex = 10;
            // 
            // browseFileDialog
            // 
            this.browseFileDialog.Filter = "all files|*|python files |*.py";
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(586, 356);
            this.Controls.Add(this.actionEditPanel);
            this.Controls.Add(this.listBoxPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(602, 395);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(602, 395);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "CommandActions";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.actionEditPanel.ResumeLayout(false);
            this.actionEditPanel.PerformLayout();
            this.listBoxPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox actionListBox;
        private System.Windows.Forms.Button addActionButton;
        private System.Windows.Forms.Button removeActionButton;
        private System.Windows.Forms.TextBox titleTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox commandTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label fileNameLabel;
        private System.Windows.Forms.Button browseFileButton;
        private System.Windows.Forms.Panel actionEditPanel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel listBoxPanel;
        private System.Windows.Forms.OpenFileDialog browseFileDialog;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
    }
}

