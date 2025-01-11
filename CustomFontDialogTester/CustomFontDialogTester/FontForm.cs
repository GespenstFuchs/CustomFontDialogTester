using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Windows.Forms;

namespace WindowsFormsFontDialog
{
    /// <summary>
    /// フォントフォーム
    /// </summary>
    public partial class FontForm : Form
    {
        #region プロパティ

        /// <summary>
        /// 設定フォント
        /// </summary>
        public Font SetFont { get; set; }

        ///// <summary>
        ///// フォントコレクション
        ///// </summary>
        //private InstalledFontCollection FontCollection { get; set; }

        /// <summary>
        /// 設定フォント連想配列
        /// </summary>
        private Dictionary<string, int> SetFontDict { get; set; }

        /// <summary>
        /// 変更前フォント名テキスト
        /// </summary>
        private string ChangeBeforeFontNameText { get; set; } = string.Empty;

        /// <summary>
        /// フォント情報リスト
        /// </summary>
        private List<FontInfo> FontInfoList { get; set; } = new List<FontInfo>();

        #endregion

        #region コンストラクタ

        /// <summary>
        /// コンストラクタ
        /// </summary>
        public FontForm()
        {
            InitializeComponent();
            //FontCollection = new InstalledFontCollection();
            SetFontDict = new Dictionary<string, int>();
        }

        #endregion

        #region イベント

        /// <summary>
        /// 画面表示処理
        /// </summary>
        /// <param name="sender">オブジェクト</param>
        /// <param name="e">パラメータ</param>
        private void FontForm_Load(object sender, EventArgs e)
        {
            try
            {
                // 画面描画を停止する。
                FontFamilyFlowLayoutPanel.SuspendLayout();

                int index = 0;

                // 各フォント情報を設定、及び保持を行う。
                Array.ForEach(new InstalledFontCollection().Families, family =>
                {
                    Font font = new Font(family.Name, 14);

                    // ボタンを追加する。
                    Button button = new Button();
                    button.AutoSize = true;
                    button.Name = string.Concat("Button", index);
                    button.Text = family.Name;
                    button.Font = font;
                    button.Width = 200;
                    button.Height = 50;
                    button.Margin = new Padding(0);
                    FontFamilyFlowLayoutPanel.Controls.Add(button);

                    //// 文字セットを判定する。
                    //if (Equals(0, font.GdiCharSet) || Equals(128, font.GdiCharSet))
                    //{
                    //    // ANSI（0）・SHIFTJIS：（128）のいずれかの場合

                    //    // ボタンを追加する。
                    //    Button button = new Button();
                    //    button.AutoSize = true;
                    //    button.Name = string.Concat("Button", index);
                    //    button.Text = family.Name;
                    //    button.Font = font;
                    //    button.Width = 200;
                    //    button.Height = 50;
                    //    button.Margin = new Padding(0);
                    //    FontFamilyFlowLayoutPanel.Controls.Add(button);

                    //    //// フォント情報リストを設定する。
                    //    //FontInfoList.Add(new FontInfo()
                    //    //{
                    //    //    FontFamily = family.Name,
                    //    //    RegularFlg = family.IsStyleAvailable(FontStyle.Regular),
                    //    //    BoldFlg = family.IsStyleAvailable(FontStyle.Bold),
                    //    //    ItalicFlg = family.IsStyleAvailable(FontStyle.Italic),
                    //    //});
                    //}
                });
            }
            finally
            {
                // 画面描画を行う。。
                FontFamilyFlowLayoutPanel.ResumeLayout();
            }



            


            // 以下、旧ロジック

            //// フォント名リストボックス・設定フォント連想配列に、インストールされているフォントを設定する。
            //foreach (FontFamily family in FontCollection.Families)
            //{
            //    if (Const.UseFontDict.ContainsKey(family.Name))
            //    {
            //        FontNameListBox.Items.Add(family.Name);
            //        SetFontDict.Add(family.Name, Const.UseFontDict[family.Name]);
            //    }
            //}

            //string setFontName = Const.DefaultFontName;

            //// サイズを保持する。
            //decimal setSize = decimal.Parse(Math.Round(SetFont.Size).ToString());

            //// フォント名の有無を判定する。
            //if (Const.UseFontDict.ContainsKey(SetFont.Name))
            //{
            //    // 存在する場合
            //    setFontName = SetFont.Name;
            //}

            //// フォントを保持する。
            //Font setFont;
            //if (SetFont.Bold && SetFont.Italic)
            //{
            //    setFont = new Font(setFontName, SetFont.Size, FontStyle.Bold | FontStyle.Italic);
            //}
            //else if (SetFont.Bold && !SetFont.Italic)
            //{
            //    setFont = new Font(setFontName, SetFont.Size, FontStyle.Bold);
            //}
            //else if (!SetFont.Bold && SetFont.Italic)
            //{
            //    setFont = new Font(setFontName, SetFont.Size, FontStyle.Italic);
            //}
            //else
            //{
            //    setFont = new Font(setFontName, SetFont.Size);
            //}

            //// フォント情報を画面に反映する。
            //// フォント名リストボックス
            //FontNameListBox.SelectedIndex = FontNameListBox.FindString(setFontName);

            //// フォントを設定する。
            //SampleViewLabel.Font = setFont;

            //// スタイルリストボックス
            //if (SampleViewLabel.Font.Bold && SampleViewLabel.Font.Italic)
            //{
            //    StyleListBox.SelectedIndex = 3;
            //}
            //else if (!SampleViewLabel.Font.Bold && SampleViewLabel.Font.Italic)
            //{
            //    StyleListBox.SelectedIndex = 2;
            //}
            //else if (SampleViewLabel.Font.Bold && !SampleViewLabel.Font.Italic)
            //{
            //    StyleListBox.SelectedIndex = 1;
            //}
            //else
            //{
            //    StyleListBox.SelectedIndex = 0;
            //}

            //// サイズニューメリックアップダウン
            //SizeNumericUpDown.Value = setSize;

            //// アクティブコントロールを設定する。
            //ActiveControl = FontNameListBox;
        }

