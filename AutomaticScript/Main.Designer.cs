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
            this.日志输出 = new System.Windows.Forms.GroupBox();
            this.textLog = new System.Windows.Forms.TextBox();
            this.日志输出.SuspendLayout();
            this.SuspendLayout();
            // 
            // 日志输出
            // 
            this.日志输出.Controls.Add(this.textLog);
            this.日志输出.Location = new System.Drawing.Point(272, 13);
            this.日志输出.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.日志输出.Name = "日志输出";
            this.日志输出.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.日志输出.Size = new System.Drawing.Size(382, 326);
            this.日志输出.TabIndex = 0;
            this.日志输出.TabStop = false;
            this.日志输出.Text = "日志输出";
            // 
            // textLog
            // 
            this.textLog.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textLog.Location = new System.Drawing.Point(6, 24);
            this.textLog.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textLog.Multiline = true;
            this.textLog.Name = "textLog";
            this.textLog.Size = new System.Drawing.Size(370, 294);
            this.textLog.TabIndex = 0;
            this.textLog.Text = "开始程序：Shift + D\r\n停止程序：Shift + F";
            // 
            // AutomaticScript
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(666, 352);
            this.Controls.Add(this.日志输出);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AutomaticScript";
            this.Text = "AutomaticScript";
            this.Load += new System.EventHandler(this.AutomaticScript_Load);
            this.日志输出.ResumeLayout(false);
            this.日志输出.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox 日志输出;
        private System.Windows.Forms.TextBox textLog;
    }
}

