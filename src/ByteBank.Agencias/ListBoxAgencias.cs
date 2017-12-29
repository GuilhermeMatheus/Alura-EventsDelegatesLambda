using ByteBank.Agencias.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace ByteBank.Agencias
{
    public class ListBoxAgencias : ListBox
    {
        private MainWindow _janelaMae;

        public ListBoxAgencias(MainWindow janelaMae)
        {
            _janelaMae = janelaMae ?? throw new ArgumentNullException(nameof(janelaMae));
        }

        protected override void OnSelectionChanged(SelectionChangedEventArgs e)
        {
            base.OnSelectionChanged(e);
            _janelaMae.AtualizarAgenciaAtual((Agencia)SelectedItem);
        }
    }
}
