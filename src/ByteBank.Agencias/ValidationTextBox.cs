using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace ByteBank.Agencias
{
    public delegate bool ValidarCampoDeTexto(string text);

    public class ValidationTextBox : TextBox
    {
        public event ValidarCampoDeTexto ValidandoCampoDeTexto;

        protected override void OnTextChanged(TextChangedEventArgs e)
        {
            base.OnTextChanged(e);

            ValidandoCampoDeTexto(Text);
        }
    }
}
