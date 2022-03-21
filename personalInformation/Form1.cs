using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace personalInformation
{
    public partial class frmPersonal_information : Form
    {
       private PersonalDataEntities _db;
        public frmPersonal_information()
        {
            InitializeComponent();
            _db = new PersonalDataEntities();
        }
        
        private void btnSave_Click(object sender, EventArgs e)
        {
            personalData nxt = new personalData();
            nxt.FIRST_NAME = txtFirstName.Text;
            nxt.LAST_NAME = txtLastName.Text;
            nxt.CAR_MODEL = cmbCarBrand.Text;
            nxt.DATE_OF_BIRTH = dtDateOfBirth.Text;
            var dtAge = DateTime.Parse(dtDateOfBirth.Text);
            nxt.AGE = DateTime.Now.Year - dtAge.Year;
            nxt.RENTAL_DATE = dtRentalDate.Text;
            nxt.RETURN_DATE = dtReturnDate.Text;

            var renDate = DateTime.Parse(dtRentalDate.Text);
            var retDate = DateTime.Parse(dtReturnDate.Text);
            double dailyRate = 5000.00;
            var days = (retDate.Day - renDate.Day)*dailyRate;
            nxt.DEPOSIT = days.ToString();

            nxt.LATE_RETURN = dtLateReturn.Text;

            var lateDate = DateTime.Parse(dtLateReturn.Text).Day - retDate.Day;
            //dailyRate *= Convert.ToDouble(lateDate); Just testing different ways to do the same operation
            //nxt.BALANCE = dailyRate.ToString();  
            nxt.BALANCE = (Convert.ToDouble(lateDate) * dailyRate).ToString(); //This line compounds the previous 2 lines to achieve the same result
            var totPaid = days + (lateDate * dailyRate);
            nxt.TOTAL_PAID = totPaid.ToString();
                        
            _db.personalDatas.Add(nxt);
            _db.SaveChanges();

            
  
            var ageString = nxt.AGE.ToString();
            lblAgeDisplay.Text = ageString;
            //var depositString = nxt.DEPOSIT.ToString();
            lblDisplay.Text = nxt.DEPOSIT;
            lblBalance.Text = nxt.BALANCE;
            lblTotalPaid.Text = nxt.TOTAL_PAID;
            
            MessageBox.Show("Success");
        }

        private void frmPersonal_information_Load(object sender, EventArgs e)
        {
            personalData nxt2 = new personalData();

        }
    }
}
