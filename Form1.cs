using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace apCaminhosEmMarte
{
  public partial class FrmCaminhos : Form
  {
    public FrmCaminhos()
    {
      InitializeComponent();
    }

    ITabelaDeHash<Cidade> tabela;

    private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
    {

    }

    private void btnLerArquivo_Click(object sender, EventArgs e)
    {
      if (dlgAbrir.ShowDialog() == DialogResult.OK)
      {
        if (rbBucketHash.Checked)
           tabela = new BucketHash<Cidade>();
        else
          if (rbHashLinear.Checked)
             tabela = new HashLinear<Cidade>();
          else 
            if (rbHashQuadratico.Checked)
               tabela = new HashQuadratico<Cidade>();
            else
              if (rbHashDuplo.Checked)
                tabela = new HashDuplo<Cidade>();

        var arquivo = new StreamReader(dlgAbrir.FileName);
        while (! arquivo.EndOfStream) 
        {
          Cidade umaCidade = new Cidade();
          umaCidade.LerRegistro(arquivo);
          tabela.Inserir(umaCidade);
        }
        lsbCidades.Items.Clear();  // limpa o listBox
        var asCidades = tabela.Conteudo();
        foreach (Cidade cid in asCidades)
          lsbCidades.Items.Add(cid);
        arquivo.Close();
      }
    }

    private void FrmCaminhos_FormClosing(object sender, FormClosingEventArgs e)
    {
      // abrir o arquivo para saida, se houver um arquivo selecionado
      // obter todo o conteúdo da tabela de hash
      // percorrer o conteúdo da tabela de hash, acessando
      // cada cidade individualmente e usar esse objeto Cidade
      // para gravar seus próprios dados no arquivo
      // fechar o arquivo ao final do percurso
    }
  }
}
