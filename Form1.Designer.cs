namespace N13__YP__Task_4_14._04._2025
{
    partial class Form5
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;

            // Настройка формы
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Text = "Задание 4: Вычисление функции";

            // Создание элементов управления
            this.txtResult = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();

            // Настройка TextBox для вывода результатов
            this.txtResult.Location = new System.Drawing.Point(50, 50);
            this.txtResult.Size = new System.Drawing.Size(700, 300);
            this.txtResult.Name = "txtResult";
            this.txtResult.Multiline = true; // Многострочный режим
            this.txtResult.ScrollBars = System.Windows.Forms.ScrollBars.Vertical; // Вертикальная прокрутка
            this.txtResult.Font = new System.Drawing.Font("Consolas", 10F); // Устанавливаем шрифт для лучшей читаемости

            // Настройка кнопки "Вычислить"
            this.btnCalculate.Location = new System.Drawing.Point(300, 370);
            this.btnCalculate.Size = new System.Drawing.Size(200, 50);
            this.btnCalculate.Text = "Вычислить";
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);

            // Добавление элементов на форму
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.btnCalculate);
        }

        #endregion

        // Декларация элементов управления
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Button btnCalculate;
    }
}
