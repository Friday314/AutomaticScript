namespace AutomaticScript
{
    partial class AutomaticScript
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

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AutomaticScript));
            this.状态栏 = new System.Windows.Forms.GroupBox();
            this.日志栏 = new System.Windows.Forms.GroupBox();
            this.textLog = new System.Windows.Forms.TextBox();
            this.日志栏.SuspendLayout();
            this.SuspendLayout();
            // 
            // 状态栏
            // 
            this.状态栏.Location = new System.Drawing.Point(232, 12);
            this.状态栏.Name = "状态栏";
            this.状态栏.Size = new System.Drawing.Size(179, 374);
            this.状态栏.TabIndex = 0;
            this.状态栏.TabStop = false;
            this.状态栏.Text = "状态栏";
            // 
            // 日志栏
            // 
            this.日志栏.Controls.Add(this.textLog);
            this.日志栏.Location = new System.Drawing.Point(417, 12);
            this.日志栏.Name = "日志栏";
            this.日志栏.Size = new System.Drawing.Size(246, 374);
            this.日志栏.TabIndex = 1;
            this.日志栏.TabStop = false;
            this.日志栏.Text = "日志栏";
            // 
            // textLog
            // 
            this.textLog.Location = new System.Drawing.Point(6, 20);
            this.textLog.Multiline = true;
            this.textLog.Name = "textLog";
            this.textLog.Size = new System.Drawing.Size(234, 348);
            this.textLog.TabIndex = 0;
            // 
            // AutomaticScript
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(672, 391);
            this.Controls.Add(this.日志栏);
            this.Controls.Add(this.状态栏);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "AutomaticScript";
            this.Text = "AutomaticScript";
            this.Load += new System.EventHandler(this.AutomaticScript_Load);
            this.日志栏.ResumeLayout(false);
            this.日志栏.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox 状态栏;
        private System.Windows.Forms.GroupBox 日志栏;
        private System.Windows.Forms.TextBox textLog;
    }
}

