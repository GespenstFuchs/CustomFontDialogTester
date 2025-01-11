using System;
using System.Windows.Forms;
using WindowsFormsFontDialog;

namespace CustomFontDialogTester
{
    public partial class MainForm : Form
    {
        /// <summary>
        /// コンストラクタ
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// ラベルフォント変更ダイアログ表示ボタン押下処理
        /// </summary>
        /// <param name="sender">オブジェクト</param>
        /// <param name="e">イベント</param>
        private void LabelFontChangeButton_Click(object sender, EventArgs e)
        {
            using (FontForm fontForm = new FontForm())
            {
                fontForm.SetFont = ChangeLabel.Font;

                // ダイアログを表示し、結果を判定する。
                if (Equals(fontForm.ShowDialog(this), DialogResult.OK))
                {
                    // OKボタンが押下された場合
                    ChangeLabel.Font = fontForm.SetFont;
                }
            }
        }

        /// <summary>
        /// テキストボックスフォント変更ダイアログ表示ボタン押下処理
        /// </summary>
        /// <param name="sender">オブジェクト</param>
        /// <param name="e">イベント</param>
        private void TextBoxFontChangeButton_Click(object sender, EventArgs e)
        {
            using (FontForm fontForm = new FontForm())
            {
                fontForm.SetFont = ChangeTextBox.Font;

                // ダイアログを表示し、結果を判定する。
                if (Equals(fontForm.ShowDialog(this), DialogResult.OK))
                {
                    // OKボタンが押下された場合
                    ChangeTextBox.Font = fontForm.SetFont;
                }
            }
        }
    }
}
