using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using ByteBank.Agencias.DAL;

namespace ByteBank.Agencias
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private ByteBankEntities _db = new ByteBankEntities();
        private ListBoxAgencias lstAgencias;

        public Agencia AgenciaAtual { get; private set; }

        public MainWindow()
        {
            InitializeComponent();
            IniciarControles();
        }

        public void AtualizarAgenciaAtual(Agencia novaAgencia)
        {
            AgenciaAtual = novaAgencia;

            Nome.Text = AgenciaAtual?.Nome;
            Numero.Text = AgenciaAtual?.Numero;
            Descricao.Text = AgenciaAtual?.Descricao;
            Telefone.Text = AgenciaAtual?.Telefone;
            Endereco.Text = AgenciaAtual?.Endereco;
        }

        private void IniciarControles()
        {
            lstAgencias = new ListBoxAgencias(this) { Width = 247.5, Height = 290 };

            container.Children.Add(lstAgencias);
            Canvas.SetTop(lstAgencias, 15);
            Canvas.SetLeft(lstAgencias, 15);

            AtualizarLista();
        }

        private void AtualizarLista()
        {
            lstAgencias.Items.Clear();
            foreach (var item in _db.Agencias)
                lstAgencias.Items.Add(item);
        }
    }
}