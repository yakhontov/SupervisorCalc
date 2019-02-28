namespace SupervisorCalc
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.negRb = new System.Windows.Forms.RadioButton();
            this.loVoltTb = new System.Windows.Forms.TextBox();
            this.posRb = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.R3tb = new System.Windows.Forms.TextBox();
            this.R2tb = new System.Windows.Forms.TextBox();
            this.R1tb = new System.Windows.Forms.TextBox();
            this.hiVoltTb = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.grid1 = new SourceGrid.Grid();
            this.calcPB = new System.Windows.Forms.ProgressBar();
            this.btnRunStop = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.maxItb = new System.Windows.Forms.TextBox();
            this.minItb = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.maxUtb = new System.Windows.Forms.TextBox();
            this.minUtb = new System.Windows.Forms.TextBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.seriestb = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label6 = new System.Windows.Forms.Label();
            this.CalcResWorker = new System.ComponentModel.BackgroundWorker();
            this.snake1 = new SupervisorCalc.Snake();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(424, 672);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.negRb);
            this.tabPage1.Controls.Add(this.loVoltTb);
            this.tabPage1.Controls.Add(this.posRb);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.R3tb);
            this.tabPage1.Controls.Add(this.R2tb);
            this.tabPage1.Controls.Add(this.R1tb);
            this.tabPage1.Controls.Add(this.hiVoltTb);
            this.tabPage1.Controls.Add(this.pictureBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(416, 646);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Calc voltage";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // negRb
            // 
            this.negRb.AutoSize = true;
            this.negRb.Location = new System.Drawing.Point(300, 618);
            this.negRb.Name = "negRb";
            this.negRb.Size = new System.Drawing.Size(104, 17);
            this.negRb.TabIndex = 13;
            this.negRb.Text = "Negative polarity";
            this.negRb.UseVisualStyleBackColor = true;
            this.negRb.CheckedChanged += new System.EventHandler(this.Rtb_TextChanged);
            // 
            // loVoltTb
            // 
            this.loVoltTb.Enabled = false;
            this.loVoltTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loVoltTb.Location = new System.Drawing.Point(6, 602);
            this.loVoltTb.Name = "loVoltTb";
            this.loVoltTb.Size = new System.Drawing.Size(250, 38);
            this.loVoltTb.TabIndex = 12;
            this.loVoltTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // posRb
            // 
            this.posRb.AutoSize = true;
            this.posRb.Checked = true;
            this.posRb.Location = new System.Drawing.Point(300, 19);
            this.posRb.Name = "posRb";
            this.posRb.Size = new System.Drawing.Size(98, 17);
            this.posRb.TabIndex = 11;
            this.posRb.TabStop = true;
            this.posRb.Text = "Positive polarity";
            this.posRb.UseVisualStyleBackColor = true;
            this.posRb.CheckedChanged += new System.EventHandler(this.Rtb_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(2, 427);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "R3, kOhm";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(2, 276);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "R2, kOhm";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(-1, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "R1, kOhm";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(262, 605);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 31);
            this.label2.TabIndex = 7;
            this.label2.Text = "V";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(262, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 31);
            this.label1.TabIndex = 6;
            this.label1.Text = "V";
            // 
            // R3tb
            // 
            this.R3tb.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::SupervisorCalc.Properties.Settings.Default, "R3", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.R3tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.R3tb.Location = new System.Drawing.Point(3, 450);
            this.R3tb.Name = "R3tb";
            this.R3tb.Size = new System.Drawing.Size(80, 38);
            this.R3tb.TabIndex = 4;
            this.R3tb.Text = global::SupervisorCalc.Properties.Settings.Default.R3;
            this.R3tb.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.R3tb.TextChanged += new System.EventHandler(this.Rtb_TextChanged);
            // 
            // R2tb
            // 
            this.R2tb.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::SupervisorCalc.Properties.Settings.Default, "R2", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.R2tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.R2tb.Location = new System.Drawing.Point(3, 299);
            this.R2tb.Name = "R2tb";
            this.R2tb.Size = new System.Drawing.Size(80, 38);
            this.R2tb.TabIndex = 3;
            this.R2tb.Text = global::SupervisorCalc.Properties.Settings.Default.R2;
            this.R2tb.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.R2tb.TextChanged += new System.EventHandler(this.Rtb_TextChanged);
            // 
            // R1tb
            // 
            this.R1tb.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::SupervisorCalc.Properties.Settings.Default, "R1", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.R1tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.R1tb.Location = new System.Drawing.Point(3, 147);
            this.R1tb.Name = "R1tb";
            this.R1tb.Size = new System.Drawing.Size(80, 38);
            this.R1tb.TabIndex = 2;
            this.R1tb.Text = global::SupervisorCalc.Properties.Settings.Default.R1;
            this.R1tb.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.R1tb.TextChanged += new System.EventHandler(this.Rtb_TextChanged);
            // 
            // hiVoltTb
            // 
            this.hiVoltTb.Enabled = false;
            this.hiVoltTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.hiVoltTb.Location = new System.Drawing.Point(6, 3);
            this.hiVoltTb.Name = "hiVoltTb";
            this.hiVoltTb.Size = new System.Drawing.Size(250, 38);
            this.hiVoltTb.TabIndex = 1;
            this.hiVoltTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SupervisorCalc.Properties.Resources.Schematic;
            this.pictureBox1.Location = new System.Drawing.Point(89, 50);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(320, 544);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.label12);
            this.tabPage3.Controls.Add(this.label11);
            this.tabPage3.Controls.Add(this.grid1);
            this.tabPage3.Controls.Add(this.calcPB);
            this.tabPage3.Controls.Add(this.btnRunStop);
            this.tabPage3.Controls.Add(this.label9);
            this.tabPage3.Controls.Add(this.label10);
            this.tabPage3.Controls.Add(this.maxItb);
            this.tabPage3.Controls.Add(this.minItb);
            this.tabPage3.Controls.Add(this.label8);
            this.tabPage3.Controls.Add(this.label7);
            this.tabPage3.Controls.Add(this.maxUtb);
            this.tabPage3.Controls.Add(this.minUtb);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(416, 646);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Calc resistors";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.Location = new System.Drawing.Point(8, 97);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(107, 20);
            this.label12.TabIndex = 20;
            this.label12.Text = "Circuit current";
            this.label12.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(8, 3);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(136, 20);
            this.label11.TabIndex = 19;
            this.label11.Text = "Controlled voltage";
            this.label11.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // grid1
            // 
            this.grid1.ColumnsCount = 6;
            this.grid1.DefaultWidth = 200;
            this.grid1.EnableSort = true;
            this.grid1.FixedRows = 1;
            this.grid1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.grid1.Location = new System.Drawing.Point(3, 196);
            this.grid1.Name = "grid1";
            this.grid1.OptimizeMode = SourceGrid.CellOptimizeMode.ForRows;
            this.grid1.SelectionMode = SourceGrid.GridSelectionMode.Row;
            this.grid1.Size = new System.Drawing.Size(410, 447);
            this.grid1.TabIndex = 18;
            this.grid1.TabStop = true;
            this.grid1.ToolTipText = "";
            // 
            // calcPB
            // 
            this.calcPB.Location = new System.Drawing.Point(266, 53);
            this.calcPB.Name = "calcPB";
            this.calcPB.Size = new System.Drawing.Size(144, 23);
            this.calcPB.TabIndex = 17;
            // 
            // btnRunStop
            // 
            this.btnRunStop.Location = new System.Drawing.Point(264, 148);
            this.btnRunStop.Name = "btnRunStop";
            this.btnRunStop.Size = new System.Drawing.Size(144, 23);
            this.btnRunStop.TabIndex = 15;
            this.btnRunStop.Text = "Calculate";
            this.btnRunStop.UseVisualStyleBackColor = true;
            this.btnRunStop.Click += new System.EventHandler(this.btnRunStop_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(132, 117);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(79, 20);
            this.label9.TabIndex = 14;
            this.label9.Text = "I max, mA";
            this.label9.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(8, 117);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(75, 20);
            this.label10.TabIndex = 13;
            this.label10.Text = "I min, mA";
            this.label10.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // maxItb
            // 
            this.maxItb.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::SupervisorCalc.Properties.Settings.Default, "MaxI", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.maxItb.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.maxItb.Location = new System.Drawing.Point(136, 140);
            this.maxItb.Name = "maxItb";
            this.maxItb.Size = new System.Drawing.Size(122, 38);
            this.maxItb.TabIndex = 12;
            this.maxItb.Text = global::SupervisorCalc.Properties.Settings.Default.MaxI;
            this.maxItb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // minItb
            // 
            this.minItb.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::SupervisorCalc.Properties.Settings.Default, "MinI", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.minItb.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.minItb.Location = new System.Drawing.Point(8, 140);
            this.minItb.Name = "minItb";
            this.minItb.Size = new System.Drawing.Size(122, 38);
            this.minItb.TabIndex = 11;
            this.minItb.Text = global::SupervisorCalc.Properties.Settings.Default.MinI;
            this.minItb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(132, 23);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 20);
            this.label8.TabIndex = 10;
            this.label8.Text = "U max, V";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(8, 23);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 20);
            this.label7.TabIndex = 9;
            this.label7.Text = "U min, V";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // maxUtb
            // 
            this.maxUtb.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::SupervisorCalc.Properties.Settings.Default, "MaxV", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.maxUtb.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.maxUtb.Location = new System.Drawing.Point(136, 46);
            this.maxUtb.Name = "maxUtb";
            this.maxUtb.Size = new System.Drawing.Size(122, 38);
            this.maxUtb.TabIndex = 3;
            this.maxUtb.Text = global::SupervisorCalc.Properties.Settings.Default.MaxV;
            this.maxUtb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // minUtb
            // 
            this.minUtb.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::SupervisorCalc.Properties.Settings.Default, "MinV", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.minUtb.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.minUtb.Location = new System.Drawing.Point(8, 46);
            this.minUtb.Name = "minUtb";
            this.minUtb.Size = new System.Drawing.Size(122, 38);
            this.minUtb.TabIndex = 2;
            this.minUtb.Text = global::SupervisorCalc.Properties.Settings.Default.MinV;
            this.minUtb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.button5);
            this.tabPage4.Controls.Add(this.button6);
            this.tabPage4.Controls.Add(this.button7);
            this.tabPage4.Controls.Add(this.button8);
            this.tabPage4.Controls.Add(this.button2);
            this.tabPage4.Controls.Add(this.button4);
            this.tabPage4.Controls.Add(this.button3);
            this.tabPage4.Controls.Add(this.button1);
            this.tabPage4.Controls.Add(this.seriestb);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(416, 646);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Resitors series";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(314, 586);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(96, 23);
            this.button5.TabIndex = 9;
            this.button5.Tag = "12";
            this.button5.Text = "Reset to E12";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(110, 586);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(96, 23);
            this.button6.TabIndex = 8;
            this.button6.Tag = "3";
            this.button6.Text = "Reset to E3";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(8, 586);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(96, 23);
            this.button7.TabIndex = 7;
            this.button7.Text = "Clear";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(212, 586);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(96, 23);
            this.button8.TabIndex = 6;
            this.button8.Tag = "6";
            this.button8.Text = "Reset to E6";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(314, 615);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(96, 23);
            this.button2.TabIndex = 5;
            this.button2.Tag = "192";
            this.button2.Text = "Reset to E192";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(110, 615);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(96, 23);
            this.button4.TabIndex = 4;
            this.button4.Tag = "48";
            this.button4.Text = "Reset to E48";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(8, 615);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(96, 23);
            this.button3.TabIndex = 3;
            this.button3.Tag = "24";
            this.button3.Text = "Reset to E24";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(212, 615);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 23);
            this.button1.TabIndex = 2;
            this.button1.Tag = "96";
            this.button1.Text = "Reset to E96";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // seriestb
            // 
            this.seriestb.Location = new System.Drawing.Point(3, 3);
            this.seriestb.Multiline = true;
            this.seriestb.Name = "seriestb";
            this.seriestb.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.seriestb.Size = new System.Drawing.Size(410, 577);
            this.seriestb.TabIndex = 0;
            this.seriestb.Text = resources.GetString("seriestb.Text");
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.snake1);
            this.tabPage2.Controls.Add(this.linkLabel1);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(416, 646);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "About";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(8, 628);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(115, 13);
            this.linkLabel1.TabIndex = 2;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "yakhontov@gmail.com";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(334, 91);
            this.label6.TabIndex = 0;
            this.label6.Text = resources.GetString("label6.Text");
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // CalcResWorker
            // 
            this.CalcResWorker.WorkerReportsProgress = true;
            this.CalcResWorker.WorkerSupportsCancellation = true;
            this.CalcResWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.CalcResWorker_DoWork);
            this.CalcResWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.CalcResWorker_ProgressChanged);
            this.CalcResWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.CalcResWorker_RunWorkerCompleted);
            // 
            // snake1
            // 
            this.snake1.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.snake1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.snake1.Location = new System.Drawing.Point(11, 12);
            this.snake1.Name = "snake1";
            this.snake1.Size = new System.Drawing.Size(391, 601);
            this.snake1.TabIndex = 1;
            this.snake1.Visible = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 672);
            this.Controls.Add(this.tabControl1);
            this.DataBindings.Add(new System.Windows.Forms.Binding("Location", global::SupervisorCalc.Properties.Settings.Default, "Location", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = global::SupervisorCalc.Properties.Settings.Default.Location;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Supervisor calculator";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox R3tb;
        private System.Windows.Forms.TextBox R2tb;
        private System.Windows.Forms.TextBox R1tb;
        private System.Windows.Forms.TextBox hiVoltTb;
        private System.Windows.Forms.RadioButton negRb;
        private System.Windows.Forms.TextBox loVoltTb;
        private System.Windows.Forms.RadioButton posRb;
        private System.Windows.Forms.Label label6;
        private Snake snake1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox maxUtb;
        private System.Windows.Forms.TextBox minUtb;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox maxItb;
        private System.Windows.Forms.TextBox minItb;
        private System.Windows.Forms.Button btnRunStop;
        private System.Windows.Forms.TextBox seriestb;
        private System.ComponentModel.BackgroundWorker CalcResWorker;
        private System.Windows.Forms.ProgressBar calcPB;
        private SourceGrid.Grid grid1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
    }
}