        /// <summary>
        /// フォント名リストボックス・項目描画処理
        /// </summary>
        /// <param name="sender">オブジェクト</param>
        /// <param name="e">パラメータ</param>
        private void FontNameListBox_DrawItem(object sender, DrawItemEventArgs e)
        {
            //// 項目が選択されている場合、強調表示する。
            //e.DrawBackground();

            //// 項目位置を判定する。
            //if (!Equals(-1, e.Index))
            //{
            //    // 項目が存在する場合

            //    // 文字色を取得・保持する。
            //    using (Brush brush = new SolidBrush(e.ForeColor))
            //    {
            //        // 項目に設定している文字列を取得・保持する。
            //        string itemText = FontNameListBox.GetItemText(FontNameListBox.Items[e.Index]);

            //        // フォントを設定する。
            //        Font font = new Font(itemText, 12);

            //        // 表示位置の微調整を行いながら、項目を描画する。
            //        // 項目名を判定する。
            //        switch (itemText)
            //        {
            //            case "Segoe Print":
            //                e.Graphics.DrawString(itemText, font, brush, e.Bounds.Left, e.Bounds.Top - 5);
            //                break;

            //            case "Segoe Script":
            //                // 26
            //                e.Graphics.DrawString(itemText, font, brush, e.Bounds.Left, e.Bounds.Top - 2);
            //                break;

            //            case "Comic Sans MS":
            //            case "Meiryo UI":
            //            case "Palatino Linotype":
            //            case "Segoe UI":
            //            case "Yu Gothic UI":
            //            case "メイリオ":
            //                // 22
            //                e.Graphics.DrawString(itemText, font, brush, e.Bounds.Left, e.Bounds.Top - 1);
            //                break;

            //            case "Arial":
            //            case "Calibri":
            //            case "Cascadia Code":
            //            case "Consolas":
            //            case "Constantia":
            //            case "Courier New":
            //            case "Georgia":
            //            case "Hack":
            //            case "Verdana":
            //                // 20
            //                e.Graphics.DrawString(itemText, font, brush, e.Bounds.Left, e.Bounds.Top + 1);
            //                break;

            //            case "Fira Code":
            //            case "MS UI Gothic":
            //            case "Roboto":
            //            case "UD デジタル 教科書体 N-R":
            //            case "UD デジタル 教科書体 NK-R":
            //            case "UD デジタル 教科書体 NP-R":
            //            case "ＭＳ ゴシック":
            //            case "ＭＳ Ｐゴシック":
            //                // 19
            //                e.Graphics.DrawString(itemText, font, brush, e.Bounds.Left, e.Bounds.Top + 2);
            //                break;

            //            case "BIZ UDPゴシック":
            //            case "BIZ UDゴシック":
            //            case "ＭＳ 明朝":
            //            case "ＭＳ Ｐ明朝":
            //                // 16
            //                e.Graphics.DrawString(itemText, font, brush, e.Bounds.Left, e.Bounds.Top + 3);
            //                break;

            //            default:
            //                // 21
            //                e.Graphics.DrawString(itemText, font, brush, e.Bounds);
            //                break;
            //        }
            //    }
            //}
        }

