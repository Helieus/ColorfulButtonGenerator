using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            int x= 57 , y=99, row= 0 , cells =0 ;
            Random rnd = new Random();
            int userVal = int.Parse(InputInt.Text);
             List<Button> buttons = new List<Button>();
             for (int i = 1; i <= userVal; i++)
            {
                Color randomColor = Color.FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256));
                Button newButton = new Button();
                newButton.Name = "Butt" + i;
                newButton.BackColor = randomColor;
                newButton.Size = new Size(40, 40);
                newButton.Location = new Point(x + 50 * cells, y + 50 * row);
                cells++;
                if (i % 23 == 0)
                {
                    row++;
                    cells = 0;
                }
                newButton.Click += new EventHandler(NewButton_Click);
                newButton.Text =  i.ToString() ;
                buttons.Add(newButton);  //create new buttons
                this.Controls.Add(newButton);
            }
        }

        private void NewButton_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            int userVal = int.Parse(InputInt.Text);
            for (int i = 1; i <= userVal; i++)
            {
                if (btn.Name == ("Butt" + i))
                {
                    // When find specific button do what do you want.
                    //Then exit from loop by break.
                    MessageBox.Show(i.ToString());
                    break;
                }
            }
        }




        private void label1_Click(object sender, EventArgs e)
        {

        }

    
        private void TextBox_TextChanged(object sender, EventArgs e)
        {

        }
    
    }
}
