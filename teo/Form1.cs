using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;


namespace teo
{
    public partial class Form1 : Form
    {
        char ch = ',';
        int indexOfChar;
        double tmv, Smc, Km, Mv;
        public Form1()
        {
            InitializeComponent();
            
            ToolTip t = new ToolTip();
            t.SetToolTip(label121, "коэффициент, учитывающий дополнительную заработную плату в \r\nдолях к основной заработной плате\r\nМеньше/равно 1");
            t.SetToolTip(label120, "коэффициент, учитывающий отчисления на социальные нужды, в \r\nдолях к сумме основной и дополнительной заработной платы разработчиков\r\nМеньше/равно 1");
            t.SetToolTip(label119, "коэффициент, учитывающий накладные расходы организации, в\r\n долях к основной заработной плате разработчиков\r\nМеньше/равно 1");
            t.SetToolTip(label118, "машинное время компьютера, необходимое для\r\n разработки программного продукта, дней");
            t.SetToolTip(label117, "стоимость 1 часа машинного времени, руб");
            t.SetToolTip(label116, "коэффициент мультипрограммности\r\nМеньше/равно 1");
            t.SetToolTip(label115, "затраты на использование машинного времени, руб.");
            t.SetToolTip(label123, "коэффициент, учитывающий дополнительную заработную плату в \r\nдолях к основной заработной плате\r\nМеньше/равно 1");
            t.SetToolTip(label122, "коэффициент, учитывающий отчисления на социальные нужды, в \r\nдолях к сумме основной и дополнительной заработной платы разработчиков\r\nМеньше/равно 1");
            t.SetToolTip(label188, "норма годовых амортизационных отчислений для j-гo вида оборудования, в данном случае 20%");
            t.SetToolTip(label195, "укажите суммарную мощность используемого оборудования");
            t.SetToolTip(label191, "установленная мощность j-го вида технических средств, кВт;");
            t.SetToolTip(label193, "тариф на электроэнергию, руб./кВт ч.");
            t.SetToolTip(label197, "норматив затрат на ремонт");
            t.SetToolTip(label190, "количество единиц оборудования j-гo вида");
            t.SetToolTip(label189, "трудоемкость однократной обработки информации по к-й задаче на j-м \r\nвиде технических средств, часов машинного времени");
            t.SetToolTip(label200, "нормативный коэффициент экономической эффективности");
            t.SetToolTip(label15, "комплексный показатель качества продукта по группе показателей проекта");
            t.SetToolTip(label20, "комплексный показатель качества продукта по группе показателей аналога");
            t.SetToolTip(label21, "коэффициент эксплуатационно-технической эквивалентности, или технического уровня");
            
            label114.Visible = false;
            dataGridView1.Visible = false;
            button4.Visible = false;
            button3.Visible = false;
            tabPage2.AutoScrollMinSize = new System.Drawing.Size(1000, 1000);
            tabPage2.Size = new Size(1000, 1000);
            dateTimePicker3.Enabled = false;
            dateTimePicker4.Enabled = false;
            dateTimePicker5.Enabled = false;
            dateTimePicker6.Enabled = false;
            dateTimePicker7.Enabled = false;
            dateTimePicker8.Enabled = false;
            dateTimePicker9.Enabled = false;
            dateTimePicker10.Enabled = false;
            dateTimePicker11.Enabled = false;
            dateTimePicker12.Enabled = false;
            dateTimePicker13.Enabled = false;
            dateTimePicker14.Enabled = false;
            dateTimePicker15.Enabled = false;
            dateTimePicker16.Enabled = false;
            dateTimePicker17.Enabled = false;
            dateTimePicker18.Enabled = false;
            dateTimePicker19.Enabled = false;
            dateTimePicker20.Enabled = false;
            dateTimePicker21.Enabled = false;
            dateTimePicker22.Enabled = false;
            dateTimePicker23.Enabled = false;
            dateTimePicker24.Enabled = false;
            dateTimePicker25.Enabled = false;
            dateTimePicker26.Enabled = false;
            dateTimePicker27.Enabled = false;
            dateTimePicker28.Enabled = false;
            dateTimePicker29.Enabled = false;
            dateTimePicker30.Enabled = false;
            dateTimePicker31.Enabled = false;
            dateTimePicker32.Enabled = false;
            dateTimePicker33.Enabled = false;
            dateTimePicker34.Enabled = false;
            dateTimePicker35.Enabled = false;
            dateTimePicker36.Enabled = false;
            dateTimePicker37.Enabled = false;
            dateTimePicker38.Enabled = false;
            dateTimePicker39.Enabled = false;
            dateTimePicker40.Enabled = false;
            dateTimePicker41.Enabled = false;
            dateTimePicker42.Enabled = false;
            dateTimePicker43.Enabled = false;
            dateTimePicker44.Enabled = false;
            dateTimePicker45.Enabled = false;
            dateTimePicker46.Enabled = false;
            dateTimePicker47.Enabled = false;
            dateTimePicker48.Enabled = false;
            dateTimePicker49.Enabled = false;
            dateTimePicker50.Enabled = false;
            dateTimePicker51.Enabled = false;
            dateTimePicker52.Enabled = false;
            dateTimePicker53.Enabled = false;
            dateTimePicker54.Enabled = false;
            dateTimePicker55.Enabled = false;
            dateTimePicker56.Enabled = false;
            dateTimePicker57.Enabled = false;
            dateTimePicker58.Enabled = false;
            dateTimePicker59.Enabled = false;
            dateTimePicker60.Enabled = false;
            dateTimePicker61.Enabled = false;
            dateTimePicker62.Enabled = false;
            dateTimePicker63.Enabled = false;
            dateTimePicker64.Enabled = false;
            dateTimePicker65.Enabled = false;
            dateTimePicker66.Enabled = false;
            dateTimePicker67.Enabled = false;
            dateTimePicker68.Enabled = false;
            textBoxПок1.Visible = false;
            textBoxПок2.Visible = false;
            textBoxПок3.Visible = false;
            textBoxПок4.Visible = false;
            textBoxПок5.Visible = false;
            textBoxВjД1.Visible = false;
            textBoxВjД2.Visible = false;
            textBoxВjД3.Visible = false;
            textBoxВjД4.Visible = false;
            textBoxВjД5.Visible = false;
            textBoxAjД1.Visible = false;
            textBoxAjД2.Visible = false;
            textBoxAjД3.Visible = false;
            textBoxAjД4.Visible = false;
            textBoxAjД5.Visible = false;
            textBoxВjXjД1.Visible = false;
            textBoxВjXjД2.Visible = false;
            textBoxВjXjД3.Visible = false;
            textBoxВjXjД4.Visible = false;
            textBoxВjXjД5.Visible = false;
            textBoxXjД1.Visible = false;
            textBoxXjД2.Visible = false;
            textBoxXjД3.Visible = false;
            textBoxXjД4.Visible = false;
            textBoxXjД5.Visible = false;
            textBoxВjXjДA1.Visible = false;
            textBoxВjXjДA2.Visible = false;
            textBoxВjXjДA3.Visible = false;
            textBoxВjXjДA4.Visible = false;
            textBoxВjXjДA5.Visible = false;
            label92.Visible = false;
            OZPsum.Visible = false;
            button6.Visible = false;
            MATsum.Visible = false;
            label95.Visible = false;
            lbItog1.Visible = false;
            lbItog.Visible = false;
            lbY1.Visible = false;
            lbY.Visible = false;
            label82.Visible = false;
            kolvoobsh.Visible = false;
        }
        int sumPr;
        int q;
        private void button12_Click(object sender, EventArgs e)
        {
            if (q<6) q++;
            switch (q)
            {
                case 1:
                    textBoxПок1.Visible = true;
                    textBoxВjД1.Visible = true;
                    textBoxAjД1.Visible = true;
                    textBoxВjXjД1.Visible = true;
                    textBoxXjД1.Visible = true;
                    textBoxВjXjДA1.Visible = true;
                    break;
                case 2:
                    textBoxПок2.Visible = true;
                    textBoxВjД2.Visible = true;
                    textBoxAjД2.Visible = true;
                    textBoxВjXjД2.Visible = true;
                    textBoxXjД2.Visible = true;
                    textBoxВjXjДA2.Visible = true;
                    break;
                case 3:
                    textBoxПок3.Visible = true;
                    textBoxВjД3.Visible = true;
                    textBoxAjД3.Visible = true;
                    textBoxВjXjД3.Visible = true;
                    textBoxXjД3.Visible = true;
                    textBoxВjXjДA3.Visible = true;
                    break;
                case 4:
                    textBoxПок4.Visible = true;
                    textBoxВjД4.Visible = true;
                    textBoxAjД4.Visible = true;
                    textBoxВjXjД4.Visible = true;
                    textBoxXjД4.Visible = true;
                    textBoxВjXjДA4.Visible = true;
                    break;
                case 5:
                    textBoxПок5.Visible = true;
                    textBoxВjД5.Visible = true;
                    textBoxAjД5.Visible = true;
                    textBoxВjXjД5.Visible = true;
                    textBoxXjД5.Visible = true;
                    textBoxВjXjДA5.Visible = true;
                    break;
            }
        }
        private void buttonKach_Click(object sender, EventArgs e)
        {
            try
            { //проверки
                if (q == 0)
                {
                    if ((Convert.ToDouble(textBoxВj1.Text) + Convert.ToDouble(textBoxВj2.Text) + Convert.ToDouble(textBoxВj3.Text) +
                    Convert.ToDouble(textBoxВj4.Text) + Convert.ToDouble(textBoxВj5.Text) + Convert.ToDouble(textBoxВj6.Text) +
                    Convert.ToDouble(textBoxВj7.Text) + Convert.ToDouble(textBoxВj8.Text) + Convert.ToDouble(textBoxВj9.Text)) == 1)
                    { }
                    else MessageBox.Show("Сумма коэффициентов весомости должна быть равна 1");
                    if ((Convert.ToDouble(textBoxXj1.Text) > 5) || (Convert.ToDouble(textBoxXj2.Text) > 5) || (Convert.ToDouble(textBoxXj3.Text) > 5)
                   || (Convert.ToDouble(textBoxXj4.Text) > 5) || (Convert.ToDouble(textBoxXj5.Text) > 5) || (Convert.ToDouble(textBoxXj6.Text) > 5)
                   || (Convert.ToDouble(textBoxXj7.Text) > 5) || (Convert.ToDouble(textBoxXj8.Text) > 5) || (Convert.ToDouble(textBoxXj9.Text) > 5))
                    {
                        MessageBox.Show("Значение коэффициента Xi должно быть не больше 5");
                    }
                    if ((Convert.ToDouble(textBoxXjA1.Text) > 5) || (Convert.ToDouble(textBoxXjA2.Text) > 5) || (Convert.ToDouble(textBoxXjA3.Text) > 5)
                    || (Convert.ToDouble(textBoxXjA4.Text) > 5) || (Convert.ToDouble(textBoxXjA5.Text) > 5) || (Convert.ToDouble(textBoxXjA6.Text) > 5)
                    || (Convert.ToDouble(textBoxXjA7.Text) > 5) || (Convert.ToDouble(textBoxXjA8.Text) > 5) || (Convert.ToDouble(textBoxXjA9.Text) > 5))
                    {
                        MessageBox.Show("Значение коэффициента Xj должно быть не больше 5");
                    }
                }
                else if (q == 1)
                {
                    if ((Convert.ToDouble(textBoxВj1.Text) + Convert.ToDouble(textBoxВj2.Text) + Convert.ToDouble(textBoxВj3.Text) +
                    Convert.ToDouble(textBoxВj4.Text) + Convert.ToDouble(textBoxВj5.Text) + Convert.ToDouble(textBoxВj6.Text) +
                    Convert.ToDouble(textBoxВj7.Text) + Convert.ToDouble(textBoxВj8.Text) + Convert.ToDouble(textBoxВj9.Text) +
                    Convert.ToDouble(textBoxВjД1.Text)) == 1)
                    { }
                    else MessageBox.Show("Сумма коэффициентов весомости должна быть равна 1");
                    if ((Convert.ToDouble(textBoxXj1.Text) > 5) || (Convert.ToDouble(textBoxXj2.Text) > 5) || (Convert.ToDouble(textBoxXj3.Text) > 5)
                   || (Convert.ToDouble(textBoxXj4.Text) > 5) || (Convert.ToDouble(textBoxXj5.Text) > 5) || (Convert.ToDouble(textBoxXj6.Text) > 5)
                   || (Convert.ToDouble(textBoxXj7.Text) > 5) || (Convert.ToDouble(textBoxXj8.Text) > 5) || (Convert.ToDouble(textBoxXj9.Text) > 5)
                   || (Convert.ToDouble(textBoxAjД1.Text) > 5))
                    {
                        MessageBox.Show("Значение коэффициента Xi должно быть не больше 5");
                    }
                    if ((Convert.ToDouble(textBoxXjA1.Text) > 5) || (Convert.ToDouble(textBoxXjA2.Text) > 5) || (Convert.ToDouble(textBoxXjA3.Text) > 5)
                    || (Convert.ToDouble(textBoxXjA4.Text) > 5) || (Convert.ToDouble(textBoxXjA5.Text) > 5) || (Convert.ToDouble(textBoxXjA6.Text) > 5)
                    || (Convert.ToDouble(textBoxXjA7.Text) > 5) || (Convert.ToDouble(textBoxXjA8.Text) > 5) || (Convert.ToDouble(textBoxXjA9.Text) > 5)
                    || (Convert.ToDouble(textBoxXjД1.Text) > 5))
                    {
                        MessageBox.Show("Значение коэффициента Xj должно быть не больше 5");
                    }
                }
                else if (q == 2)
                {
                    if ((Convert.ToDouble(textBoxВj1.Text) + Convert.ToDouble(textBoxВj2.Text) + Convert.ToDouble(textBoxВj3.Text) +
                    Convert.ToDouble(textBoxВj4.Text) + Convert.ToDouble(textBoxВj5.Text) + Convert.ToDouble(textBoxВj6.Text) +
                    Convert.ToDouble(textBoxВj7.Text) + Convert.ToDouble(textBoxВj8.Text) + Convert.ToDouble(textBoxВj9.Text) +
                    Convert.ToDouble(textBoxВjД1.Text) + Convert.ToDouble(textBoxВjД2.Text)) == 1)
                    { }
                    else MessageBox.Show("Сумма коэффициентов весомости должна быть равна 1");
                    if ((Convert.ToDouble(textBoxXj1.Text) > 5) || (Convert.ToDouble(textBoxXj2.Text) > 5) || (Convert.ToDouble(textBoxXj3.Text) > 5)
                   || (Convert.ToDouble(textBoxXj4.Text) > 5) || (Convert.ToDouble(textBoxXj5.Text) > 5) || (Convert.ToDouble(textBoxXj6.Text) > 5)
                   || (Convert.ToDouble(textBoxXj7.Text) > 5) || (Convert.ToDouble(textBoxXj8.Text) > 5) || (Convert.ToDouble(textBoxXj9.Text) > 5)
                   || (Convert.ToDouble(textBoxAjД1.Text) > 5) || (Convert.ToDouble(textBoxAjД2.Text) > 5))
                    {
                        MessageBox.Show("Значение коэффициента Xi должно быть не больше 5");
                    }
                    if ((Convert.ToDouble(textBoxXjA1.Text) > 5) || (Convert.ToDouble(textBoxXjA2.Text) > 5) || (Convert.ToDouble(textBoxXjA3.Text) > 5)
                    || (Convert.ToDouble(textBoxXjA4.Text) > 5) || (Convert.ToDouble(textBoxXjA5.Text) > 5) || (Convert.ToDouble(textBoxXjA6.Text) > 5)
                    || (Convert.ToDouble(textBoxXjA7.Text) > 5) || (Convert.ToDouble(textBoxXjA8.Text) > 5) || (Convert.ToDouble(textBoxXjA9.Text) > 5)
                    || (Convert.ToDouble(textBoxXjД1.Text) > 5) || (Convert.ToDouble(textBoxXjД2.Text) > 5))
                    {
                        MessageBox.Show("Значение коэффициента Xj должно быть не больше 5");
                    }
                }
                else if (q == 3)
                {
                    if ((Convert.ToDouble(textBoxВj1.Text) + Convert.ToDouble(textBoxВj2.Text) + Convert.ToDouble(textBoxВj3.Text) +
                    Convert.ToDouble(textBoxВj4.Text) + Convert.ToDouble(textBoxВj5.Text) + Convert.ToDouble(textBoxВj6.Text) +
                    Convert.ToDouble(textBoxВj7.Text) + Convert.ToDouble(textBoxВj8.Text) + Convert.ToDouble(textBoxВj9.Text) +
                    Convert.ToDouble(textBoxВjД1.Text) + Convert.ToDouble(textBoxВjД2.Text) + Convert.ToDouble(textBoxВjД3.Text)) == 1)
                    { }
                    else MessageBox.Show("Сумма коэффициентов весомости должна быть равна 1");
                    if ((Convert.ToDouble(textBoxXj1.Text) > 5) || (Convert.ToDouble(textBoxXj2.Text) > 5) || (Convert.ToDouble(textBoxXj3.Text) > 5)
                   || (Convert.ToDouble(textBoxXj4.Text) > 5) || (Convert.ToDouble(textBoxXj5.Text) > 5) || (Convert.ToDouble(textBoxXj6.Text) > 5)
                   || (Convert.ToDouble(textBoxXj7.Text) > 5) || (Convert.ToDouble(textBoxXj8.Text) > 5) || (Convert.ToDouble(textBoxXj9.Text) > 5)
                   || (Convert.ToDouble(textBoxAjД1.Text) > 5) || (Convert.ToDouble(textBoxAjД2.Text) > 5) || (Convert.ToDouble(textBoxAjД3.Text) > 5))
                    {
                        MessageBox.Show("Значение коэффициента Xi должно быть не больше 5");
                    }
                    if ((Convert.ToDouble(textBoxXjA1.Text) > 5) || (Convert.ToDouble(textBoxXjA2.Text) > 5) || (Convert.ToDouble(textBoxXjA3.Text) > 5)
                    || (Convert.ToDouble(textBoxXjA4.Text) > 5) || (Convert.ToDouble(textBoxXjA5.Text) > 5) || (Convert.ToDouble(textBoxXjA6.Text) > 5)
                    || (Convert.ToDouble(textBoxXjA7.Text) > 5) || (Convert.ToDouble(textBoxXjA8.Text) > 5) || (Convert.ToDouble(textBoxXjA9.Text) > 5)
                    || (Convert.ToDouble(textBoxXjД1.Text) > 5) || (Convert.ToDouble(textBoxXjД2.Text) > 5) || (Convert.ToDouble(textBoxXjД3.Text) > 5))
                    {
                        MessageBox.Show("Значение коэффициента Xj должно быть не больше 5");
                    }
                }
                else if (q == 4)
                {
                    if ((Convert.ToDouble(textBoxВj1.Text) + Convert.ToDouble(textBoxВj2.Text) + Convert.ToDouble(textBoxВj3.Text) +
                    Convert.ToDouble(textBoxВj4.Text) + Convert.ToDouble(textBoxВj5.Text) + Convert.ToDouble(textBoxВj6.Text) +
                    Convert.ToDouble(textBoxВj7.Text) + Convert.ToDouble(textBoxВj8.Text) + Convert.ToDouble(textBoxВj9.Text) +
                    Convert.ToDouble(textBoxВjД1.Text) + Convert.ToDouble(textBoxВjД2.Text) + Convert.ToDouble(textBoxВjД3.Text)
                    + Convert.ToDouble(textBoxВjД4.Text)) == 1)
                    { }
                    else MessageBox.Show("Сумма коэффициентов весомости должна быть равна 1");
                    if ((Convert.ToDouble(textBoxXj1.Text) > 5) || (Convert.ToDouble(textBoxXj2.Text) > 5) || (Convert.ToDouble(textBoxXj3.Text) > 5)
                   || (Convert.ToDouble(textBoxXj4.Text) > 5) || (Convert.ToDouble(textBoxXj5.Text) > 5) || (Convert.ToDouble(textBoxXj6.Text) > 5)
                   || (Convert.ToDouble(textBoxXj7.Text) > 5) || (Convert.ToDouble(textBoxXj8.Text) > 5) || (Convert.ToDouble(textBoxXj9.Text) > 5)
                   || (Convert.ToDouble(textBoxAjД1.Text) > 5) || (Convert.ToDouble(textBoxAjД2.Text) > 5) || (Convert.ToDouble(textBoxAjД3.Text) > 5)
                   || (Convert.ToDouble(textBoxAjД4.Text) > 5))
                    {
                        MessageBox.Show("Значение коэффициента Xi должно быть не больше 5");
                        if ((Convert.ToDouble(textBoxXjA1.Text) > 5) || (Convert.ToDouble(textBoxXjA2.Text) > 5) || (Convert.ToDouble(textBoxXjA3.Text) > 5)
                    || (Convert.ToDouble(textBoxXjA4.Text) > 5) || (Convert.ToDouble(textBoxXjA5.Text) > 5) || (Convert.ToDouble(textBoxXjA6.Text) > 5)
                    || (Convert.ToDouble(textBoxXjA7.Text) > 5) || (Convert.ToDouble(textBoxXjA8.Text) > 5) || (Convert.ToDouble(textBoxXjA9.Text) > 5)
                    || (Convert.ToDouble(textBoxXjД1.Text) > 5) || (Convert.ToDouble(textBoxXjД2.Text) > 5) || (Convert.ToDouble(textBoxXjД3.Text) > 5)
                    || (Convert.ToDouble(textBoxXjД4.Text) > 5))
                        {
                            MessageBox.Show("Значение коэффициента Xj должно быть не больше 5");
                        }
                    }
                }
                else
                {
                    if ((Convert.ToDouble(textBoxВj1.Text) + Convert.ToDouble(textBoxВj2.Text) + Convert.ToDouble(textBoxВj3.Text) +
                    Convert.ToDouble(textBoxВj4.Text) + Convert.ToDouble(textBoxВj5.Text) + Convert.ToDouble(textBoxВj6.Text) +
                    Convert.ToDouble(textBoxВj7.Text) + Convert.ToDouble(textBoxВj8.Text) + Convert.ToDouble(textBoxВj9.Text) +
                    Convert.ToDouble(textBoxВjД1.Text) + Convert.ToDouble(textBoxВjД2.Text) + Convert.ToDouble(textBoxВjД3.Text)
                    + Convert.ToDouble(textBoxВjД4.Text) + Convert.ToDouble(textBoxВjД5.Text)) == 1)
                    { }
                    else MessageBox.Show("Сумма коэффициентов весомости должна быть равна 1");
                    if ((Convert.ToDouble(textBoxXj1.Text) > 5) || (Convert.ToDouble(textBoxXj2.Text) > 5) || (Convert.ToDouble(textBoxXj3.Text) > 5)
                   || (Convert.ToDouble(textBoxXj4.Text) > 5) || (Convert.ToDouble(textBoxXj5.Text) > 5) || (Convert.ToDouble(textBoxXj6.Text) > 5)
                   || (Convert.ToDouble(textBoxXj7.Text) > 5) || (Convert.ToDouble(textBoxXj8.Text) > 5) || (Convert.ToDouble(textBoxXj9.Text) > 5)
                   || (Convert.ToDouble(textBoxAjД1.Text) > 5) || (Convert.ToDouble(textBoxAjД2.Text) > 5) || (Convert.ToDouble(textBoxAjД3.Text) > 5)
                   || (Convert.ToDouble(textBoxAjД4.Text) > 5) || (Convert.ToDouble(textBoxAjД5.Text) > 5))
                    {
                        MessageBox.Show("Значение коэффициента Xi должно быть не больше 5");
                    }
                    if ((Convert.ToDouble(textBoxXjA1.Text) > 5) || (Convert.ToDouble(textBoxXjA2.Text) > 5) || (Convert.ToDouble(textBoxXjA3.Text) > 5)
                    || (Convert.ToDouble(textBoxXjA4.Text) > 5) || (Convert.ToDouble(textBoxXjA5.Text) > 5) || (Convert.ToDouble(textBoxXjA6.Text) > 5)
                    || (Convert.ToDouble(textBoxXjA7.Text) > 5) || (Convert.ToDouble(textBoxXjA8.Text) > 5) || (Convert.ToDouble(textBoxXjA9.Text) > 5)
                    || (Convert.ToDouble(textBoxXjД1.Text) > 5) || (Convert.ToDouble(textBoxXjД2.Text) > 5) || (Convert.ToDouble(textBoxXjД3.Text) > 5)
                    || (Convert.ToDouble(textBoxXjД4.Text) > 5) || (Convert.ToDouble(textBoxXjД5.Text) > 5))
                    {
                        MessageBox.Show("Значение коэффициента Xj должно быть не больше 5");
                    }
                }



                //Проект Вj*Xj
                textBoxВjXj1.Text = Convert.ToString(Convert.ToDouble(textBoxВj1.Text) * Convert.ToDouble(textBoxXj1.Text));
                textBoxВjXj2.Text = Convert.ToString(Convert.ToDouble(textBoxВj2.Text) * Convert.ToDouble(textBoxXj2.Text));
                textBoxВjXj3.Text = Convert.ToString(Convert.ToDouble(textBoxВj3.Text) * Convert.ToDouble(textBoxXj3.Text));
                textBoxВjXj4.Text = Convert.ToString(Convert.ToDouble(textBoxВj4.Text) * Convert.ToDouble(textBoxXj4.Text));
                textBoxВjXj5.Text = Convert.ToString(Convert.ToDouble(textBoxВj5.Text) * Convert.ToDouble(textBoxXj5.Text));
                textBoxВjXj6.Text = Convert.ToString(Convert.ToDouble(textBoxВj6.Text) * Convert.ToDouble(textBoxXj6.Text));
                textBoxВjXj7.Text = Convert.ToString(Convert.ToDouble(textBoxВj7.Text) * Convert.ToDouble(textBoxXj7.Text));
                textBoxВjXj8.Text = Convert.ToString(Convert.ToDouble(textBoxВj8.Text) * Convert.ToDouble(textBoxXj8.Text));
                textBoxВjXj9.Text = Convert.ToString(Convert.ToDouble(textBoxВj9.Text) * Convert.ToDouble(textBoxXj9.Text));
                if ((textBoxВjД1.Text != "") && (textBoxAjД1.Text != ""))
                {
                    textBoxВjXjД1.Text = Convert.ToString(Convert.ToDouble(textBoxВjД1.Text) * Convert.ToDouble(textBoxAjД1.Text));

                }
                if ((textBoxВjД2.Text != "") && (textBoxAjД2.Text != ""))
                {
                    textBoxВjXjД2.Text = Convert.ToString(Convert.ToDouble(textBoxВjД2.Text) * Convert.ToDouble(textBoxAjД2.Text));
                }
                if ((textBoxВjД3.Text != "") && (textBoxAjД3.Text != ""))
                {
                    textBoxВjXjД3.Text = Convert.ToString(Convert.ToDouble(textBoxВjД3.Text) * Convert.ToDouble(textBoxAjД3.Text));
                }
                if ((textBoxВjД4.Text != "") && (textBoxAjД4.Text != ""))
                {
                    textBoxВjXjД4.Text = Convert.ToString(Convert.ToDouble(textBoxВjД4.Text) * Convert.ToDouble(textBoxAjД4.Text));
                }
                if ((textBoxВjД5.Text != "") && (textBoxAjД5.Text != ""))
                {
                    textBoxВjXjД5.Text = Convert.ToString(Convert.ToDouble(textBoxВjД5.Text) * Convert.ToDouble(textBoxAjД5.Text));
                }
                //JЭТУ1
                double x;
                textBoxJЭТУ1.Text = Convert.ToString(Convert.ToDouble(textBoxВjXj1.Text) + Convert.ToDouble(textBoxВjXj2.Text) + Convert.ToDouble(textBoxВjXj3.Text) +
                    Convert.ToDouble(textBoxВjXj4.Text) + Convert.ToDouble(textBoxВjXj5.Text) + Convert.ToDouble(textBoxВjXj6.Text) +
                    Convert.ToDouble(textBoxВjXj7.Text) + Convert.ToDouble(textBoxВjXj8.Text) + Convert.ToDouble(textBoxВjXj9.Text));
                if (textBoxВjXjД1.Text != "")
                {
                    x = Convert.ToDouble(textBoxJЭТУ1.Text) + Convert.ToDouble(textBoxВjXjД1.Text);
                    textBoxJЭТУ1.Text = Convert.ToString(x);
                }
                if (textBoxВjXjД2.Text != "")
                {
                    x = Convert.ToDouble(textBoxJЭТУ1.Text) + Convert.ToDouble(textBoxВjXjД2.Text);
                    textBoxJЭТУ1.Text = Convert.ToString(x);
                }
                if (textBoxВjXjД3.Text != "")
                {
                    x = Convert.ToDouble(textBoxJЭТУ1.Text) + Convert.ToDouble(textBoxВjXjД3.Text);
                    textBoxJЭТУ1.Text = Convert.ToString(x);
                }
                if (textBoxВjXjД4.Text != "")
                {
                    x = Convert.ToDouble(textBoxJЭТУ1.Text) + Convert.ToDouble(textBoxВjXjД4.Text);
                    textBoxJЭТУ1.Text = Convert.ToString(x);
                }
                if (textBoxВjXjД5.Text != "")
                {
                    x = Convert.ToDouble(textBoxJЭТУ1.Text) + Convert.ToDouble(textBoxВjXjД5.Text);
                    textBoxJЭТУ1.Text = Convert.ToString(x);
                }
                //Аналог Вj*Xj
                textBoxВjXjA1.Text = Convert.ToString(Convert.ToDouble(textBoxВj1.Text) * Convert.ToDouble(textBoxXjA1.Text));
                textBoxВjXjA2.Text = Convert.ToString(Convert.ToDouble(textBoxВj2.Text) * Convert.ToDouble(textBoxXjA2.Text));
                textBoxВjXjA3.Text = Convert.ToString(Convert.ToDouble(textBoxВj3.Text) * Convert.ToDouble(textBoxXjA3.Text));
                textBoxВjXjA4.Text = Convert.ToString(Convert.ToDouble(textBoxВj4.Text) * Convert.ToDouble(textBoxXjA4.Text));
                textBoxВjXjA5.Text = Convert.ToString(Convert.ToDouble(textBoxВj5.Text) * Convert.ToDouble(textBoxXjA5.Text));
                textBoxВjXjA6.Text = Convert.ToString(Convert.ToDouble(textBoxВj6.Text) * Convert.ToDouble(textBoxXjA6.Text));
                textBoxВjXjA7.Text = Convert.ToString(Convert.ToDouble(textBoxВj7.Text) * Convert.ToDouble(textBoxXjA7.Text));
                textBoxВjXjA8.Text = Convert.ToString(Convert.ToDouble(textBoxВj8.Text) * Convert.ToDouble(textBoxXjA8.Text));
                textBoxВjXjA9.Text = Convert.ToString(Convert.ToDouble(textBoxВj9.Text) * Convert.ToDouble(textBoxXjA9.Text));
                if ((textBoxВjД1.Text != "") && (textBoxXjД1.Text != ""))
                {
                    textBoxВjXjДA1.Text = Convert.ToString(Convert.ToDouble(textBoxВjД1.Text) * Convert.ToDouble(textBoxXjД1.Text));
                }
                if ((textBoxВjД2.Text != "") && (textBoxXjД2.Text != ""))
                {
                    textBoxВjXjДA2.Text = Convert.ToString(Convert.ToDouble(textBoxВjД2.Text) * Convert.ToDouble(textBoxXjД2.Text));
                }
                if ((textBoxВjД3.Text != "") && (textBoxXjД3.Text != ""))
                {
                    textBoxВjXjДA3.Text = Convert.ToString(Convert.ToDouble(textBoxВjД3.Text) * Convert.ToDouble(textBoxXjД3.Text));
                }
                if ((textBoxВjД4.Text != "") && (textBoxXjД4.Text != ""))
                {
                    textBoxВjXjДA4.Text = Convert.ToString(Convert.ToDouble(textBoxВjД4.Text) * Convert.ToDouble(textBoxXjД4.Text));
                } if ((textBoxВjД5.Text != "") && (textBoxXjД5.Text != ""))
                {
                    textBoxВjXjДA5.Text = Convert.ToString(Convert.ToDouble(textBoxВjД5.Text) * Convert.ToDouble(textBoxXjД5.Text));
                }
                //JЭТУ2
                textBoxJЭТУ2.Text = Convert.ToString(Convert.ToDouble(textBoxВjXjA1.Text) + Convert.ToDouble(textBoxВjXjA2.Text) + Convert.ToDouble(textBoxВjXjA3.Text) +
                    Convert.ToDouble(textBoxВjXjA4.Text) + Convert.ToDouble(textBoxВjXjA5.Text) + Convert.ToDouble(textBoxВjXjA6.Text) +
                    Convert.ToDouble(textBoxВjXjA7.Text) + Convert.ToDouble(textBoxВjXjA8.Text) + Convert.ToDouble(textBoxВjXjA9.Text));
                if ((textBoxВjXjДA1.Text != ""))
                {
                    x = Convert.ToDouble(textBoxJЭТУ2.Text) + Convert.ToDouble(textBoxВjXjДA1.Text);
                    textBoxJЭТУ2.Text = Convert.ToString(x);
                }
                if ((textBoxВjXjДA2.Text != ""))
                {
                    x = Convert.ToDouble(textBoxJЭТУ2.Text) + Convert.ToDouble(textBoxВjXjДA2.Text);
                    textBoxJЭТУ2.Text = Convert.ToString(x);
                }
                if ((textBoxВjXjДA3.Text != ""))
                {
                    x = Convert.ToDouble(textBoxJЭТУ2.Text) + Convert.ToDouble(textBoxВjXjДA3.Text);
                    textBoxJЭТУ2.Text = Convert.ToString(x);
                }
                if ((textBoxВjXjДA4.Text != ""))
                {
                    x = Convert.ToDouble(textBoxJЭТУ2.Text) + Convert.ToDouble(textBoxВjXjДA4.Text);
                    textBoxJЭТУ2.Text = Convert.ToString(x);
                }
                if ((textBoxВjXjДA5.Text != ""))
                {
                    x = Convert.ToDouble(textBoxJЭТУ2.Text) + Convert.ToDouble(textBoxВjXjДA5.Text);
                    textBoxJЭТУ2.Text = Convert.ToString(x);
                }
                textBoxAk.Text = Convert.ToString(Convert.ToDouble(textBoxJЭТУ1.Text) / Convert.ToDouble(textBoxJЭТУ2.Text));
            }
            catch
            {
                MessageBox.Show("Не верно заполнены поля \r\nПроверьте поля ");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToInt32(hoursR1.Text) != 0)
                {
                    dateTimePicker2.Value = dateTimePicker1.Value.AddDays(Convert.ToInt32(hoursR1.Text) - 1);
                }
                else { dateTimePicker2.Value = dateTimePicker1.Value.AddDays(0); dateTimePicker2.Visible = false; }
                dateTimePicker3.Value = dateTimePicker2.Value.AddDays(0);
                if (Convert.ToInt32(hoursP1.Text) != 0)
                {
                    dateTimePicker4.Value = dateTimePicker3.Value.AddDays(Convert.ToInt32(hoursP1.Text) - 1);
                }
                else { dateTimePicker4.Value = dateTimePicker3.Value.AddDays(0); dateTimePicker4.Visible = false; }
                if (dateTimePicker4.Value > dateTimePicker3.Value)
                    dateTimePicker5.Value = dateTimePicker4.Value.AddDays(1);
                else dateTimePicker5.Value = dateTimePicker3.Value.AddDays(1);

                if (Convert.ToInt32(hoursR2.Text) != 0)
                {
                    dateTimePicker6.Value = dateTimePicker5.Value.AddDays(Convert.ToInt32(hoursR2.Text) - 1);
                }
                else { dateTimePicker6.Value = dateTimePicker5.Value.AddDays(0); dateTimePicker6.Visible = false; }
                dateTimePicker7.Value = dateTimePicker5.Value.AddDays(0);
                if (Convert.ToInt32(hoursP2.Text) != 0)
                {
                    dateTimePicker8.Value = dateTimePicker7.Value.AddDays(Convert.ToInt32(hoursP2.Text) - 1);
                }
                else { dateTimePicker8.Value = dateTimePicker7.Value.AddDays(0); dateTimePicker8.Visible = false; }
                if (dateTimePicker8.Value > dateTimePicker7.Value)
                    dateTimePicker9.Value = dateTimePicker8.Value.AddDays(1);
                else dateTimePicker9.Value = dateTimePicker7.Value.AddDays(1);

                if (Convert.ToInt32(hoursR3.Text) != 0)
                {
                    dateTimePicker10.Value = dateTimePicker9.Value.AddDays(Convert.ToInt32(hoursR3.Text) - 1);
                }
                else { dateTimePicker10.Value = dateTimePicker9.Value.AddDays(0); dateTimePicker10.Visible = false; }
                dateTimePicker11.Value = dateTimePicker9.Value.AddDays(0);
                if (Convert.ToInt32(hoursP3.Text) != 0)
                {
                    dateTimePicker12.Value = dateTimePicker11.Value.AddDays(Convert.ToInt32(hoursP3.Text) - 1);
                }
                else { dateTimePicker12.Value = dateTimePicker11.Value.AddDays(0); dateTimePicker12.Visible = false; }
                if (dateTimePicker12.Value > dateTimePicker11.Value) dateTimePicker13.Value = dateTimePicker12.Value.AddDays(1);
                else dateTimePicker13.Value = dateTimePicker11.Value.AddDays(1);

                if (Convert.ToInt32(hoursR4.Text) != 0)
                {
                    dateTimePicker14.Value = dateTimePicker13.Value.AddDays(Convert.ToInt32(hoursR4.Text) - 1);
                }
                else { dateTimePicker14.Value = dateTimePicker13.Value.AddDays(0); dateTimePicker14.Visible = false; }
                dateTimePicker15.Value = dateTimePicker13.Value.AddDays(0);
                if (Convert.ToInt32(hoursP4.Text) != 0)
                {
                    dateTimePicker16.Value = dateTimePicker15.Value.AddDays(Convert.ToInt32(hoursP4.Text) - 1);
                }
                else { dateTimePicker16.Value = dateTimePicker15.Value.AddDays(0); dateTimePicker16.Visible = false; }
                if (dateTimePicker16.Value > dateTimePicker15.Value) dateTimePicker17.Value = dateTimePicker16.Value.AddDays(1);
                else dateTimePicker17.Value = dateTimePicker15.Value.AddDays(1);

                if (Convert.ToInt32(hoursR5.Text) != 0)
                {
                    dateTimePicker18.Value = dateTimePicker17.Value.AddDays(Convert.ToInt32(hoursR5.Text) - 1);
                }
                else { dateTimePicker18.Value = dateTimePicker17.Value.AddDays(0); dateTimePicker18.Visible = false; }
                dateTimePicker19.Value = dateTimePicker17.Value.AddDays(0);
                if (Convert.ToInt32(hoursP5.Text) != 0)
                {
                    dateTimePicker20.Value = dateTimePicker19.Value.AddDays(Convert.ToInt32(hoursP5.Text) - 1);
                }
                else { dateTimePicker20.Value = dateTimePicker19.Value.AddDays(0); dateTimePicker20.Visible = false; }
                if (dateTimePicker20.Value > dateTimePicker19.Value) dateTimePicker21.Value = dateTimePicker20.Value.AddDays(1);
                else dateTimePicker21.Value = dateTimePicker19.Value.AddDays(1);

                if (Convert.ToInt32(hoursR6.Text) != 0)
                {
                    dateTimePicker22.Value = dateTimePicker21.Value.AddDays(Convert.ToInt32(hoursR6.Text) - 1);
                }
                else { dateTimePicker22.Value = dateTimePicker21.Value.AddDays(0); dateTimePicker22.Visible = false; }
                dateTimePicker23.Value = dateTimePicker21.Value.AddDays(0);
                if (Convert.ToInt32(hoursP6.Text) != 0)
                {
                    dateTimePicker24.Value = dateTimePicker23.Value.AddDays(Convert.ToInt32(hoursP6.Text) - 1);
                }
                else { dateTimePicker24.Value = dateTimePicker23.Value.AddDays(0); dateTimePicker24.Visible = false; }
                if (dateTimePicker24.Value > dateTimePicker23.Value) dateTimePicker25.Value = dateTimePicker24.Value.AddDays(1);
                else dateTimePicker25.Value = dateTimePicker23.Value.AddDays(1);

                if (Convert.ToInt32(hoursR7.Text) != 0)
                {
                    dateTimePicker26.Value = dateTimePicker25.Value.AddDays(Convert.ToInt32(hoursR7.Text) - 1);
                }
                else { dateTimePicker26.Value = dateTimePicker25.Value.AddDays(0); dateTimePicker26.Visible = false; }
                dateTimePicker27.Value = dateTimePicker25.Value.AddDays(0);
                if (Convert.ToInt32(hoursP7.Text) != 0)
                {
                    dateTimePicker28.Value = dateTimePicker27.Value.AddDays(Convert.ToInt32(hoursP7.Text) - 1);
                }
                else { dateTimePicker28.Value = dateTimePicker27.Value.AddDays(0); dateTimePicker28.Visible = false; }
                if (dateTimePicker28.Value > dateTimePicker27.Value) dateTimePicker29.Value = dateTimePicker28.Value.AddDays(1);
                else dateTimePicker29.Value = dateTimePicker27.Value.AddDays(1);

                if (Convert.ToInt32(hoursR8.Text) != 0)
                {
                    dateTimePicker30.Value = dateTimePicker29.Value.AddDays(Convert.ToInt32(hoursR8.Text) - 1);
                }
                else { dateTimePicker30.Value = dateTimePicker29.Value.AddDays(0); dateTimePicker30.Visible = false; }
                dateTimePicker31.Value = dateTimePicker29.Value.AddDays(0);
                if (Convert.ToInt32(hoursP8.Text) != 0)
                {
                    dateTimePicker32.Value = dateTimePicker31.Value.AddDays(Convert.ToInt32(hoursP8.Text) - 1);
                }
                else { dateTimePicker32.Value = dateTimePicker31.Value.AddDays(0); dateTimePicker32.Visible = false; }
                if (dateTimePicker32.Value > dateTimePicker31.Value) dateTimePicker33.Value = dateTimePicker32.Value.AddDays(1);
                else dateTimePicker33.Value = dateTimePicker31.Value.AddDays(1);

                if (Convert.ToInt32(hoursR9.Text) != 0)
                {
                    dateTimePicker34.Value = dateTimePicker33.Value.AddDays(Convert.ToInt32(hoursR9.Text) - 1);
                }
                else { dateTimePicker34.Value = dateTimePicker33.Value.AddDays(0); dateTimePicker34.Visible = false; }
                dateTimePicker35.Value = dateTimePicker33.Value.AddDays(0);
                if (Convert.ToInt32(hoursP9.Text) != 0)
                {
                    dateTimePicker36.Value = dateTimePicker35.Value.AddDays(Convert.ToInt32(hoursP9.Text) - 1);
                }
                else { dateTimePicker36.Value = dateTimePicker35.Value.AddDays(0); dateTimePicker36.Visible = false; }
                if (dateTimePicker36.Value > dateTimePicker35.Value) dateTimePicker37.Value = dateTimePicker36.Value.AddDays(1);
                else dateTimePicker37.Value = dateTimePicker35.Value.AddDays(1);

                if (Convert.ToInt32(hoursR10.Text) != 0)
                {
                    dateTimePicker38.Value = dateTimePicker37.Value.AddDays(Convert.ToInt32(hoursR10.Text) - 1);
                }
                else { dateTimePicker38.Value = dateTimePicker37.Value.AddDays(0); dateTimePicker38.Visible = false; }
                dateTimePicker39.Value = dateTimePicker37.Value.AddDays(0);
                if (Convert.ToInt32(hoursP10.Text) != 0)
                {
                    dateTimePicker40.Value = dateTimePicker39.Value.AddDays(Convert.ToInt32(hoursP10.Text) - 1);
                }
                else { dateTimePicker40.Value = dateTimePicker39.Value.AddDays(0); dateTimePicker40.Visible = false; }
                if (dateTimePicker40.Value > dateTimePicker39.Value) dateTimePicker41.Value = dateTimePicker40.Value.AddDays(1);
                else dateTimePicker41.Value = dateTimePicker39.Value.AddDays(1);

                if (Convert.ToInt32(hoursR11.Text) != 0)
                {
                    dateTimePicker42.Value = dateTimePicker41.Value.AddDays(Convert.ToInt32(hoursR11.Text) - 1);
                }
                else { dateTimePicker42.Value = dateTimePicker41.Value.AddDays(0); dateTimePicker42.Visible = false; }
                dateTimePicker43.Value = dateTimePicker41.Value.AddDays(0);
                if (Convert.ToInt32(hoursP11.Text) != 0)
                {
                    dateTimePicker44.Value = dateTimePicker43.Value.AddDays(Convert.ToInt32(hoursP11.Text) - 1);
                }
                else { dateTimePicker44.Value = dateTimePicker43.Value.AddDays(0); dateTimePicker44.Visible = false; }
                if (dateTimePicker44.Value > dateTimePicker43.Value) dateTimePicker45.Value = dateTimePicker44.Value.AddDays(1);
                else dateTimePicker45.Value = dateTimePicker43.Value.AddDays(1);

                if (Convert.ToInt32(hoursR12.Text) != 0)
                {
                    dateTimePicker46.Value = dateTimePicker45.Value.AddDays(Convert.ToInt32(hoursR12.Text) - 1);
                }
                else { dateTimePicker46.Value = dateTimePicker45.Value.AddDays(0); dateTimePicker46.Visible = false; }
                dateTimePicker47.Value = dateTimePicker45.Value.AddDays(0);
                if (Convert.ToInt32(hoursP12.Text) != 0)
                {
                    dateTimePicker48.Value = dateTimePicker47.Value.AddDays(Convert.ToInt32(hoursP12.Text) - 1);
                }
                else { dateTimePicker48.Value = dateTimePicker47.Value.AddDays(0); dateTimePicker48.Visible = false; }
                if (dateTimePicker48.Value > dateTimePicker47.Value) dateTimePicker49.Value = dateTimePicker48.Value.AddDays(1);
                else dateTimePicker49.Value = dateTimePicker47.Value.AddDays(1);

                if (Convert.ToInt32(hoursR13.Text) != 0)
                {
                    dateTimePicker50.Value = dateTimePicker49.Value.AddDays(Convert.ToInt32(hoursR13.Text) - 1);
                }
                else { dateTimePicker50.Value = dateTimePicker49.Value.AddDays(0); dateTimePicker50.Visible = false; }
                dateTimePicker51.Value = dateTimePicker49.Value.AddDays(0);
                if (Convert.ToInt32(hoursP13.Text) != 0)
                {
                    dateTimePicker52.Value = dateTimePicker51.Value.AddDays(Convert.ToInt32(hoursP13.Text) - 1);
                }
                else { dateTimePicker52.Value = dateTimePicker51.Value.AddDays(0); dateTimePicker52.Visible = false; }
                if (dateTimePicker52.Value > dateTimePicker51.Value) dateTimePicker53.Value = dateTimePicker52.Value.AddDays(1);
                else dateTimePicker53.Value = dateTimePicker51.Value.AddDays(1);

                if (Convert.ToInt32(hoursR14.Text) != 0)
                {
                    dateTimePicker54.Value = dateTimePicker53.Value.AddDays(Convert.ToInt32(hoursR14.Text) - 1);
                }
                else { dateTimePicker54.Value = dateTimePicker53.Value.AddDays(0); dateTimePicker54.Visible = false; }
                dateTimePicker55.Value = dateTimePicker53.Value.AddDays(0);
                if (Convert.ToInt32(hoursP14.Text) != 0)
                {
                    dateTimePicker56.Value = dateTimePicker55.Value.AddDays(Convert.ToInt32(hoursP14.Text) - 1);
                }
                else { dateTimePicker56.Value = dateTimePicker55.Value.AddDays(0); dateTimePicker56.Visible = false; }
                if (dateTimePicker56.Value > dateTimePicker55.Value) dateTimePicker57.Value = dateTimePicker56.Value.AddDays(1);
                else dateTimePicker57.Value = dateTimePicker55.Value.AddDays(1);

                if (Convert.ToInt32(hoursR15.Text) != 0)
                {
                    dateTimePicker58.Value = dateTimePicker57.Value.AddDays(Convert.ToInt32(hoursR15.Text) - 1);
                }
                else { dateTimePicker58.Value = dateTimePicker57.Value.AddDays(0); dateTimePicker58.Visible = false; }
                dateTimePicker59.Value = dateTimePicker57.Value.AddDays(0);
                if (Convert.ToInt32(hoursP15.Text) != 0)
                {
                    dateTimePicker60.Value = dateTimePicker59.Value.AddDays(Convert.ToInt32(hoursP15.Text) - 1);
                }
                else { dateTimePicker60.Value = dateTimePicker59.Value.AddDays(0); dateTimePicker60.Visible = false; }
                if (dateTimePicker60.Value > dateTimePicker59.Value) dateTimePicker61.Value = dateTimePicker60.Value.AddDays(1);
                else dateTimePicker61.Value = dateTimePicker59.Value.AddDays(1);

                if (Convert.ToInt32(hoursR16.Text) != 0)
                {
                    dateTimePicker62.Value = dateTimePicker61.Value.AddDays(Convert.ToInt32(hoursR16.Text) - 1);
                }
                else { dateTimePicker62.Value = dateTimePicker61.Value.AddDays(0); dateTimePicker62.Visible = false; }
                dateTimePicker63.Value = dateTimePicker61.Value.AddDays(0);
                if (Convert.ToInt32(hoursP16.Text) != 0)
                {
                    dateTimePicker64.Value = dateTimePicker63.Value.AddDays(Convert.ToInt32(hoursP16.Text) - 1);
                }
                else { dateTimePicker64.Value = dateTimePicker63.Value.AddDays(0); dateTimePicker64.Visible = false; }
                if (dateTimePicker64.Value > dateTimePicker63.Value) dateTimePicker65.Value = dateTimePicker64.Value.AddDays(1);
                else dateTimePicker65.Value = dateTimePicker63.Value.AddDays(1);

                if (Convert.ToInt32(hoursR17.Text) != 0)
                {
                    dateTimePicker66.Value = dateTimePicker65.Value.AddDays(Convert.ToInt32(hoursR17.Text) - 1);
                }
                else { dateTimePicker66.Value = dateTimePicker65.Value.AddDays(0); dateTimePicker66.Visible = false; }
                dateTimePicker67.Value = dateTimePicker65.Value.AddDays(0);
                if (Convert.ToInt32(hoursP17.Text) != 0)
                {
                    dateTimePicker68.Value = dateTimePicker67.Value.AddDays(Convert.ToInt32(hoursP17.Text) - 1);
                }
                else { dateTimePicker68.Value = dateTimePicker67.Value.AddDays(0); dateTimePicker68.Visible = false; }
            }
            catch
            {
                MessageBox.Show("Не заполнено поле Длительность, дни\r\nВ данном окне поля длительности - целочисленного формата\r\nПроверьте поля ");
            }

