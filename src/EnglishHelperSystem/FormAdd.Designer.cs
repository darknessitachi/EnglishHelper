namespace EnglishHelperSystem
{
    partial class FormAdd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAdd));
            this.txtArticlePath = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.btnSave = new DevComponents.DotNetBar.ButtonX();
            this.txtEnglishWordsHtmlPath = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtWordsLibraryPath = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.SuspendLayout();
            // 
            // txtArticlePath
            // 
            // 
            // 
            // 
            this.txtArticlePath.Border.Class = "TextBoxBorder";
            this.txtArticlePath.Location = new System.Drawing.Point(197, 23);
            this.txtArticlePath.Name = "txtArticlePath";
            this.txtArticlePath.Size = new System.Drawing.Size(368, 21);
            this.txtArticlePath.TabIndex = 0;
            // 
            // btnSave
            // 
            this.btnSave.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSave.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnSave.Location = new System.Drawing.Point(115, 178);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(346, 53);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Save New Words From Aritcle File To Words Library File And Display The New Words " +
                "At English Words Html File. ";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtEnglishWordsHtmlPath
            // 
            // 
            // 
            // 
            this.txtEnglishWordsHtmlPath.Border.Class = "TextBoxBorder";
            this.txtEnglishWordsHtmlPath.Location = new System.Drawing.Point(197, 103);
            this.txtEnglishWordsHtmlPath.Name = "txtEnglishWordsHtmlPath";
            this.txtEnglishWordsHtmlPath.Size = new System.Drawing.Size(368, 21);
            this.txtEnglishWordsHtmlPath.TabIndex = 2;
            // 
            // txtWordsLibraryPath
            // 
            // 
            // 
            // 
            this.txtWordsLibraryPath.Border.Class = "TextBoxBorder";
            this.txtWordsLibraryPath.Location = new System.Drawing.Point(197, 63);
            this.txtWordsLibraryPath.Name = "txtWordsLibraryPath";
            this.txtWordsLibraryPath.Size = new System.Drawing.Size(368, 21);
            this.txtWordsLibraryPath.TabIndex = 3;
            // 
            // labelX1
            // 
            this.labelX1.Location = new System.Drawing.Point(29, 23);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(91, 23);
            this.labelX1.TabIndex = 4;
            this.labelX1.Text = "Article Path:";
            // 
            // labelX2
            // 
            this.labelX2.Location = new System.Drawing.Point(29, 103);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(161, 23);
            this.labelX2.TabIndex = 5;
            this.labelX2.Text = "English Words Html Path:";
            // 
            // labelX3
            // 
            this.labelX3.Location = new System.Drawing.Point(29, 63);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(142, 23);
            this.labelX3.TabIndex = 6;
            this.labelX3.Text = "Words Library Path:";
            // 
            // FormAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(577, 307);
            this.Controls.Add(this.labelX3);
            this.Controls.Add(this.labelX2);
            this.Controls.Add(this.labelX1);
            this.Controls.Add(this.txtWordsLibraryPath);
            this.Controls.Add(this.txtEnglishWordsHtmlPath);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtArticlePath);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormAdd";
            this.Text = "Add New Words";
            this.Load += new System.EventHandler(this.FormAdd_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.TextBoxX txtArticlePath;
        private DevComponents.DotNetBar.ButtonX btnSave;
        private DevComponents.DotNetBar.Controls.TextBoxX txtEnglishWordsHtmlPath;
        private DevComponents.DotNetBar.Controls.TextBoxX txtWordsLibraryPath;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.LabelX labelX3;
    }
}