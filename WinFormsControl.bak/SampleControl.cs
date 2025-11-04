
using System.ComponentModel;

namespace WinFormsControl
{
    public partial class SampleControl : UserControl
    {
        public SampleControl()
        {
            InitializeComponent();
        }

        //----------------------------------------------------------------
        //    InputText プロパティ
        //
        [Browsable(true)
          , Description("入力テキストボックスに入力された文字列")
          , Category("表示")
        ]
        public String InputText
        {
            get { return txtInput.Text; }
            set { txtInput.Text = value; }
        }

        //----------------------------------------------------------------
        //    OutputText プロパティ
        //
        [Browsable(true)
          , Description("出力テキストボックスに表示する文字列")
          , Category("表示")
        ]
        public String OutputText
        {
            get { return txtOutput.Text; }
            set { txtOutput.Text = value; }
        }

        //----------------------------------------------------------------
        /**   RunButtonClick イベント
        **
        **/
        [Browsable(true)
          , Description("実行ボタンがクリックされた時に発生します")
          , Category("アクション")
        ]
        public event EventHandler<EventArgs>? RunButtonClick;

        //----------------------------------------------------------------
        /**   イベントハンドラを呼び出すメソッド
        **
        **/
        protected virtual void OnRunButtonClick(EventArgs e)
        {
            var eventHandler = RunButtonClick;
            if (eventHandler != null) {
                eventHandler(this, e);
            }
        }

        //----------------------------------------------------------------
        /**   イベントハンドラ
        **
        **    「クリア」ボタンのクリックイベント
        **/
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtInput.Text = "";
            txtOutput.Text = "";
        }

        //----------------------------------------------------------------
        /**   イベントハンドラ
        **
        **    「実行」ボタンのクリックイベント
        **/
        private void btnRun_Click(object sender, EventArgs e)
        {
            OnRunButtonClick(e);
        }

    }
}
