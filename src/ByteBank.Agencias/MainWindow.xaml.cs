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
        private ListBoxAgencias _lstAgencias;
        private ButtonApagar _btnApagar;

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

        public void ApagarAgenciaAtual()
        {
            _db.Agencias.Remove(AgenciaAtual);
            _db.SaveChanges();
            AtualizarLista();
        }

        private void IniciarControles()
        {
            _lstAgencias = new ListBoxAgencias(this) { Width = 247.5, Height = 290 };
            container.Children.Add(_lstAgencias);
            Canvas.SetTop(_lstAgencias, 15);
            Canvas.SetLeft(_lstAgencias, 15);

            _btnApagar = new ButtonApagar(this) { Width = 120, Content = "Apagar" };
            container.Children.Add(_btnApagar);
            Canvas.SetBottom(_btnApagar, 15);
            Canvas.SetRight(_btnApagar, 15);

            AtualizarLista();
        }

        private void AtualizarLista()
        {
            _lstAgencias.Items.Clear();
            foreach (var item in _db.Agencias)
                _lstAgencias.Items.Add(item);
        }
    }
}