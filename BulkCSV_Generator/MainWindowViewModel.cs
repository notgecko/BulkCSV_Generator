using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Windows.Input;

namespace BulkCSV_Generator
{
    public class MainWindowViewModel : BasePropertyChanged
    {
        private ButtonModel button = new ButtonModel();
        private TextBoxModel textBox = new TextBoxModel();

        public ButtonModel Button
        {
            get => this.button;
            set => this.SetValue<ButtonModel>(value, ref this.button, "Button");
        }

        public TextBoxModel TextBox
        {
            get => this.textBox;
            set => this.SetValue<TextBoxModel>(value, ref this.textBox, "TextBox");
        }
    }
}