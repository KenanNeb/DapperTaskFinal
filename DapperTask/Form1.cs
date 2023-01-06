using Dapper;
using System.Data;
using System.Data.SqlClient;

namespace DapperTask
{
    public partial class Form1 : Form
    {
        public Product Product { get; set; } = new();
        Form2 formEdit = new Form2();
        private IDbConnection db;
        public Form1()
        {
            InitializeComponent();
            db = new SqlConnection();
            db.ConnectionString = @"Data Source=DESKTOP-7HUNHTF;Integrated Security=True;ApplicationIntent=ReadWrite; Initial Catalog=Catalog;";
            var sqlcomand = "SELECT Name FROM Products";

            using (SqlConnection dbConnect = new SqlConnection(db.ConnectionString))
            {
                dbConnect.Open();
                SqlCommand cmd = new SqlCommand(sqlcomand, dbConnect);
                SqlDataReader reader = cmd.ExecuteReader();
                try
                {
                    while (reader.Read())
                    {
                        string[] stateList = new string[70];
                        for (int i = 1; i <= 70; i++)
                            stateList[i - 1] = reader.GetString(0);

                        for (int i = 0; i < stateList.Length; i++)
                            if (!listBox1.Items.Contains(stateList[i]))
                                listBox1.Items.Add(stateList[i].ToString());
                    }
                }
                finally { reader.Close(); }
            }
        }
        public Product Add(Product product)
        {
            var sql = "INSERT INTO Products (Name, OrignCountry, Cost) VALUES(@Name, @Country, @Cost)";
            db.Execute(sql, product);
            listBox1.Items.Add(product.Name.ToString());
            return product;
        }

        public void Remove(int id) 
        {
            db.Execute("DELETE FROM Products WHERE Id=@Id", new { @id = id }); 
        }

        public Product Update(Product product)
        {
            var sql = "UPDATE Products SET Name=@Name, OrignCountry=@Country, Cost=@Cost WHERE Id=@Id";
            db.Execute(sql, product);
            return product;
        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            formEdit.ShowDialog();

            Product.Name = formEdit.prodname_tbox.Text;
            Product.Country = formEdit.prodcountry_tbox.Text;
            Product.Cost = Convert.ToDecimal(formEdit.prodcost_tbox.Text);

            Add(Product);
        }

        private void edit_btn_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                FillProducts();

                DialogResult result = formEdit.ShowDialog();

                if (formEdit.DialogResult == DialogResult.Yes)
                {
                    Product.Name = formEdit.prodname_tbox.Text;
                    Product.Country = formEdit.prodcountry_tbox.Text;
                    Product.Cost = Convert.ToDecimal(formEdit.prodcost_tbox.Text);

                    FillProducts();
                };
                MessageBox.Show(result.ToString());
            }
            else
            { 
                MessageBox.Show("Select an item");
            }
            Update(Product);
        }

        private void remove_btn_Click(object sender, EventArgs e)
        {
            while (listBox1.SelectedItems.Count > 0)
            {
               listBox1.Items.Remove(listBox1.SelectedItems[0]);
            }
            Remove(listBox1.SelectedIndex);
        }

        private void FillProducts()
        {
            formEdit.prodname_tbox.Text = Product.Name;
            formEdit.prodcost_tbox.Text = Product.Cost.ToString();
            formEdit.prodcountry_tbox.Text = Product.Country;
        }

        private void clear_btn_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }
    }
}