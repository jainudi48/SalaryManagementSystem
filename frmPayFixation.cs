using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Configuration;
using System.Data.SqlClient;

namespace WindowsFormsApplication1
{
    public partial class frmPayFixation : Form
    {
        Int64 empId, pay, gradePay;
        public frmPayFixation()
        {
            InitializeComponent();
        }

        private void frmPayFixation_Load(object sender, EventArgs e)
        {
            monthCalendar1.Visible = false;
            btnSubmit.Enabled = false;
            chkConfirm.Checked = false;
            chkConfirm.Enabled = false;

        }

        private void btnShowDatePanel_Click(object sender, EventArgs e)
        {
            monthCalendar1.Visible = true;
            monthCalendar1.MaxDate = DateTime.Now;
        }

        private void btnFetch_Click(object sender, EventArgs e)
        {
            if(!txtEmpID.Equals(""))
            {
                fetchPayByEmpID();
            }
        }
        private void fetchPayByEmpID()
        {
            Int64 empid = 0;
            try{
                empid = Convert.ToInt64(txtEmpID.Text.Trim());
                empId = empid;
            }
            catch(Exception e)
            {
                return;
            }
            
            string connectionStr = "Server = (localdb)\\MSSQLLocalDB; Initial Catalog = Sample; Integrated Security = true";
            using(SqlConnection con = new SqlConnection(connectionStr))
            {
                using (SqlCommand cmd = new SqlCommand("sp_getPayAndAgp", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@empid", empid);
                    cmd.Parameters.Add("@pay", SqlDbType.BigInt);
                    cmd.Parameters.Add("@gradepay", SqlDbType.BigInt);
                    cmd.Parameters["@pay"].Direction = ParameterDirection.Output;
                    cmd.Parameters["@gradepay"].Direction = ParameterDirection.Output;
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    txtPayBand.Text = cmd.Parameters["@pay"].Value.ToString();
                    txtGradePay.Text = cmd.Parameters["@gradepay"].Value.ToString();
                    try
                    {
                        pay = Convert.ToInt64(txtPayBand.Text);
                        gradePay = Convert.ToInt64(txtGradePay.Text);
                    }
                    catch(Exception e)
                    {
                        MessageBox.Show("No records for given EmpID!");
                        return;
                    }
                    
                    btnShowDatePanel.Enabled = true;
                }
            }
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            
        }

        private void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
        {
            txtEffectiveDate.Text = e.Start.ToShortDateString();
            chkConfirm.Enabled = true;
        }

        private void chkConfirm_CheckedChanged(object sender, EventArgs e)
        {
            Int64 newPay, newGradePay;
            if(chkConfirm.Checked)
            {
                if(txtPayBand.Text.Equals("") || txtGradePay.Text.Equals(""))
                {
                    MessageBox.Show("Pay and Paygrade fields can't be empty!");
                    chkConfirm.Checked = false;
                    return;
                }
                try
                {
                    Convert.ToDateTime(txtEffectiveDate.Text).ToShortDateString();
                }
                catch(Exception ee)
                {
                    MessageBox.Show("Invalid Date!");
                    chkConfirm.Checked = false;
                }
                newPay = Convert.ToInt64(txtPayBand.Text);
                newGradePay = Convert.ToInt64(txtGradePay.Text);
                if(newPay.Equals(pay) && newGradePay.Equals(gradePay))
                {
                    MessageBox.Show("Old and Current values can't be same!");
                    chkConfirm.Checked = false;
                    return;
                }
                btnSubmit.Enabled = true;

                txtEmpID.Enabled = false;
                txtPayBand.Enabled = false;
                txtGradePay.Enabled = false;
                txtEffectiveDate.Enabled = false;
            }
            else
            {
                btnSubmit.Enabled = false;

                txtEmpID.Enabled = true;
                txtPayBand.Enabled = true;
                txtGradePay.Enabled = true;
                txtEffectiveDate.Enabled = true;
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string conStr = "Server = (localdb)\\MSSQLLocalDB; Initial Catalog = Sample; Integrated Security = true";
            using (SqlConnection con = new SqlConnection(conStr))
            {
                using (SqlCommand cmd = new SqlCommand("sp_payFixation", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@empid", empId);
                    cmd.Parameters.AddWithValue("@newpay", Convert.ToInt64(txtPayBand.Text));
                    cmd.Parameters.AddWithValue("@newgradepay", Convert.ToInt64(txtGradePay.Text));
                    cmd.Parameters.AddWithValue("@effectivedate", Convert.ToDateTime(txtEffectiveDate.Text).Date);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Successfully Updated!");
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void txtGradePay_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

    }
}
