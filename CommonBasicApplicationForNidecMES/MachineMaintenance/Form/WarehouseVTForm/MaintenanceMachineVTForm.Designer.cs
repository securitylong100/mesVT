﻿namespace Com.Nidec.Mes.Common.Basic.MachineMaintenance.Form
{
    partial class MaintenanceMachineVTForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.setting_gbc = new Com.Nidec.Mes.Framework.GroupBoxCommon();
            this.add_btn = new Com.Nidec.Mes.Framework.ButtonCommon();
            this.update_btn = new Com.Nidec.Mes.Framework.ButtonCommon();
            this.delete_btn = new Com.Nidec.Mes.Framework.ButtonCommon();
            this.search_btn = new Com.Nidec.Mes.Framework.ButtonCommon();
            this.machine_status_lbl = new Com.Nidec.Mes.Framework.LabelCommon();
            this.machine_status_cmb = new Com.Nidec.Mes.Framework.ComboBoxCommon();
            this.location_lbl = new Com.Nidec.Mes.Framework.LabelCommon();
            this.location_cmb = new Com.Nidec.Mes.Framework.ComboBoxCommon();
            this.supplier_lbl = new Com.Nidec.Mes.Framework.LabelCommon();
            this.model_lbl = new Com.Nidec.Mes.Framework.LabelCommon();
            this.serial_lbl = new Com.Nidec.Mes.Framework.LabelCommon();
            this.machine_supplier_cmb = new Com.Nidec.Mes.Framework.ComboBoxCommon();
            this.machine_model_cmb = new Com.Nidec.Mes.Framework.ComboBoxCommon();
            this.machine_serial_cmb = new Com.Nidec.Mes.Framework.ComboBoxCommon();
            this.rfid_txt = new Com.Nidec.Mes.Framework.TextBoxCommon();
            this.rfid_lbl = new Com.Nidec.Mes.Framework.LabelCommon();
            this.mainternance_vt_dgv = new Com.Nidec.Mes.Framework.DataGridViewCommon();
            this.col_machineid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_rfid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_machinecode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_machinename = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_usercode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_datetime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_machineqty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_machineserial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_machinemodel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_machinelocation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_machinesupplier = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_machinestatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colfactorycd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_machineinvoice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_machinecostvalue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCheckTime_final = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.setting_gbc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainternance_vt_dgv)).BeginInit();
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
            this.setting_gbc.Location = new System.Drawing.Point(12, 199);
            this.setting_gbc.Name = "setting_gbc";
            this.setting_gbc.Size = new System.Drawing.Size(443, 64);
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
            this.search_btn.Click += new System.EventHandler(this.search_btn_Click);
            // 
            // machine_status_lbl
            // 
            this.machine_status_lbl.AutoSize = true;
            this.machine_status_lbl.ControlId = null;
            this.machine_status_lbl.Font = new System.Drawing.Font("Arial", 9F);
            this.machine_status_lbl.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.machine_status_lbl.Location = new System.Drawing.Point(784, 154);
            this.machine_status_lbl.Name = "machine_status_lbl";
            this.machine_status_lbl.Size = new System.Drawing.Size(91, 15);
            this.machine_status_lbl.TabIndex = 97;
            this.machine_status_lbl.Text = "Machine Status";
            // 
            // machine_status_cmb
            // 
            this.machine_status_cmb.ControlId = null;
            this.machine_status_cmb.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.machine_status_cmb.FormattingEnabled = true;
            this.machine_status_cmb.Location = new System.Drawing.Point(787, 172);
            this.machine_status_cmb.Name = "machine_status_cmb";
            this.machine_status_cmb.Size = new System.Drawing.Size(121, 23);
            this.machine_status_cmb.TabIndex = 96;
            // 
            // location_lbl
            // 
            this.location_lbl.AutoSize = true;
            this.location_lbl.ControlId = null;
            this.location_lbl.Font = new System.Drawing.Font("Arial", 9F);
            this.location_lbl.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.location_lbl.Location = new System.Drawing.Point(639, 154);
            this.location_lbl.Name = "location_lbl";
            this.location_lbl.Size = new System.Drawing.Size(57, 15);
            this.location_lbl.TabIndex = 95;
            this.location_lbl.Text = "Location:";
            // 
            // location_cmb
            // 
            this.location_cmb.ControlId = null;
            this.location_cmb.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.location_cmb.FormattingEnabled = true;
            this.location_cmb.Location = new System.Drawing.Point(642, 172);
            this.location_cmb.Name = "location_cmb";
            this.location_cmb.Size = new System.Drawing.Size(121, 23);
            this.location_cmb.TabIndex = 94;
            // 
            // supplier_lbl
            // 
            this.supplier_lbl.AutoSize = true;
            this.supplier_lbl.ControlId = null;
            this.supplier_lbl.Font = new System.Drawing.Font("Arial", 9F);
            this.supplier_lbl.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.supplier_lbl.Location = new System.Drawing.Point(457, 156);
            this.supplier_lbl.Name = "supplier_lbl";
            this.supplier_lbl.Size = new System.Drawing.Size(56, 15);
            this.supplier_lbl.TabIndex = 91;
            this.supplier_lbl.Text = "Suppiler:";
            // 
            // model_lbl
            // 
            this.model_lbl.AutoSize = true;
            this.model_lbl.ControlId = null;
            this.model_lbl.Font = new System.Drawing.Font("Arial", 9F);
            this.model_lbl.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.model_lbl.Location = new System.Drawing.Point(153, 154);
            this.model_lbl.Name = "model_lbl";
            this.model_lbl.Size = new System.Drawing.Size(43, 15);
            this.model_lbl.TabIndex = 92;
            this.model_lbl.Text = "Model:";
            // 
            // serial_lbl
            // 
            this.serial_lbl.AutoSize = true;
            this.serial_lbl.ControlId = null;
            this.serial_lbl.Font = new System.Drawing.Font("Arial", 9F);
            this.serial_lbl.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.serial_lbl.Location = new System.Drawing.Point(308, 154);
            this.serial_lbl.Name = "serial_lbl";
            this.serial_lbl.Size = new System.Drawing.Size(42, 15);
            this.serial_lbl.TabIndex = 93;
            this.serial_lbl.Text = "Serial:";
            // 
            // machine_supplier_cmb
            // 
            this.machine_supplier_cmb.ControlId = null;
            this.machine_supplier_cmb.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.machine_supplier_cmb.FormattingEnabled = true;
            this.machine_supplier_cmb.Location = new System.Drawing.Point(460, 174);
            this.machine_supplier_cmb.Name = "machine_supplier_cmb";
            this.machine_supplier_cmb.Size = new System.Drawing.Size(147, 23);
            this.machine_supplier_cmb.TabIndex = 88;
            // 
            // machine_model_cmb
            // 
            this.machine_model_cmb.ControlId = null;
            this.machine_model_cmb.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.machine_model_cmb.FormattingEnabled = true;
            this.machine_model_cmb.Location = new System.Drawing.Point(156, 172);
            this.machine_model_cmb.Name = "machine_model_cmb";
            this.machine_model_cmb.Size = new System.Drawing.Size(121, 23);
            this.machine_model_cmb.TabIndex = 89;
            this.machine_model_cmb.SelectedIndexChanged += new System.EventHandler(this.machine_model_cmb_SelectedIndexChanged);
            // 
            // machine_serial_cmb
            // 
            this.machine_serial_cmb.ControlId = null;
            this.machine_serial_cmb.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.machine_serial_cmb.FormattingEnabled = true;
            this.machine_serial_cmb.Location = new System.Drawing.Point(311, 172);
            this.machine_serial_cmb.Name = "machine_serial_cmb";
            this.machine_serial_cmb.Size = new System.Drawing.Size(121, 23);
            this.machine_serial_cmb.TabIndex = 90;
            // 
            // rfid_txt
            // 
            this.rfid_txt.ControlId = null;
            this.rfid_txt.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rfid_txt.InputType = Com.Nidec.Mes.Framework.TextBoxCommon.InputTypeList.All;
            this.rfid_txt.Location = new System.Drawing.Point(11, 174);
            this.rfid_txt.MaxLength = 10;
            this.rfid_txt.Name = "rfid_txt";
            this.rfid_txt.Size = new System.Drawing.Size(121, 21);
            this.rfid_txt.TabIndex = 87;
            // 
            // rfid_lbl
            // 
            this.rfid_lbl.AutoSize = true;
            this.rfid_lbl.ControlId = null;
            this.rfid_lbl.Font = new System.Drawing.Font("Arial", 9F);
            this.rfid_lbl.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.rfid_lbl.Location = new System.Drawing.Point(14, 156);
            this.rfid_lbl.Name = "rfid_lbl";
            this.rfid_lbl.Size = new System.Drawing.Size(93, 15);
            this.rfid_lbl.TabIndex = 86;
            this.rfid_lbl.Text = "RFID Numbers:";
            // 
            // mainternance_vt_dgv
            // 
            this.mainternance_vt_dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.mainternance_vt_dgv.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(232)))), ((int)(((byte)(180)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.mainternance_vt_dgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.mainternance_vt_dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_machineid,
            this.col_rfid,
            this.col_machinecode,
            this.col_machinename,
            this.col_usercode,
            this.col_datetime,
            this.col_machineqty,
            this.col_machineserial,
            this.col_machinemodel,
            this.col_machinelocation,
            this.col_machinesupplier,
            this.col_machinestatus,
            this.colfactorycd,
            this.col_machineinvoice,
            this.col_machinecostvalue,
            this.colCheckTime_final});
            this.mainternance_vt_dgv.ControlId = null;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.mainternance_vt_dgv.DefaultCellStyle = dataGridViewCellStyle2;
            this.mainternance_vt_dgv.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.mainternance_vt_dgv.Location = new System.Drawing.Point(0, 273);
            this.mainternance_vt_dgv.Name = "mainternance_vt_dgv";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(232)))), ((int)(((byte)(180)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.mainternance_vt_dgv.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.mainternance_vt_dgv.Size = new System.Drawing.Size(1277, 426);
            this.mainternance_vt_dgv.TabIndex = 98;
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
            this.col_machinecode.HeaderText = "Machine Code";
            this.col_machinecode.Name = "col_machinecode";
            this.col_machinecode.Width = 111;
            // 
            // col_machinename
            // 
            this.col_machinename.DataPropertyName = "MachineName";
            this.col_machinename.HeaderText = "Machine Name";
            this.col_machinename.Name = "col_machinename";
            this.col_machinename.Width = 115;
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
            this.col_machinelocation.HeaderText = "Location";
            this.col_machinelocation.Name = "col_machinelocation";
            this.col_machinelocation.Width = 79;
            // 
            // col_machinesupplier
            // 
            this.col_machinesupplier.DataPropertyName = "MachineSupplier";
            this.col_machinesupplier.HeaderText = "Machine Supplier";
            this.col_machinesupplier.Name = "col_machinesupplier";
            this.col_machinesupplier.Width = 127;
            // 
            // col_machinestatus
            // 
            this.col_machinestatus.DataPropertyName = "MachineStatus";
            this.col_machinestatus.HeaderText = "Status";
            this.col_machinestatus.Name = "col_machinestatus";
            this.col_machinestatus.Width = 67;
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
            // MaintenanceMachineVTForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1277, 699);
            this.Controls.Add(this.mainternance_vt_dgv);
            this.Controls.Add(this.machine_status_lbl);
            this.Controls.Add(this.machine_status_cmb);
            this.Controls.Add(this.location_lbl);
            this.Controls.Add(this.location_cmb);
            this.Controls.Add(this.supplier_lbl);
            this.Controls.Add(this.model_lbl);
            this.Controls.Add(this.serial_lbl);
            this.Controls.Add(this.machine_supplier_cmb);
            this.Controls.Add(this.machine_model_cmb);
            this.Controls.Add(this.machine_serial_cmb);
            this.Controls.Add(this.rfid_txt);
            this.Controls.Add(this.rfid_lbl);
            this.Controls.Add(this.setting_gbc);
            this.Name = "MaintenanceMachineVTForm";
            this.Text = "Equipments Management";
            this.TitleText = "Maintenance Machine Form";
            this.Load += new System.EventHandler(this.MaintenanceMachineVTForm_Load);
            this.Controls.SetChildIndex(this.setting_gbc, 0);
            this.Controls.SetChildIndex(this.rfid_lbl, 0);
            this.Controls.SetChildIndex(this.rfid_txt, 0);
            this.Controls.SetChildIndex(this.machine_serial_cmb, 0);
            this.Controls.SetChildIndex(this.machine_model_cmb, 0);
            this.Controls.SetChildIndex(this.machine_supplier_cmb, 0);
            this.Controls.SetChildIndex(this.serial_lbl, 0);
            this.Controls.SetChildIndex(this.model_lbl, 0);
            this.Controls.SetChildIndex(this.supplier_lbl, 0);
            this.Controls.SetChildIndex(this.location_cmb, 0);
            this.Controls.SetChildIndex(this.location_lbl, 0);
            this.Controls.SetChildIndex(this.machine_status_cmb, 0);
            this.Controls.SetChildIndex(this.machine_status_lbl, 0);
            this.Controls.SetChildIndex(this.mainternance_vt_dgv, 0);
            this.setting_gbc.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mainternance_vt_dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Framework.GroupBoxCommon setting_gbc;
        private Framework.ButtonCommon update_btn;
        private Framework.ButtonCommon delete_btn;
        private Framework.ButtonCommon search_btn;
        private Framework.ButtonCommon add_btn;
        private Framework.LabelCommon machine_status_lbl;
        private Framework.ComboBoxCommon machine_status_cmb;
        private Framework.LabelCommon location_lbl;
        private Framework.ComboBoxCommon location_cmb;
        private Framework.LabelCommon supplier_lbl;
        private Framework.LabelCommon model_lbl;
        private Framework.LabelCommon serial_lbl;
        private Framework.ComboBoxCommon machine_supplier_cmb;
        private Framework.ComboBoxCommon machine_model_cmb;
        private Framework.ComboBoxCommon machine_serial_cmb;
        private Framework.TextBoxCommon rfid_txt;
        private Framework.LabelCommon rfid_lbl;
        private Framework.DataGridViewCommon mainternance_vt_dgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_machineid;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_rfid;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_machinecode;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_machinename;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_usercode;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_datetime;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_machineqty;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_machineserial;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_machinemodel;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_machinelocation;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_machinesupplier;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_machinestatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn colfactorycd;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_machineinvoice;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_machinecostvalue;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCheckTime_final;
    }
}
