namespace _2048_on_PC
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
            this.Frame = new System.Windows.Forms.TableLayoutPanel();
            this.tile33 = new System.Windows.Forms.Label();
            this.tile32 = new System.Windows.Forms.Label();
            this.tile23 = new System.Windows.Forms.Label();
            this.tile14 = new System.Windows.Forms.Label();
            this.tile13 = new System.Windows.Forms.Label();
            this.tile12 = new System.Windows.Forms.Label();
            this.tile24 = new System.Windows.Forms.Label();
            this.tile34 = new System.Windows.Forms.Label();
            this.tile44 = new System.Windows.Forms.Label();
            this.tile41 = new System.Windows.Forms.Label();
            this.tile42 = new System.Windows.Forms.Label();
            this.tile43 = new System.Windows.Forms.Label();
            this.tile21 = new System.Windows.Forms.Label();
            this.tile22 = new System.Windows.Forms.Label();
            this.tile31 = new System.Windows.Forms.Label();
            this.tile11 = new System.Windows.Forms.Label();
            this.toplabel = new System.Windows.Forms.Label();
            this.bottomlabel = new System.Windows.Forms.Label();
            this.scorelabel = new System.Windows.Forms.Label();
            this.undolabel = new System.Windows.Forms.Label();
            this.Frame.SuspendLayout();
            this.SuspendLayout();
            // 
            // Frame
            // 
            this.Frame.BackColor = System.Drawing.Color.Gray;
            this.Frame.ColumnCount = 4;
            this.Frame.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.Frame.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.Frame.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.Frame.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.Frame.Controls.Add(this.tile33, 2, 2);
            this.Frame.Controls.Add(this.tile32, 1, 2);
            this.Frame.Controls.Add(this.tile23, 2, 1);
            this.Frame.Controls.Add(this.tile14, 3, 0);
            this.Frame.Controls.Add(this.tile13, 2, 0);
            this.Frame.Controls.Add(this.tile12, 1, 0);
            this.Frame.Controls.Add(this.tile24, 3, 1);
            this.Frame.Controls.Add(this.tile34, 3, 2);
            this.Frame.Controls.Add(this.tile44, 3, 3);
            this.Frame.Controls.Add(this.tile41, 0, 3);
            this.Frame.Controls.Add(this.tile42, 1, 3);
            this.Frame.Controls.Add(this.tile43, 2, 3);
            this.Frame.Controls.Add(this.tile21, 0, 1);
            this.Frame.Controls.Add(this.tile22, 1, 1);
            this.Frame.Controls.Add(this.tile31, 0, 2);
            this.Frame.Controls.Add(this.tile11, 0, 0);
            this.Frame.Location = new System.Drawing.Point(12, 75);
            this.Frame.Name = "Frame";
            this.Frame.RowCount = 4;
            this.Frame.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.Frame.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.Frame.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.Frame.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.Frame.Size = new System.Drawing.Size(360, 360);
            this.Frame.TabIndex = 0;
            // 
            // tile33
            // 
            this.tile33.BackColor = System.Drawing.Color.LightGray;
            this.tile33.Font = new System.Drawing.Font("メイリオ", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tile33.Location = new System.Drawing.Point(181, 181);
            this.tile33.Margin = new System.Windows.Forms.Padding(1);
            this.tile33.Name = "tile33";
            this.tile33.Size = new System.Drawing.Size(88, 88);
            this.tile33.TabIndex = 21;
            this.tile33.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tile32
            // 
            this.tile32.BackColor = System.Drawing.Color.LightGray;
            this.tile32.Font = new System.Drawing.Font("メイリオ", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tile32.Location = new System.Drawing.Point(91, 181);
            this.tile32.Margin = new System.Windows.Forms.Padding(1);
            this.tile32.Name = "tile32";
            this.tile32.Size = new System.Drawing.Size(88, 88);
            this.tile32.TabIndex = 20;
            this.tile32.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tile23
            // 
            this.tile23.BackColor = System.Drawing.Color.LightGray;
            this.tile23.Font = new System.Drawing.Font("メイリオ", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tile23.Location = new System.Drawing.Point(181, 91);
            this.tile23.Margin = new System.Windows.Forms.Padding(1);
            this.tile23.Name = "tile23";
            this.tile23.Size = new System.Drawing.Size(88, 88);
            this.tile23.TabIndex = 19;
            this.tile23.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tile14
            // 
            this.tile14.BackColor = System.Drawing.Color.LightGray;
            this.tile14.Font = new System.Drawing.Font("メイリオ", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tile14.Location = new System.Drawing.Point(271, 4);
            this.tile14.Margin = new System.Windows.Forms.Padding(1, 4, 4, 1);
            this.tile14.Name = "tile14";
            this.tile14.Size = new System.Drawing.Size(85, 85);
            this.tile14.TabIndex = 3;
            this.tile14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tile13
            // 
            this.tile13.BackColor = System.Drawing.Color.LightGray;
            this.tile13.Font = new System.Drawing.Font("メイリオ", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tile13.Location = new System.Drawing.Point(181, 4);
            this.tile13.Margin = new System.Windows.Forms.Padding(1, 4, 1, 1);
            this.tile13.Name = "tile13";
            this.tile13.Size = new System.Drawing.Size(88, 85);
            this.tile13.TabIndex = 2;
            this.tile13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tile12
            // 
            this.tile12.BackColor = System.Drawing.Color.LightGray;
            this.tile12.Font = new System.Drawing.Font("メイリオ", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tile12.Location = new System.Drawing.Point(91, 4);
            this.tile12.Margin = new System.Windows.Forms.Padding(1, 4, 1, 1);
            this.tile12.Name = "tile12";
            this.tile12.Size = new System.Drawing.Size(88, 85);
            this.tile12.TabIndex = 1;
            this.tile12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tile24
            // 
            this.tile24.BackColor = System.Drawing.Color.LightGray;
            this.tile24.Font = new System.Drawing.Font("メイリオ", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tile24.Location = new System.Drawing.Point(271, 91);
            this.tile24.Margin = new System.Windows.Forms.Padding(1, 1, 4, 1);
            this.tile24.Name = "tile24";
            this.tile24.Size = new System.Drawing.Size(85, 88);
            this.tile24.TabIndex = 11;
            this.tile24.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tile34
            // 
            this.tile34.BackColor = System.Drawing.Color.LightGray;
            this.tile34.Font = new System.Drawing.Font("メイリオ", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tile34.Location = new System.Drawing.Point(271, 181);
            this.tile34.Margin = new System.Windows.Forms.Padding(1, 1, 4, 1);
            this.tile34.Name = "tile34";
            this.tile34.Size = new System.Drawing.Size(85, 88);
            this.tile34.TabIndex = 12;
            this.tile34.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tile44
            // 
            this.tile44.BackColor = System.Drawing.Color.LightGray;
            this.tile44.Font = new System.Drawing.Font("メイリオ", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tile44.Location = new System.Drawing.Point(271, 271);
            this.tile44.Margin = new System.Windows.Forms.Padding(1, 1, 4, 4);
            this.tile44.Name = "tile44";
            this.tile44.Size = new System.Drawing.Size(85, 85);
            this.tile44.TabIndex = 13;
            this.tile44.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tile41
            // 
            this.tile41.BackColor = System.Drawing.Color.LightGray;
            this.tile41.Font = new System.Drawing.Font("メイリオ", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tile41.Location = new System.Drawing.Point(4, 271);
            this.tile41.Margin = new System.Windows.Forms.Padding(4, 1, 1, 4);
            this.tile41.Name = "tile41";
            this.tile41.Size = new System.Drawing.Size(85, 85);
            this.tile41.TabIndex = 16;
            this.tile41.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tile42
            // 
            this.tile42.BackColor = System.Drawing.Color.LightGray;
            this.tile42.Font = new System.Drawing.Font("メイリオ", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tile42.Location = new System.Drawing.Point(91, 271);
            this.tile42.Margin = new System.Windows.Forms.Padding(1, 1, 1, 4);
            this.tile42.Name = "tile42";
            this.tile42.Size = new System.Drawing.Size(88, 85);
            this.tile42.TabIndex = 15;
            this.tile42.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tile43
            // 
            this.tile43.BackColor = System.Drawing.Color.LightGray;
            this.tile43.Font = new System.Drawing.Font("メイリオ", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tile43.Location = new System.Drawing.Point(181, 271);
            this.tile43.Margin = new System.Windows.Forms.Padding(1, 1, 1, 4);
            this.tile43.Name = "tile43";
            this.tile43.Size = new System.Drawing.Size(88, 85);
            this.tile43.TabIndex = 14;
            this.tile43.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tile21
            // 
            this.tile21.BackColor = System.Drawing.Color.LightGray;
            this.tile21.Font = new System.Drawing.Font("メイリオ", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tile21.Location = new System.Drawing.Point(4, 91);
            this.tile21.Margin = new System.Windows.Forms.Padding(4, 1, 1, 1);
            this.tile21.Name = "tile21";
            this.tile21.Size = new System.Drawing.Size(85, 88);
            this.tile21.TabIndex = 17;
            this.tile21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tile22
            // 
            this.tile22.BackColor = System.Drawing.Color.LightGray;
            this.tile22.Font = new System.Drawing.Font("メイリオ", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tile22.Location = new System.Drawing.Point(91, 91);
            this.tile22.Margin = new System.Windows.Forms.Padding(1);
            this.tile22.Name = "tile22";
            this.tile22.Size = new System.Drawing.Size(88, 88);
            this.tile22.TabIndex = 18;
            this.tile22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tile31
            // 
            this.tile31.BackColor = System.Drawing.Color.LightGray;
            this.tile31.Font = new System.Drawing.Font("メイリオ", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tile31.Location = new System.Drawing.Point(4, 181);
            this.tile31.Margin = new System.Windows.Forms.Padding(4, 1, 1, 1);
            this.tile31.Name = "tile31";
            this.tile31.Size = new System.Drawing.Size(85, 88);
            this.tile31.TabIndex = 4;
            this.tile31.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tile11
            // 
            this.tile11.BackColor = System.Drawing.Color.LightGray;
            this.tile11.Font = new System.Drawing.Font("メイリオ", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tile11.Location = new System.Drawing.Point(4, 4);
            this.tile11.Margin = new System.Windows.Forms.Padding(4, 4, 1, 1);
            this.tile11.Name = "tile11";
            this.tile11.Size = new System.Drawing.Size(85, 85);
            this.tile11.TabIndex = 0;
            this.tile11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // toplabel
            // 
            this.toplabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.toplabel.Font = new System.Drawing.Font("Meiryo UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.toplabel.ForeColor = System.Drawing.Color.Red;
            this.toplabel.Location = new System.Drawing.Point(12, 9);
            this.toplabel.Name = "toplabel";
            this.toplabel.Size = new System.Drawing.Size(360, 63);
            this.toplabel.TabIndex = 2;
            this.toplabel.Text = "2048 on PC";
            this.toplabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bottomlabel
            // 
            this.bottomlabel.Font = new System.Drawing.Font("Meiryo UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.bottomlabel.Location = new System.Drawing.Point(10, 438);
            this.bottomlabel.Name = "bottomlabel";
            this.bottomlabel.Size = new System.Drawing.Size(362, 63);
            this.bottomlabel.TabIndex = 3;
            this.bottomlabel.Text = "S→スタート\r\nU or BS→アンドゥON/OFF切り替え";
            this.bottomlabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // scorelabel
            // 
            this.scorelabel.AutoSize = true;
            this.scorelabel.Font = new System.Drawing.Font("Meiryo UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.scorelabel.Location = new System.Drawing.Point(7, 522);
            this.scorelabel.Name = "scorelabel";
            this.scorelabel.Size = new System.Drawing.Size(0, 26);
            this.scorelabel.TabIndex = 4;
            this.scorelabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // undolabel
            // 
            this.undolabel.AutoSize = true;
            this.undolabel.Font = new System.Drawing.Font("Meiryo UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.undolabel.Location = new System.Drawing.Point(283, 522);
            this.undolabel.Name = "undolabel";
            this.undolabel.Size = new System.Drawing.Size(92, 26);
            this.undolabel.TabIndex = 5;
            this.undolabel.Text = "UNDO×";
            this.undolabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 557);
            this.Controls.Add(this.undolabel);
            this.Controls.Add(this.scorelabel);
            this.Controls.Add(this.bottomlabel);
            this.Controls.Add(this.toplabel);
            this.Controls.Add(this.Frame);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainForm";
            this.Text = "2048 on PC";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormOnKeyDown);
            this.Frame.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel Frame;
        private System.Windows.Forms.Label tile33;
        private System.Windows.Forms.Label tile32;
        private System.Windows.Forms.Label tile23;
        private System.Windows.Forms.Label tile14;
        private System.Windows.Forms.Label tile13;
        private System.Windows.Forms.Label tile12;
        private System.Windows.Forms.Label tile11;
        private System.Windows.Forms.Label tile24;
        private System.Windows.Forms.Label tile34;
        private System.Windows.Forms.Label tile44;
        private System.Windows.Forms.Label tile41;
        private System.Windows.Forms.Label tile42;
        private System.Windows.Forms.Label tile43;
        private System.Windows.Forms.Label tile21;
        private System.Windows.Forms.Label tile22;
        private System.Windows.Forms.Label tile31;
        private System.Windows.Forms.Label toplabel;
        private System.Windows.Forms.Label bottomlabel;
        private System.Windows.Forms.Label scorelabel;
        private System.Windows.Forms.Label undolabel;
    }
}

