using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace SupervisorCalc
{
    public partial class Snake : UserControl
    {
        const int cellSize = 30;
        const int cellBordrer = 5;
        const int fieldWidth = 11;
        const int fieldHeight = 17;

        int[,] cells = new int[fieldWidth, fieldHeight];

        Snakie snake = new Snakie();

        Brush rabbit = Brushes.Red;
        Brush body = Brushes.Blue;
        Brush space = SystemBrushes.Control;

        Random r = new Random();

        public Snake()
        {
            InitializeComponent();
            TabStop = true;
            SetStyle(ControlStyles.Selectable, true);
            TabStop = true;
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            this.Focus();
            base.OnMouseDown(e);
        }

        protected override bool IsInputKey(Keys keyData)
        {
            if (keyData == Keys.Up || keyData == Keys.Down) return true;
            if (keyData == Keys.Left || keyData == Keys.Right) return true;
            return base.IsInputKey(keyData);
        }

        protected override void OnEnter(EventArgs e)
        {
            this.Invalidate();
            base.OnEnter(e);
        }

        protected override void OnLeave(EventArgs e)
        {
            this.Invalidate();
            base.OnLeave(e);
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
            if (this.Focused)
            {
                var rc = this.ClientRectangle;
                rc.Inflate(-2, -2);
                ControlPaint.DrawFocusRectangle(pe.Graphics, rc);
            }
        }

        private void Snake_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Brush b;
            for (int x = 0; x < fieldWidth; x++)
                for (int y = 0; y < fieldHeight; y++)
                {
                    if (cells[x, y] > 0)
                        b = body;
                    else
                    {
                        if (cells[x, y] < 0)
                            b = rabbit;
                        else
                            b = space;
                    }
                    if (!snake.Live)
                        b = Brushes.Black;
                    g.FillRectangle(b, x * (cellBordrer + cellSize) + cellBordrer, y * (cellBordrer + cellSize) + cellBordrer, cellSize, cellSize);
                }
        }

        private void Snake_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up || e.KeyCode == Keys.Left || e.KeyCode == Keys.Down || e.KeyCode == Keys.Right)

                if (!((e.KeyCode == Keys.Up && snake.Dir == Keys.Down) ||
                    (e.KeyCode == Keys.Down && snake.Dir == Keys.Up) ||
                    (e.KeyCode == Keys.Left && snake.Dir == Keys.Right) ||
                    (e.KeyCode == Keys.Right && snake.Dir == Keys.Left)))
                    snake.Dir = e.KeyCode;
        }

        private void placeRandomRabbit()
        {
            int x, y;
            do
            {
                x = r.Next(fieldWidth);
                y = r.Next(fieldHeight);
            }
            while (cells[x, y] != 0);
            cells[x, y] = -1;
        }

        private void redrawTimer_Tick(object sender, EventArgs e)
        {
            int newX = snake.PosX;
            int newY = snake.PosY;

            switch (snake.Dir)
            {
                case Keys.Left:
                    newX--;
                    break;
                case Keys.Up:
                    newY--;
                    break;
                case Keys.Right:
                    newX++;
                    break;
                case Keys.Down:
                    newY++;
                    break;
            }
            if (snake.Live == false || newX < 0 || newX > (fieldWidth - 1) || newY < 0 || newY > (fieldHeight - 1) || cells[newX, newY] > 0)
            {
                snake.Live = false;
                Visible = false;
                redrawTimer.Enabled = false;
            }
            else
            {
                if (cells[newX, newY] < 0)
                {
                    snake.Len++;
                    placeRandomRabbit();
                    Text = snake.Len.ToString();
                }
                else
                    for (int x = 0; x < fieldWidth; x++)
                        for (int y = 0; y < fieldHeight; y++)
                        {
                            if (cells[x, y] > 0)
                                cells[x, y]--;
                        }

                cells[newX, newY] = snake.Len;
                snake.PosX = newX;
                snake.PosY = newY;
            }
            Invalidate();
        }

        private void Snake_Load(object sender, EventArgs e)
        {
            Run();
        }

        public void Run()
        {
            Array.Clear(cells, 0, cells.Length);

            snake.Reset(fieldWidth / 2, fieldHeight - 1);

            placeRandomRabbit();
            Visible = true;
            Invalidate();
            redrawTimer.Enabled = true;
        }
    }

    public class Snakie
    {
        public int PosX = 0;
        public int PosY = 0;
        public int Len = 1;
        public Keys Dir = Keys.Up;
        public bool Live = true;

        public void Reset(int x, int y)
        {
            PosX = x;
            PosY = y;
            Len = 1;
            Dir = Keys.Up;
            Live = true;
        }
    }
}
