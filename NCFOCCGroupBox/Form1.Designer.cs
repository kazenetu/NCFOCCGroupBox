namespace NCFOCCGroupBox
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
    /// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
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
      this.ncfoccGroupBox1 = new UserControls.NCFOCCGroupBox();
      this.button12 = new System.Windows.Forms.Button();
      this.ncfoccGroupBox1.SuspendLayout();
      this.SuspendLayout();
      // 
      // ncfoccGroupBox1
      // 
      this.ncfoccGroupBox1.Controls.Add(this.button12);
      this.ncfoccGroupBox1.Font = new System.Drawing.Font("MS UI Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
      this.ncfoccGroupBox1.Location = new System.Drawing.Point(336, 103);
      this.ncfoccGroupBox1.Name = "ncfoccGroupBox1";
      this.ncfoccGroupBox1.Size = new System.Drawing.Size(269, 180);
      this.ncfoccGroupBox1.TabIndex = 0;
      this.ncfoccGroupBox1.TabStop = false;
      this.ncfoccGroupBox1.Text = "ncfoccGroupBox1";
      // 
      // button12
      // 
      this.button12.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
      this.button12.Location = new System.Drawing.Point(132, 127);
      this.button12.Name = "button12";
      this.button12.Size = new System.Drawing.Size(75, 23);
      this.button12.TabIndex = 0;
      this.button12.Text = "button1";
      this.button12.UseVisualStyleBackColor = true;
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(800, 450);
      this.Controls.Add(this.ncfoccGroupBox1);
      this.Name = "Form1";
      this.Text = "Form1";
      this.ncfoccGroupBox1.ResumeLayout(false);
      this.ResumeLayout(false);

    }

    #endregion

    private UserControls.NCFOCCGroupBox ncfoccGroupBox1;
    private System.Windows.Forms.Button button12;
  }
}

