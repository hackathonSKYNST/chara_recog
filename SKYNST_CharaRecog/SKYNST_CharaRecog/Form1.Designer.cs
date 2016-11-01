namespace SKYNST_CharaRecog
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
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
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.button_start = new System.Windows.Forms.Button();
            this.button_output = new System.Windows.Forms.Button();
            this.button_webcam = new System.Windows.Forms.Button();
            this.button_brows = new System.Windows.Forms.Button();
            this.textBox_pass = new System.Windows.Forms.TextBox();
            this.textBox_result = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(12, 131);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(360, 268);
            this.pictureBox.TabIndex = 9;
            this.pictureBox.TabStop = false;
            // 
            // button_start
            // 
            this.button_start.Location = new System.Drawing.Point(297, 86);
            this.button_start.Name = "button_start";
            this.button_start.Size = new System.Drawing.Size(75, 23);
            this.button_start.TabIndex = 5;
            this.button_start.Text = "開始";
            this.button_start.UseVisualStyleBackColor = true;
            this.button_start.Click += new System.EventHandler(this.button_start_Click);
            // 
            // button_output
            // 
            this.button_output.Location = new System.Drawing.Point(297, 477);
            this.button_output.Name = "button_output";
            this.button_output.Size = new System.Drawing.Size(75, 23);
            this.button_output.TabIndex = 6;
            this.button_output.Text = "出力";
            this.button_output.UseVisualStyleBackColor = true;
            this.button_output.Click += new System.EventHandler(this.button_output_Click);
            // 
            // button_webcam
            // 
            this.button_webcam.Location = new System.Drawing.Point(217, 12);
            this.button_webcam.Name = "button_webcam";
            this.button_webcam.Size = new System.Drawing.Size(155, 23);
            this.button_webcam.TabIndex = 7;
            this.button_webcam.Text = "Webカメラから読み込む";
            this.button_webcam.UseVisualStyleBackColor = true;
            this.button_webcam.Click += new System.EventHandler(this.button_webcam_Click);
            // 
            // button_brows
            // 
            this.button_brows.Location = new System.Drawing.Point(297, 57);
            this.button_brows.Name = "button_brows";
            this.button_brows.Size = new System.Drawing.Size(75, 23);
            this.button_brows.TabIndex = 8;
            this.button_brows.Text = "参照";
            this.button_brows.UseVisualStyleBackColor = true;
            this.button_brows.Click += new System.EventHandler(this.button_brows_Click);
            // 
            // textBox_pass
            // 
            this.textBox_pass.Location = new System.Drawing.Point(12, 59);
            this.textBox_pass.Name = "textBox_pass";
            this.textBox_pass.Size = new System.Drawing.Size(266, 19);
            this.textBox_pass.TabIndex = 3;
            this.textBox_pass.Text = "C:\\.....";
            // 
            // textBox_result
            // 
            this.textBox_result.Location = new System.Drawing.Point(12, 425);
            this.textBox_result.Multiline = true;
            this.textBox_result.Name = "textBox_result";
            this.textBox_result.Size = new System.Drawing.Size(266, 75);
            this.textBox_result.TabIndex = 4;
            this.textBox_result.Text = "文字認識結果文字列";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 512);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.button_start);
            this.Controls.Add(this.button_output);
            this.Controls.Add(this.button_webcam);
            this.Controls.Add(this.button_brows);
            this.Controls.Add(this.textBox_pass);
            this.Controls.Add(this.textBox_result);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Button button_start;
        private System.Windows.Forms.Button button_output;
        private System.Windows.Forms.Button button_webcam;
        private System.Windows.Forms.Button button_brows;
        private System.Windows.Forms.TextBox textBox_pass;
        private System.Windows.Forms.TextBox textBox_result;

    }
}

