﻿using System;
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

        private void Form1_Load(object sender, EventArgs e)
        {
            Rtb_TextChanged(null, null);
            if (Properties.Settings.Default.Polarity == 0)
                negRb.Checked = true;
            else
                posRb.Checked = true;
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

        private void button2_Click(object sender, EventArgs e)
        {
            seriestb.Clear();
            seriestb.Text = "1Ohm 1.01Ohm 1.02Ohm 1.04Ohm 1.05Ohm 1.06Ohm 1.07Ohm 1.09Ohm 1.1Ohm 1.11Ohm 1.13Ohm 1.14Ohm 1.15Ohm 1.17Ohm 1.18Ohm 1.2Ohm 1.21Ohm 1.23Ohm 1.24Ohm 1.26Ohm 1.27Ohm 1.29Ohm 1.3Ohm 1.32Ohm 1.33Ohm 1.35Ohm 1.37Ohm 1.38Ohm 1.4Ohm 1.42Ohm 1.43Ohm 1.45Ohm 1.47Ohm 1.49Ohm 1.5Ohm 1.52Ohm 1.54Ohm 1.56Ohm 1.58Ohm 1.6Ohm 1.62Ohm 1.64Ohm 1.65Ohm 1.67Ohm 1.69Ohm 1.72Ohm 1.74Ohm 1.76Ohm 1.78Ohm 1.8Ohm 1.82Ohm 1.84Ohm 1.87Ohm 1.89Ohm 1.91Ohm 1.93Ohm 1.96Ohm 1.98Ohm 2Ohm 2.03Ohm 2.05Ohm 2.08Ohm 2.1Ohm 2.13Ohm 2.15Ohm 2.18Ohm 2.21Ohm 2.23Ohm 2.26Ohm 2.29Ohm 2.32Ohm 2.34Ohm 2.37Ohm 2.4Ohm 2.43Ohm 2.46Ohm 2.49Ohm 2.52Ohm 2.55Ohm 2.58Ohm 2.61Ohm 2.64Ohm 2.67Ohm 2.71Ohm 2.74Ohm 2.77Ohm 2.8Ohm 2.84Ohm 2.87Ohm 2.91Ohm 2.94Ohm 2.98Ohm 3.01Ohm 3.05Ohm 3.09Ohm 3.12Ohm 3.16Ohm 3.2Ohm 3.24Ohm 3.28Ohm 3.32Ohm 3.36Ohm 3.4Ohm 3.44Ohm 3.48Ohm 3.52Ohm 3.57Ohm 3.61Ohm 3.65Ohm 3.7Ohm 3.74Ohm 3.79Ohm 3.83Ohm 3.88Ohm 3.92Ohm 3.97Ohm 4.02Ohm 4.07Ohm 4.12Ohm 4.17Ohm 4.22Ohm 4.27Ohm 4.32Ohm 4.37Ohm 4.42Ohm 4.48Ohm 4.53Ohm 4.59Ohm 4.64Ohm 4.7Ohm 4.75Ohm 4.81Ohm 4.87Ohm 4.93Ohm 4.99Ohm 5.05Ohm 5.11Ohm 5.17Ohm 5.23Ohm 5.3Ohm 5.36Ohm 5.42Ohm 5.49Ohm 5.56Ohm 5.62Ohm 5.69Ohm 5.76Ohm 5.83Ohm 5.9Ohm 5.97Ohm 6.04Ohm 6.12Ohm 6.19Ohm 6.26Ohm 6.34Ohm 6.42Ohm 6.49Ohm 6.57Ohm 6.65Ohm 6.73Ohm 6.81Ohm 6.9Ohm 6.98Ohm 7.06Ohm 7.15Ohm 7.23Ohm 7.32Ohm 7.41Ohm 7.5Ohm 7.59Ohm 7.68Ohm 7.77Ohm 7.87Ohm 7.96Ohm 8.06Ohm 8.16Ohm 8.25Ohm 8.35Ohm 8.45Ohm 8.56Ohm 8.66Ohm 8.76Ohm 8.87Ohm 8.98Ohm 9.09Ohm 9.19Ohm 9.31Ohm 9.42Ohm 9.53Ohm 9.65Ohm 9.76Ohm 9.88Ohm 10Ohm 10.1Ohm 10.2Ohm 10.4Ohm 10.5Ohm 10.6Ohm 10.7Ohm 10.9Ohm 11Ohm 11.1Ohm 11.3Ohm 11.4Ohm 11.5Ohm 11.7Ohm 11.8Ohm 12Ohm 12.1Ohm 12.3Ohm 12.4Ohm 12.6Ohm 12.7Ohm 12.9Ohm 13Ohm 13.2Ohm 13.3Ohm 13.5Ohm 13.7Ohm 13.8Ohm 14Ohm 14.2Ohm 14.3Ohm 14.5Ohm 14.7Ohm 14.9Ohm 15Ohm 15.2Ohm 15.4Ohm 15.6Ohm 15.8Ohm 16Ohm 16.2Ohm 16.4Ohm 16.5Ohm 16.7Ohm 16.9Ohm 17.2Ohm 17.4Ohm 17.6Ohm 17.8Ohm 18Ohm 18.2Ohm 18.4Ohm 18.7Ohm 18.9Ohm 19.1Ohm 19.3Ohm 19.6Ohm 19.8Ohm 20Ohm 20.3Ohm 20.5Ohm 20.8Ohm 21Ohm 21.3Ohm 21.5Ohm 21.8Ohm 22.1Ohm 22.3Ohm 22.6Ohm 22.9Ohm 23.2Ohm 23.4Ohm 23.7Ohm 24Ohm 24.3Ohm 24.6Ohm 24.9Ohm 25.2Ohm 25.5Ohm 25.8Ohm 26.1Ohm 26.4Ohm 26.7Ohm 27.1Ohm 27.4Ohm 27.7Ohm 28Ohm 28.4Ohm 28.7Ohm 29.1Ohm 29.4Ohm 29.8Ohm 30.1Ohm 30.5Ohm 30.9Ohm 31.2Ohm 31.6Ohm 32Ohm 32.4Ohm 32.8Ohm 33.2Ohm 33.6Ohm 34Ohm 34.4Ohm 34.8Ohm 35.2Ohm 35.7Ohm 36.1Ohm 36.5Ohm 37Ohm 37.4Ohm 37.9Ohm 38.3Ohm 38.8Ohm 39.2Ohm 39.7Ohm 40.2Ohm 40.7Ohm 41.2Ohm 41.7Ohm 42.2Ohm 42.7Ohm 43.2Ohm 43.7Ohm 44.2Ohm 44.8Ohm 45.3Ohm 45.9Ohm 46.4Ohm 47Ohm 47.5Ohm 48.1Ohm 48.7Ohm 49.3Ohm 49.9Ohm 50.5Ohm 51.1Ohm 51.7Ohm 52.3Ohm 53Ohm 53.6Ohm 54.2Ohm 54.9Ohm 55.6Ohm 56.2Ohm 56.9Ohm 57.6Ohm 58.3Ohm 59Ohm 59.7Ohm 60.4Ohm 61.2Ohm 61.9Ohm 62.6Ohm 63.4Ohm 64.2Ohm 64.9Ohm 65.7Ohm 66.5Ohm 67.3Ohm 68.1Ohm 69Ohm 69.8Ohm 70.6Ohm 71.5Ohm 72.3Ohm 73.2Ohm 74.1Ohm 75Ohm 75.9Ohm 76.8Ohm 77.7Ohm 78.7Ohm 79.6Ohm 80.6Ohm 81.6Ohm 82.5Ohm 83.5Ohm 84.5Ohm 85.6Ohm 86.6Ohm 87.6Ohm 88.7Ohm 89.8Ohm 90.9Ohm 91.9Ohm 93.1Ohm 94.2Ohm 95.3Ohm 96.5Ohm 97.6Ohm 98.8Ohm 100Ohm 101Ohm 102Ohm 104Ohm 105Ohm 106Ohm 107Ohm 109Ohm 110Ohm 111Ohm 113Ohm 114Ohm 115Ohm 117Ohm 118Ohm 120Ohm 121Ohm 123Ohm 124Ohm 126Ohm 127Ohm 129Ohm 130Ohm 132Ohm 133Ohm 135Ohm 137Ohm 138Ohm 140Ohm 142Ohm 143Ohm 145Ohm 147Ohm 149Ohm 150Ohm 152Ohm 154Ohm 156Ohm 158Ohm 160Ohm 162Ohm 164Ohm 165Ohm 167Ohm 169Ohm 172Ohm 174Ohm 176Ohm 178Ohm 180Ohm 182Ohm 184Ohm 187Ohm 189Ohm 191Ohm 193Ohm 196Ohm 198Ohm 200Ohm 203Ohm 205Ohm 208Ohm 210Ohm 213Ohm 215Ohm 218Ohm 221Ohm 223Ohm 226Ohm 229Ohm 232Ohm 234Ohm 237Ohm 240Ohm 243Ohm 246Ohm 249Ohm 252Ohm 255Ohm 258Ohm 261Ohm 264Ohm 267Ohm 271Ohm 274Ohm 277Ohm 280Ohm 284Ohm 287Ohm 291Ohm 294Ohm 298Ohm 301Ohm 305Ohm 309Ohm 312Ohm 316Ohm 320Ohm 324Ohm 328Ohm 332Ohm 336Ohm 340Ohm 344Ohm 348Ohm 352Ohm 357Ohm 361Ohm 365Ohm 370Ohm 374Ohm 379Ohm 383Ohm 388Ohm 392Ohm 397Ohm 402Ohm 407Ohm 412Ohm 417Ohm 422Ohm 427Ohm 432Ohm 437Ohm 442Ohm 448Ohm 453Ohm 459Ohm 464Ohm 470Ohm 475Ohm 481Ohm 487Ohm 493Ohm 499Ohm 505Ohm 511Ohm 517Ohm 523Ohm 530Ohm 536Ohm 542Ohm 549Ohm 556Ohm 562Ohm 569Ohm 576Ohm 583Ohm 590Ohm 597Ohm 604Ohm 612Ohm 619Ohm 626Ohm 634Ohm 642Ohm 649Ohm 657Ohm 665Ohm 673Ohm 681Ohm 690Ohm 698Ohm 706Ohm 715Ohm 723Ohm 732Ohm 741Ohm 750Ohm 759Ohm 768Ohm 777Ohm 787Ohm 796Ohm 806Ohm 816Ohm 825Ohm 835Ohm 845Ohm 856Ohm 866Ohm 876Ohm 887Ohm 898Ohm 909Ohm 919Ohm 931Ohm 942Ohm 953Ohm 965Ohm 976Ohm 988Ohm 1kOhm 1.01kOhm 1.02kOhm 1.04kOhm 1.05kOhm 1.06kOhm 1.07kOhm 1.09kOhm 1.1kOhm 1.11kOhm 1.13kOhm 1.14kOhm 1.15kOhm 1.17kOhm 1.18kOhm 1.2kOhm 1.21kOhm 1.23kOhm 1.24kOhm 1.26kOhm 1.27kOhm 1.29kOhm 1.3kOhm 1.32kOhm 1.33kOhm 1.35kOhm 1.37kOhm 1.38kOhm 1.4kOhm 1.42kOhm 1.43kOhm 1.45kOhm 1.47kOhm 1.49kOhm 1.5kOhm 1.52kOhm 1.54kOhm 1.56kOhm 1.58kOhm 1.6kOhm 1.62kOhm 1.64kOhm 1.65kOhm 1.67kOhm 1.69kOhm 1.72kOhm 1.74kOhm 1.76kOhm 1.78kOhm 1.8kOhm 1.82kOhm 1.84kOhm 1.87kOhm 1.89kOhm 1.91kOhm 1.93kOhm 1.96kOhm 1.98kOhm 2kOhm 2.03kOhm 2.05kOhm 2.08kOhm 2.1kOhm 2.13kOhm 2.15kOhm 2.18kOhm 2.21kOhm 2.23kOhm 2.26kOhm 2.29kOhm 2.32kOhm 2.34kOhm 2.37kOhm 2.4kOhm 2.43kOhm 2.46kOhm 2.49kOhm 2.52kOhm 2.55kOhm 2.58kOhm 2.61kOhm 2.64kOhm 2.67kOhm 2.71kOhm 2.74kOhm 2.77kOhm 2.8kOhm 2.84kOhm 2.87kOhm 2.91kOhm 2.94kOhm 2.98kOhm 3.01kOhm 3.05kOhm 3.09kOhm 3.12kOhm 3.16kOhm 3.2kOhm 3.24kOhm 3.28kOhm 3.32kOhm 3.36kOhm 3.4kOhm 3.44kOhm 3.48kOhm 3.52kOhm 3.57kOhm 3.61kOhm 3.65kOhm 3.7kOhm 3.74kOhm 3.79kOhm 3.83kOhm 3.88kOhm 3.92kOhm 3.97kOhm 4.02kOhm 4.07kOhm 4.12kOhm 4.17kOhm 4.22kOhm 4.27kOhm 4.32kOhm 4.37kOhm 4.42kOhm 4.48kOhm 4.53kOhm 4.59kOhm 4.64kOhm 4.7kOhm 4.75kOhm 4.81kOhm 4.87kOhm 4.93kOhm 4.99kOhm 5.05kOhm 5.11kOhm 5.17kOhm 5.23kOhm 5.3kOhm 5.36kOhm 5.42kOhm 5.49kOhm 5.56kOhm 5.62kOhm 5.69kOhm 5.76kOhm 5.83kOhm 5.9kOhm 5.97kOhm 6.04kOhm 6.12kOhm 6.19kOhm 6.26kOhm 6.34kOhm 6.42kOhm 6.49kOhm 6.57kOhm 6.65kOhm 6.73kOhm 6.81kOhm 6.9kOhm 6.98kOhm 7.06kOhm 7.15kOhm 7.23kOhm 7.32kOhm 7.41kOhm 7.5kOhm 7.59kOhm 7.68kOhm 7.77kOhm 7.87kOhm 7.96kOhm 8.06kOhm 8.16kOhm 8.25kOhm 8.35kOhm 8.45kOhm 8.56kOhm 8.66kOhm 8.76kOhm 8.87kOhm 8.98kOhm 9.09kOhm 9.19kOhm 9.31kOhm 9.42kOhm 9.53kOhm 9.65kOhm 9.76kOhm 9.88kOhm 10kOhm 10.1kOhm 10.2kOhm 10.4kOhm 10.5kOhm 10.6kOhm 10.7kOhm 10.9kOhm 11kOhm 11.1kOhm 11.3kOhm 11.4kOhm 11.5kOhm 11.7kOhm 11.8kOhm 12kOhm 12.1kOhm 12.3kOhm 12.4kOhm 12.6kOhm 12.7kOhm 12.9kOhm 13kOhm 13.2kOhm 13.3kOhm 13.5kOhm 13.7kOhm 13.8kOhm 14kOhm 14.2kOhm 14.3kOhm 14.5kOhm 14.7kOhm 14.9kOhm 15kOhm 15.2kOhm 15.4kOhm 15.6kOhm 15.8kOhm 16kOhm 16.2kOhm 16.4kOhm 16.5kOhm 16.7kOhm 16.9kOhm 17.2kOhm 17.4kOhm 17.6kOhm 17.8kOhm 18kOhm 18.2kOhm 18.4kOhm 18.7kOhm 18.9kOhm 19.1kOhm 19.3kOhm 19.6kOhm 19.8kOhm 20kOhm 20.3kOhm 20.5kOhm 20.8kOhm 21kOhm 21.3kOhm 21.5kOhm 21.8kOhm 22.1kOhm 22.3kOhm 22.6kOhm 22.9kOhm 23.2kOhm 23.4kOhm 23.7kOhm 24kOhm 24.3kOhm 24.6kOhm 24.9kOhm 25.2kOhm 25.5kOhm 25.8kOhm 26.1kOhm 26.4kOhm 26.7kOhm 27.1kOhm 27.4kOhm 27.7kOhm 28kOhm 28.4kOhm 28.7kOhm 29.1kOhm 29.4kOhm 29.8kOhm 30.1kOhm 30.5kOhm 30.9kOhm 31.2kOhm 31.6kOhm 32kOhm 32.4kOhm 32.8kOhm 33.2kOhm 33.6kOhm 34kOhm 34.4kOhm 34.8kOhm 35.2kOhm 35.7kOhm 36.1kOhm 36.5kOhm 37kOhm 37.4kOhm 37.9kOhm 38.3kOhm 38.8kOhm 39.2kOhm 39.7kOhm 40.2kOhm 40.7kOhm 41.2kOhm 41.7kOhm 42.2kOhm 42.7kOhm 43.2kOhm 43.7kOhm 44.2kOhm 44.8kOhm 45.3kOhm 45.9kOhm 46.4kOhm 47kOhm 47.5kOhm 48.1kOhm 48.7kOhm 49.3kOhm 49.9kOhm 50.5kOhm 51.1kOhm 51.7kOhm 52.3kOhm 53kOhm 53.6kOhm 54.2kOhm 54.9kOhm 55.6kOhm 56.2kOhm 56.9kOhm 57.6kOhm 58.3kOhm 59kOhm 59.7kOhm 60.4kOhm 61.2kOhm 61.9kOhm 62.6kOhm 63.4kOhm 64.2kOhm 64.9kOhm 65.7kOhm 66.5kOhm 67.3kOhm 68.1kOhm 69kOhm 69.8kOhm 70.6kOhm 71.5kOhm 72.3kOhm 73.2kOhm 74.1kOhm 75kOhm 75.9kOhm 76.8kOhm 77.7kOhm 78.7kOhm 79.6kOhm 80.6kOhm 81.6kOhm 82.5kOhm 83.5kOhm 84.5kOhm 85.6kOhm 86.6kOhm 87.6kOhm 88.7kOhm 89.8kOhm 90.9kOhm 91.9kOhm 93.1kOhm 94.2kOhm 95.3kOhm 96.5kOhm 97.6kOhm 98.8kOhm 100kOhm 101kOhm 102kOhm 104kOhm 105kOhm 106kOhm 107kOhm 109kOhm 110kOhm 111kOhm 113kOhm 114kOhm 115kOhm 117kOhm 118kOhm 120kOhm 121kOhm 123kOhm 124kOhm 126kOhm 127kOhm 129kOhm 130kOhm 132kOhm 133kOhm 135kOhm 137kOhm 138kOhm 140kOhm 142kOhm 143kOhm 145kOhm 147kOhm 149kOhm 150kOhm 152kOhm 154kOhm 156kOhm 158kOhm 160kOhm 162kOhm 164kOhm 165kOhm 167kOhm 169kOhm 172kOhm 174kOhm 176kOhm 178kOhm 180kOhm 182kOhm 184kOhm 187kOhm 189kOhm 191kOhm 193kOhm 196kOhm 198kOhm 200kOhm 203kOhm 205kOhm 208kOhm 210kOhm 213kOhm 215kOhm 218kOhm 221kOhm 223kOhm 226kOhm 229kOhm 232kOhm 234kOhm 237kOhm 240kOhm 243kOhm 246kOhm 249kOhm 252kOhm 255kOhm 258kOhm 261kOhm 264kOhm 267kOhm 271kOhm 274kOhm 277kOhm 280kOhm 284kOhm 287kOhm 291kOhm 294kOhm 298kOhm 301kOhm 305kOhm 309kOhm 312kOhm 316kOhm 320kOhm 324kOhm 328kOhm 332kOhm 336kOhm 340kOhm 344kOhm 348kOhm 352kOhm 357kOhm 361kOhm 365kOhm 370kOhm 374kOhm 379kOhm 383kOhm 388kOhm 392kOhm 397kOhm 402kOhm 407kOhm 412kOhm 417kOhm 422kOhm 427kOhm 432kOhm 437kOhm 442kOhm 448kOhm 453kOhm 459kOhm 464kOhm 470kOhm 475kOhm 481kOhm 487kOhm 493kOhm 499kOhm 505kOhm 511kOhm 517kOhm 523kOhm 530kOhm 536kOhm 542kOhm 549kOhm 556kOhm 562kOhm 569kOhm 576kOhm 583kOhm 590kOhm 597kOhm 604kOhm 612kOhm 619kOhm 626kOhm 634kOhm 642kOhm 649kOhm 657kOhm 665kOhm 673kOhm 681kOhm 690kOhm 698kOhm 706kOhm 715kOhm 723kOhm 732kOhm 741kOhm 750kOhm 759kOhm 768kOhm 777kOhm 787kOhm 796kOhm 806kOhm 816kOhm 825kOhm 835kOhm 845kOhm 856kOhm 866kOhm 876kOhm 887kOhm 898kOhm 909kOhm 919kOhm 931kOhm 942kOhm 953kOhm 965kOhm 976kOhm 988kOhm 1MOhm 1.01MOhm 1.02MOhm 1.04MOhm 1.05MOhm 1.06MOhm 1.07MOhm 1.09MOhm 1.1MOhm 1.11MOhm 1.13MOhm 1.14MOhm 1.15MOhm 1.17MOhm 1.18MOhm 1.2MOhm 1.21MOhm 1.23MOhm 1.24MOhm 1.26MOhm 1.27MOhm 1.29MOhm 1.3MOhm 1.32MOhm 1.33MOhm 1.35MOhm 1.37MOhm 1.38MOhm 1.4MOhm 1.42MOhm 1.43MOhm 1.45MOhm 1.47MOhm 1.49MOhm 1.5MOhm 1.52MOhm 1.54MOhm 1.56MOhm 1.58MOhm 1.6MOhm 1.62MOhm 1.64MOhm 1.65MOhm 1.67MOhm 1.69MOhm 1.72MOhm 1.74MOhm 1.76MOhm 1.78MOhm 1.8MOhm 1.82MOhm 1.84MOhm 1.87MOhm 1.89MOhm 1.91MOhm 1.93MOhm 1.96MOhm 1.98MOhm 2MOhm 2.03MOhm 2.05MOhm 2.08MOhm 2.1MOhm 2.13MOhm 2.15MOhm 2.18MOhm 2.21MOhm 2.23MOhm 2.26MOhm 2.29MOhm 2.32MOhm 2.34MOhm 2.37MOhm 2.4MOhm 2.43MOhm 2.46MOhm 2.49MOhm 2.52MOhm 2.55MOhm 2.58MOhm 2.61MOhm 2.64MOhm 2.67MOhm 2.71MOhm 2.74MOhm 2.77MOhm 2.8MOhm 2.84MOhm 2.87MOhm 2.91MOhm 2.94MOhm 2.98MOhm 3.01MOhm 3.05MOhm 3.09MOhm 3.12MOhm 3.16MOhm 3.2MOhm 3.24MOhm 3.28MOhm 3.32MOhm 3.36MOhm 3.4MOhm 3.44MOhm 3.48MOhm 3.52MOhm 3.57MOhm 3.61MOhm 3.65MOhm 3.7MOhm 3.74MOhm 3.79MOhm 3.83MOhm 3.88MOhm 3.92MOhm 3.97MOhm 4.02MOhm 4.07MOhm 4.12MOhm 4.17MOhm 4.22MOhm 4.27MOhm 4.32MOhm 4.37MOhm 4.42MOhm 4.48MOhm 4.53MOhm 4.59MOhm 4.64MOhm 4.7MOhm 4.75MOhm 4.81MOhm 4.87MOhm 4.93MOhm 4.99MOhm 5.05MOhm 5.11MOhm 5.17MOhm 5.23MOhm 5.3MOhm 5.36MOhm 5.42MOhm 5.49MOhm 5.56MOhm 5.62MOhm 5.69MOhm 5.76MOhm 5.83MOhm 5.9MOhm 5.97MOhm 6.04MOhm 6.12MOhm 6.19MOhm 6.26MOhm 6.34MOhm 6.42MOhm 6.49MOhm 6.57MOhm 6.65MOhm 6.73MOhm 6.81MOhm 6.9MOhm 6.98MOhm 7.06MOhm 7.15MOhm 7.23MOhm 7.32MOhm 7.41MOhm 7.5MOhm 7.59MOhm 7.68MOhm 7.77MOhm 7.87MOhm 7.96MOhm 8.06MOhm 8.16MOhm 8.25MOhm 8.35MOhm 8.45MOhm 8.56MOhm 8.66MOhm 8.76MOhm 8.87MOhm 8.98MOhm 9.09MOhm 9.19MOhm 9.31MOhm 9.42MOhm 9.53MOhm 9.65MOhm 9.76MOhm 9.88MOhm 10MOhm 10.1MOhm 10.2MOhm 10.4MOhm 10.5MOhm 10.6MOhm 10.7MOhm 10.9MOhm 11MOhm 11.1MOhm 11.3MOhm 11.4MOhm 11.5MOhm 11.7MOhm 11.8MOhm 12MOhm 12.1MOhm 12.3MOhm 12.4MOhm 12.6MOhm 12.7MOhm 12.9MOhm 13MOhm 13.2MOhm 13.3MOhm 13.5MOhm 13.7MOhm 13.8MOhm 14MOhm 14.2MOhm 14.3MOhm 14.5MOhm 14.7MOhm 14.9MOhm 15MOhm 15.2MOhm 15.4MOhm 15.6MOhm 15.8MOhm 16MOhm 16.2MOhm 16.4MOhm 16.5MOhm 16.7MOhm 16.9MOhm 17.2MOhm 17.4MOhm 17.6MOhm 17.8MOhm 18MOhm 18.2MOhm 18.4MOhm 18.7MOhm 18.9MOhm 19.1MOhm 19.3MOhm 19.6MOhm 19.8MOhm 20MOhm 20.3MOhm 20.5MOhm 20.8MOhm 21MOhm 21.3MOhm 21.5MOhm 21.8MOhm 22.1MOhm 22.3MOhm 22.6MOhm 22.9MOhm 23.2MOhm 23.4MOhm 23.7MOhm 24MOhm 24.3MOhm 24.6MOhm 24.9MOhm 25.2MOhm 25.5MOhm 25.8MOhm 26.1MOhm 26.4MOhm 26.7MOhm 27.1MOhm 27.4MOhm 27.7MOhm 28MOhm 28.4MOhm 28.7MOhm 29.1MOhm 29.4MOhm 29.8MOhm 30.1MOhm 30.5MOhm 30.9MOhm 31.2MOhm 31.6MOhm 32MOhm 32.4MOhm 32.8MOhm 33.2MOhm 33.6MOhm 34MOhm 34.4MOhm 34.8MOhm 35.2MOhm 35.7MOhm 36.1MOhm 36.5MOhm 37MOhm 37.4MOhm 37.9MOhm 38.3MOhm 38.8MOhm 39.2MOhm 39.7MOhm 40.2MOhm 40.7MOhm 41.2MOhm 41.7MOhm 42.2MOhm 42.7MOhm 43.2MOhm 43.7MOhm 44.2MOhm 44.8MOhm 45.3MOhm 45.9MOhm 46.4MOhm 47MOhm 47.5MOhm 48.1MOhm 48.7MOhm 49.3MOhm 49.9MOhm 50.5MOhm 51.1MOhm 51.7MOhm 52.3MOhm 53MOhm 53.6MOhm 54.2MOhm 54.9MOhm 55.6MOhm 56.2MOhm 56.9MOhm 57.6MOhm 58.3MOhm 59MOhm 59.7MOhm 60.4MOhm 61.2MOhm 61.9MOhm 62.6MOhm 63.4MOhm 64.2MOhm 64.9MOhm 65.7MOhm 66.5MOhm 67.3MOhm 68.1MOhm 69MOhm 69.8MOhm 70.6MOhm 71.5MOhm 72.3MOhm 73.2MOhm 74.1MOhm 75MOhm 75.9MOhm 76.8MOhm 77.7MOhm 78.7MOhm 79.6MOhm 80.6MOhm 81.6MOhm 82.5MOhm 83.5MOhm 84.5MOhm 85.6MOhm 86.6MOhm 87.6MOhm 88.7MOhm 89.8MOhm 90.9MOhm 91.9MOhm 93.1MOhm 94.2MOhm 95.3MOhm 96.5MOhm 97.6MOhm 98.8MOhm";
        }

        private void btnRunStop_Click(object sender, EventArgs e)
        {
            if (CalcResWorker.IsBusy)
                CalcResWorker.CancelAsync();
            else
            {
                ThreadParameters tp = new ThreadParameters(seriestb.Text);
                if (!double.TryParse(minUtb.Text.Replace(".", CultureInfo.CurrentUICulture.NumberFormat.NumberDecimalSeparator), out tp.MinU) ||
                    !double.TryParse(maxUtb.Text.Replace(".", CultureInfo.CurrentUICulture.NumberFormat.NumberDecimalSeparator), out tp.MaxU) ||
                    !double.TryParse(minItb.Text.Replace(".", CultureInfo.CurrentUICulture.NumberFormat.NumberDecimalSeparator), out tp.MinI) ||
                    !double.TryParse(maxItb.Text.Replace(".", CultureInfo.CurrentUICulture.NumberFormat.NumberDecimalSeparator), out tp.MaxI))
                    return;
                CalcResWorker.RunWorkerAsync(tp);
                btnRunStop.Text = "Stop calculate";
            }
        }

        private void CalcResWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            if (e.UserState == null)
                return;

            ThreadParameters tp = (ThreadParameters)e.UserState;
            resultsTb.Clear();
            foreach(CalcResult c in tp.Results)
            {
                resultsTb.Text += c.ToString() + "\r\n";
            }
        }

        private void CalcResWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            btnRunStop.Text = "Calculate";
        }

        private void CalcResWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            if (e.Argument == null)
                return;

            ThreadParameters tp = (ThreadParameters)e.Argument;

            //////////////////////////////////////////////////////////////////////////////////////////////////

            double
                minU = tp.MinU,
                maxU = tp.MaxU,
                minI = tp.MinI,
                maxI = tp.MaxI,
                minR = minU / minI,
                maxR = maxU / maxI,
                R1, R2, R3, I1, I2, I3;

                

            //c.Resistors.Find()
            
            //////////////////////////////////////////////////////////////////////////////////////////////////

            for (; ; )
            {
                if (CalcResWorker.CancellationPending)
                {
                    e.Cancel = true;
                    break;
                }


                System.Threading.Thread.Sleep(500);
                //calc.Results.AddResult(new CalcResult(5000, 300, 70, 8));
                //CalcResWorker.ReportProgress(0, new ResultList(calc.Results));
            }
        }
    }
}