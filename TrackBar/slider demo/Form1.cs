using System;
using System.Drawing; // см. http://grafika.me/node/24
using System.Windows.Forms;

namespace slider_demo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Обработчик для Красной прокрутки
        private void tbrRed_Scroll(object sender, EventArgs e)
        {

            lblRedValue.Text = "Красный = " + tbrRed.Value.ToString();
            ColorIt();
        }

        // Обработчик для зеленой прокрутки
        private void tbrGreen_Scroll(object sender, EventArgs e)
        {
            lblGreenValue.Text = "Зелёный = " + tbrGreen.Value.ToString();
            ColorIt();
        }

        // Обработчик для Синей прокрутки
        private void tbrBlue_Scroll(object sender, EventArgs e)
        {
            lblBlueValue.Text = "Синий = " + tbrBlue.Value.ToString();
            ColorIt();
        }

        // Обработчик для прокрутки насыщения
        private void tbrSaturation_Scroll(object sender, EventArgs e)
        {
            lblSaturationValue.Text = "Насыщенность = " + tbrSaturation.Value.ToString();
            ColorIt();
        }

        // Установка насыщенности и цвет в окне pbxSquare (черное справа)
        private void ColorIt()
        {
            pbxSquare.BackColor =
                Color.FromArgb(tbrSaturation.Value, tbrRed.Value, tbrGreen.Value, tbrBlue.Value);
        }

        // Обработка щелчка кнопки "Выход"
        private void btnQuit_Click(object sender, EventArgs e)
        {
            Close();
        }

        // Обработка щелчка кнопки "Сброс"
        private void btnReset_Click(object sender, EventArgs e)
        {
            tbrRed.Value = 0;
            tbrGreen.Value = 0;
            tbrBlue.Value = 0;
            tbrSaturation.Value = 255;
            lblRedValue.Text = "Красный = 0";
            lblGreenValue.Text = "Зелёный = 0";
            lblBlueValue.Text = "Синий = 0";
            lblSaturationValue.Text = "Насыщенность = 255";
            ColorIt();
        }

        // Обработка события FormClosing (при выходе)
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            string message = "Вам понравилось пользоваться этой программой?";
            MessageBox.Show(message, "The Vasilenko Color Mixer",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question); // кнопки Yes и No
        }
        // Инициализация pbxSquare (черное окно справа)

        private void pbxSquare_Click(object sender, EventArgs e)
        {

        }
    }
}
