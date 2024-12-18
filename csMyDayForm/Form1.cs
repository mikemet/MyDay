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
        Random rand = new Random();
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

        private int Generate()
        {
            int selectedNumber = Convert.ToInt16(input);

            switch (selectedNumber)
            {
                case 28:
                    days = selectedNumber;
                    break;
                case 29:
                    days = selectedNumber;
                    break;
                case 30:
                    days = selectedNumber;
                    break;
                case 31:
                    days = selectedNumber;
                    break;
                default: days = 0; break;
            }

            List<int> listDays = [.. Enumerable.Range(1, days)];
            day = rand.Next(listDays.Count);
            
            return day;
        }

        private void lbYourDay_Click(object sender, EventArgs e)
        {
            
        }
    }
}
