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
            vt_search_moving_dgv.AutoGenerateColumns = false;
        }
        private void MovingMachineVTForm_Load(object sender, EventArgs e)
        {
            ValueObjectList<WarehouseVTVo> machineserial = (ValueObjectList<WarehouseVTVo>)DefaultCbmInvoker.Invoke(new GetMachineSerialCbm(), new WarehouseVTVo());
            machine_serial_cmb.DisplayMember = "MachineSerial";
            machine_serial_cmb.DataSource = machineserial.GetList();
            machine_serial_cmb.Text = "";

            // factory_tranfer_cmb
            FactoryVo factory_tranfer = (FactoryVo)DefaultCbmInvoker.Invoke(new GetFactoryMasterMntCbm(), new FactoryVo());
            factory_tranfer_cmb.DisplayMember = "FactoryCode";
            factory_tranfer_cmb.DataSource = factory_tranfer.FactoryListVo;
            factory_tranfer_cmb.Text = "";

            FactoryVo factory_received = (FactoryVo)DefaultCbmInvoker.Invoke(new GetFactoryMasterMntCbm(), new FactoryVo());
            factory_received_cmb.DisplayMember = "FactoryCode";
            factory_received_cmb.DataSource = factory_received.FactoryListVo;
            factory_received_cmb.Text = "";
        }
        private void rfid_txt_TextChanged(object sender, EventArgs e)
        {
            if (rfid_txt.TextLength == 10)
            {
                ValueObjectList<WarehouseVTVo> machineserial = (ValueObjectList<WarehouseVTVo>)DefaultCbmInvoker.Invoke(new SearchMachineCbm(), new WarehouseVTVo { RFId = rfid_txt.Text });
                machine_serial_cmb.DisplayMember = "MachineSerial";
                machine_serial_cmb.DataSource = machineserial.GetList();
            }
        }
        private void code_status_cmb_SelectedIndexChanged(object sender, EventArgs e) //call disctint codename from each codestatus
        {
            ValueObjectList<MovingMachineVTVo> codename = (ValueObjectList<MovingMachineVTVo>)DefaultCbmInvoker.Invoke(new GetCodeNameMovingVTCbm(), new MovingMachineVTVo { CodeStatus = code_status_cmb.Text });
            code_name_cmb.DisplayMember = "CodeName";
            code_name_cmb.DataSource = codename.GetList();
            code_name_cmb.Text = "";
        }
        private void search_btn_Click(object sender, EventArgs e)
        {
            GindBind();

        }
        void GindBind()
        {
            try
            {
                MovingMachineVTVo inVo = new MovingMachineVTVo
                {
                    MachineSerial = machine_serial_cmb.Text,
                    ReceivedFactoryCode = factory_received_cmb.Text,
                    TranferFactoryCode = factory_tranfer_cmb.Text,
                    CodeStatus = code_status_cmb.Text,
                    CodeName = code_name_cmb.Text,
                };
                ValueObjectList<WarehouseVTVo> listvo = (ValueObjectList<WarehouseVTVo>)DefaultCbmInvoker.Invoke(new Cbm.SearchMovingVTCbm(), inVo);
                vt_search_moving_dgv.DataSource = listvo.GetList();
            }
            catch (Framework.ApplicationException exception)
            {
                popUpMessage.ApplicationError(exception.GetMessageData(), Text);
                logger.Error(exception.GetMessageData());
            }
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
