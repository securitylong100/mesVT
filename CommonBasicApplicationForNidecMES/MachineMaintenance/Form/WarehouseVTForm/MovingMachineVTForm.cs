using Com.Nidec.Mes.Framework;
using Com.Nidec.Mes.Common.Basic.MachineMaintenance.Vo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using Com.Nidec.Mes.GlobalMasterMaintenance.Cbm;
using Com.Nidec.Mes.GlobalMasterMaintenance.Vo;
using Com.Nidec.Mes.Common.Basic.MachineMaintenance.Cbm;
using System.Net.NetworkInformation;
using System.Security.Cryptography;
namespace Com.Nidec.Mes.Common.Basic.MachineMaintenance.Form
{//WarehouseVTCheckForm
    public partial class MovingMachineVTForm : FormCommonNCVP
    {


        public MovingMachineVTForm()
        {
            InitializeComponent();
            warehouse_vt_dgv.AutoGenerateColumns = false;
        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            AddMovingMachineVTForm addmovingform = new AddMovingMachineVTForm();
            addmovingform.ShowDialog();

        }

        private void update_btn_Click(object sender, EventArgs e)
        {

        }

        private void delete_btn_Click(object sender, EventArgs e)
        {

        }
    }

}
