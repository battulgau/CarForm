using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(cmbAngilal.SelectedItem.ToString());
            Car myCar = new Car(txtZagvar.Text.Trim(), txtAralDugaar.Text.Trim(), txtUngu.Text.Trim(), Convert.ToInt32(maskOn.Text.Trim()), Convert.ToChar(cmbAngilal.SelectedItem.ToString()), maskUlsDugaar.Text.Trim());
            lblInfo.Text = myCar.Mashinii_medeelel_avah();
        }
    }
}
