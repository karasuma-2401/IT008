using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai07
{
    public partial class Cinema : Form
    {
        int[] seatStatus = new int[15];
        Button[] SeatBtns;

        public Cinema()
        {
            InitializeComponent();
            SeatBtns = new Button[]
            {
                seat1, seat2, seat3, seat4, seat5,
                seat6, seat7, seat8, seat9, seat10,
                seat11, seat12, seat13, seat14, seat15,
            };
            foreach (Button button in SeatBtns)
            {
                button.Click += SeatBtn_Click;
            }
        }
        private void SeatBtn_Click (object sender, EventArgs e)
        {
            Button clickedBtn = sender as Button;
            int seatIndex = Array.IndexOf(SeatBtns, clickedBtn);

            if (seatIndex == -1)
                return;
            if (seatStatus[seatIndex] == 0)
            {
                seatStatus[seatIndex] = 1;
                clickedBtn.BackColor = Color.Blue;
            }
            else if (seatStatus[seatIndex] == 1)
            {
                seatStatus[seatIndex] = 0;
                clickedBtn.BackColor = Color.White;
            }
            else
            {
                MessageBox.Show("Seat have been selected !");
            }
        }
        private void ChooseBtn_Click(object sender, EventArgs e)
        {
            long MoneySum = 0;
            for (int index =0; index < seatStatus.Length; index ++)
            {
                if (seatStatus[index] == 1)
                {
                    seatStatus[index] = -1;
                    // a position have been selected
                    SeatBtns[index].BackColor = Color.Yellow;
                    // check A slots
                    if (index >= 0 && index < 4)
                    {
                        MoneySum += 5000;
                    }
                    else if (index >= 5 && index <= 9)
                    {
                        MoneySum += 6500;
                    }
                    else
                        MoneySum += 8000;
                }
            }
            ThanhTien_Box.Text = MoneySum.ToString();
        }

        private void CancelBtn_CLick (object sender, EventArgs e)
        {
            for (int index = 0; index < seatStatus.Length; index++)
            {
                if (seatStatus[index] == 1)
                {
                    seatStatus[index] = 0;
                    SeatBtns[index].BackColor = Color.White;
                }
            }
            ThanhTien_Box.Text = "0";
        }
        private void FinishBtn_Click (object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}