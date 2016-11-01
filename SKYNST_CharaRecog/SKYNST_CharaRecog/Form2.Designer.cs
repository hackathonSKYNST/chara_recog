namespace SKYNST_CharaRecog
{
    partial class Form2
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
            this.webcamArea = new System.Windows.Forms.PictureBox();
            this.button_cansel = new System.Windows.Forms.Button();
            this.button_chapture = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.webcamArea)).BeginInit();
            this.SuspendLayout();
            // 
            // webcamArea
            // 
            this.webcamArea.Location = new System.Drawing.Point(13, 16);
            this.webcamArea.Name = "webcamArea";
            this.webcamArea.Size = new System.Drawing.Size(458, 268);
            this.webcamArea.TabIndex = 5;
            this.webcamArea.TabStop = false;
            // 
            // button_cansel
            // 
            this.button_cansel.Location = new System.Drawing.Point(396, 304);
            this.button_cansel.Name = "button_cansel";
            this.button_cansel.Size = new System.Drawing.Size(75, 23);
            this.button_cansel.TabIndex = 3;
            this.button_cansel.Text = "キャンセル";
            this.button_cansel.UseVisualStyleBackColor = true;
            this.button_cansel.Click += new System.EventHandler(this.button_cansel_Click);
            // 
            // button_chapture
            // 
            this.button_chapture.Location = new System.Drawing.Point(305, 304);
            this.button_chapture.Name = "button_chapture";
            this.button_chapture.Size = new System.Drawing.Size(75, 23);
            this.button_chapture.TabIndex = 4;
            this.button_chapture.Text = "シャッター";
            this.button_chapture.UseVisualStyleBackColor = true;
            this.button_chapture.Click += new System.EventHandler(this.button_chapture_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 342);
            this.Controls.Add(this.webcamArea);
            this.Controls.Add(this.button_cansel);
            this.Controls.Add(this.button_chapture);
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.webcamArea)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox webcamArea;
        private System.Windows.Forms.Button button_cansel;
        private System.Windows.Forms.Button button_chapture;
    }
}