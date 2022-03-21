using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarMart_home
{
    public partial class CarMart_Home : Form
    {
        private sof_carMartEntities1 _db;
        public CarMart_Home()
        {
            InitializeComponent();
            _db = new sof_carMartEntities1();            
        }

        

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cmbMake.Text))
            {
                MessageBox.Show("All fields are required!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
               
            }
            else
            {
                
                sofCarMart newEntry = new sofCarMart();
                newEntry.MAKE = cmbMake.SelectedValue.ToString();
                newEntry.MODEL = cbModel.SelectedValue.ToString();
                newEntry.YEAR = cmbYear.SelectedValue.ToString();
                //var date_out = dtDateOut.Value.ToString();
                //newEntry.DATE_OUT = DateTime.Parse(date_out);
                //var date_ex = dtExpReturn.Value.ToString();
                //newEntry.DATE_EXP_RETURN = DateTime.Parse(date_ex);
                //var date_ac = dtReturned.Value.ToString();
                //newEntry.DATE_ACTUAL_RETURN = DateTime.Parse(date_ac);

                _db.sofCarMarts.Add(newEntry);
                _db.SaveChanges();
                MessageBox.Show("Save Successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information );
            }
        }


    }
}
