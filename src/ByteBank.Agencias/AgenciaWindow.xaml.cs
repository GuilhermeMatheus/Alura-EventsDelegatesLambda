using ByteBank.Agencias.DAL;
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
using System.Windows.Shapes;

namespace ByteBank.Agencias
{
    /// <summary>
    /// Interaction logic for AgenciaWindow.xaml
    /// </summary>
    public partial class AgenciaWindow : Window
    {
        private readonly Agencia _agencia;

        public AgenciaWindow(Agencia agencia)
        {
            _agencia = agencia ?? throw new ArgumentNullException(nameof(agencia));
            InitializeComponent();
            AtualizarView();
        }

        private void AtualizarView()
        {
            txtNumero.Text = _agencia.Numero;
            txtNome.Text = _agencia.Nome;
            txtTelefone.Text = _agencia.Telefone;
            txtDescricao.Text = _agencia.Descricao;
            txtEndereco.Text = _agencia.Endereco;

            btnOk.Click += new RoutedEventHandler(btnOk_Click);
            btnCancelar.Click += new RoutedEventHandler(btnCancelar_Click);

            txtNumero.TextChanged += new TextChangedEventHandler(txtNumero_TextChanged);
            txtNome.TextChanged += new TextChangedEventHandler(txtNome_TextChanged);
            txtTelefone.TextChanged += new TextChangedEventHandler(txtTelefone_TextChanged);
            txtDescricao.TextChanged += new TextChangedEventHandler(txtDescricao_TextChanged);
            txtEndereco.TextChanged += new TextChangedEventHandler(txtEndereco_TextChanged);
        }

        private void txtNumero_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (String.IsNullOrEmpty(txtNumero.Text))
                txtNumero.Background = new SolidColorBrush(Colors.OrangeRed);
        }

        private void txtNome_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (String.IsNullOrEmpty(txtNome.Text))
                txtNumero.Background = new SolidColorBrush(Colors.OrangeRed);
        }

        private void txtTelefone_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (String.IsNullOrEmpty(txtNumero.Text))
                txtTelefone.Background = new SolidColorBrush(Colors.OrangeRed);
        }

        private void txtDescricao_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (String.IsNullOrEmpty(txtNumero.Text))
                txtDescricao.Background = new SolidColorBrush(Colors.OrangeRed);
        }

        private void txtEndereco_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (String.IsNullOrEmpty(txtNumero.Text))
                txtEndereco.Background = new SolidColorBrush(Colors.OrangeRed);
        }

        private void btnOk_Click(object sender, RoutedEventArgs e) =>
            DialogResult = true;

        private void btnCancelar_Click(object sender, RoutedEventArgs e) =>
            DialogResult = false;
    }
}