        /// <summary>
        /// フォント名リストボックス・選択項目位置変更後処理
        /// </summary>
        /// <param name="sender">オブジェクト</param>
        /// <param name="e">パラメータ</param>
        private void FontNameListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //int charSet = Const.UseFontDict[FontNameListBox.Text];
            //if (Equals(Const.CharSetTypAnsi, charSet))
            //{
            //    JapaneseRadioButton.Enabled = false;
            //    EuropeanLanguageRadioButton.Enabled = true;
            //    EuropeanLanguageRadioButton.Checked = true;
            //}
            //else if (Equals(Const.CharSetTypShiftJis, charSet))
            //{
            //    JapaneseRadioButton.Enabled = true;
            //    EuropeanLanguageRadioButton.Enabled = false;
            //    JapaneseRadioButton.Checked = true;
            //}
            //else
            //{
            //    JapaneseRadioButton.Enabled = true;
            //    EuropeanLanguageRadioButton.Enabled = true;
            //}

            SetSampleViewLabelFont();
        }

        /// <summary>
        /// フォント名テキストボックス・テキスト変更処理
        /// </summary>
        /// <param name="sender">オブジェクト</param>
        /// <param name="e">パラメータ</param>
        private void FontNameTextBox_TextChanged(object sender, EventArgs e)
        {
            // 文字色を判定する。
            if (Equals(Color.DarkGray, FontNameTextBox.ForeColor))
            {
                return;
            }

            // 変更前フォント名テキスト・フォント名テキストボックスのテキストを比較する。
            if (!string.Equals(ChangeBeforeFontNameText, FontNameTextBox.Text))
            {
                // 不一致の場合

                //// フォント名テキストボックスのテキストの有無を判定する。
                //if (string.IsNullOrEmpty(FontNameTextBox.Text))
                //{
                //    // 未入力の場合

                //    FontNameListBox.Items.Clear();
                //    foreach (KeyValuePair<string, int> setFont in SetFontDict)
                //    {
                //        FontNameListBox.Items.Add(setFont.Key);
                //    }

                //    FontNameListBox.SelectedIndex = 0;
                //}
                //else
                //{
                //    // 入力されている場合

                //    // フォント名リストボックスの項目をクリアする。
                //    FontNameListBox.Items.Clear();

                //    // フォント名を限定し、フォント名リストに項目を追加する。
                //    foreach (KeyValuePair<string, int> setFont in SetFontDict.Where(item => item.Key.Contains(FontNameTextBox.Text)))
                //    {
                //        FontNameListBox.Items.Add(setFont.Key);
                //    }

                //    // 項目数を判定する。
                //    if (!Equals(0, FontNameListBox.Items.Count))
                //    {
                //        // 項目が存在する場合
                //        FontNameListBox.SelectedIndex = 0;
                //    }
                //}

                // フォント名テキストボックスのテキストを保持する。
                ChangeBeforeFontNameText = FontNameTextBox.Text;
            }
        }

