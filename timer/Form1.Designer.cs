
namespace timer
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器
        /// 修改這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.lockToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.紅色ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.黃色ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.綠色ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.藍色ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.黑色ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.白色ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.離開ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lockToolStripMenuItem,
            this.toolStripSeparator1,
            this.紅色ToolStripMenuItem,
            this.黃色ToolStripMenuItem,
            this.綠色ToolStripMenuItem,
            this.藍色ToolStripMenuItem,
            this.黑色ToolStripMenuItem,
            this.白色ToolStripMenuItem,
            this.toolStripSeparator2,
            this.離開ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(122, 224);
            // 
            // lockToolStripMenuItem
            // 
            this.lockToolStripMenuItem.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lockToolStripMenuItem.Name = "lockToolStripMenuItem";
            this.lockToolStripMenuItem.Size = new System.Drawing.Size(121, 26);
            this.lockToolStripMenuItem.Text = "Lock";
            this.lockToolStripMenuItem.Click += new System.EventHandler(this.lockToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(118, 6);
            // 
            // 紅色ToolStripMenuItem
            // 
            this.紅色ToolStripMenuItem.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.紅色ToolStripMenuItem.Name = "紅色ToolStripMenuItem";
            this.紅色ToolStripMenuItem.Size = new System.Drawing.Size(121, 26);
            this.紅色ToolStripMenuItem.Text = "Red";
            this.紅色ToolStripMenuItem.Click += new System.EventHandler(this.紅色ToolStripMenuItem_Click);
            // 
            // 黃色ToolStripMenuItem
            // 
            this.黃色ToolStripMenuItem.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.黃色ToolStripMenuItem.Name = "黃色ToolStripMenuItem";
            this.黃色ToolStripMenuItem.Size = new System.Drawing.Size(121, 26);
            this.黃色ToolStripMenuItem.Text = "Yellow";
            this.黃色ToolStripMenuItem.Click += new System.EventHandler(this.黃色ToolStripMenuItem_Click);
            // 
            // 綠色ToolStripMenuItem
            // 
            this.綠色ToolStripMenuItem.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.綠色ToolStripMenuItem.Name = "綠色ToolStripMenuItem";
            this.綠色ToolStripMenuItem.Size = new System.Drawing.Size(121, 26);
            this.綠色ToolStripMenuItem.Text = "Green";
            this.綠色ToolStripMenuItem.Click += new System.EventHandler(this.綠色ToolStripMenuItem_Click);
            // 
            // 藍色ToolStripMenuItem
            // 
            this.藍色ToolStripMenuItem.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.藍色ToolStripMenuItem.Name = "藍色ToolStripMenuItem";
            this.藍色ToolStripMenuItem.Size = new System.Drawing.Size(121, 26);
            this.藍色ToolStripMenuItem.Text = "Blue";
            this.藍色ToolStripMenuItem.Click += new System.EventHandler(this.藍色ToolStripMenuItem_Click);
            // 
            // 黑色ToolStripMenuItem
            // 
            this.黑色ToolStripMenuItem.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.黑色ToolStripMenuItem.Name = "黑色ToolStripMenuItem";
            this.黑色ToolStripMenuItem.Size = new System.Drawing.Size(121, 26);
            this.黑色ToolStripMenuItem.Text = "Black";
            this.黑色ToolStripMenuItem.Click += new System.EventHandler(this.黑色ToolStripMenuItem_Click);
            // 
            // 白色ToolStripMenuItem
            // 
            this.白色ToolStripMenuItem.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.白色ToolStripMenuItem.Name = "白色ToolStripMenuItem";
            this.白色ToolStripMenuItem.Size = new System.Drawing.Size(121, 26);
            this.白色ToolStripMenuItem.Text = "White";
            this.白色ToolStripMenuItem.Click += new System.EventHandler(this.白色ToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(118, 6);
            // 
            // 離開ToolStripMenuItem
            // 
            this.離開ToolStripMenuItem.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.離開ToolStripMenuItem.Name = "離開ToolStripMenuItem";
            this.離開ToolStripMenuItem.Size = new System.Drawing.Size(121, 26);
            this.離開ToolStripMenuItem.Text = "Exit";
            this.離開ToolStripMenuItem.Click += new System.EventHandler(this.離開ToolStripMenuItem_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "設定";
            this.notifyIcon1.Visible = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(30F, 60F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 229);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Font = new System.Drawing.Font("華康魏碑體", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(11, 12, 11, 12);
            this.Name = "Form1";
            this.ShowInTaskbar = false;
            this.Text = "Form1";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.LocationChanged += new System.EventHandler(this.Form1_LocationChanged);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseEnter += new System.EventHandler(this.Form1_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.Form1_MouseLeave);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 紅色ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 藍色ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 黑色ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 白色ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 離開ToolStripMenuItem;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ToolStripMenuItem 黃色ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 綠色ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lockToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
    }
}

