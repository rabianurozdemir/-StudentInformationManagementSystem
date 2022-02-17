using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Threading;


namespace Ebakus
{
    public partial class Form1 : Form
    {
        static public MySqlConnection connection = new MySqlConnection("SERVER=remotemysql.com;PORT=3306;DATABASE=dJ66FYlFxK;UID=dJ66FYlFxK;PWD=4n9TcIA0tV;");
        bool move;
        int mouse_x;
        int mouse_y;

        public Form1()
        {
            
            InitializeComponent();

            
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            move = true;
            mouse_x = e.X;
            mouse_y = e.Y;
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            move = false;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (move)
            {
                this.SetDesktopLocation(MousePosition.X - mouse_x, MousePosition.Y - mouse_y);
            }
        }

        private void timeryukleniyor_Tick(object sender, EventArgs e)
        {
            paneldolu.Width += 1;
            paneldolu2.Width += 1;

            if (paneldolu.Width >=300)
            {
                try
                {
                    timeryukleniyor.Stop();
                    connection.Open();
                    connection.Close();
                    Login loginform = new Login();
                    loginform.Show();
                    this.Hide();
                    
                }
                catch (Exception)
                {

                    MessageBox.Show("Lütfen internet bağlantınızı kontrol ediniz");
                    Application.Exit();
                }
                
            }
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            
            
        }
    }
}
