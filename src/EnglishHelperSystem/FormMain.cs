using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using DevComponents.DotNetBar;
using DevComponents.DotNetBar.Rendering;

namespace EnglishHelperSystem
{
    public partial class FormMain : Office2007RibbonForm
    {
        //窗体样式的变量
        private eOffice2007ColorScheme m_BaseColorScheme = eOffice2007ColorScheme.Blue;

        public FormMain()
        {
            InitializeComponent();
        }

        private void btnAddNewWords_Click(object sender, EventArgs e)
        {
            string tabName = "Add New Words";

            if (!IsOpenTab(tabName))
            {
                FormAdd doc = new FormAdd();
                doc.MdiParent = this;
                doc.WindowState = FormWindowState.Maximized;
                doc.Show();
                doc.Update();
            }
        }

        private void btnAboutPrograme_Click(object sender, EventArgs e)
        {
            MessageBoxEx.Show("English Helper System V2.05.14\r\nTo English learner who persevere in!", "prompt", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnAboutAuthor_Click(object sender, EventArgs e)
        {
            MessageBoxEx.Show("Developed by depravedAngel!\r\nBlog:http://depravedAngel.javaeye.com", "prompt", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            FormAdd doc = new FormAdd();
            doc.MdiParent = this;
            doc.WindowState = FormWindowState.Maximized;
            doc.Show();
            doc.Update();
        }

        private void CommandTheme_Executed(object sender, EventArgs e)
        {
            ICommandSource source = sender as ICommandSource;
            if (source.CommandParameter is string)
            {
                eOffice2007ColorScheme colorScheme = (eOffice2007ColorScheme)Enum.Parse(typeof(eOffice2007ColorScheme), source.CommandParameter.ToString());
                ribbonControl1.Office2007ColorTable = colorScheme;
            }
            else if (source.CommandParameter is Color)
            {
                RibbonPredefinedColorSchemes.ChangeOffice2007ColorTable(this, m_BaseColorScheme, (Color)source.CommandParameter);
            }
            this.Invalidate();
        }

        /// <summary>
        /// 防止打开多个同样的子窗体,检查是否已打开某个子窗体,如果打开了就返回true,否则返回false
        /// </summary>
        /// <param name="tabName">子窗体的窗体名称</param>
        /// <returns></returns>
        private bool IsOpenTab(string tabName)
        {
            foreach (TabItem tab in tabStrip1.Tabs)
            {
                if (tab.Text.Trim() == tabName)
                {
                    tabStrip1.SelectedTab = tab;
                    return true;
                }
            }

            return false;
        }
    }
}