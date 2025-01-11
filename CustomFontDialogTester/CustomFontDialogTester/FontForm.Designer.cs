namespace WindowsFormsFontDialog
{
    partial class FontForm
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
            this.MainPanel = new System.Windows.Forms.Panel();
            this.SampleTextBox = new System.Windows.Forms.TextBox();
            this.StyleFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.RegularRadioButton = new System.Windows.Forms.RadioButton();
            this.BoldRadioButton = new System.Windows.Forms.RadioButton();
            this.ItalicRadioButton = new System.Windows.Forms.RadioButton();
            this.BoldAndItalicRadioButton = new System.Windows.Forms.RadioButton();
            this.FontFamilyFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.SampleLabel = new System.Windows.Forms.Label();
            this.CloseButton = new System.Windows.Forms.Button();
            this.OkButton = new System.Windows.Forms.Button();
            this.SizeNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.SizeLabel = new System.Windows.Forms.Label();
            this.StyleLabel = new System.Windows.Forms.Label();
            this.FontNameTextBox = new System.Windows.Forms.TextBox();
            this.FontNameContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.UndoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.CutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CopyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.AllSelectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FontNameLabel = new System.Windows.Forms.Label();
            this.MainPanel.SuspendLayout();
            this.StyleFlowLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SizeNumericUpDown)).BeginInit();
            this.FontNameContextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainPanel
            // 
            this.MainPanel.Controls.Add(this.SampleTextBox);
            this.MainPanel.Controls.Add(this.StyleFlowLayoutPanel);
            this.MainPanel.Controls.Add(this.FontFamilyFlowLayoutPanel);
            this.MainPanel.Controls.Add(this.SampleLabel);
            this.MainPanel.Controls.Add(this.CloseButton);
            this.MainPanel.Controls.Add(this.OkButton);
            this.MainPanel.Controls.Add(this.SizeNumericUpDown);
            this.MainPanel.Controls.Add(this.SizeLabel);
            this.MainPanel.Controls.Add(this.StyleLabel);
            this.MainPanel.Controls.Add(this.FontNameTextBox);
            this.MainPanel.Controls.Add(this.FontNameLabel);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(0, 0);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(414, 496);
            this.MainPanel.TabIndex = 0;
            // 
            // SampleTextBox
            // 
            this.SampleTextBox.BackColor = System.Drawing.Color.Azure;
            this.SampleTextBox.Location = new System.Drawing.Point(28, 319);
            this.SampleTextBox.MaxLength = 0;
            this.SampleTextBox.Multiline = true;
            this.SampleTextBox.Name = "SampleTextBox";
            this.SampleTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.SampleTextBox.Size = new System.Drawing.Size(356, 95);
            this.SampleTextBox.TabIndex = 13;
            this.SampleTextBox.Text = "サンプル文字列ABC";
            // 
            // StyleFlowLayoutPanel
            // 
            this.StyleFlowLayoutPanel.AutoScroll = true;
            this.StyleFlowLayoutPanel.BackColor = System.Drawing.Color.Azure;
            this.StyleFlowLayoutPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.StyleFlowLayoutPanel.Controls.Add(this.RegularRadioButton);
            this.StyleFlowLayoutPanel.Controls.Add(this.BoldRadioButton);
            this.StyleFlowLayoutPanel.Controls.Add(this.ItalicRadioButton);
            this.StyleFlowLayoutPanel.Controls.Add(this.BoldAndItalicRadioButton);
            this.StyleFlowLayoutPanel.Location = new System.Drawing.Point(267, 54);
            this.StyleFlowLayoutPanel.Name = "StyleFlowLayoutPanel";
            this.StyleFlowLayoutPanel.Size = new System.Drawing.Size(118, 136);
            this.StyleFlowLayoutPanel.TabIndex = 3;
            // 
            // RegularRadioButton
            // 
            this.RegularRadioButton.AutoSize = true;
            this.RegularRadioButton.Checked = true;
            this.RegularRadioButton.Location = new System.Drawing.Point(3, 3);
            this.RegularRadioButton.Name = "RegularRadioButton";
            this.RegularRadioButton.Size = new System.Drawing.Size(60, 25);
            this.RegularRadioButton.TabIndex = 0;
            this.RegularRadioButton.TabStop = true;
            this.RegularRadioButton.Text = "標準";
            this.RegularRadioButton.UseVisualStyleBackColor = true;
            // 
            // BoldRadioButton
            // 
            this.BoldRadioButton.AutoSize = true;
            this.BoldRadioButton.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold);
            this.BoldRadioButton.Location = new System.Drawing.Point(3, 34);
            this.BoldRadioButton.Name = "BoldRadioButton";
            this.BoldRadioButton.Size = new System.Drawing.Size(60, 25);
            this.BoldRadioButton.TabIndex = 1;
            this.BoldRadioButton.Text = "太字";
            this.BoldRadioButton.UseVisualStyleBackColor = true;
            // 
            // ItalicRadioButton
            // 
            this.ItalicRadioButton.AutoSize = true;
            this.ItalicRadioButton.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Italic);
            this.ItalicRadioButton.Location = new System.Drawing.Point(3, 65);
            this.ItalicRadioButton.Name = "ItalicRadioButton";
            this.ItalicRadioButton.Size = new System.Drawing.Size(60, 25);
            this.ItalicRadioButton.TabIndex = 2;
            this.ItalicRadioButton.Text = "斜体";
            this.ItalicRadioButton.UseVisualStyleBackColor = true;
            // 
            // BoldAndItalicRadioButton
            // 
            this.BoldAndItalicRadioButton.AutoSize = true;
            this.BoldAndItalicRadioButton.Font = new System.Drawing.Font("Yu Gothic UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.BoldAndItalicRadioButton.Location = new System.Drawing.Point(3, 96);
            this.BoldAndItalicRadioButton.Name = "BoldAndItalicRadioButton";
            this.BoldAndItalicRadioButton.Size = new System.Drawing.Size(100, 25);
            this.BoldAndItalicRadioButton.TabIndex = 3;
            this.BoldAndItalicRadioButton.Text = "太字・斜体";
            this.BoldAndItalicRadioButton.UseVisualStyleBackColor = true;
            // 
            // FontFamilyFlowLayoutPanel
            // 
            this.FontFamilyFlowLayoutPanel.AutoScroll = true;
            this.FontFamilyFlowLayoutPanel.BackColor = System.Drawing.Color.Azure;
            this.FontFamilyFlowLayoutPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FontFamilyFlowLayoutPanel.Location = new System.Drawing.Point(28, 54);
            this.FontFamilyFlowLayoutPanel.Name = "FontFamilyFlowLayoutPanel";
            this.FontFamilyFlowLayoutPanel.Size = new System.Drawing.Size(220, 193);
            this.FontFamilyFlowLayoutPanel.TabIndex = 1;
            this.FontFamilyFlowLayoutPanel.TabStop = true;
            // 
            // SampleLabel
            // 
            this.SampleLabel.AutoSize = true;
            this.SampleLabel.Location = new System.Drawing.Point(24, 295);
            this.SampleLabel.Name = "SampleLabel";
            this.SampleLabel.Size = new System.Drawing.Size(58, 21);
            this.SampleLabel.TabIndex = 10;
            this.SampleLabel.Text = "サンプル";
            // 
            // CloseButton
            // 
            this.CloseButton.Location = new System.Drawing.Point(284, 430);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(100, 40);
            this.CloseButton.TabIndex = 12;
            this.CloseButton.Text = "キャンセル";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // OkButton
            // 
            this.OkButton.Location = new System.Drawing.Point(168, 430);
            this.OkButton.Name = "OkButton";
            this.OkButton.Size = new System.Drawing.Size(100, 40);
            this.OkButton.TabIndex = 11;
            this.OkButton.Text = "OK";
            this.OkButton.UseVisualStyleBackColor = true;
            this.OkButton.Click += new System.EventHandler(this.OkButton_Click);
            // 
            // SizeNumericUpDown
            // 
            this.SizeNumericUpDown.BackColor = System.Drawing.Color.Azure;
            this.SizeNumericUpDown.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.SizeNumericUpDown.Location = new System.Drawing.Point(266, 251);
            this.SizeNumericUpDown.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.SizeNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.SizeNumericUpDown.Name = "SizeNumericUpDown";
            this.SizeNumericUpDown.Size = new System.Drawing.Size(60, 29);
            this.SizeNumericUpDown.TabIndex = 6;
            this.SizeNumericUpDown.Value = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.SizeNumericUpDown.ValueChanged += new System.EventHandler(this.SizeNumericUpDown_ValueChanged);
            this.SizeNumericUpDown.Leave += new System.EventHandler(this.SizeNumericUpDown_Leave);
            // 
            // SizeLabel
            // 
            this.SizeLabel.AutoSize = true;
            this.SizeLabel.Location = new System.Drawing.Point(262, 226);
            this.SizeLabel.Name = "SizeLabel";
            this.SizeLabel.Size = new System.Drawing.Size(46, 21);
            this.SizeLabel.TabIndex = 5;
            this.SizeLabel.Text = "サイズ";
            // 
            // StyleLabel
            // 
            this.StyleLabel.AutoSize = true;
            this.StyleLabel.Location = new System.Drawing.Point(263, 30);
            this.StyleLabel.Name = "StyleLabel";
            this.StyleLabel.Size = new System.Drawing.Size(58, 21);
            this.StyleLabel.TabIndex = 3;
            this.StyleLabel.Text = "スタイル";
            // 
            // FontNameTextBox
            // 
            this.FontNameTextBox.BackColor = System.Drawing.Color.Azure;
            this.FontNameTextBox.ContextMenuStrip = this.FontNameContextMenuStrip;
            this.FontNameTextBox.ForeColor = System.Drawing.Color.DarkGray;
            this.FontNameTextBox.Location = new System.Drawing.Point(28, 253);
            this.FontNameTextBox.MaxLength = 0;
            this.FontNameTextBox.Name = "FontNameTextBox";
            this.FontNameTextBox.Size = new System.Drawing.Size(220, 29);
            this.FontNameTextBox.TabIndex = 2;
            this.FontNameTextBox.Text = "フォント名を絞り込む";
            this.FontNameTextBox.TextChanged += new System.EventHandler(this.FontNameTextBox_TextChanged);
            this.FontNameTextBox.Enter += new System.EventHandler(this.FontNameTextBox_Enter);
            this.FontNameTextBox.Leave += new System.EventHandler(this.FontNameTextBox_Leave);
            // 
            // FontNameContextMenuStrip
            // 
            this.FontNameContextMenuStrip.Font = new System.Drawing.Font("Yu Gothic UI", 12F);
            this.FontNameContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.UndoToolStripMenuItem,
            this.toolStripSeparator1,
            this.CutToolStripMenuItem,
            this.CopyToolStripMenuItem,
            this.PasteToolStripMenuItem,
            this.DelToolStripMenuItem,
            this.toolStripSeparator2,
            this.AllSelectToolStripMenuItem});
            this.FontNameContextMenuStrip.Name = "FontNameContextMenuStrip";
            this.FontNameContextMenuStrip.Size = new System.Drawing.Size(193, 172);
            this.FontNameContextMenuStrip.Opening += new System.ComponentModel.CancelEventHandler(this.FontNameContextMenuStrip_Opening);
            // 
            // UndoToolStripMenuItem
            // 
            this.UndoToolStripMenuItem.Font = new System.Drawing.Font("Yu Gothic UI", 12F);
            this.UndoToolStripMenuItem.Name = "UndoToolStripMenuItem";
            this.UndoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.UndoToolStripMenuItem.Size = new System.Drawing.Size(192, 26);
            this.UndoToolStripMenuItem.Text = "元に戻す";
            this.UndoToolStripMenuItem.Click += new System.EventHandler(this.UndoToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(189, 6);
            // 
            // CutToolStripMenuItem
            // 
            this.CutToolStripMenuItem.Name = "CutToolStripMenuItem";
            this.CutToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.CutToolStripMenuItem.Size = new System.Drawing.Size(192, 26);
            this.CutToolStripMenuItem.Text = "切り取り";
            this.CutToolStripMenuItem.Click += new System.EventHandler(this.CutToolStripMenuItem_Click);
            // 
            // CopyToolStripMenuItem
            // 
            this.CopyToolStripMenuItem.Name = "CopyToolStripMenuItem";
            this.CopyToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.CopyToolStripMenuItem.Size = new System.Drawing.Size(192, 26);
            this.CopyToolStripMenuItem.Text = "コピー";
            this.CopyToolStripMenuItem.Click += new System.EventHandler(this.CopyToolStripMenuItem_Click);
            // 
            // PasteToolStripMenuItem
            // 
            this.PasteToolStripMenuItem.Name = "PasteToolStripMenuItem";
            this.PasteToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.PasteToolStripMenuItem.Size = new System.Drawing.Size(192, 26);
            this.PasteToolStripMenuItem.Text = "貼り付け";
            this.PasteToolStripMenuItem.Click += new System.EventHandler(this.PasteToolStripMenuItem_Click);
            // 
            // DelToolStripMenuItem
            // 
            this.DelToolStripMenuItem.Name = "DelToolStripMenuItem";
            this.DelToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Delete;
            this.DelToolStripMenuItem.Size = new System.Drawing.Size(192, 26);
            this.DelToolStripMenuItem.Text = "削除";
            this.DelToolStripMenuItem.Click += new System.EventHandler(this.DelToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(189, 6);
            // 
            // AllSelectToolStripMenuItem
            // 
            this.AllSelectToolStripMenuItem.Name = "AllSelectToolStripMenuItem";
            this.AllSelectToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.AllSelectToolStripMenuItem.Size = new System.Drawing.Size(192, 26);
            this.AllSelectToolStripMenuItem.Text = "全選択";
            this.AllSelectToolStripMenuItem.Click += new System.EventHandler(this.AllSelectToolStripMenuItem_Click);
            // 
            // FontNameLabel
            // 
            this.FontNameLabel.AutoSize = true;
            this.FontNameLabel.Location = new System.Drawing.Point(24, 30);
            this.FontNameLabel.Name = "FontNameLabel";
            this.FontNameLabel.Size = new System.Drawing.Size(71, 21);
            this.FontNameLabel.TabIndex = 0;
            this.FontNameLabel.Text = "フォント名";
            // 
            // FontForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(414, 496);
            this.Controls.Add(this.MainPanel);
            this.Font = new System.Drawing.Font("Yu Gothic UI", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FontForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "フォント";
            this.Load += new System.EventHandler(this.FontForm_Load);
            this.MainPanel.ResumeLayout(false);
            this.MainPanel.PerformLayout();
            this.StyleFlowLayoutPanel.ResumeLayout(false);
            this.StyleFlowLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SizeNumericUpDown)).EndInit();
            this.FontNameContextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.TextBox FontNameTextBox;
        private System.Windows.Forms.Label FontNameLabel;
        private System.Windows.Forms.Label StyleLabel;
        private System.Windows.Forms.NumericUpDown SizeNumericUpDown;
        private System.Windows.Forms.Label SizeLabel;
        private System.Windows.Forms.Label SampleLabel;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Button OkButton;
        private System.Windows.Forms.ContextMenuStrip FontNameContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem UndoToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem CutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CopyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem PasteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DelToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem AllSelectToolStripMenuItem;
        private System.Windows.Forms.FlowLayoutPanel FontFamilyFlowLayoutPanel;
        private System.Windows.Forms.FlowLayoutPanel StyleFlowLayoutPanel;
        private System.Windows.Forms.RadioButton RegularRadioButton;
        private System.Windows.Forms.RadioButton BoldRadioButton;
        private System.Windows.Forms.RadioButton ItalicRadioButton;
        private System.Windows.Forms.RadioButton BoldAndItalicRadioButton;
        private System.Windows.Forms.TextBox SampleTextBox;
    }
}