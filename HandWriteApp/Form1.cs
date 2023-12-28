using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HandWriteApp
{
    public partial class Form1 : Form
    {
        private Bitmap big_bitmap;
        private Bitmap small_bitmap;
        private Graphics big_graphics;
        private Graphics small_graphics;
        SolidBrush brush;
        private int CurrentX;
        private int CurrentY;
        private bool isClick;

        byte[] picByte;

        SerialPort serialPort;

        public Form1()
        {
            InitializeComponent();
            PictureInit();
        }

        #region HandWriteRegion
        private void PictureInit()
        {
            isClick = false;
            picByte = new byte[28 * 28];
            big_bitmap = new Bitmap(280, 280);
            big_graphics = Graphics.FromImage(big_bitmap);

            small_bitmap = new Bitmap(28, 28);
            small_graphics = Graphics.FromImage(small_bitmap);

            big_graphics.Clear(Color.White);
            small_graphics.Clear(Color.Black);
            brush = new SolidBrush(Color.Black);
            pictureBox_big.Image = big_bitmap;
            pictureBox_small.Image = small_bitmap;

        }

        private void PictureClear()
        {
            big_graphics.Clear(Color.White);
            pictureBox_big.Image = big_bitmap;

            small_graphics.Clear(Color.Black);
            pictureBox_small.Image = small_bitmap;
        }

        private void PictureDrawLine(int x, int y)
        {
            big_graphics.FillEllipse(brush, CurrentX, CurrentY, 25, 25);
            CurrentX = x;
            CurrentY = y;
            pictureBox_big.Image = big_bitmap;
        }
        private void btn_clearPic_Click(object sender, EventArgs e)
        {
            PictureClear();
        }

        private void pictureBox_big_MouseDown(object sender, MouseEventArgs e)
        {
            isClick = true;
            CurrentX = e.X;
            CurrentY = e.Y;
            //tb_log.Text = $"{CurrentX},{CurrentY}";
        }

        private void pictureBox_big_MouseUp(object sender, MouseEventArgs e)
        {
            isClick = false;
            for (int y = 0; y < 28; y++)
            {
                for (int x = 0; x < 28; x++)
                {
                    picByte[y *28+ x] = 0;
                    Color c = big_bitmap.GetPixel(x*10, y* 10);
                    if (c.R == 0 && c.G == 0 && c.B == 0)
                    {
                        small_bitmap.SetPixel(x, y, Color.White);
                        picByte[y * 28 + x] = 1;
                    }
                }
            }
            pictureBox_small.Image = small_bitmap;
        }

        private void pictureBox_big_MouseMove(object sender, MouseEventArgs e)
        {
            if (isClick)
            {
                PictureDrawLine(e.X, e.Y);
            }
        }

        #endregion

        #region SerialSend

        private void comboBox_COM_MouseClick(object sender, MouseEventArgs e)
        {
            string[] coms = System.IO.Ports.SerialPort.GetPortNames();
            comboBox_COM.Items.Clear();
            comboBox_COM.Items.AddRange(coms);
        }
  

        private void btn_serial_open_Click(object sender, EventArgs e)
        {
            try
            {
                if (btn_serial_open.Text == "Open")
                {
                    btn_serial_open.Text = "Close";
                    serialPort = new SerialPort(comboBox_COM.Text, Convert.ToInt32(tb_baud.Text));
                    serialPort.DataReceived += SerialReadEven;
                    serialPort.Open();
                }
                else
                {
                    btn_serial_open.Text = "Open";
                    serialPort.Close();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Serial open/close error:" + ex.Message, "Error");
            }
        }

        void SerialReadEven(object sender, SerialDataReceivedEventArgs e)
        {
            try
            {
                string msg  = serialPort.ReadLine();
                this.Invoke(new Action(() =>
                {
                    tb_log.Text += msg+"\r\n";
                }));
            }
            catch (Exception ex)
            {
                MessageBox.Show("Serial read error:" + ex.Message, "Error");
            }

        }

        private void btn_Send_Click(object sender, EventArgs e)
        {
            try
            {
                tb_log.Text = "";
                byte[] cmdHead = { 0XAA };
                byte[] cmdEnd = { 0X0D, 0X0A };

                if (serialPort != null && serialPort.IsOpen)
                {
                    serialPort.DiscardInBuffer();
                    serialPort.Write(cmdHead, 0, cmdHead.Length);
                    serialPort.Write(picByte, 0, picByte.Length);
                    serialPort.Write(cmdEnd, 0, cmdEnd.Length);
                }
            }
            catch (Exception ex )
            {
                MessageBox.Show("Serial send error:" + ex.Message, "Error");
            }
        }
        #endregion
    }
}
