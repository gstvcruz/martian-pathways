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
        City[] cities;
        int[,] adjacencyMatrix;
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
            
            List<City> cityList = new List<City>();
            
            while (!file.EndOfStream)
            {
                City city = new City();
                city.ReadRegistry(file);
                cityList.Add(city);
                // table.Insert(city);
            }
            // UpdateLsbCities();
            file.Close();
        
            cities = cityList.OrderBy(c => c.CityName.Trim()).ToArray();
            CreateAdjacencyMatrix();

            UpdateComboBoxes();
            UpdateLsbCities();
        }
        private void CreateAdjacencyMatrix()
        {
            int n = cities.Length;
            adjacencyMatrix = new int[n, n];

            // Initialize the matrix with -1 indicating no direct path
            for (int i = 0; i < n; i++)
                for (int j = 0; j < n; j++)
                    adjacencyMatrix[i, j] = -1;
            
            // Verification status file (Open)
            if (dlgOpen.ShowDialog() != DialogResult.OK)
                return;

            var pathFile = new StreamReader(dlgOpen.FileName);
            while (!pathFile.EndOfStream)
            {
                string line = pathFile.ReadLine();
                string origin = line.Substring(0,15).Trim();
                string destination = line.Substring(15, 15).Trim();
                int distance = int.Parse(line.Substring(30, 5).Trim());

                int originIndex = Array.FindIndex(cities, c => c.CityName.Trim() == origin);
                int destinationIndex = Array.FindIndex(cities, c => c.CityName.Trim() == destination);

                // Matrix of Adjacency is defined by distance of a city to other
                adjacencyMatrix[originIndex, destinationIndex] = distance;
            }
            pathFile.Close();
        }

        private void UpdateComboBoxes()
        {
            cbxOrigem.Items.Clear();
            cbxDestino.Items.Clear();

            foreach (City c in cities)
            {
                cbxOrigem.Items.Add(c.CityName.Trim());
                cbxDestino.Items.Add(c.CityName.Trim());
            }
        }

        private void UpdateLsbCities()
        {
            lsbCities.Items.Clear();
            foreach (City c in cities)
                lsbCities.Items.Add(c)
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

        // Method to manipulate the matrix of adjacencys if/as necessary.
        private void btnAddConnection_Click(object sender, EventArgs e)
        {
            int originIndex = cbxOrigem.SelectedIndex;
            int destinationIndex = cbxDestino.SelectedIndex;
            int distance = (int)udDistance.Value;

            adjacencyMatrix[originIndex, destinationIndex] = distance
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
