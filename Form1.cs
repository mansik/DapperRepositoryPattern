using DapperRepositoryPattern;
using DapperRepositoryPattern.Models;

namespace DapperRepositoryPattern1
{
    public partial class Form1 : Form
    {
        IProductRepository? productRepository;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            productRepository = new ProductReopsitory();
            dataGridView.DataSource = productRepository.GetProducts();
            lblTotalRecords.Text = $"Total records: {dataGridView.RowCount}";
        }
    }
}