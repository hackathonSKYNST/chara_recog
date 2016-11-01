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
        public Form1()
        {//16行目
            InitializeComponent();




















            





























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


            string text1 = textBox_pass.Text;

            try
            {
                // 画像をビットマップ型で読み込み
                Bitmap image1 = new Bitmap(text1);

                pictureBox.Image = image1;
            }
            catch (System.ArgumentException)
            {
                MessageBox.Show("入力が無効です。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }




































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
                writer.WriteLine("テスト書き込みです。");//ここにtesseractから送られてきた文字をぶち込む//
                writer.Close();
            }





            


























        }//288行目

        //================ 以下、自作のクラス ================
        

        //●文字認識を行うクラス
        private string chara_recog()
        {
            string str = "";

            return str;
















































        }//347行目
    }
}
