using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace apMartianPathways
{
    public partial class FrmPaths : Form
    {
        IHashTable<City> table;
        string fileName = null;
        public FrmPaths()
        {
            InitializeComponent();
        }

        private void btnOpenFile_Click(object sender, EventArgs e)
        {
            if (dlgOpen.ShowDialog() != DialogResult.OK)
                return;

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

            fileName = dlgOpen.FileName;
            var file = new StreamReader(fileName);
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

        private void FrmPaths_FormClosing(object sender, FormClosingEventArgs e)
        {
            // abrir o file para saida, se houver um file selecionado
            // obter todo o conteúdo da table de hash
            // percorrer o conteúdo da table de hash, acessando
            // cada cidade individualmente e usar esse objeto Cidade
            // para gravar seus próprios dados no file
            // fechar o file ao final do percurso
            if (fileName == null)
                return;

            var file = new StreamWriter(fileName);
            List<City> cities = table.Content();
            foreach (City c in cities)
                c.WriteData(file);
            file.Close();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {

        }

        private void btnRemove_Click(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

        }

        private void btnList_Click(object sender, EventArgs e)
        {

        }
    }
}
