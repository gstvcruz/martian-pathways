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
            UpdateLsbCities();
            file.Close();
        }

        private void FrmPaths_FormClosing(object sender, FormClosingEventArgs e)
        {
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
            try
            {
                City city = new City();
                city.CityName = txtCity.Text;
                city.X = (double)udX.Value;
                city.Y = (double)udY.Value;

                table.Insert(city);
                UpdateLsbCities();
            }
            catch (NullReferenceException)
            {
                string msg = "There's no opened file to save this city.";
                string cap = "File not found";
                MessageBoxButtons btn = MessageBoxButtons.OK;
                MessageBoxIcon ico = MessageBoxIcon.Error;
                MessageBox.Show(msg, cap, btn, ico);
            }
            catch (ArgumentOutOfRangeException _e)
            {
                string msg = _e.Message;
                string cap = "Coordinate out of bounds";
                MessageBoxButtons btn = MessageBoxButtons.OK;
                MessageBoxIcon ico = MessageBoxIcon.Error;
                MessageBox.Show(msg, cap, btn, ico);
            }
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

        private void UpdateLsbCities()
        {
            lsbCities.Items.Clear();
            var cities = table.Content();
            foreach (City c in cities)
                lsbCities.Items.Add(c);
        }
    }
}
