namespace N13__YP__Task_4_14._04._2025
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        // Обработчик события "Вычислить"
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            double A = 2.5, D = 7.5, H = 0.5, B = 3;

            // Очищаем текстовое поле перед новыми вычислениями
            txtResult.Clear();

            for (double x = A; x <= D; x += H)
            {
                double y;
                if (x < B)
                {
                    y = Math.Log(x); // ln(X) при X < B
                }
                else
                {
                    y = Math.Sqrt(x); // sqrt(X) при X >= B
                }

                // Выводим результаты в текстовое поле
                txtResult.AppendText($"X = {x:F2}, Y = {y:F2}\n");
            }
        }
    }
}
