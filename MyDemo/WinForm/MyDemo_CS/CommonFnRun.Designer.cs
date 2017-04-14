namespace MyDemo_CS
{
    partial class CommonFnRun
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
            this.EnumFn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // EnumFn
            // 
            this.EnumFn.Location = new System.Drawing.Point(33, 22);
            this.EnumFn.Name = "EnumFn";
            this.EnumFn.Size = new System.Drawing.Size(176, 23);
            this.EnumFn.TabIndex = 0;
            this.EnumFn.Text = "枚举获取方法类";
            this.EnumFn.UseVisualStyleBackColor = true;
            this.EnumFn.Click += new System.EventHandler(this.EnumFn_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(259, 22);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "特性";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // CommonFnRun
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1138, 261);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.EnumFn);
            this.Name = "CommonFnRun";
            this.Text = "CommonFnRun";
            this.Load += new System.EventHandler(this.CommonFnRun_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button EnumFn;
        private System.Windows.Forms.Button button1;
    }
}