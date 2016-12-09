using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;

namespace EnglishHelperSystem
{
    public partial class FormAdd : Office2007Form
    {
        private EnglishHelper englishHelper = new EnglishHelper();

        public FormAdd()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            englishHelper.ArticlePath = this.txtArticlePath.Text;
            englishHelper.WordsLibraryPath = this.txtWordsLibraryPath.Text;
            englishHelper.EnglishWordsHtmlPath = this.txtEnglishWordsHtmlPath.Text;
            
            int result = englishHelper.SaveWords();
            if (result == 0)
            {
                MessageBoxEx.Show("Save Success!", "prompt", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (result == 1)
            {
                MessageBoxEx.Show("Article Path is not accurate!", "prompt", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (result == 2)
            {
                MessageBoxEx.Show("Words Library Path is not accurate!", "prompt", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (result == 3)
            {
                MessageBoxEx.Show("English Words Html Path is not accurate!", "prompt", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void FormAdd_Load(object sender, EventArgs e)
        {
            this.txtArticlePath.Text = englishHelper.ArticlePath;
            this.txtWordsLibraryPath.Text = englishHelper.WordsLibraryPath;
            this.txtEnglishWordsHtmlPath.Text = englishHelper.EnglishWordsHtmlPath;
        }


    }
}