using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SKYNST_CharaRecog
{
    public partial class Form1 : Form
    {
        string chara_recog_result;











        public Form1()
        {//28行目
            InitializeComponent();

            this.textBox_result.ReadOnly = true;

            button_output.Enabled = false;
            
















            

















        }//68行目

        private void button_webcam_Click(object sender, EventArgs e)
        {//71行目



















































        }//123行目

        private void button_brows_Click(object sender, EventArgs e)
        {//126行目
            DialogResult dr = openFileDialog1.ShowDialog();
            if (dr == System.Windows.Forms.DialogResult.OK)
            {
                textBox_pass.Text = openFileDialog1.FileName;
            }











































                        


        }//178行目

        private void button_start_Click(object sender, EventArgs e)
        {//181行目
            string text = textBox_pass.Text;
            Bitmap image1 = null;
            try
            {
                // 画像をビットマップ型で読み込み
                image1 = new Bitmap(text);

                pictureBox.Image = image1;
            }
            catch (System.ArgumentException)
            {
                MessageBox.Show("入力が無効です。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            textBox_result.Text = chara_recog_result = chara_recog(image1);

            button_output.Enabled = true;

































        }//233行目
        
        private void button_output_Click(object sender, EventArgs e)
        {//236行目
            //ここから出力ダイアログボックスの設定//
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.FileName = "新しいファイル.txt";
            sfd.InitialDirectory = @"C:\";
            sfd.Filter = "テキストファイル(*.txt;)|*.txt;*|すべてのファイル(*.*)|*.*";
            sfd.FilterIndex = 2;
            sfd.Title = "保存先のファイルを選択してください";
            sfd.RestoreDirectory = true;
            sfd.OverwritePrompt = true;
            sfd.CheckPathExists = true;
            //ここまで出力ダイアログボックスの設定//

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                Encoding sjisEnc = Encoding.GetEncoding("Shift_JIS");
                System.IO.StreamWriter writer = new System.IO.StreamWriter(@sfd.FileName, false, sjisEnc);
                writer.WriteLine(chara_recog_result);//ここにtesseractから送られてきた文字をぶち込む//
                writer.Close();
            }





            


























        }//288行目

        //================ 以下、自作のクラス ================
        

        //●文字認識を行うクラス
        private string chara_recog(Bitmap image)
        {
            //文字認識結果
            string str;

            // OCRを行うオブジェクトの生成
            //  言語データの場所と言語名を引数で指定する
            var tesseract = new Tesseract.TesseractEngine(
                @"..\..\..\tessdata", // 言語ファイルを「C:\tessdata」に置いた場合
                "jpg");         // 英語なら"eng" 「○○.traineddata」の○○の部分

            // OCRの実行と表示
            var page = tesseract.Process(image);
            str = page.GetText();

            //文字認識結果を返す
            return str;












































        }//347行目
    }
}
