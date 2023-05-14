using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Diagnostics;

using System.Data.Linq;
using System.Windows.Documents;

namespace TiMP_CourseWork
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        internal InitValues InitValues
        {
            get => default;
            set
            {
            }
        }

        internal OutValues OutValues
        {
            get => default;
            set
            {
            }
        }

        DataTable table = new DataTable();
        //table.Columns.Add(" ", typeof(string));
        private void Form1_Load(object sender, EventArgs e)
        {
            if(firstCoeftb.CanFocus)
                firstCoeftb.Focus();
        }

        private async void executebtn_Click(object sender, EventArgs e)
        {
            //Формирование таблицы для отображения результатов 
            table.Columns.Clear();
            table.Rows.Clear();
            table.Columns.Add("Время (мс)", typeof(string));
            table.Columns.Add("Значение X", typeof(string));
            table.Columns.Add("Значение Y", typeof(string));
            table.Columns.Add("Значение Z", typeof(string));
            //Начальные условия
            double x0, xf, y0, z0, h;
            //Cтрочные переменнные для коэффициентов
            string sc1, sc2, sc3, sc4;
            //Численные переменнные для коэффициентов
            double c1, c2, c3, c4;
            c4 = 0;
            c1 = 1;
            //Показатели наличия аргумента в членах функции
            bool[] xcount = new bool[2];
            xcount[0] = false; xcount[1] = false;
            //Коэффициенты для расчета приращения производной функции
            double k1, k2, k3, k4;
            //Коэффициенты для расчета приращения самой функции
            double q1, q2, q3, q4;

            try
            {
                x0 = Convert.ToDouble(intervaltb1.Text);
                y0 = Convert.ToDouble(zeroYtb1.Text);
                z0 = Convert.ToDouble(zeroZtb.Text);
                xf = Convert.ToDouble(intervaltb2.Text);
                h = Convert.ToDouble(steptb.Text);
                sc1 = firstCoeftb.Text;
                sc2 = secondCoeftb.Text;
                sc3 = thirdCoeftb.Text;
                sc4 = freeCoeftb.Text;

                //В старшем коэффициенте не может быть x
                //Или положим старший коэффициент всегда 1 (нет не положим)
                if (sc1 == null)
                    c1 = 1;
                else if (sc1.Contains('-')&&sc1.Length==1)
                    c1 = -1;
                else if (sc1.Contains('x'))
                    MessageBox.Show("Вы неверно ввели начальные условия\r\nСтарший коэффициент не должен содержать переменные", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                /*else if (sc1.Contains('x') && sc1.Length > 1)
                {
                    c1 = Convert.ToInt32(sc1.Split('x')[0]);
                    x1 = true;
                    //if (c1 == 0 && x1) { c1 = 1; }
                }*/
                else { c1 = Convert.ToInt32(sc1); }
                
                //ВтороЙ коэффициент может содержать X
                if (sc2 == null)
                    c2 = 1;
                else if (sc2.Contains('-') && sc2.Length == 1)
                    c2 = -1;
                else if (sc2.Contains('x') && sc2.Length > 1 && !sc2.Contains('-'))
                {
                    c2 = Convert.ToInt32(sc2.Split('x')[0]);
                    xcount[0] = true;
                } 
                else if (sc2.Contains('x') && sc2.Length == 1 && !sc2.Contains('-'))
                {
                    c2 = 1;
                    xcount[0] = true;
                }
                else if (sc2.Contains('-') && sc2.Contains('x'))
                {
                    c2 = -1;
                    xcount[0] = true;
                }
                else
                { c2 = Convert.ToInt32(sc2); }

                //Третий коэффициент может содержать X
                if (sc3 == null)
                    c3 = 1;
                else if (sc3.Contains('-') && sc3.Length == 1)
                    c3 = -1;
                else if (sc3.Contains('x') && sc3.Length > 1 && !sc3.Contains('-'))
                {
                    c3 = Convert.ToInt32(sc3.Split('x')[0]);
                    xcount[1] = true;
                }
                else if (sc3.Contains('x') && sc3.Length == 1 && !sc3.Contains('-'))
                {
                    c3 = 1;
                    xcount[1] = true;
                }
                else if (sc3.Contains('-') && sc3.Contains('x'))
                {
                    c3 = -1;
                    xcount[1] = true;
                }
                else { c3 = Convert.ToInt32(sc3); }

                //Свободный коэффициент не может содержать x
                if (sc4.Contains('x'))
                    MessageBox.Show("Вы неверно ввели начальные условия\r\nСвободный член не должен содержать переменные", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else if (sc4 == null)
                    c4 = 1;
                else if (sc4.Contains('-') && sc4.Length == 1)
                    c4 = -1;
                else { c4 = Convert.ToDouble(sc4); }
                //Внесение начальных  условий в БД
                if (dbchbox.Checked==true)
                {
                    string[] coeffs = new string[4];
                    coeffs[0] = sc1; coeffs[1] = sc2; coeffs[2] = sc3; coeffs[3] = sc4;
                    await TimpPGSQLSender.InitSend(coeffs, x0, y0, z0);
                }
                
                //Инициализация параметров класса
                RungeKutta rk = new RungeKutta 
                {
                    fc = c1,
                    sc = c2,
                    tc = c3,
                    frc = c4, 
                    xc = xcount 
                };
                //Определение количества шагов в алгоритме
                int count = Convert.ToInt32(Math.Round((xf - x0) / h, 0));
                //Объявление массивов для вывода значений
                double[] Xout = new double[count + 1];
                Xout[0] = x0;
                double[] Yout = new double[count + 1];
                Yout[0] = y0;
                double[] Zout= new double[count + 1];
                Zout[0] = z0;
                //Инициализация секундомера
                Stopwatch stopwatch = new Stopwatch();
                double time = 0;
                Process currentProcess = System.Diagnostics.Process.GetCurrentProcess();
                long memorybeforeUsed = currentProcess.PrivateMemorySize64;
                //Основной цикл расчета значений
                for (int i = 1; i < count + 1 ; i++) 
                {
                    DataRow row1 = table.NewRow();
                    row1[0] = time;
                    row1[1] = Xout[i-1];
                    row1[2] = Yout[i-1];
                    row1[3] = Zout[i-1];
                    table.Rows.Add(row1);
                    if (dbchbox.Checked==true) 
                        await TimpPGSQLSender.OutSend(time, Xout[i - 1], Yout[i - 1], Zout[i - 1]);
                    stopwatch.Start();
                    q1 = z0;
                    k1 = rk.Function(x0, y0, z0);
                    q2 = z0 + k1 * h * 0.5;
                    k2 = rk.Function( x0 + h * 0.5, y0 + q1 * h * 0.5, z0 + k1 * h * 0.5); 
                    q3 = z0 + k2 * h * 0.5;
                    k3 = rk.Function(x0 + h * 0.5, y0 + q2 * h * 0.5, z0 + k2 * h * 0.5);
                    q4 = z0 + k3 * h;
                    k4 = rk.Function(x0 + h, y0 + q3 * h, z0 + k3 * h);
                    x0 += h;
                    y0 += h / 6 * (q1 + 2 * q2 + 2 * q3 + q4);
                    z0 += h / 6 * (k1 + 2 * k2 + 2 * k3 + k4);
                    Xout[i] = x0;
                    Yout[i] = y0;
                    Zout[i] = z0;
                    stopwatch.Stop();
                    time = 1000 * (double)stopwatch.ElapsedTicks / Stopwatch.Frequency;
                }
                //Вывод последних значений 
                currentProcess.Refresh();
                long memoryafterUsed = currentProcess.PrivateMemorySize64;
                //currentProcess.Exited;
                
                DataRow rowL = table.NewRow();
                rowL[0] = time;
                rowL[1] = Xout[count];
                rowL[2] = Yout[count];
                rowL[3] = Zout[count];
                /*DataRow rowR = table.NewRow();
                rowR[0] = "Затраченные ресурсы памяти";
                rowR[1] = Convert.ToDouble(memoryafterUsed - memorybeforeUsed);*/
                table.Rows.Add(rowL);
                table.Rows.Add("Затраченные ресурсы памяти", Convert.ToString(memoryafterUsed - memorybeforeUsed));
                //Визуализация таблицы
                dataGridView1.DataSource = table;
                //richTextBox1.Text += $"{Xout[count]}" + "   " + $"{Yout[count]}" + "    " + $"{Zout[count]}\r\n";
            }
            catch { MessageBox.Show("Вы неверно ввели начальные условия\r\nНеверный формат", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        

        private void firstCoeftb_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9') || char.IsControl(e.KeyChar) || (e.KeyChar == '-') || (e.KeyChar == ','))
            { return; }
            e.Handled = true; 
        }

        private void secondCoeftb_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9') || char.IsControl(e.KeyChar) || (e.KeyChar == '-') || (e.KeyChar == ',') || (e.KeyChar == 'x'))
            { return; }
            e.Handled = true;
        }

        private void thirdCoeftb_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void thirdCoeftb_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {

        }

        private void thirdCoeftb_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9') || char.IsControl(e.KeyChar) || (e.KeyChar == '-') || (e.KeyChar == ',') || (e.KeyChar == 'x'))
            { return; }
            e.Handled = true;
        }
        private void freeCoeftb_TextChanged(object sender, EventArgs e)
        {

        }
        private void freeCoeftb_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9') || char.IsControl(e.KeyChar) || (e.KeyChar == '-') || (e.KeyChar == ','))
            { return; }
            e.Handled = true;
        }

        private void zeroYtb1_TextChanged(object sender, EventArgs e)
        {

        }

        private void zeroYtb1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9') || char.IsControl(e.KeyChar) || (e.KeyChar == '-') || (e.KeyChar == ','))
            { return; }
            e.Handled = true;
        }

        private void zeroZtb_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9') || char.IsControl(e.KeyChar) || (e.KeyChar == '-') || (e.KeyChar == ','))
            { return; }
            e.Handled = true;
        }

        private void steptb_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9') || char.IsControl(e.KeyChar) || (e.KeyChar == '-') || (e.KeyChar == ','))
            { return; }
            e.Handled = true;
        }

        private void intervaltb1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9') || char.IsControl(e.KeyChar) || (e.KeyChar == '-') || (e.KeyChar == ','))
            { return; }
            e.Handled = true;
        }

        private void intervaltb2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9') || char.IsControl(e.KeyChar) || (e.KeyChar == '-') || (e.KeyChar == ','))
            { return; }
            e.Handled = true;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //e.Handled = true;
            
        }

        private void dataGridView1_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            e.Control.KeyPress += new KeyPressEventHandler(Control_KeyPress);
        }
        void Control_KeyPress(object sender, KeyPressEventArgs e)
        {
            
                e.Handled = true;
           
        }

        private void clrbtn_Click(object sender, EventArgs e)
        {
            table.Columns.Clear();
            table.Rows.Clear();
            dataGridView1.DataSource = table;   
        }
    }
}
