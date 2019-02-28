using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Text;
using System.Windows.Forms;

namespace SupervisorCalc
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void Rtb_TextChanged(object sender, EventArgs e)
        {
            double Ih, Il, Vl, Vh, R, R1 = double.NaN, R2 = double.NaN, R3 = double.NaN;

            if (posRb.Checked)
                loVoltTb.Text = "0";
            else
                hiVoltTb.Text = "1";

            double.TryParse(R1tb.Text.Replace(".", CultureInfo.CurrentUICulture.NumberFormat.NumberDecimalSeparator), out R1);
            double.TryParse(R2tb.Text.Replace(".", CultureInfo.CurrentUICulture.NumberFormat.NumberDecimalSeparator), out R2);
            double.TryParse(R3tb.Text.Replace(".", CultureInfo.CurrentUICulture.NumberFormat.NumberDecimalSeparator), out R3);

            if(double.IsNaN(R1) || double.IsNaN(R2) || double.IsNaN(R3))
            {
                hiVoltTb.Text = "—";
                return;
            }

            R = R1 + R2 + R3;

            if (posRb.Checked)
            {
                Ih = 0.5 / R3;
                Vh = Ih * R;
                Il = 0.5 / (R2 + R3);
                Vl = Il * R;
                hiVoltTb.Text = Vl.ToString("F3") + "..." + Vh.ToString("F3");
            }
            else
            {
                Ih = 0.5 / R1;
                Vh = -(Ih * R - 1);
                Il = 0.5 / (R1 + R2);
                Vl = -(Il * R - 1);
                loVoltTb.Text = Vl.ToString("F3") + "..." + Vh.ToString("F3");
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.Polarity = (posRb.Checked) ? 1 : 0;
            Properties.Settings.Default.Save();
        }

        string tbTextLostWorkaround;
        private void Form1_Load(object sender, EventArgs e)
        {
            Rtb_TextChanged(null, null);
            if (Properties.Settings.Default.Polarity == 0)
                negRb.Checked = true;
            else
                posRb.Checked = true;
            tbTextLostWorkaround = seriestb.Text;

            grid1.Rows.Insert(0);
            grid1[0, 0] = new SourceGrid.Cells.ColumnHeader("Error max, mV");
            grid1[0, 1] = new SourceGrid.Cells.ColumnHeader("R1");
            grid1[0, 2] = new SourceGrid.Cells.ColumnHeader("R2");
            grid1[0, 3] = new SourceGrid.Cells.ColumnHeader("R3");
            grid1[0, 4] = new SourceGrid.Cells.ColumnHeader("Current max, mA");
            grid1[0, 5] = new SourceGrid.Cells.ColumnHeader("Limits, V");

            grid1.Columns[0].Width = 50;
            grid1.Columns[1].Width = 70;
            grid1.Columns[2].Width = 70;
            grid1.Columns[3].Width = 70;
            grid1.Columns[4].Width = 40;
            grid1.Columns[5].Width = 110;
        }

        private void label6_Click(object sender, EventArgs e)
        {
            snake1.Run();
            snake1.Focus();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("mailto:yakhontov@gmail.com");
        }

        double maxUAtStart = 0;
        private void btnRunStop_Click(object sender, EventArgs e)
        {
            if (CalcResWorker.IsBusy)
                CalcResWorker.CancelAsync();
            else
            {
                // Некоторое время назад вылетал забавный баг - строка seriestb.Text читалась при
                // определенных условиях пустой. Баг стабильно воспроизводился.
                // ХЗ с чем это было связано, но после гибернации компьютера прошло
                ThreadParameters tp = new ThreadParameters(seriestb.Text);
                if (!double.TryParse(minUtb.Text.Replace(".", CultureInfo.CurrentUICulture.NumberFormat.NumberDecimalSeparator), out tp.MinU) ||
                    !double.TryParse(maxUtb.Text.Replace(".", CultureInfo.CurrentUICulture.NumberFormat.NumberDecimalSeparator), out tp.MaxU) ||
                    !double.TryParse(minItb.Text.Replace(".", CultureInfo.CurrentUICulture.NumberFormat.NumberDecimalSeparator), out tp.MinI) ||
                    !double.TryParse(maxItb.Text.Replace(".", CultureInfo.CurrentUICulture.NumberFormat.NumberDecimalSeparator), out tp.MaxI))
                    return;
                // Переводим и миллиамперов в амперы
                tp.MinI /= 1000;
                tp.MaxI /= 1000;
                maxUAtStart = tp.MaxU;
                CalcResWorker.RunWorkerAsync(tp);
                btnRunStop.Text = "Stop calculate";
            }
        }

        private void CalcResWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            calcPB.Value = e.ProgressPercentage;

            if (e.UserState != null)
            {
                ResultList rl = (ResultList)e.UserState;

                if (grid1.RowsCount > 1)
                    grid1.Rows.RemoveRange(1, grid1.RowsCount-1);

                int r = 1;
                foreach(CalcResult c in rl)
                {
                    grid1.Rows.Insert(r);
                    grid1[r, 0] = new SourceGrid.Cells.Cell((c.Error*1000).ToString("F2"), typeof(string));
                    grid1[r, 1] = new SourceGrid.Cells.Cell(CalcResult.RToString(c.R1), typeof(string));
                    grid1[r, 2] = new SourceGrid.Cells.Cell(CalcResult.RToString(c.R2), typeof(string));
                    grid1[r, 3] = new SourceGrid.Cells.Cell(CalcResult.RToString(c.R3), typeof(string));
                    grid1[r, 4] = new SourceGrid.Cells.Cell((maxUAtStart*1000/(c.R1+c.R2+c.R3)).ToString("F2"), typeof(string));
                    grid1[r, 5] = new SourceGrid.Cells.Cell(c.GetRangeV(), typeof(string));
                    r++;
                }


            }
        }

        private void CalcResWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            calcPB.Value = 0;
            btnRunStop.Text = "Calculate";
        }

        private void CalcResWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            if (e.Argument == null)
                return;

            ThreadParameters tp = (ThreadParameters)e.Argument;
            ResistorSeries resistors = tp.Resistors;

            //////////////////////////////////////////////////////////////////////////////////////////////////
            double
                minU = tp.MinU,
                maxU = tp.MaxU,
                minI = tp.MinI,
                maxI = tp.MaxI,
                // Исходя из допустимого тока посчитали минимальное и максимальное сопротивление цепочки
                // Минимальное сопротивление всего делителя из 3-х резисторов исходя из заданного тока и контролируемого напряжения
                minR = minU / maxI,
                // Максимальное сопротивление всего делителя из 3-х резисторов исходя из заданного тока и контролируемого напряжения
                maxR = maxU / minI;

            // Индекс ближайшего меньшего по номиналу резистора
            int maxR1id = resistors.FindLowerId(maxR);
            double maxR1 = resistors[maxR1id];

            // В переборе первого резистора нет смысла выходить за пределы максимального сопротивления,
            // т.к. в противном случае общее сопротивление цепочки окажется выше максимального
            for(int R1id = 0; R1id <= maxR1id; R1id++)
            {
                // Номинал текущего резистора R1
                double R1 = resistors[R1id];

                // Максимальное сопротивление второго резистора не может быть больше максимального
                // сопротивления цепочки минус сопротивление первого резистора,
                // в противном случае общее сопротивление цепочки окажется выше максимального
                int maxR2id = resistors.FindLowerId(maxR - R1);

                for(int R2id = 0; R2id<=maxR2id; R2id++)
                {
                    // Номинал текущего резистора R2
                    double R2 = resistors[R2id];

                    // Максимальное сопротивление третьего резистора не может быть больше максимального
                    // сопротивления цепочки минус сопротивление первого и второго резисторов,
                    // в противном случае общее сопротивление цепочки окажется выше максимального
                    int maxR3id = resistors.FindLowerId(maxR - R1 - R2);

                    // Минимальное сопротивление третьего резистора не может быть ниже минимального
                    // сопротивления цепочки минус сопротивление первого и второго резисторов
                    int minR3id = resistors.FindGreaterId(minR - R1 - R2);

                    for(int R3id = minR3id; R3id <= maxR3id; R3id++)
                    {
                        // Номинал текущего резистора R2
                        double R3 = resistors[R3id];

                        // Общее сопротивление цепочки для данных резисторов
                        double R = R1 + R2 + R3;

                        if (R > maxR || R < minR)
                            continue;

                        // Супервизор срабатывает при повышении напряжения на R3 выше 0,5В, ток на R3 при этом составялет:
                        double Ih = 0.5 / R3;
                        // При этом токе напряжение на всей цепочке составляет:
                        double Uh = Ih * R;
                        // Супервизор срабатывает при понижении напряжения на (R2+R3) ниже 0,5В, ток на (R2+R3) при этом составялет:
                        double Il = 0.5 / (R2 + R3);
                        // При этом токе напряжение на всей цепочке составляет:
                        double Ul = Il * R;
                        // Добавляем расчеты в список, внутри уже разберемся нужен этот результат или нет
                        tp.Results.AddResult(R1, R2, R3, minU - Ul, maxU - Uh);
                    }
                }

                ///////////////////////////////////////
                if (CalcResWorker.CancellationPending)
                {
                    e.Cancel = true;
                    break;
                }
                CalcResWorker.ReportProgress(100 * R1id / maxR1id, new ResultList(tp.Results));
                ///////////////////////////////////////
            }
            //////////////////////////////////////////////////////////////////////////////////////////////////
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            seriestb.Clear();
            if (((Control)sender).Tag == null)
                return;
            int i = Convert.ToInt32(((Control)sender).Tag);
            switch(i)
            {
                case 3: seriestb.Text = ResistorSeries.E3(); break;
                case 6: seriestb.Text = ResistorSeries.E6(); break;
                case 12: seriestb.Text = ResistorSeries.E12(); break;
                case 24: seriestb.Text = ResistorSeries.E24(); break;
                case 48: seriestb.Text = ResistorSeries.E48(); break;
                case 96: seriestb.Text = ResistorSeries.E96(); break;
                case 192: seriestb.Text = ResistorSeries.E192(); break;
            }
        }
    }
}