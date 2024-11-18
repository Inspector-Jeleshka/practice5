namespace practice5
{
	public partial class Form1 : Form
	{
		private List<HomeAppliance> homeAppliances = new();

		public Form1()
		{
			InitializeComponent();
		}

		private void addHomeApplianceButton_Click(object sender, EventArgs e)
		{
			string brand = brandTextBox.Text;
			int price = int.Parse(priceTextBox.Text);

			homeAppliances.Add(new HomeAppliance(brand, price));
		}

		private void addMicrowaveButton_Click(object sender, EventArgs e)
		{
			string brand = brandTextBox.Text;
			int price = int.Parse(priceTextBox.Text);
			int volume = int.Parse(paramTextBox.Text);

			homeAppliances.Add(new Microwave(brand, price, volume));
		}

		private void addFridgeButton_Click(object sender, EventArgs e)
		{
			string brand = brandTextBox.Text;
			int price = int.Parse(priceTextBox.Text);
			int volume = int.Parse(paramTextBox.Text);

			homeAppliances.Add(new Fridge(brand, price, volume));
		}

		private void printButton_Click(object sender, EventArgs e)
		{
			printTextBox.Text = string.Empty;
			foreach (var item in homeAppliances)
				printTextBox.Text += item.ToString() + "\r\n";
		}

		private void brandTextBox_Enter(object sender, EventArgs e)
		{
			if (brandTextBox.Text == "Brand")
				brandTextBox.Clear();
		}

		private void priceTextBox_Enter(object sender, EventArgs e)
		{
			if (priceTextBox.Text == "Price")
				priceTextBox.Clear();
		}

		private void paramTextBox_Enter(object sender, EventArgs e)
		{
			if (paramTextBox.Text == "Temperture/Volume")
				paramTextBox.Clear();
		}
	}
}
