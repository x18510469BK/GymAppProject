using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
namespace GymAppProject
{
    public partial class frmtrainingPlan : Form
    {
        public frmtrainingPlan()
        {
            InitializeComponent();
        }
        public OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=db_users.mdb");
        public OleDbCommand cmd = new OleDbCommand();
        public OleDbDataAdapter da = new OleDbDataAdapter();
    }
}
