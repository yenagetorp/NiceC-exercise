using NumberUtils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EventsWindwsForm
{
    public partial class Form1 : Form
    {
        //skapa instans
        NumberGenerator numberGenerator = new NumberGenerator();
        public Form1()
        {
            InitializeComponent();
            //pprenumerera ett event
            numberGenerator.Even += NumberGenerator_Even;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            numberGenerator.Start();
        }

        private void NumberGenerator_Even(int i)
        {
            if (i%2==0)
            {
                lstEvenNumbers.Items.Add($"{i} is even");
            }
            else
            {
                lstOddNumbers.Items.Add($"{i} is odd");
            }
        }

        private void lstOddNumbers_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
