namespace MyDemo_CS
{
    partial class 自定义进度条
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this._Progress = new System.Windows.Forms.ProgressBar();
            this.lbProcessMsg = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // _Progress
            // 
            this._Progress.Location = new System.Drawing.Point(129, 0);
            this._Progress.Name = "_Progress";
            this._Progress.Size = new System.Drawing.Size(664, 30);
            this._Progress.TabIndex = 1;
            // 
            // lbProcessMsg
            // 
            this.lbProcessMsg.AutoSize = true;
            this.lbProcessMsg.Location = new System.Drawing.Point(4, 9);
            this.lbProcessMsg.Name = "lbProcessMsg";
            this.lbProcessMsg.Size = new System.Drawing.Size(41, 12);
            this.lbProcessMsg.TabIndex = 2;
            this.lbProcessMsg.Text = "label1";
            // 
            // 进度条111
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbProcessMsg);
            this.Controls.Add(this._Progress);
            this.Name = "进度条111";
            this.Size = new System.Drawing.Size(794, 59);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar _Progress;
        private System.Windows.Forms.Label lbProcessMsg;
    }
}
