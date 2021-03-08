using System.IO;
using System.Text;

namespace BulkCSV_Generator
{
    public class TextBoxModel : BasePropertyChanged
    {
        public static readonly string saveFileName = @"memo.txt";

        public TextBoxModel()
        {
            if (!File.Exists(saveFileName))
            {
                return;
            }

            StreamReader sr = new StreamReader(saveFileName, Encoding.UTF8);
            Text = sr.ReadToEnd();
            sr.Close();
        }

        private string text = "";

        public string Text
        {
            get { return this.text; }
            set{this.SetValue<string>(value, ref this.text, "Text");}
        }
    }
}