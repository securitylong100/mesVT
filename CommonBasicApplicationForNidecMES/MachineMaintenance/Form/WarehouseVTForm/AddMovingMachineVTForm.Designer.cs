namespace Com.Nidec.Mes.Common.Basic.MachineMaintenance.Form
{
    partial class AddMovingMachineVTForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.setting_gbc = new Com.Nidec.Mes.Framework.GroupBoxCommon();
            this.add_btn = new Com.Nidec.Mes.Framework.ButtonCommon();
            this.update_btn = new Com.Nidec.Mes.Framework.ButtonCommon();
            this.delete_btn = new Com.Nidec.Mes.Framework.ButtonCommon();
            this.search_btn = new Com.Nidec.Mes.Framework.ButtonCommon();
            this.warehouse_vt_dgv = new Com.Nidec.Mes.Framework.DataGridViewCommon();
            this.col_machineid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_rfid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_machinecode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_usercode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_datetime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_machinename = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_machineqty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_machineserial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_machinemodel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_machinelocation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_machinesupplier = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colfactorycd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_machineinvoice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_machinecostvalue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCheckTime_final = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.machine_serial_cmb = new Com.Nidec.Mes.Framework.ComboBoxCommon();
            this.serialmachine_lbl = new Com.Nidec.Mes.Framework.LabelCommon();
            this.factory_received_lbl = new Com.Nidec.Mes.Framework.LabelCommon();
            this.factory_received_cmb = new Com.Nidec.Mes.Framework.ComboBoxCommon();
            this.factory_tranfer_lbl = new Com.Nidec.Mes.Framework.LabelCommon();
            this.factory_tranfer_cmb = new Com.Nidec.Mes.Framework.ComboBoxCommon();
            this.rfid_txt = new Com.Nidec.Mes.Framework.TextBoxCommon();
            this.rfid_lbl = new Com.Nidec.Mes.Framework.LabelCommon();
            this.code_name_cmb = new Com.Nidec.Mes.Framework.TextBoxCommon();
            this.code_name_lbl = new Com.Nidec.Mes.Framework.LabelCommon();
            this.code_status_cmb = new Com.Nidec.Mes.Framework.ComboBoxCommon();
            this.code_status_lbl = new Com.Nidec.Mes.Framework.LabelCommon();
            this.setting_gbc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.warehouse_vt_dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // setting_gbc
            // 
            this.setting_gbc.ControlId = null;
            this.setting_gbc.Controls.Add(this.add_btn);
            this.setting_gbc.Controls.Add(this.update_btn);
            this.setting_gbc.Controls.Add(this.delete_btn);
            this.setting_gbc.Controls.Add(this.search_btn);
            this.setting_gbc.Font = new System.Drawing.Font("Arial", 9F);
            this.setting_gbc.Location = new System.Drawing.Point(45, 193);
            this.setting_gbc.Name = "setting_gbc";
            this.setting_gbc.Size = new System.Drawing.Size(421, 64);
            this.setting_gbc.TabIndex = 60;
            this.setting_gbc.TabStop = false;
            // 
            // add_btn
            // 
            this.add_btn.BackColor = System.Drawing.SystemColors.Control;
            this.add_btn.ControlId = "";
            this.add_btn.Font = new System.Drawing.Font("Arial", 9F);
            this.add_btn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.add_btn.Location = new System.Drawing.Point(114, 20);
            this.add_btn.Name = "add_btn";
            this.add_btn.Size = new System.Drawing.Size(88, 33);
            this.add_btn.TabIndex = 11;
            this.add_btn.Text = "Add";
            this.add_btn.UseVisualStyleBackColor = false;
            this.add_btn.Click += new System.EventHandler(this.add_btn_Click);
            // 
            // update_btn
            // 
            this.update_btn.BackColor = System.Drawing.SystemColors.Control;
            this.update_btn.ControlId = "";
            this.update_btn.Font = new System.Drawing.Font("Arial", 9F);
            this.update_btn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.update_btn.Location = new System.Drawing.Point(220, 20);
            this.update_btn.Name = "update_btn";
            this.update_btn.Size = new System.Drawing.Size(84, 33);
            this.update_btn.TabIndex = 11;
            this.update_btn.Text = "Update";
            this.update_btn.UseVisualStyleBackColor = false;
            this.update_btn.Click += new System.EventHandler(this.update_btn_Click);
            // 
            // delete_btn
            // 
            this.delete_btn.BackColor = System.Drawing.SystemColors.Control;
            this.delete_btn.ControlId = null;
            this.delete_btn.Font = new System.Drawing.Font("Arial", 9F);
            this.delete_btn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.delete_btn.Location = new System.Drawing.Point(320, 20);
            this.delete_btn.Name = "delete_btn";
            this.delete_btn.Size = new System.Drawing.Size(90, 33);
            this.delete_btn.TabIndex = 10;
            this.delete_btn.Text = "Delete";
            this.delete_btn.UseVisualStyleBackColor = false;
            this.delete_btn.Click += new System.EventHandler(this.delete_btn_Click);
            // 
            // search_btn
            // 
            this.search_btn.BackColor = System.Drawing.SystemColors.Control;
            this.search_btn.ControlId = null;
            this.search_btn.Font = new System.Drawing.Font("Arial", 9F);
            this.search_btn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.search_btn.Location = new System.Drawing.Point(15, 20);
            this.search_btn.Name = "search_btn";
            this.search_btn.Size = new System.Drawing.Size(80, 33);
            this.search_btn.TabIndex = 10;
            this.search_btn.Text = "Search";
            this.search_btn.UseVisualStyleBackColor = false;
            // 
            // warehouse_vt_dgv
            // 
            this.warehouse_vt_dgv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.warehouse_vt_dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.warehouse_vt_dgv.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(232)))), ((int)(((byte)(180)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.warehouse_vt_dgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.warehouse_vt_dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_machineid,
            this.col_rfid,
            this.col_machinecode,
            this.col_usercode,
            this.col_datetime,
            this.col_machinename,
            this.col_machineqty,
            this.col_machineserial,
            this.col_machinemodel,
            this.col_machinelocation,
            this.col_machinesupplier,
            this.colfactorycd,
            this.col_machineinvoice,
            this.col_machinecostvalue,
            this.colCheckTime_final});
            this.warehouse_vt_dgv.ControlId = null;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.warehouse_vt_dgv.DefaultCellStyle = dataGridViewCellStyle5;
            this.warehouse_vt_dgv.Location = new System.Drawing.Point(4, 355);
            this.warehouse_vt_dgv.Name = "warehouse_vt_dgv";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(232)))), ((int)(((byte)(180)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.warehouse_vt_dgv.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.warehouse_vt_dgv.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.warehouse_vt_dgv.Size = new System.Drawing.Size(946, 340);
            this.warehouse_vt_dgv.TabIndex = 75;
            // 
            // col_machineid
            // 
            this.col_machineid.DataPropertyName = "MachineId";
            this.col_machineid.HeaderText = "Machine ID";
            this.col_machineid.Name = "col_machineid";
            this.col_machineid.Visible = false;
            this.col_machineid.Width = 93;
            // 
            // col_rfid
            // 
            this.col_rfid.DataPropertyName = "RFId";
            this.col_rfid.HeaderText = "RFID ";
            this.col_rfid.Name = "col_rfid";
            this.col_rfid.Width = 63;
            // 
            // col_machinecode
            // 
            this.col_machinecode.DataPropertyName = "MachineCode";
            this.col_machinecode.HeaderText = "Code Name";
            this.col_machinecode.Name = "col_machinecode";
            this.col_machinecode.Width = 99;
            // 
            // col_usercode
            // 
            this.col_usercode.DataPropertyName = "RegistrationUserCode";
            this.col_usercode.HeaderText = "User Add";
            this.col_usercode.Name = "col_usercode";
            this.col_usercode.Width = 82;
            // 
            // col_datetime
            // 
            this.col_datetime.DataPropertyName = "RegistrationDateTime";
            this.col_datetime.HeaderText = "Date Time Add";
            this.col_datetime.Name = "col_datetime";
            this.col_datetime.Width = 112;
            // 
            // col_machinename
            // 
            this.col_machinename.DataPropertyName = "MachineName";
            this.col_machinename.HeaderText = "Machine Name";
            this.col_machinename.Name = "col_machinename";
            this.col_machinename.Width = 115;
            // 
            // col_machineqty
            // 
            this.col_machineqty.DataPropertyName = "MachineQty";
            this.col_machineqty.HeaderText = "Machine Qty";
            this.col_machineqty.Name = "col_machineqty";
            this.col_machineqty.Width = 98;
            // 
            // col_machineserial
            // 
            this.col_machineserial.DataPropertyName = "MachineSerial";
            this.col_machineserial.HeaderText = "Machine Serial";
            this.col_machineserial.Name = "col_machineserial";
            this.col_machineserial.Width = 113;
            // 
            // col_machinemodel
            // 
            this.col_machinemodel.DataPropertyName = "MachineModel";
            this.col_machinemodel.HeaderText = "Machine Model";
            this.col_machinemodel.Name = "col_machinemodel";
            this.col_machinemodel.Width = 114;
            // 
            // col_machinelocation
            // 
            this.col_machinelocation.DataPropertyName = "MachineLocation";
            this.col_machinelocation.HeaderText = "Before Factory";
            this.col_machinelocation.Name = "col_machinelocation";
            this.col_machinelocation.Width = 110;
            // 
            // col_machinesupplier
            // 
            this.col_machinesupplier.DataPropertyName = "MachineSupplier";
            this.col_machinesupplier.HeaderText = "After Factory";
            this.col_machinesupplier.Name = "col_machinesupplier";
            this.col_machinesupplier.Width = 98;
            // 
            // colfactorycd
            // 
            this.colfactorycd.DataPropertyName = "FactoryCode";
            this.colfactorycd.HeaderText = "Factory";
            this.colfactorycd.Name = "colfactorycd";
            this.colfactorycd.Width = 71;
            // 
            // col_machineinvoice
            // 
            this.col_machineinvoice.DataPropertyName = "MachineInvoice";
            this.col_machineinvoice.HeaderText = "Machine Invoice";
            this.col_machineinvoice.Name = "col_machineinvoice";
            this.col_machineinvoice.Width = 119;
            // 
            // col_machinecostvalue
            // 
            this.col_machinecostvalue.DataPropertyName = "MachineCostValue";
            this.col_machinecostvalue.HeaderText = "Cost";
            this.col_machinecostvalue.Name = "col_machinecostvalue";
            this.col_machinecostvalue.Width = 58;
            // 
            // colCheckTime_final
            // 
            this.colCheckTime_final.DataPropertyName = "TimeCheck";
            this.colCheckTime_final.HeaderText = "Check Time";
            this.colCheckTime_final.Name = "colCheckTime_final";
            this.colCheckTime_final.Width = 98;
            // 
            // machine_serial_cmb
            // 
            this.machine_serial_cmb.ControlId = null;
            this.machine_serial_cmb.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.machine_serial_cmb.FormattingEnabled = true;
            this.machine_serial_cmb.Location = new System.Drawing.Point(202, 163);
            this.machine_serial_cmb.Name = "machine_serial_cmb";
            this.machine_serial_cmb.Size = new System.Drawing.Size(121, 23);
            this.machine_serial_cmb.TabIndex = 80;
            // 
            // serialmachine_lbl
            // 
            this.serialmachine_lbl.AutoSize = true;
            this.serialmachine_lbl.ControlId = null;
            this.serialmachine_lbl.Font = new System.Drawing.Font("Arial", 9F);
            this.serialmachine_lbl.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.serialmachine_lbl.Location = new System.Drawing.Point(199, 145);
            this.serialmachine_lbl.Name = "serialmachine_lbl";
            this.serialmachine_lbl.Size = new System.Drawing.Size(88, 15);
            this.serialmachine_lbl.TabIndex = 81;
            this.serialmachine_lbl.Text = "Serial Machine";
            // 
            // factory_received_lbl
            // 
            this.factory_received_lbl.AutoSize = true;
            this.factory_received_lbl.ControlId = null;
            this.factory_received_lbl.Font = new System.Drawing.Font("Arial", 9F);
            this.factory_received_lbl.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.factory_received_lbl.Location = new System.Drawing.Point(506, 149);
            this.factory_received_lbl.Name = "factory_received_lbl";
            this.factory_received_lbl.Size = new System.Drawing.Size(100, 15);
            this.factory_received_lbl.TabIndex = 85;
            this.factory_received_lbl.Text = "Factory Received";
            // 
            // factory_received_cmb
            // 
            this.factory_received_cmb.ControlId = null;
            this.factory_received_cmb.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.factory_received_cmb.FormattingEnabled = true;
            this.factory_received_cmb.Location = new System.Drawing.Point(509, 167);
            this.factory_received_cmb.Name = "factory_received_cmb";
            this.factory_received_cmb.Size = new System.Drawing.Size(121, 23);
            this.factory_received_cmb.TabIndex = 84;
            // 
            // factory_tranfer_lbl
            // 
            this.factory_tranfer_lbl.AutoSize = true;
            this.factory_tranfer_lbl.ControlId = null;
            this.factory_tranfer_lbl.Font = new System.Drawing.Font("Arial", 9F);
            this.factory_tranfer_lbl.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.factory_tranfer_lbl.Location = new System.Drawing.Point(356, 147);
            this.factory_tranfer_lbl.Name = "factory_tranfer_lbl";
            this.factory_tranfer_lbl.Size = new System.Drawing.Size(88, 15);
            this.factory_tranfer_lbl.TabIndex = 87;
            this.factory_tranfer_lbl.Text = "Factory Tranfer";
            // 
            // factory_tranfer_cmb
            // 
            this.factory_tranfer_cmb.ControlId = null;
            this.factory_tranfer_cmb.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.factory_tranfer_cmb.FormattingEnabled = true;
            this.factory_tranfer_cmb.Location = new System.Drawing.Point(359, 165);
            this.factory_tranfer_cmb.Name = "factory_tranfer_cmb";
            this.factory_tranfer_cmb.Size = new System.Drawing.Size(121, 23);
            this.factory_tranfer_cmb.TabIndex = 86;
            // 
            // rfid_txt
            // 
            this.rfid_txt.ControlId = null;
            this.rfid_txt.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rfid_txt.InputType = Com.Nidec.Mes.Framework.TextBoxCommon.InputTypeList.All;
            this.rfid_txt.Location = new System.Drawing.Point(45, 163);
            this.rfid_txt.Multiline = true;
            this.rfid_txt.Name = "rfid_txt";
            this.rfid_txt.Size = new System.Drawing.Size(120, 24);
            this.rfid_txt.TabIndex = 99;
            this.rfid_txt.TextChanged += new System.EventHandler(this.rfid_txt_TextChanged);
            // 
            // rfid_lbl
            // 
            this.rfid_lbl.AutoSize = true;
            this.rfid_lbl.ControlId = null;
            this.rfid_lbl.Font = new System.Drawing.Font("Arial", 9F);
            this.rfid_lbl.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.rfid_lbl.Location = new System.Drawing.Point(61, 145);
            this.rfid_lbl.Name = "rfid_lbl";
            this.rfid_lbl.Size = new System.Drawing.Size(83, 15);
            this.rfid_lbl.TabIndex = 101;
            this.rfid_lbl.Text = "RFID Number";
            // 
            // code_name_cmb
            // 
            this.code_name_cmb.ControlId = null;
            this.code_name_cmb.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.code_name_cmb.InputType = Com.Nidec.Mes.Framework.TextBoxCommon.InputTypeList.All;
            this.code_name_cmb.Location = new System.Drawing.Point(802, 167);
            this.code_name_cmb.Multiline = true;
            this.code_name_cmb.Name = "code_name_cmb";
            this.code_name_cmb.Size = new System.Drawing.Size(106, 23);
            this.code_name_cmb.TabIndex = 102;
            // 
            // code_name_lbl
            // 
            this.code_name_lbl.AutoSize = true;
            this.code_name_lbl.ControlId = null;
            this.code_name_lbl.Font = new System.Drawing.Font("Arial", 9F);
            this.code_name_lbl.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.code_name_lbl.Location = new System.Drawing.Point(809, 149);
            this.code_name_lbl.Name = "code_name_lbl";
            this.code_name_lbl.Size = new System.Drawing.Size(77, 15);
            this.code_name_lbl.TabIndex = 103;
            this.code_name_lbl.Text = "Code Name:";
            // 
            // code_status_cmb
            // 
            this.code_status_cmb.ControlId = null;
            this.code_status_cmb.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.code_status_cmb.FormattingEnabled = true;
            this.code_status_cmb.Items.AddRange(new object[] {
            "Bàn Giao",
            "Mượn",
            "Trả",
            "Thuê"});
            this.code_status_cmb.Location = new System.Drawing.Point(660, 167);
            this.code_status_cmb.Name = "code_status_cmb";
            this.code_status_cmb.Size = new System.Drawing.Size(121, 23);
            this.code_status_cmb.TabIndex = 84;
            this.code_status_cmb.SelectedIndexChanged += new System.EventHandler(this.code_status_cmb_SelectedIndexChanged);
            // 
            // code_status_lbl
            // 
            this.code_status_lbl.AutoSize = true;
            this.code_status_lbl.ControlId = null;
            this.code_status_lbl.Font = new System.Drawing.Font("Arial", 9F);
            this.code_status_lbl.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.code_status_lbl.Location = new System.Drawing.Point(657, 149);
            this.code_status_lbl.Name = "code_status_lbl";
            this.code_status_lbl.Size = new System.Drawing.Size(75, 15);
            this.code_status_lbl.TabIndex = 85;
            this.code_status_lbl.Text = "Code Status";
            // 
            // AddMovingMachineVTForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(953, 699);
            this.Controls.Add(this.code_name_cmb);
            this.Controls.Add(this.code_name_lbl);
            this.Controls.Add(this.rfid_lbl);
            this.Controls.Add(this.rfid_txt);
            this.Controls.Add(this.factory_tranfer_lbl);
            this.Controls.Add(this.factory_tranfer_cmb);
            this.Controls.Add(this.code_status_lbl);
            this.Controls.Add(this.factory_received_lbl);
            this.Controls.Add(this.code_status_cmb);
            this.Controls.Add(this.factory_received_cmb);
            this.Controls.Add(this.serialmachine_lbl);
            this.Controls.Add(this.machine_serial_cmb);
            this.Controls.Add(this.setting_gbc);
            this.Controls.Add(this.warehouse_vt_dgv);
            this.Name = "AddMovingMachineVTForm";
            this.Text = "g";
            this.TitleText = "Equipments Management";
            this.Load += new System.EventHandler(this.AddMovingMachineVTForm_Load);
            this.Controls.SetChildIndex(this.warehouse_vt_dgv, 0);
            this.Controls.SetChildIndex(this.setting_gbc, 0);
            this.Controls.SetChildIndex(this.machine_serial_cmb, 0);
            this.Controls.SetChildIndex(this.serialmachine_lbl, 0);
            this.Controls.SetChildIndex(this.factory_received_cmb, 0);
            this.Controls.SetChildIndex(this.code_status_cmb, 0);
            this.Controls.SetChildIndex(this.factory_received_lbl, 0);
            this.Controls.SetChildIndex(this.code_status_lbl, 0);
            this.Controls.SetChildIndex(this.factory_tranfer_cmb, 0);
            this.Controls.SetChildIndex(this.factory_tranfer_lbl, 0);
            this.Controls.SetChildIndex(this.rfid_txt, 0);
            this.Controls.SetChildIndex(this.rfid_lbl, 0);
            this.Controls.SetChildIndex(this.code_name_lbl, 0);
            this.Controls.SetChildIndex(this.code_name_cmb, 0);
            this.setting_gbc.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.warehouse_vt_dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Framework.GroupBoxCommon setting_gbc;
        private Framework.ButtonCommon update_btn;
        private Framework.ButtonCommon delete_btn;
        private Framework.ButtonCommon search_btn;
        private Framework.DataGridViewCommon warehouse_vt_dgv;
        private Framework.ComboBoxCommon machine_serial_cmb;
        private Framework.LabelCommon serialmachine_lbl;
        private Framework.ButtonCommon add_btn;
        private Framework.LabelCommon factory_received_lbl;
        private Framework.ComboBoxCommon factory_received_cmb;
        private Framework.LabelCommon factory_tranfer_lbl;
        private Framework.ComboBoxCommon factory_tranfer_cmb;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_machineid;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_rfid;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_machinecode;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_usercode;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_datetime;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_machinename;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_machineqty;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_machineserial;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_machinemodel;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_machinelocation;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_machinesupplier;
        private System.Windows.Forms.DataGridViewTextBoxColumn colfactorycd;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_machineinvoice;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_machinecostvalue;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCheckTime_final;
        private Framework.TextBoxCommon rfid_txt;
        private Framework.LabelCommon rfid_lbl;
        private Framework.TextBoxCommon code_name_cmb;
        private Framework.LabelCommon code_name_lbl;
        private Framework.ComboBoxCommon code_status_cmb;
        private Framework.LabelCommon code_status_lbl;
    }
}
