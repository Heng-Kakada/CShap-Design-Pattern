namespace Adapter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private BindingSource bs = new BindingSource();
        private void Form1_Load(object sender, EventArgs e)
        {
            bs.DataSource = typeof(IInfo);
            bs.Add(new Product("P1", "Nescafe Espresso Roast", 23.5));
            bs.Add(new Product("P2", "Coke", 8.5));
            dataGridView1.DataSource = bs;
            dataGridView1.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.DisplayedCells;

            dataGridView1.DataSource = bs;
            dataGridView1.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.DisplayedCells;
        }
    }
}
