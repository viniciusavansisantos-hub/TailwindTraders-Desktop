using System;
using System.Windows;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace CadastroClienteApp 
{
    public partial class Mainform : Form
    {
    public Mainform () {
    initializeComponent()};
    }    
}

 private void btnSalvar_click(object sander, EventArgs e)
 {
     salvarDadosClientes(txtNome.Text, txtEndereco.Text, txtTelefone.text, txtEmail.text);
