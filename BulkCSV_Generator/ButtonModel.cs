using System;
using System.IO;
using System.Windows.Input;
using Microsoft.Win32;

namespace BulkCSV_Generator
{
    public class ButtonModel
    {
        private DelegateCommand command;

        public ICommand ButtonCommand
        {
            get
            {
                if (this.command == null)
                {
                    this.command = new DelegateCommand()
                    {
                        ExecuteHandler = OnClickButton
                    };
                }

                return this.command;
            }
        }

        private void OnClickButton(object parameter)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.CurrentDirectory;
            saveFileDialog.FileName = TextBoxModel.saveFileName;
            if(saveFileDialog.ShowDialog() == true)
            {
                System.IO.Stream stream;
                stream = saveFileDialog.OpenFile();
                if (stream != null)
                {
                    System.IO.StreamWriter sw = new StreamWriter(stream);
                    sw.Write(parameter.ToString());
                    sw.Close();
                    stream.Close();
                }
            }
        }
    }
    
}