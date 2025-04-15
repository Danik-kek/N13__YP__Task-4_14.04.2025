namespace N13__YP__Task_4_14._04._2025
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        // ���������� ������� "���������"
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            double A = 2.5, D = 7.5, H = 0.5, B = 3;

            // ������� ��������� ���� ����� ������ ������������
            txtResult.Clear();

            for (double x = A; x <= D; x += H)
            {
                double y;
                if (x < B)
                {
                    y = Math.Log(x); // ln(X) ��� X < B
                }
                else
                {
                    y = Math.Sqrt(x); // sqrt(X) ��� X >= B
                }

                // ������� ���������� � ��������� ����
                txtResult.AppendText($"X = {x:F2}, Y = {y:F2}\n");
            }
        }
    }
}
