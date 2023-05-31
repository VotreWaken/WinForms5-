namespace WinFormsApp5
{
    public partial class Form1 : Form
    {
        private List<Product> _products = new();
        int total;
        public Form1()
        {
            InitializeComponent();
            CBDataProduct.DisplayMember = "ProductName";
            LBChosenProd.DisplayMember = "ProductName";
        }

        private void BtnAddDataBase_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            DialogResult result = form2.ShowDialog();
            if (result == DialogResult.OK)
            {
                _products.Add(form2._product);
                CBDataProduct.Items.Add(form2._product);
            }
        }

        private void CBDataProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            var res = from product in _products
                      where CBDataProduct.SelectedItem == product
                      select product;

            foreach (var item in res)
                TBPrice.Text = item.Price.ToString();
        }

        private void BtnAddChosen_Click(object sender, EventArgs e)
        {
            if (CBDataProduct.SelectedItem != null)
            {
                total += Convert.ToInt32(TBPrice.Text);
                TBTotalPrice.Text = total.ToString();
                LBChosenProd.Items.Add((Product)CBDataProduct.SelectedItem);
                CBDataProduct.SelectedItem = null;
            }
            else
                MessageBox.Show("Не выбрано ни одного товара!", "Предупреждение",
                                 MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}