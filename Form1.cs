using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeInformation
{
	public partial class frmUI : Form
	{
		public frmUI()
		{
			InitializeComponent();
		}

		private void frmUI_Load(object sender, EventArgs e)
		{
			// TODO: This line of code loads data into the 'dataSetEmployee.employee' table. You can move, or remove it, as needed.
			this.employeeTableAdapter.Fill(this.dataSetEmployee.employee);
			employeeBindingSource.DataSource = this.dataSetEmployee.employee;
		}

		private void btnExit_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show("Are you sure to exit?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
			{
				this.Close();
			}
		}

		private void btnNew_Click(object sender, EventArgs e)
		{
			try
			{
				pnlEntry.Enabled = true;
				txtFirstName.Focus();
				this.dataSetEmployee.employee.AddemployeeRow(this.dataSetEmployee.employee.NewemployeeRow());
				employeeBindingSource.MoveLast();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void btnEdit_Click(object sender, EventArgs e)
		{
			pnlEntry.Enabled = true;
			txtFirstName.Focus();
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			try
			{
				employeeBindingSource.EndEdit();
				employeeTableAdapter.Update(this.dataSetEmployee.employee);
				pnlEntry.Enabled = false;
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			pnlEntry.Enabled = false;
			employeeBindingSource.ResetBindings(false);
		}

		private void btnSearch_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(txtSearch.Text))
			{
				this.employeeTableAdapter.Fill(this.dataSetEmployee.employee);
				employeeBindingSource.DataSource = this.dataSetEmployee.employee;
			}
			else
			{
				var query = from o in this.dataSetEmployee.employee
							where o.lastname.Contains(txtSearch.Text) || o.email == txtSearch.Text || o.address.Contains(txtSearch.Text)
							select o;
				employeeBindingSource.DataSource = query.ToList();
			}
		}

		private void cboDept_SelectedValueChanged(object sender, EventArgs e)
		{
			txtDept.Text = cboDept.SelectedItem.ToString();
		}

		private void datePickerDOB_ValueChanged(object sender, EventArgs e)
		{
			txtDOB.Text = datePickerDOB.Value.ToShortDateString();
		}

		private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (e.KeyChar == (char)13)
			{
				if (string.IsNullOrEmpty(txtSearch.Text))
				{
					this.employeeTableAdapter.Fill(this.dataSetEmployee.employee);
					employeeBindingSource.DataSource = this.dataSetEmployee.employee;
				}
				else
				{
					var query = from o in this.dataSetEmployee.employee
								where o.lastname.Contains(txtSearch.Text) || o.email == txtSearch.Text || o.address.Contains(txtSearch.Text)
								select o;
					employeeBindingSource.DataSource = query.ToList();
				}
			}
		}

		private void dataGridView_KeyDown(object sender, KeyEventArgs e)
		{
			if(e.KeyCode == Keys.Delete)
			{
				if (MessageBox.Show("Are you sure want to delete this record?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
				{
					employeeBindingSource.RemoveCurrent();
				}
			}
		}
	}
}
