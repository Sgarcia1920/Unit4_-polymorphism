namespace Unit4__polymorphism
{
	public partial class Form1 : Form
	{
		double value_end = 0.0;
		string option = "";
		Conversion first_conversion = new Conversion();
		public Form1()
		{
			InitializeComponent();
		}
		private void txtvalue_TextChanged(object sender, EventArgs e)
		{
			if (double.TryParse(txtvalue.Text, out double parsedValue))
			{
				value_end= parsedValue;
			}
		}
		
		
		private void btn_convert_Click(object sender, EventArgs e)
		{
			
			 option = txtoption_Unit.Text.ToUpper();
			switch (option)
			{
				case "FEET":

					MessageBox.Show("" + first_conversion.feet_to_cm(value_end));

					break;
				case "KILOMETERS":

					MessageBox.Show("" + first_conversion.kilometers_to_cm(value_end));
					break;

				default:
					Console.WriteLine("No data entered");
					break;
			}
				
		}

			
	}
}
