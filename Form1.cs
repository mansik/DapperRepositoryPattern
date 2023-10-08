using DapperRepositoryPattern.Models;

namespace DapperRepositoryPattern
{
    public partial class Form1 : Form
    {
        ProductReopsitory? productRepository;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            productRepository = new ProductReopsitory();
            dataGridView.DataSource = productRepository.GetAll();
            lblTotalRecords.Text = $"Total records: {dataGridView.RowCount}";
        }
    }
}