        /// <summary>
        /// フォント名テキストボックス・フォーカス取得処理
        /// </summary>
        /// <param name="sender">オブジェクト</param>
        /// <param name="e">パラメータ</param>
        private void FontNameTextBox_Enter(object sender, EventArgs e)
        {
            if (Equals(Color.DarkGray, FontNameTextBox.ForeColor))
            {
                FontNameTextBox.Text = string.Empty;
                FontNameTextBox.ForeColor = SystemColors.WindowText;
            }
        }

        /// <summary>
        /// フォント名テキストボックス・フォーカス喪失処理
        /// </summary>
        /// <param name="sender">オブジェクト</param>
        /// <param name="e">パラメータ</param>
        private void FontNameTextBox_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(FontNameTextBox.Text))
            {
                FontNameTextBox.ForeColor = Color.DarkGray;
                FontNameTextBox.Text = Const.FontNamePlaceholderText;
            }
        }

        /// <summary>
        /// スタイルリストボックス・項目描画処理
        /// </summary>
        /// <param name="sender">オブジェクト</param>
        /// <param name="e">パラメータ</param>
        private void StyleListBox_DrawItem(object sender, DrawItemEventArgs e)
        {
            // 項目が選択されている場合、強調表示する。
            e.DrawBackground();

            // 項目位置を判定する。
            if (!Equals(-1, e.Index))
            {
                // 項目が存在する場合

                // 文字色を取得・保持する。
                using (Brush brush = new SolidBrush(e.ForeColor))
                {
                    // 項目に設定している文字列を取得・保持する。
                    string itemText = ((ListBox)sender).Items[e.Index].ToString();

                    // フォントを設定する。
                    Font font;

                    // 項目名を判定する。
                    switch (itemText)
                    {
                        case Const.FontStyleTextBold:
                            font = new Font(Const.DefaultFontName, 12, FontStyle.Bold);
                            break;

                        case Const.FontStyleTextItalic:
                            font = new Font(Const.DefaultFontName, 12, FontStyle.Italic);
                            break;

                        case Const.FontStyleTextBoldAndItalic:
                            font = new Font(Const.DefaultFontName, 12, FontStyle.Bold | FontStyle.Italic);
                            break;

                        default:
                            font = new Font(Const.DefaultFontName, 12);
                            break;
                    }

                    // 項目を描画する。
                    e.Graphics.DrawString(itemText, font, brush, e.Bounds);
                }
            }
        }

        /// <summary>
        /// スタイルリストボックス・選択項目位置変更後処理
        /// </summary>
        /// <param name="sender">オブジェクト</param>
        /// <param name="e">パラメータ</param>
        private void StyleListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetSampleViewLabelFont();
        }

        /// <summary>
        /// サイズニューメリックアップダウン・フォーカス喪失処理
        /// </summary>
        /// <param name="sender">オブジェクト</param>
        /// <param name="e">パラメータ</param>
        private void SizeNumericUpDown_Leave(object sender, EventArgs e)
        {
            TextBox sizeTextBox = SizeNumericUpDown.Controls[1] as TextBox;
            if (string.IsNullOrWhiteSpace(sizeTextBox.Text))
            {
                // ブランクの場合、【1】を設定する。
                sizeTextBox.Text = "1";
                sizeTextBox.SelectionStart = 1;
            }
        }

        /// <summary>
        /// サイズニューメリックアップダウン・値変更後処理
        /// </summary>
        /// <param name="sender">オブジェクト</param>
        /// <param name="e">パラメータ</param>
        private void SizeNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            SetSampleViewLabelFont();
        }

        /// <summary>
        /// 日本語ラジオボタン・チェック変更後処理
        /// </summary>
        /// <param name="sender">オブジェクト</param>
        /// <param name="e">パラメータ</param>
        private void JapaneseRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            CharSetRadioButtonCheckedChanged();
        }

        /// <summary>
        /// 欧文ラジオボタン・チェック変更後処理
        /// </summary>
        /// <param name="sender">オブジェクト</param>
        /// <param name="e">パラメータ</param>
        private void EuropeanLanguageRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            CharSetRadioButtonCheckedChanged();
        }

        /// <summary>
        /// OKボタン押下処理
        /// </summary>
        /// <param name="sender">オブジェクト</param>
        /// <param name="e">パラメータ</param>
        private void OkButton_Click(object sender, EventArgs e)
        {
            //bool boldFlg = false, italicFlg = false;
            //if (Equals(StyleListBox.SelectedIndex, 3))
            //{
            //    boldFlg = true;
            //    italicFlg = true;
            //}
            //else if (Equals(StyleListBox.SelectedIndex, 2))
            //{
            //    italicFlg = true;
            //}
            //else if (Equals(StyleListBox.SelectedIndex, 1))
            //{
            //    boldFlg = true;
            //}

            //if (boldFlg && italicFlg)
            //{
            //    SetFont = new Font(
            //        FontNameListBox.Text,
            //        float.Parse(SizeNumericUpDown.Value.ToString()),
            //        FontStyle.Bold | FontStyle.Italic);
            //}
            //else if (!boldFlg && italicFlg)
            //{
            //    SetFont = new Font(
            //        FontNameListBox.Text,
            //        float.Parse(SizeNumericUpDown.Value.ToString()),
            //        FontStyle.Italic);
            //}
            //else if (boldFlg && !italicFlg)
            //{
            //    SetFont = new Font(
            //        FontNameListBox.Text,
            //        float.Parse(SizeNumericUpDown.Value.ToString()),
            //        FontStyle.Bold);
            //}
            //else
            //{
            //    SetFont = new Font(
            //        FontNameListBox.Text,
            //        float.Parse(SizeNumericUpDown.Value.ToString()));
            //}

            DialogResult = DialogResult.OK;
            Close();
        }

        /// <summary>
        /// キャンセルボタン押下処理
        /// （【CancelButton】だと、警告が表示されるので、【CloseButton】にしている。）
        /// </summary>
        /// <param name="sender">オブジェクト</param>
        /// <param name="e">パラメータ</param>
        private void CloseButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        /// <summary>
        /// フォント名コンテキストメニュー・表示処理
        /// </summary>
        /// <param name="sender">オブジェクト</param>
        /// <param name="e">パラメータ</param>
        private void FontNameContextMenuStrip_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {
            UndoToolStripMenuItem.Enabled = FontNameTextBox.CanUndo;
        }

        /// <summary>
        /// フォント名コンテキストメニュー・元に戻す項目押下処理
        /// </summary>
        /// <param name="sender">オブジェクト</param>
        /// <param name="e">パラメータ</param>
        private void UndoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontNameTextBox.Undo();
        }

        /// <summary>
        /// フォント名コンテキストメニュー・切り取り項目押下処理
        /// </summary>
        /// <param name="sender">オブジェクト</param>
        /// <param name="e">パラメータ</param>
        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontNameTextBox.Cut();
        }

        /// <summary>
        /// フォント名コンテキストメニュー・コピー項目押下処理
        /// </summary>
        /// <param name="sender">オブジェクト</param>
        /// <param name="e">パラメータ</param>
        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontNameTextBox.Copy();
        }

        /// <summary>
        /// フォント名コンテキストメニュー・貼り付け項目押下処理
        /// </summary>
        /// <param name="sender">オブジェクト</param>
        /// <param name="e">パラメータ</param>
        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontNameTextBox.Paste();
        }

        /// <summary>
        /// フォント名コンテキストメニュー・削除項目押下処理
        /// </summary>
        /// <param name="sender">オブジェクト</param>
        /// <param name="e">パラメータ</param>
        private void DelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int selectionStart = FontNameTextBox.SelectionStart;

            // 選択範囲を判定する。
            if (Equals(FontNameTextBox.SelectionLength, 0))
            {
                // 存在しない場合

                // 選択開始位置と入力された桁数を判定する。
                if (selectionStart < FontNameTextBox.Text.Length)
                {
                    // 桁数の方が多い場合
                    FontNameTextBox.Text = FontNameTextBox.Text.Remove(selectionStart, 1);
                }
            }
            else
            {
                // 存在する場合
                FontNameTextBox.SelectedText = string.Empty;
            }

            FontNameTextBox.SelectionStart = selectionStart;
        }

        /// <summary>
        /// フォント名コンテキストメニュー・全選択項目押下処理
        /// </summary>
        /// <param name="sender">オブジェクト</param>
        /// <param name="e">パラメータ</param>
        private void AllSelectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontNameTextBox.SelectAll();
        }

        #endregion

        #region ヘルパーメソッド

        /// <summary>
        /// 文字セットラジオボタン・チェック変更後処理
        /// </summary>
        private void CharSetRadioButtonCheckedChanged()
        {
            //if (JapaneseRadioButton.Checked)
            //{
            //    SampleViewLabel.Text = Const.SampleTextJapanese;
            //}
            //else
            //{
            //    SampleViewLabel.Text = Const.SampleTextEuropeanLanguage;
            //}
        }

        /// <summary>
        /// サンプル表示ラベル・フォント設定処理
        /// </summary>
        private void SetSampleViewLabelFont()
        {
            //bool boldFlg = false, italicFlg = false;
            //if (Equals(StyleListBox.SelectedIndex, 3))
            //{
            //    boldFlg = true;
            //    italicFlg = true;
            //}
            //else if (Equals(StyleListBox.SelectedIndex, 2))
            //{
            //    italicFlg = true;
            //}
            //else if (Equals(StyleListBox.SelectedIndex, 1))
            //{
            //    boldFlg = true;
            //}

            //Font font;
            //if (boldFlg && italicFlg)
            //{
            //    font = new Font(
            //        FontNameListBox.Text,
            //        float.Parse(SizeNumericUpDown.Value.ToString()),
            //        FontStyle.Bold | FontStyle.Italic);
            //}
            //else if (!boldFlg && italicFlg)
            //{
            //    font = new Font(
            //        FontNameListBox.Text,
            //        float.Parse(SizeNumericUpDown.Value.ToString()),
            //        FontStyle.Italic);
            //}
            //else if (boldFlg && !italicFlg)
            //{
            //    font = new Font(
            //        FontNameListBox.Text,
            //        float.Parse(SizeNumericUpDown.Value.ToString()),
            //        FontStyle.Bold);
            //}
            //else
            //{
            //    font = new Font(
            //        FontNameListBox.Text,
            //        float.Parse(SizeNumericUpDown.Value.ToString()));
            //}

            //SampleViewLabel.Font = font;
        }

        #endregion
    }

    /// <summary>
    /// 定数
    /// </summary>
    public class Const
    {
        /// <summary>
        /// デフォルトフォント名
        /// </summary>
        public const string DefaultFontName = "Yu Gothic UI";

        /// <summary>
        /// フォント名プレースホルダーテキスト
        /// </summary>
        public const string FontNamePlaceholderText = "フォント名を絞り込む";

        /// <summary>
        /// フォントスタイルテキスト：標準
        /// </summary>
        public const string FontStyleTextRegular = "標準";

        /// <summary>
        /// フォントスタイルテキスト：太字
        /// </summary>
        public const string FontStyleTextBold = "太字";

        /// <summary>
        /// フォントスタイルテキスト：斜体
        /// </summary>
        public const string FontStyleTextItalic = "斜体";

        /// <summary>
        /// フォントスタイルテキスト：太字・斜体
        /// </summary>
        public const string FontStyleTextBoldAndItalic = "太字・斜体";

        /// <summary>
        /// サンプルテキスト：日本語
        /// </summary>
        public const string SampleTextJapanese = "Aaあぁアァ亜宇";

        /// <summary>
        /// サンプルテキスト：欧文
        /// </summary>
        public const string SampleTextEuropeanLanguage = "AaBbYyZz";

        /// <summary>
        /// 文字セット：ANSI_CHARSET（欧文）
        /// </summary>
        public const int CharSetTypAnsi = 0;

        /// <summary>
        /// 文字セット：SHIFTJIS_CHARSET（日本語）
        /// </summary>
        public const int CharSetTypShiftJis = 1;

        /// <summary>
        /// 文字セット：ANSI_CHARSET・SHIFTJIS_CHARSET（混合）
        /// </summary>
        public const int CharSetTypMix = 2;

        /// <summary>
        /// 使用フォント連想配列
        /// （選定基準：文字セット：【ANSI_CHARSET】・【SHIFTJIS_CHARSET】のどちらを保持し、
        /// かつ、スタイルに【標準】・【斜体】・【太字】・【斜体 太字】を保持しているもの）
        /// </summary>
        public static readonly Dictionary<string, int> UseFontDict = new Dictionary<string, int>
        {
            { "Arial", CharSetTypAnsi },
            { "BIZ UDPゴシック", CharSetTypMix },
            { "BIZ UDゴシック", CharSetTypMix },
            { "Calibri", CharSetTypAnsi },
            { "Cambria", CharSetTypAnsi },
            { "Candara", CharSetTypAnsi },
            { "Cascadia Code", CharSetTypAnsi },
            { "Comic Sans MS", CharSetTypAnsi },
            { "Consolas", CharSetTypAnsi },
            { "Constantia", CharSetTypAnsi },
            { "Corbel", CharSetTypAnsi },
            { "Courier New", CharSetTypAnsi },
            { "Fira Code", CharSetTypAnsi },
            { "Georgia", CharSetTypAnsi },
            { "Hack", CharSetTypAnsi },
            { "Ink Free", CharSetTypAnsi },
            { "JetBrains Mono", CharSetTypAnsi },
            { "MS UI Gothic", CharSetTypMix },
            { "Meiryo UI", CharSetTypMix },
            { "Palatino Linotype", CharSetTypAnsi },
            { "Roboto", CharSetTypAnsi },
            { "Segoe Print", CharSetTypAnsi },
            { "Segoe Script", CharSetTypAnsi },
            { "Segoe UI", CharSetTypAnsi },
            { "Source Code Pro", CharSetTypAnsi },
            { "UD デジタル 教科書体 N-R", CharSetTypShiftJis },
            { "UD デジタル 教科書体 NK-R", CharSetTypShiftJis },
            { "UD デジタル 教科書体 NP-R", CharSetTypShiftJis },
            { "Verdana", CharSetTypAnsi },
            { "Yu Gothic UI", CharSetTypMix },
            { "メイリオ", CharSetTypMix },
            { "游ゴシック", CharSetTypMix },
            { "ＭＳ ゴシック", CharSetTypMix },
            { "ＭＳ 明朝", CharSetTypMix },
            { "ＭＳ Ｐゴシック", CharSetTypMix },
            { "ＭＳ Ｐ明朝", CharSetTypMix }
        };
    }

    /// <summary>
    /// フォント情報
    /// </summary>
    public class FontInfo
    {
        /// <summary>
        /// フォントファミリー
        /// </summary>
        public string FontFamily { get; set; }

        /// <summary>
        /// 標準フラグ
        /// （true：標準有り・false：標準無し） 
        /// </summary>
        public bool RegularFlg { get; set; }

        /// <summary>
        /// 太字フラグ
        /// （true：太字有り・false：太字無し） 
        /// </summary>
        public bool BoldFlg { get; set; }

        /// <summary>
        /// 斜体フラグ
        /// （true：斜体有り・false：斜体無し） 
        /// </summary>
        public bool ItalicFlg { get; set; }

        /// <summary>
        /// 文字セット
        /// 0：ANSI_CHARSET（欧文）
        /// 1：SHIFTJIS_CHARSET（日本語）
        /// 2：ANSI_CHARSET・SHIFTJIS_CHARSET（混合）
        /// </summary>
        public int CharSetTyp { get; set; }

        /// <summary>
        /// 幅
        /// </summary>
        public int Width { get; set; }

        /// <summary>
        /// 高さ
        /// </summary>
        public int Height { get; set; }
    }
}
