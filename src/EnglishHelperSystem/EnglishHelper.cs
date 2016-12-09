using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Configuration;
using System.Text.RegularExpressions;
using Sky.Darkness.Commons.Util;

namespace EnglishHelperSystem
{
    public class EnglishHelper
    {
        private string articlePath;
        private string wordsLibraryPath;
        private string englishWordsHtmlPath;

        public string ArticlePath
        {
            get { return this.articlePath; }
            set { this.articlePath = value; }
        }

        public string WordsLibraryPath
        {
            get { return this.wordsLibraryPath; }
            set { this.wordsLibraryPath = value; }
        }

        public string EnglishWordsHtmlPath 
        {
            get { return this.englishWordsHtmlPath; }
            set { this.englishWordsHtmlPath = value; }
        }

        public EnglishHelper()
        {
            this.articlePath = ConfigurationSettings.AppSettings["Article"];
            this.wordsLibraryPath = ConfigurationSettings.AppSettings["WordsLibrary"];
            this.englishWordsHtmlPath = ConfigurationSettings.AppSettings["English_Words_Html"];
        }

        public int SaveWords()
        {

            StreamReader articelReader = null;
            try
            {
                articelReader = File.OpenText(this.articlePath);
            }
            catch
            {
                Console.WriteLine("File open failed!");
                return 1;
            }

            StreamReader wordsLibReader = null;
            try
            {
                wordsLibReader = File.OpenText(this.wordsLibraryPath);
            }
            catch
            {
                Console.WriteLine("File open failed!");
                return 2;
            }

            try
            {

                String line;
                Set<String> words = new Set<String>();
                List<String> wordsNew = new List<String>();

                // get words form the wordsLibrary
                while ((line = wordsLibReader.ReadLine()) != null)
                {
                    string[] arrWords = line.Split(' ');
                    foreach (string word in arrWords)
                    {
                        words.Add(word);
                    }
                }
                wordsLibReader.Close();

                while ((line = articelReader.ReadLine()) != null)
                {
                    string[] arrWords = line
                                        .Replace(',',' ')
                                        .Replace('.',' ')
                                        .Replace('!',' ')
                                        .Replace('?',' ')
                                        .Replace(':',' ')
                                        .Replace('(',' ')
                                        .Replace(')',' ')
                                        .Replace('0',' ')
                                        .Replace('1',' ')
                                        .Replace('2',' ')
                                        .Replace('3',' ')
                                        .Replace('4',' ')
                                        .Replace('5',' ')
                                        .Replace('6',' ')
                                        .Replace('7',' ')
                                        .Replace('8',' ')
                                        .Replace('9',' ').Split(' ');
                    // string[] arrWords = Regex..Split(line, " ,.?!:/()0123456789");
                    foreach (string word in arrWords)
                    {
                        if (!words.Contains(word)
                            && !wordsNew.Contains(word)
                            && " ,.?!:/()0123456789".IndexOf(word) == -1)
                            wordsNew.Add(word);
                    }
                }
                articelReader.Close();

                StreamWriter outTxtWriter = new StreamWriter(this.wordsLibraryPath, true);
                StreamWriter outHtmlWriter = new StreamWriter(this.englishWordsHtmlPath, true);
                // create a array for conserve the words
                String[] wordArray = new String[0];
                // write the wordsNew to a array
                wordArray = wordsNew.ToArray();
                // a flag for how many words in a line

                foreach (String w in wordArray)
                {
                    outTxtWriter.Write(w + " ");
                }// for
                outTxtWriter.Close();

                int num = 1;
                outHtmlWriter.Write("<h1>" + DateTime.Now.ToLocalTime() + "</h1>");
                outHtmlWriter.Write("<table border='1'>");
                foreach (String w in wordArray)
                {
                    if (num % 6 == 1)
                    {
                        outHtmlWriter.Write("<tr>");
                        outHtmlWriter.Write("<td>" + num / 6 + "</td>");
                        num++;
                    }
                    if ((num - 1) % 6 == 0)
                    {
                        outHtmlWriter.Write("</tr>");
                        num++;
                    }
                    outHtmlWriter.Write("<td>" + w + "</td>");
                    num++;

                }// for
                outHtmlWriter.Write("</table>");
                outHtmlWriter.Close();

                Console.WriteLine("Words have written successfully!");
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return 3;
            }
            return 0;
        }
    }
}
