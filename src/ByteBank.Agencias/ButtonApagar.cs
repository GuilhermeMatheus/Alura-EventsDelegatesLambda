using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace ByteBank.Agencias
{
    public class ButtonApagar : Button
    {
        private MainWindow _mainWindow;
     
        public ButtonApagar(MainWindow mainWindow)
        {
            _mainWindow = mainWindow ?? throw new ArgumentNullException(nameof(mainWindow));
        }

        protected override void OnClick()
        {
            base.OnClick();
            
            var resposta = 
                MessageBox.Show(
                    $"Você deseja mesmo apagar a agência {_mainWindow.AgenciaAtual}?",
                    "Confirmação",
                    MessageBoxButton.YesNo,
                    MessageBoxImage.Question);

            if (resposta == MessageBoxResult.Yes)
                _mainWindow.ApagarAgenciaAtual();
        }
    }
}
