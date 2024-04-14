using System;
using System.ComponentModel;
using System.IO;
using System.Windows.Forms;

namespace apMartianPathways
{
    public partial class FrmPaths : Form
    {
        public FrmPaths()
        {
            InitializeComponent();
        }

        IHashTable<City> table;

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void btnOpenFile_Click(object sender, EventArgs e)
        {
            if (dlgOpen.ShowDialog() == DialogResult.OK)
            {
                if (rbBucketHashing.Checked)
                    table = new BucketHashing<City>();
                else
                    if (rbLinearProbing.Checked)
                        table = new LinearProbing<City>();
                    else
                        if (rbQuadraticProbing.Checked)
                            table = new QuadraticProbing<City>();
                        else
                            if (rbDoubleHashing.Checked)
                                table = new DoubleHashing<City>();

                var file = new StreamReader(dlgOpen.FileName);
                while (!file.EndOfStream)
                {
                    City city = new City();
                    city.ReadRegistry(file);
                    table.Insert(city);
                }
                lsbCities.Items.Clear();
                var cities = table.Content();
                foreach (City c in cities)
                    lsbCities.Items.Add(c);
                file.Close();
            }
        }

        private void FrmPaths_FormClosing(object sender, FormClosingEventArgs e)
        {
            // abrir o file para saida, se houver um file selecionado
            // obter todo o conteúdo da table de hash
            // percorrer o conteúdo da table de hash, acessando
            // cada cidade individualmente e usar esse objeto Cidade
            // para gravar seus próprios dados no file
            // fechar o file ao final do percurso
        }
    }
}