            try
            {
                kolvoRykov.Text = Convert.ToString(Convert.ToInt32(hoursR1.Text) + Convert.ToInt32(hoursR2.Text) + Convert.ToInt32(hoursR3.Text) +
                    Convert.ToInt32(hoursR4.Text) + Convert.ToInt32(hoursR5.Text) + Convert.ToInt32(hoursR6.Text) + Convert.ToInt32(hoursR7.Text) +
                    Convert.ToInt32(hoursR8.Text) + Convert.ToInt32(hoursR9.Text) + Convert.ToInt32(hoursR10.Text) + Convert.ToInt32(hoursR11.Text) +
                    Convert.ToInt32(hoursR12.Text) + Convert.ToInt32(hoursR13.Text) + Convert.ToInt32(hoursR14.Text) + Convert.ToInt32(hoursR15.Text) +
                    Convert.ToInt32(hoursR16.Text) + Convert.ToInt32(hoursR17.Text));
                kolvoProgr.Text = Convert.ToString(Convert.ToInt32(hoursP1.Text) + Convert.ToInt32(hoursP2.Text) + Convert.ToInt32(hoursP3.Text) +
                    Convert.ToInt32(hoursP4.Text) + Convert.ToInt32(hoursP5.Text) + Convert.ToInt32(hoursP6.Text) + Convert.ToInt32(hoursP7.Text) +
                    Convert.ToInt32(hoursP8.Text) + Convert.ToInt32(hoursP9.Text) + Convert.ToInt32(hoursP10.Text) + Convert.ToInt32(hoursP11.Text) +
                    Convert.ToInt32(hoursP12.Text) + Convert.ToInt32(hoursP13.Text) + Convert.ToInt32(hoursP14.Text) + Convert.ToInt32(hoursP15.Text) +
                    Convert.ToInt32(hoursP16.Text) + Convert.ToInt32(hoursP17.Text));
                if (Convert.ToInt32(kolvoRykov.Text) > Convert.ToInt32(kolvoProgr.Text)) { kolvoobsh.Text = kolvoRykov.Text; }
                else { kolvoobsh.Text = kolvoProgr.Text; }
            }
            catch
            {
            }

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void label49_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                double cell1 = Math.Truncate(Convert.ToDouble(textBox1.Text)) ;
                double cell2 = Math.Truncate(Convert.ToDouble(textBox2.Text));
                if ((cell1 == Convert.ToDouble(textBox1.Text)) && (cell2 == Convert.ToDouble(textBox2.Text)))
                {
                    if ((Convert.ToInt32(textBox1.Text)<32) && (Convert.ToInt32(textBox1.Text))<32)
                    {
                        kolvoRykov1.Text = kolvoRykov.Text;


                        kolvoProgr1.Text = kolvoProgr.Text;

                        zpRyk.Text = (Convert.ToDouble(okladRykBox.Text) / Convert.ToInt32(textBox1.Text)).ToString("#.##");

                        zpProg.Text = (Convert.ToDouble(okladProgBox.Text) / Convert.ToInt32(textBox2.Text)).ToString("#.##");
                        OZPRyk.Text = (Convert.ToDouble(zpRyk.Text) * Convert.ToDouble(kolvoRykov1.Text)).ToString("#.##");

                        OZPProg.Text = (Convert.ToDouble(zpProg.Text) * Convert.ToDouble(kolvoProgr1.Text)).ToString("#.##");

                        OZPsum.Text = (Convert.ToDouble(OZPRyk.Text) + Convert.ToDouble(OZPProg.Text)).ToString("#.##");
                        
                        osnZP.Text = OZPsum.Text;
                        dataGridView1.Visible = true;
                        button4.Visible = true;
                        button3.Visible = true;
                    }
                    else MessageBox.Show("В месяце 30-31 день.");
                }
                else MessageBox.Show("Количество дней - целое число.");
            }
            catch { MessageBox.Show("Пропущены обязательные к заполнению поля. \r\nВозможно, вы пропустили вкладку.\r\nВозможно, вы введи данные в неверном формате, проверьте."); }
        }

        private void button4_Click(object sender, EventArgs e)
        {


            dataGridView1.RowCount = 4;
            dataGridView1[0, 0].Value = "Тетрадь общая";
            dataGridView1[0, 1].Value = "Компакт-диск CD-RW";
            dataGridView1[0, 2].Value = "Тонер для лазерного принтера";
            dataGridView1[0, 3].Value = "Бумага офисная";
            dataGridView1[1, 0].Value = "шт.";
            dataGridView1[1, 1].Value = "шт.";
            dataGridView1[1, 2].Value = "шт.";
            dataGridView1[1, 3].Value = "пачка";
            dataGridView1[2, 0].Value = 1;
            dataGridView1[2, 1].Value = 2;
            dataGridView1[2, 2].Value = 1;
            dataGridView1[2, 3].Value = 1;
            dataGridView1[3, 0].Value = 10;
            dataGridView1[3, 1].Value = 35;
            dataGridView1[3, 2].Value = 1000;
            dataGridView1[3, 3].Value = 120;

            //button4.Visible = true;
        }
        double itog;
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                itog = 0;
                int n = dataGridView1.RowCount;
                if (n > 0)
                {
                    double[] k = new double[n];//требуемое количество
                    double[] z = new double[n];//цена за единицу продукции
                    double[] s = new double[n];//сумма


                    for (int i = 0; i < n; i++)
                    {
                        k[i] = Convert.ToDouble(dataGridView1[2, i].Value);
                        z[i] = Convert.ToDouble(dataGridView1[3, i].Value);
                        s[i] = k[i] * z[i];
                        itog = itog + s[i];
                        dataGridView1[4, i].Value = (s[i]).ToString("#.##");

                    }

                    MATsum.Text = itog.ToString("#.##");
                    ZatrMash.Text = MATsum.Text;
                    panel1.Visible = true;
                    label106.Text = OZPsum.Text;
                }
                else MessageBox.Show("Введите данные в таблицу");
            }
            catch { MessageBox.Show("Проверьте правильность заполнения полей"); }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                tmv = Convert.ToDouble(tbtmv.Text) * Convert.ToDouble(kolvoobsh.Text);
                Smc = Convert.ToDouble(tbSmc.Text);
                Km = Convert.ToDouble(tbKm.Text);
                Mv = tmv * Smc * Km;
                Mb.Text = Mv.ToString("#.##");

                button5.Visible = true;
            }
            catch { MessageBox.Show("Проверьте правильность заполнения полей"); }
        }

        private void kolvoobsh_Click(object sender, EventArgs e)
        {

        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                tmv = Convert.ToDouble(tbtmv.Text) * Convert.ToDouble(kolvoobsh.Text);
                Smc = Convert.ToDouble(tbSmc.Text);
                Km = Convert.ToDouble(tbKm.Text);
                Mv = tmv * Smc * Km;
                Mb.Text = Mv.ToString("#.##");

                button5.Visible = true;
            }
            catch { MessageBox.Show("Проверьте правильность заполнения полей блока: Затраты машинного времени"); }
            try
            {
                double Wd, Wc, Wn, Kpwd, Kpwc, Kpwn;
                string Kp;
                Wd = Convert.ToDouble(tbWd.Text);
                Wc = Convert.ToDouble(tbWc.Text);
                Wn = Convert.ToDouble(tbWn.Text);
                Kpwd = Convert.ToDouble(OZPsum.Text) * Wd; //дополнительная ЗП
                Kpwc = (Kpwd + Convert.ToDouble(OZPsum.Text)) * Wc; //социальные нужды
                Kpwn = Convert.ToDouble(OZPsum.Text) * Wn; //накладные расходы
                Kp = (Convert.ToDouble(OZPsum.Text) + Kpwd + Kpwc + itog + Mv + Kpwn).ToString("#.##"); //итоговые расходы организации

                osnZP.Text = Convert.ToDouble(OZPsum.Text).ToString("#.##");
                DopZP.Text = Kpwd.ToString("#.##");
                otchSOC.Text = Kpwc.ToString("#.##");
                ZatrMAT.Text = itog.ToString("#.##");
                ZatrMash.Text = Mv.ToString("#.##");
                naklRash.Text = Kpwn.ToString("#.##");
                itog = Convert.ToDouble(osnZP.Text) + Convert.ToDouble(DopZP.Text) + Convert.ToDouble(otchSOC.Text) +
                    Convert.ToDouble(ZatrMAT.Text) + Convert.ToDouble(ZatrMash.Text) + Convert.ToDouble(naklRash.Text);
                zatrRazr.Text = itog.ToString("#.##");
            }
            catch { MessageBox.Show("Проверьте правильность заполнения полей блока: Ввод коэффициентов и расчет машинного времени"); }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int n = Convert.ToInt32(comboBox1.Text);

            dgvStoim.RowCount = n;
            DgvY.RowCount = n;

            for (int i = 1; i <= n; i++)
            {
                dgvStoim[0, i - 1].Value = i;
                DgvY[0, i - 1].Value = i;
            }
        }
        double stoim = 0, Y = 0, K = 0;
        //придется задать общими переменные, чтобы затем передать дальше
        private void button8_Click(object sender, EventArgs e)
        {
           try
            {
                stoim = 0;
                K = 0;
                Y = 0;
                lbKo.Text = "";
                lbItog.Text = "";
                lbY.Text = "";
                int n = dgvStoim.RowCount;


                for (int i = 0; i < n; i++)
                {
                    if (Convert.ToDouble(DgvY[2, i].Value) < 367)
                {
                    if (Convert.ToDouble(DgvY[4, i].Value) < 367)
                {
                    stoim = stoim + Convert.ToDouble(dgvStoim[1, i].Value) * Convert.ToDouble(dgvStoim[2, i].Value);//считаем итоговую стоимость оборудования и записываем
                    DgvY[3, i].Value = Convert.ToString(Convert.ToDouble(dgvStoim[1, i].Value) * Convert.ToDouble(dgvStoim[2, i].Value));
                    Y = Y + Convert.ToDouble(DgvY[1, i].Value) * Convert.ToDouble(DgvY[2, i].Value) / (Convert.ToDouble(DgvY[3, i].Value) * Convert.ToDouble(DgvY[4, i].Value));//сразу рассчитываем коэффициент загрузки оборудования в целом
                }
                    else MessageBox.Show("Частота решений имеется дней в году.");
                }
                else MessageBox.Show("В году 365 дней, если год високосный - 366 дней.");
                }

                K = stoim * Y * n;
                if (K > 1)
                {
                    MessageBox.Show("Затраты на основное и вспомогательное оборудование составят: " + K.ToString("#.##")+ " руб.");
                }
                else MessageBox.Show("Затраты на основное и вспомогательное оборудование составят: 0" + K.ToString("#.##") + " руб.");
                if (K > 1) lbKo.Text = K.ToString("#.##"); else lbKo.Text ="0" + K.ToString("#.##");
                lbItog.Text = stoim.ToString("#.##"); //тут стоимость оборудования
                lbY.Text = Convert.ToString(Y);
            
          }
         catch { MessageBox.Show("Проверьте корректность заполнения полей"); }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            int n = Convert.ToInt32(comboBox2.Text);

            dgvZP.RowCount = n;
            dgvZPA.RowCount = n;

            dgvZP[0, 0].Value = "Сотрудник отдела МТС";
            dgvZP[0, 1].Value = "Программист";

            dgvZPA[0, 0].Value = "Сотрудник отдела МТС";
            dgvZPA[0, 1].Value = "Программист";
        }

        private void button9_Click(object sender, EventArgs e)
        {
           
        }

        private void button9_Click_1(object sender, EventArgs e)
        {
          try
          {
                int n = dgvZP.RowCount;
                double ZP = 0, ZPA = 0, Wc = Convert.ToDouble(tbxWc.Text), Wd = Convert.ToDouble(tbxWd.Text);
                if (n != Convert.ToInt32(comboBox2.Text))
                {
                    dgvZP.RowCount = n - 1;
                    dgvZPA.RowCount = n - 1;
                    n--;
                    for (int i = 0; i < n; i++)
                    {
                        if (((Convert.ToDouble(dgvZPA[3, i].Value)) < 367) && ((Convert.ToDouble(dgvZP[3, i].Value)) < 367))
                        {
                            //рассчитываем первую таблицу с ЗП
                            dgvZP[2, i].Value = (Convert.ToDouble(dgvZP[1, i].Value) / (Convert.ToInt32(textBox4.Text))).ToString("#.##");//.ToString("#.##");
                            dgvZP[4, i].Value = (Convert.ToDouble(dgvZP[2, i].Value) * Convert.ToDouble(dgvZP[3, i].Value) * (1 + Wd) * (1 + Wc)).ToString("#.##");//.ToString("#.##");
                            ZP = ZP + Convert.ToDouble(dgvZP[4, i].Value);
                            //рассчитываем вторую таблицу с ЗП
                            dgvZPA[2, i].Value = (Convert.ToDouble(dgvZPA[1, i].Value) / (Convert.ToInt32(textBox3.Text))).ToString("#.##"); //.ToString("#.##");
                            dgvZPA[4, i].Value = (Convert.ToDouble(dgvZPA[2, i].Value) * Convert.ToDouble(dgvZPA[3, i].Value) * (1 + Wd) * (1 + Wc)).ToString("#.##"); ;//.ToString("#.##");
                            ZPA = ZPA + Convert.ToDouble(dgvZPA[4, i].Value);
                        }
                        else MessageBox.Show("Затраты времени на эксплуатацию измеряются в днях в году.");
                    }
                    dgvZP.RowCount = n + 1;
                    dgvZPA.RowCount = n + 1;

                    dgvZP[0, n].Value = "Итог";
                    dgvZP[4, n].Value = ZP;
                    dgvZPA[0, n].Value = "Итог";
                    dgvZPA[4, n].Value = ZPA;



                    //"Основная и дополнительная заработная плата с отчислениями";
                    label140.Text = Convert.ToString(dgvZP[4, n].Value);
                    label150.Text = Convert.ToString(dgvZPA[4, n].Value);
                    //Convert.ToDouble(dgvStoim[2, i].Value)

                    for (int i = 0; i < Convert.ToInt32(comboBox1.Text); i++)//количество оборудования (типов)
                    {//"Амортизационные отчисления";
                        double d = Convert.ToDouble(dgvStoim[1, i].Value);
                        for (int j = 0; j < d; j++)
                        {
                            label139.Text = ((Convert.ToDouble(dgvStoim[2, i].Value) * Convert.ToDouble(textBox5.Text) * Convert.ToDouble(textBox7.Text) * ((Convert.ToDouble(dgvZP[3, 0].Value) + Convert.ToDouble(dgvZP[3, 1].Value)) * Convert.ToDouble(hours.Text))) / (Convert.ToDouble(kolvoobsh.Text) * Convert.ToDouble(hours.Text))).ToString("#.##");

                            label147.Text = ((Convert.ToDouble(dgvStoim[2, i].Value) * Convert.ToDouble(textBox5.Text) * Convert.ToDouble(textBox7.Text) * ((Convert.ToDouble(dgvZPA[3, 0].Value) + Convert.ToDouble(dgvZPA[3, 1].Value)) * Convert.ToDouble(hoursa.Text))) / (Convert.ToDouble(kolvoobsh.Text) * Convert.ToDouble(hours.Text))).ToString("#.##");
                            //"Затраты на текущий ремонт";
                            label137.Text = ((Convert.ToDouble(textBox12.Text) * Convert.ToDouble(dgvStoim[2, i].Value) * ((Convert.ToDouble(dgvZP[3, 0].Value) + Convert.ToDouble(dgvZP[3, 1].Value)) * Convert.ToDouble(hours.Text))) / (Convert.ToDouble(kolvoobsh.Text) * Convert.ToDouble(hours.Text))).ToString("#.##");
                            label145.Text = ((Convert.ToDouble(textBox12.Text) * Convert.ToDouble(dgvStoim[2, i].Value) * ((Convert.ToDouble(dgvZPA[3, 0].Value) + Convert.ToDouble(dgvZPA[3, 1].Value)) * Convert.ToDouble(hours.Text))) / (Convert.ToDouble(kolvoobsh.Text) * Convert.ToDouble(hoursa.Text))).ToString("#.##");
                            // "Затраты на материалы";
                            label136.Text = (Convert.ToDouble(dgvStoim[2, i].Value) * Convert.ToDouble(textBox13.Text)).ToString("#.##");
                            label144.Text = (Convert.ToDouble(dgvStoim[2, i].Value) * Convert.ToDouble(textBox13.Text)).ToString("#.##");
                        }
                    }
//"Затраты на электроэнергию";
                    label138.Text = (Convert.ToDouble(textBox10.Text) * Convert.ToDouble(textBox7.Text) * ((Convert.ToDouble(dgvZP[3, 0].Value) + Convert.ToDouble(dgvZP[3, 1].Value)) * Convert.ToDouble(hours.Text)) * Convert.ToDouble(textBox9.Text)).ToString("#.##");
                    label146.Text = (Convert.ToDouble(textBox10.Text) * Convert.ToDouble(textBox7.Text) * ((Convert.ToDouble(dgvZPA[3, 0].Value) + Convert.ToDouble(dgvZPA[3, 1].Value)) * Convert.ToDouble(hoursa.Text)) * Convert.ToDouble(textBox9.Text)).ToString("#.##");
                    //"Накладные расходы ";
                    label149.Text = ((Convert.ToDouble(label140.Text) + Convert.ToDouble(label139.Text) + Convert.ToDouble(label138.Text) +
                        Convert.ToDouble(label137.Text) + Convert.ToDouble(label136.Text)) *Convert.ToDouble(textBox11.Text)).ToString("#.##");
                    label143.Text = ((Convert.ToDouble(label150.Text) + Convert.ToDouble(label147.Text) + Convert.ToDouble(label146.Text) +
                        Convert.ToDouble(label145.Text) + Convert.ToDouble(label144.Text)) * Convert.ToDouble(textBox11.Text)).ToString("#.##");
                    //"ИТОГО";
                    label148.Text = (Convert.ToDouble(label140.Text) + Convert.ToDouble(label139.Text) + Convert.ToDouble(label138.Text) +
                        Convert.ToDouble(label137.Text) + Convert.ToDouble(label136.Text) + Convert.ToDouble(label149.Text)).ToString("#.##");
                    label142.Text = (Convert.ToDouble(label150.Text) + Convert.ToDouble(label147.Text) + Convert.ToDouble(label146.Text) +
                        Convert.ToDouble(label145.Text) + Convert.ToDouble(label144.Text) + Convert.ToDouble(label143.Text)).ToString("#.##");
           
                    
                }
                for (int i = 0; i < n; i++)
                {
                    if (((Convert.ToDouble(dgvZPA[3, i].Value)) < 367) && ((Convert.ToDouble(dgvZP[3, i].Value)) < 367))
                    {
                        //рассчитываем первую таблицу с ЗП
                        dgvZP[2, i].Value = (Convert.ToDouble(dgvZP[1, i].Value) / (Convert.ToInt32(textBox4.Text))).ToString("#.##");//.ToString("#.##");
                        dgvZP[4, i].Value = (Convert.ToDouble(dgvZP[2, i].Value) * Convert.ToDouble(dgvZP[3, i].Value) * (1 + Wd) * (1 + Wc)).ToString("#.##");//.ToString("#.##");
                        ZP = ZP + Convert.ToDouble(dgvZP[4, i].Value);
                        //рассчитываем вторую таблицу с ЗП
                        dgvZPA[2, i].Value = (Convert.ToDouble(dgvZPA[1, i].Value) / (Convert.ToInt32(textBox3.Text))).ToString("#.##"); //.ToString("#.##");
                        dgvZPA[4, i].Value = (Convert.ToDouble(dgvZPA[2, i].Value) * Convert.ToDouble(dgvZPA[3, i].Value) * (1 + Wd) * (1 + Wc)).ToString("#.##"); ;//.ToString("#.##");
                        ZPA = ZPA + Convert.ToDouble(dgvZPA[4, i].Value);
                    }
                    else MessageBox.Show("Затраты времени на эксплуатацию измеряются в днях в году.");
                }
                dgvZP.RowCount = n + 1;
                dgvZPA.RowCount = n + 1;

                dgvZP[0, n].Value = "Итог";
                dgvZP[4, n].Value = ZP;
                dgvZPA[0, n].Value = "Итог";
                dgvZPA[4, n].Value = ZPA;



                //"Основная и дополнительная заработная плата с отчислениями";
                label140.Text = Convert.ToString(dgvZP[4, n].Value);
                label150.Text = Convert.ToString(dgvZPA[4, n].Value);
                //Convert.ToDouble(dgvStoim[2, i].Value)

                for (int i = 0; i < Convert.ToInt32(comboBox1.Text); i++)//количество оборудования (типов)
                {//"Амортизационные отчисления";
                    double d = Convert.ToDouble(dgvStoim[1, i].Value);
                    for (int j = 0; j < d; j++)
                    {
                        label139.Text = ((Convert.ToDouble(dgvStoim[2, i].Value) * Convert.ToDouble(textBox5.Text) * Convert.ToDouble(textBox7.Text) * ((Convert.ToDouble(dgvZP[3, 0].Value) + Convert.ToDouble(dgvZP[3, 1].Value)) * Convert.ToDouble(hours.Text))) / (Convert.ToDouble(kolvoobsh.Text) * Convert.ToDouble(hours.Text))).ToString("#.##");

                        label147.Text = ((Convert.ToDouble(dgvStoim[2, i].Value) * Convert.ToDouble(textBox5.Text) * Convert.ToDouble(textBox7.Text) * ((Convert.ToDouble(dgvZPA[3, 0].Value) + Convert.ToDouble(dgvZPA[3, 1].Value)) * Convert.ToDouble(hoursa.Text))) / (Convert.ToDouble(kolvoobsh.Text) * Convert.ToDouble(hours.Text))).ToString("#.##");
                        //"Затраты на текущий ремонт";
                        label137.Text = ((Convert.ToDouble(textBox12.Text) * Convert.ToDouble(dgvStoim[2, i].Value) * ((Convert.ToDouble(dgvZP[3, 0].Value) + Convert.ToDouble(dgvZP[3, 1].Value)) * Convert.ToDouble(hours.Text))) / (Convert.ToDouble(kolvoobsh.Text) * Convert.ToDouble(hours.Text))).ToString("#.##");
                        label145.Text = ((Convert.ToDouble(textBox12.Text) * Convert.ToDouble(dgvStoim[2, i].Value) * ((Convert.ToDouble(dgvZPA[3, 0].Value) + Convert.ToDouble(dgvZPA[3, 1].Value)) * Convert.ToDouble(hoursa.Text))) / (Convert.ToDouble(kolvoobsh.Text) * Convert.ToDouble(hours.Text))).ToString("#.##");
                        // "Затраты на материалы";
                        label136.Text = (Convert.ToDouble(dgvStoim[2, i].Value) * Convert.ToDouble(textBox13.Text)).ToString("#.##");
                        label144.Text = (Convert.ToDouble(dgvStoim[2, i].Value) * Convert.ToDouble(textBox13.Text)).ToString("#.##");
                    }
                }
                //"Затраты на электроэнергию";
                label138.Text = (Convert.ToDouble(textBox10.Text) * Convert.ToDouble(textBox7.Text) * ((Convert.ToDouble(dgvZP[3, 0].Value) + Convert.ToDouble(dgvZP[3, 1].Value)) * Convert.ToDouble(hours.Text)) * Convert.ToDouble(textBox9.Text)).ToString("#.##");
                label146.Text = (Convert.ToDouble(textBox10.Text) * Convert.ToDouble(textBox7.Text) * ((Convert.ToDouble(dgvZPA[3, 0].Value) + Convert.ToDouble(dgvZPA[3, 1].Value)) * Convert.ToDouble(hoursa.Text)) * Convert.ToDouble(textBox9.Text)).ToString("#.##");
                //"Накладные расходы ";
                label149.Text = ((Convert.ToDouble(label140.Text) + Convert.ToDouble(label139.Text) + Convert.ToDouble(label138.Text) +
                    Convert.ToDouble(label137.Text) + Convert.ToDouble(label136.Text)) * Convert.ToDouble(textBox11.Text)).ToString("#.##");
                label143.Text = ((Convert.ToDouble(label150.Text) + Convert.ToDouble(label147.Text) + Convert.ToDouble(label146.Text) +
                    Convert.ToDouble(label145.Text) + Convert.ToDouble(label144.Text)) * Convert.ToDouble(textBox11.Text)).ToString("#.##");
                //"ИТОГО";
                label148.Text = (Convert.ToDouble(label140.Text) + Convert.ToDouble(label139.Text) + Convert.ToDouble(label138.Text) +
                    Convert.ToDouble(label137.Text) + Convert.ToDouble(label136.Text) + Convert.ToDouble(label149.Text)).ToString("#.##");
                label142.Text = (Convert.ToDouble(label150.Text) + Convert.ToDouble(label147.Text) + Convert.ToDouble(label146.Text) +
                    Convert.ToDouble(label145.Text) + Convert.ToDouble(label144.Text) + Convert.ToDouble(label143.Text)).ToString("#.##");
               }
          catch { MessageBox.Show("Проверьте правильность заполнения полей\r\nПроверьте предыдущие вкладки на заполненность ячеек"); }
        }

        private void label140_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
           try
            {
                label160.Text = label142.Text;
                label161.Text = label148.Text;
                //затраты на приобретение программного продукта (37300 руб.);
                //затраты по оплате услуг на установку и сопровождение продукта (12000
                // затраты на основное и вспомогательное оборудование - stoim
                //затраты на подготовку пользователя - 9000 ryb
                label162.Text = (Convert.ToDouble(soimPRIOB.Text) + Convert.ToDouble(stoimOPLYSLYG.Text) + stoim +
                    Convert.ToDouble(stoimPODG.Text)).ToString("#.##");

                label163.Text = (Convert.ToDouble(zatrRazr.Text) + ((stoim * Convert.ToDouble(textBox7.Text) * Convert.ToDouble(textBox6.Text) * Convert.ToDouble(kolvoobsh.Text)) / (Convert.ToDouble(kolvoobsh.Text) * Convert.ToDouble(hours.Text)))).ToString("#.##");
                label164.Text = (Convert.ToDouble(label160.Text) + Convert.ToDouble(textBox14.Text) * Convert.ToDouble(label162.Text)).ToString("#.##");
                label165.Text = (Convert.ToDouble(label161.Text) + Convert.ToDouble(textBox14.Text) * Convert.ToDouble(label163.Text)).ToString("#.##");
                label166.Text = (Convert.ToDouble(label164.Text) * Convert.ToDouble(textBoxAk.Text) - (Convert.ToDouble(label165.Text))).ToString("#.##");
          }
          catch { MessageBox.Show("Проверьте правильность заполнения полей\r\nПроверьте предыдущие вкладки на заполненность ячеек"); }
        }

        private void button10_Click(object sender, EventArgs e)
        {
          //  try
         //   {
                label175.Text = label163.Text;
                label176.Text = label161.Text;
                label177.Text = label166.Text;
                label178.Text = (1 / Convert.ToDouble(label179.Text)).ToString("#.##");
                label179.Text = (Convert.ToDouble(label175.Text) / Convert.ToDouble(label177.Text)).ToString("#.##");
                if (Convert.ToDouble(label179.Text) < 0)
                {
                    label179.Text = "0" + label179.Text;
                }
          //  }
         //   catch { MessageBox.Show("Проверьте правильность заполнения полей\r\nПроверьте предыдущие вкладки на заполненность ячеек"); }
        
        }

        private void button11_Click(object sender, EventArgs e)
        {
           

            dgvZP.RowCount = 2;
            dgvZPA.RowCount = 2;

        
            dgvZP[1, 0].Value = "15000";
            dgvZP[3, 0].Value = "40";
          
            dgvZP[1, 1].Value = "10000";
            dgvZP[3, 1].Value = "20";

            dgvZPA[1, 0].Value = "15000";
            dgvZPA[3, 0].Value = "60";
     
            dgvZPA[1, 1].Value = "10000";
            dgvZPA[3, 1].Value = "40";

            
           
          
        }

        private void button11_Click_1(object sender, EventArgs e)
        {
            About newfrm = new About();
            newfrm.Show();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Process.Start("https://yadi.sk/i/kWAraAMvzyOpOA");
        }
        
        
    }
}
