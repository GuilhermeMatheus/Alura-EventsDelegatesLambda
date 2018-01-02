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

            btnOk.Click += (sender, e) => DialogResult = true;
            btnCancelar.Click += (sender, e) => DialogResult = false;


            ValidarCampoDeTexto validacaoNull = texto => !String.IsNullOrEmpty(texto);

            txtNumero.ValidandoCampoDeTexto += validacaoNull;
            txtNome.ValidandoCampoDeTexto += validacaoNull;
            txtTelefone.ValidandoCampoDeTexto += validacaoNull;
            txtDescricao.ValidandoCampoDeTexto += validacaoNull;
            txtEndereco.ValidandoCampoDeTexto += validacaoNull;
        }
    }
}
