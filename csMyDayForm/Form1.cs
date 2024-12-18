namespace csMyDayForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string? input;
        int days;
        readonly Random rand = new();
        int day;

        private void cmbxMonth_SelectedIndexChanged(object sender, EventArgs e)
        {
            input = cmbxMonth.Text;

        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            Generate();
            lbYourDay.Text = Convert.ToString(day);
        }

        private void lbYourDay_Click(object sender, EventArgs e)
        {

        }

        private int Generate()
        {
            int selectedNumber = Convert.ToInt16(input);

            days = selectedNumber switch
            {
                28 => selectedNumber,
                29 => selectedNumber,
                30 => selectedNumber,
                31 => selectedNumber,
                _ => 0,
            };
            List<int> listDays = [.. Enumerable.Range(1, days)];
            day = rand.Next(listDays.Count);
            
            return day;
        }
    }
}
