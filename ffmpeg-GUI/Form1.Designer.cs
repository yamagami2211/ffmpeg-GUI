﻿namespace ffmpeg_GUI
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
            this.ffmpegPath = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.ocVideoPath = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.logArea = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.runButton = new System.Windows.Forms.Button();
            this.saveVideoPath = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ffmpegPath
            // 
            this.ffmpegPath.Location = new System.Drawing.Point(12, 25);
            this.ffmpegPath.Name = "ffmpegPath";
            this.ffmpegPath.ReadOnly = true;
            this.ffmpegPath.Size = new System.Drawing.Size(149, 19);
            this.ffmpegPath.TabIndex = 0;
            this.ffmpegPath.Text = "ffmpeg";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "ffmpeg パス";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(167, 23);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "ffmpeg.exe";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(167, 71);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(101, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Open Video";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // ocVideoPath
            // 
            this.ocVideoPath.Location = new System.Drawing.Point(12, 69);
            this.ocVideoPath.Name = "ocVideoPath";
            this.ocVideoPath.ReadOnly = true;
            this.ocVideoPath.Size = new System.Drawing.Size(149, 19);
            this.ocVideoPath.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "元動画";
            // 
            // logArea
            // 
            this.logArea.Location = new System.Drawing.Point(12, 209);
            this.logArea.Multiline = true;
            this.logArea.Name = "logArea";
            this.logArea.Size = new System.Drawing.Size(776, 229);
            this.logArea.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 194);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 12);
            this.label3.TabIndex = 7;
            this.label3.Text = "ログ";
            // 
            // runButton
            // 
            this.runButton.Location = new System.Drawing.Point(53, 183);
            this.runButton.Name = "runButton";
            this.runButton.Size = new System.Drawing.Size(75, 23);
            this.runButton.TabIndex = 8;
            this.runButton.Text = "実行";
            this.runButton.UseVisualStyleBackColor = true;
            this.runButton.Click += new System.EventHandler(this.runButton_Click);
            // 
            // saveVideoPath
            // 
            this.saveVideoPath.Location = new System.Drawing.Point(284, 73);
            this.saveVideoPath.Name = "saveVideoPath";
            this.saveVideoPath.Size = new System.Drawing.Size(147, 19);
            this.saveVideoPath.TabIndex = 9;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(437, 71);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 10;
            this.button3.Text = "Save Folder";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(282, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 11;
            this.label4.Text = "保存先";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.saveVideoPath);
            this.Controls.Add(this.runButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.logArea);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ocVideoPath);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ffmpegPath);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ffmpegPath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox ocVideoPath;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox logArea;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button runButton;
        private System.Windows.Forms.TextBox saveVideoPath;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label4;
    }
}

