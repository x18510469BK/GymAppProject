using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GymAppProject
{
    public partial class dashboard : Form
    {
        public dashboard()
        {
            InitializeComponent();
        }


        private void btnTrainingPlan_Click_1(object sender, EventArgs e)
        {
            {
                new frmtrainingPlan().Show();
                this.Hide();
            }

        }

        private void btnDietPlan_Click(object sender, EventArgs e)
        {
            {
                new frmDietPlan().Show();
                this.Hide();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCalories_Click(object sender, EventArgs e)
        {
            {
                new frmcalorie().Show();
                this.Hide();
            }

        }
    }
}
