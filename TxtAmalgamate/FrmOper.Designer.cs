namespace TxtAmalgamate
{
    partial class FrmOper
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.tBdir = new System.Windows.Forms.TextBox();
            this.btyl = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cBchtml = new System.Windows.Forms.CheckBox();
            this.cBcjs = new System.Windows.Forms.CheckBox();
            this.btoper = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tBex = new System.Windows.Forms.TextBox();
            this.rTregx = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tBsave = new System.Windows.Forms.TextBox();
            this.btsave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tBdir
            // 
            this.tBdir.Location = new System.Drawing.Point(104, 24);
            this.tBdir.Name = "tBdir";
            this.tBdir.ReadOnly = true;
            this.tBdir.Size = new System.Drawing.Size(231, 21);
            this.tBdir.TabIndex = 0;
            // 
            // btyl
            // 
            this.btyl.Location = new System.Drawing.Point(341, 23);
            this.btyl.Name = "btyl";
            this.btyl.Size = new System.Drawing.Size(44, 23);
            this.btyl.TabIndex = 1;
            this.btyl.Text = "游览";
            this.btyl.UseVisualStyleBackColor = true;
            this.btyl.Click += new System.EventHandler(this.btyl_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "文件目录";
            // 
            // cBchtml
            // 
            this.cBchtml.AutoSize = true;
            this.cBchtml.Location = new System.Drawing.Point(104, 129);
            this.cBchtml.Name = "cBchtml";
            this.cBchtml.Size = new System.Drawing.Size(72, 16);
            this.cBchtml.TabIndex = 3;
            this.cBchtml.Text = "清除Html";
            this.cBchtml.UseVisualStyleBackColor = true;
            // 
            // cBcjs
            // 
            this.cBcjs.AutoSize = true;
            this.cBcjs.Location = new System.Drawing.Point(200, 129);
            this.cBcjs.Name = "cBcjs";
            this.cBcjs.Size = new System.Drawing.Size(72, 16);
            this.cBcjs.TabIndex = 4;
            this.cBcjs.Text = "清除脚本";
            this.cBcjs.UseVisualStyleBackColor = true;
            // 
            // btoper
            // 
            this.btoper.Location = new System.Drawing.Point(104, 288);
            this.btoper.Name = "btoper";
            this.btoper.Size = new System.Drawing.Size(75, 23);
            this.btoper.TabIndex = 5;
            this.btoper.Text = "开始操作";
            this.btoper.UseVisualStyleBackColor = true;
            this.btoper.Click += new System.EventHandler(this.btoper_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 7;
            this.label2.Text = "文件后缀名";
            // 
            // tBex
            // 
            this.tBex.Location = new System.Drawing.Point(104, 59);
            this.tBex.Name = "tBex";
            this.tBex.Size = new System.Drawing.Size(281, 21);
            this.tBex.TabIndex = 6;
            // 
            // rTregx
            // 
            this.rTregx.Location = new System.Drawing.Point(104, 157);
            this.rTregx.Name = "rTregx";
            this.rTregx.Size = new System.Drawing.Size(281, 99);
            this.rTregx.TabIndex = 8;
            this.rTregx.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(69, 201);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 9;
            this.label3.Text = "过滤";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(102, 261);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(149, 12);
            this.label4.TabIndex = 10;
            this.label4.Text = "多个过滤规则使用回车分隔";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 96);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 12);
            this.label5.TabIndex = 12;
            this.label5.Text = "保存文件名";
            // 
            // tBsave
            // 
            this.tBsave.Location = new System.Drawing.Point(104, 93);
            this.tBsave.Name = "tBsave";
            this.tBsave.ReadOnly = true;
            this.tBsave.Size = new System.Drawing.Size(231, 21);
            this.tBsave.TabIndex = 11;
            // 
            // btsave
            // 
            this.btsave.Location = new System.Drawing.Point(341, 91);
            this.btsave.Name = "btsave";
            this.btsave.Size = new System.Drawing.Size(44, 23);
            this.btsave.TabIndex = 13;
            this.btsave.Text = "保存";
            this.btsave.UseVisualStyleBackColor = true;
            this.btsave.Click += new System.EventHandler(this.btsave_Click);
            // 
            // FrmOper
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 329);
            this.Controls.Add(this.btsave);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tBsave);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.rTregx);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tBex);
            this.Controls.Add(this.btoper);
            this.Controls.Add(this.cBcjs);
            this.Controls.Add(this.cBchtml);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btyl);
            this.Controls.Add(this.tBdir);
            this.Name = "FrmOper";
            this.Text = "文本合并器";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tBdir;
        private System.Windows.Forms.Button btyl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox cBchtml;
        private System.Windows.Forms.CheckBox cBcjs;
        private System.Windows.Forms.Button btoper;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tBex;
        private System.Windows.Forms.RichTextBox rTregx;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tBsave;
        private System.Windows.Forms.Button btsave;
    }
}

