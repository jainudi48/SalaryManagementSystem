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
    public partial class frmFormulaFixation : Form
    {
        public frmFormulaFixation()
        {
            InitializeComponent();
        }

        private void frmFormulaFixation_Load(object sender, EventArgs e)
        {
            monthCalendar1.Visible = false;
            btnSubmit.Enabled = false;
            chkConfirm.Checked = false;
            chkConfirm.Enabled = false;
        }

        private void tbDaPercent_TextChanged(object sender, EventArgs e)
        {
            lblDaPercent.Text = txtDaPercent.Text + "% of PAY and AGP";
            btnShowDatePanel.Enabled = true;
        }

        private void tbHraPercent_TextChanged(object sender, EventArgs e)
        {
            lblHraPercent.Text = txtHraPercent.Text + "% of PAY and AGP";
            btnShowDatePanel.Enabled = true;
        }

        private void tbDaOnTraPercent_TextChanged(object sender, EventArgs e)
        {
            lblDaOnTraPercent.Text = txtDaOnTraPercent.Text + "% of TRA";
            btnShowDatePanel.Enabled = true;
        }

        private void btnShowDatePanel_Click(object sender, EventArgs e)
        {
            monthCalendar1.Visible = true;
        }

        private void tbDaOnTraPercent_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            txtEffectiveDate.Text = e.Start.ToShortDateString();
            chkConfirm.Enabled = true;
        }

        private void chkConfirm_CheckedChanged(object sender, EventArgs e)
        {
            Decimal newDaPercent, newHraPercent, newDaOnTraPercent;
            if(chkConfirm.Checked)
            {
                if (!txtDaPercent.Text.Equals("") && !txtHraPercent.Text.Equals("") && !txtDaOnTraPercent.Text.Equals(""))
                {
                    try
                    {
                        newDaPercent = Convert.ToDecimal(txtDaPercent.Text);
                        newHraPercent = Convert.ToDecimal(txtHraPercent.Text);
                        newDaOnTraPercent = Convert.ToDecimal(txtDaOnTraPercent.Text);
                    }
                    catch(Exception ee)
                    {
                        MessageBox.Show("Unexpected values found!");
                        chkConfirm.Checked = false;
                    }
                    try
                    {
                        Convert.ToDateTime(txtEffectiveDate.Text).ToShortDateString();
                    }
                    catch (Exception ee)
                    {
                        MessageBox.Show("Invalid Date!");
                        chkConfirm.Checked = false;
                    }
                    btnSubmit.Enabled = true;

                    txtDaPercent.Enabled = false;
                    txtHraPercent.Enabled = false;
                    txtDaOnTraPercent.Enabled = false;
                    txtEffectiveDate.Enabled = false;
                }
                else
                {
                    MessageBox.Show("Fields can't be empty!");
                    chkConfirm.Checked = false;
                }
            }
            else
            {
                btnSubmit.Enabled = false;

                txtDaPercent.Enabled = true;
                txtHraPercent.Enabled = true;
                txtDaOnTraPercent.Enabled = true;
                txtEffectiveDate.Enabled = true;
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string conStr = "Server = (localdb)\\MSSQLLocalDB; Initial Catalog = Sample; Integrated Security = true";
            using(SqlConnection con = new SqlConnection(conStr))
            {
                using(SqlCommand cmd = new SqlCommand("sp_updateFormulas", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@dapercent", Convert.ToDecimal(txtDaPercent.Text));
                    cmd.Parameters.AddWithValue("@hrapercent", Convert.ToDecimal(txtHraPercent.Text));
                    cmd.Parameters.AddWithValue("@daontrapercent", Convert.ToDecimal(txtDaOnTraPercent.Text));
                    cmd.Parameters.AddWithValue("@effectivedate", Convert.ToDateTime(txtEffectiveDate.Text).Date);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
            }
        }
    }
}
