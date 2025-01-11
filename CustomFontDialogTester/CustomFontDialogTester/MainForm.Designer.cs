namespace CustomFontDialogTester
{
    partial class MainForm
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.MainPanel = new System.Windows.Forms.Panel();
            this.ChangeTextBox = new System.Windows.Forms.TextBox();
            this.TextBoxFontChangeButton = new System.Windows.Forms.Button();
            this.ChangeLabel = new System.Windows.Forms.Label();
            this.LabelFontChangeButton = new System.Windows.Forms.Button();
            this.MainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainPanel
            // 
            this.MainPanel.Controls.Add(this.ChangeTextBox);
            this.MainPanel.Controls.Add(this.TextBoxFontChangeButton);
            this.MainPanel.Controls.Add(this.ChangeLabel);
            this.MainPanel.Controls.Add(this.LabelFontChangeButton);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(0, 0);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(800, 450);
            this.MainPanel.TabIndex = 0;
            // 
            // ChangeTextBox
            // 
            this.ChangeTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ChangeTextBox.Location = new System.Drawing.Point(32, 265);
            this.ChangeTextBox.MaxLength = 0;
            this.ChangeTextBox.Multiline = true;
            this.ChangeTextBox.Name = "ChangeTextBox";
            this.ChangeTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.ChangeTextBox.Size = new System.Drawing.Size(756, 173);
            this.ChangeTextBox.TabIndex = 3;
            this.ChangeTextBox.Text = "サンプルテキスト";
            // 
            // TextBoxFontChangeButton
            // 
            this.TextBoxFontChangeButton.Location = new System.Drawing.Point(32, 209);
            this.TextBoxFontChangeButton.Name = "TextBoxFontChangeButton";
            this.TextBoxFontChangeButton.Size = new System.Drawing.Size(300, 50);
            this.TextBoxFontChangeButton.TabIndex = 2;
            this.TextBoxFontChangeButton.Text = "テキストボックスフォント変更ダイアログ表示";
            this.TextBoxFontChangeButton.UseVisualStyleBackColor = true;
            this.TextBoxFontChangeButton.Click += new System.EventHandler(this.TextBoxFontChangeButton_Click);
            // 
            // ChangeLabel
            // 
            this.ChangeLabel.AutoSize = true;
            this.ChangeLabel.Location = new System.Drawing.Point(338, 27);
            this.ChangeLabel.Name = "ChangeLabel";
            this.ChangeLabel.Size = new System.Drawing.Size(95, 21);
            this.ChangeLabel.TabIndex = 1;
            this.ChangeLabel.Text = "サンプルラベル";
            // 
            // LabelFontChangeButton
            // 
            this.LabelFontChangeButton.Location = new System.Drawing.Point(32, 12);
            this.LabelFontChangeButton.Name = "LabelFontChangeButton";
            this.LabelFontChangeButton.Size = new System.Drawing.Size(300, 50);
            this.LabelFontChangeButton.TabIndex = 0;
            this.LabelFontChangeButton.Text = "ラベルフォント変更ダイアログ表示";
            this.LabelFontChangeButton.UseVisualStyleBackColor = true;
            this.LabelFontChangeButton.Click += new System.EventHandler(this.LabelFontChangeButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.MainPanel);
            this.Font = new System.Drawing.Font("Yu Gothic UI", 12F);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "カスタムフォントダイアログテスター";
            this.MainPanel.ResumeLayout(false);
            this.MainPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.TextBox ChangeTextBox;
        private System.Windows.Forms.Button TextBoxFontChangeButton;
        private System.Windows.Forms.Label ChangeLabel;
        private System.Windows.Forms.Button LabelFontChangeButton;
    }
}

