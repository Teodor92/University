using System.Data;
using System.Data.SqlClient;

namespace _01.SimpleFirm
{
    using System;
    using System.Windows.Forms;

    public partial class Goods : Form
    {
        public Goods()
        {
            this.InitializeComponent();
        }

        private void Goods_Load(object sender, EventArgs e)
        {
            var dataConnection = new SqlConnection(@"Data Source=.;Initial Catalog=SimpleFirm;Integrated Security=True");

            using (dataConnection)
            {
                dataConnection.Open();
                var query = new SqlCommand("SELECT * FROM Goods", dataConnection);
                var reader = query.ExecuteReader();

                try
                {
                    var dataTable = new DataTable();
                    dataTable.Load(reader);
                    this.dataGridView1.DataSource = dataTable;
                }
                catch (SqlException ol)
                {
                    MessageBox.Show(ol.Message);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void Create_Click(object sender, EventArgs e)
        {

        }

        private void Update_Click(object sender, EventArgs e)
        {

        }

        private void Delete_Click(object sender, EventArgs e)
        {

        }
    }
}
