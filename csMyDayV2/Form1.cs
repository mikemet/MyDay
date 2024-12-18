namespace csMyDayV2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string? Month;
        int days, day;
        Random rand = new Random();


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Month = comboBox1.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Generate();
            label1.Text = Convert.ToString(day);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private int Generate()
        {
            if (Month == "������" || Month == "����" || Month == "���" || Month == "����" || Month == "������" || Month == "�������" || Month == "�������")
            {
                days = 31;
            }
            else if (Month == "������" || Month == "����" || Month == "��������" || Month == "������")
            {
                days = 30;
            } else if (Month == "�������")
            {
                days = 28;
            }
            else days = 29;

            List<int> ListDays = [..Enumerable.Range(1, days)];
            day = rand.Next(ListDays.Count);

            return day;
        }
    }
}
