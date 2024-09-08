using System.Collections.ObjectModel;

namespace WFACurrencyConverter
{
    public partial class Form1 : Form
    {
        public string baseCurrency { get; set; }
        public string targetCurrency { get; set; }
        public decimal amountToConvert { get; set; }

        public Form1()
        {
            InitializeComponent();
        }

        // save user base currency input
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            // grab the currency code from the selected item
            string selectedItem = comboBox2.SelectedItem.ToString();
            baseCurrency = selectedItem.Substring(0, 3);
        }

        // save user amount input
        public void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text == string.Empty)
            {
                amountToConvert = 0;
                return;
            }
            else
            {
                amountToConvert = decimal.Parse(textBox1.Text);
            }
        }

        // save user target currency input
        public void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // grab the currency code from the selected item
            string selectedItem = comboBox1.SelectedItem.ToString();
            targetCurrency = selectedItem.Substring(0, 3);
        }

        public async void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // instantiate API service object
                APIService apiService = new APIService("YOUR_API_KEY_HERE");

                // call the GetExchangeRateAsync method to get the exchange rate
                decimal result = await apiService.GetExchangeRateAsync(baseCurrency, targetCurrency, amountToConvert);

                // display the new amount after conversion
                label3.Text = $"{amountToConvert} {baseCurrency} = {result} {targetCurrency}";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}