using Com.Nidec.Mes.Common.Basic.MachineMaintenance.Vo;
using Com.Nidec.Mes.Framework;
using Com.Nidec.Mes.GlobalMasterMaintenance.Vo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Com.Nidec.Mes.Common.Basic.MachineMaintenance.Dao
{
    public class SearchMovingVTDao : AbstractDataAccessObject
    {
        public override ValueObject Execute(TransactionContext trxContext, ValueObject vo)
        {
            MovingMachineVTVo inVo = (MovingMachineVTVo)vo;
            StringBuilder sql = new StringBuilder();
            ValueObjectList<MovingMachineVTVo> voList = new ValueObjectList<MovingMachineVTVo>();
            //create command
            DbCommandAdaptor sqlCommandAdapter = base.GetDbCommandAdaptor(trxContext, sql.ToString());

            //create parameter
            DbParameterList sqlParameter = sqlCommandAdapter.CreateParameterList();

            sql.Append(@"select a.moving_id, a.machine_serial, a.factory_tranfer_cd, a.factory_received_cd, a.bg_cd, a.m_cd, a.t_cd, a.th_cd  a.status, 
            a.comments_machine, a.reason_tranfer, a.confirm_received, a.registration_user_cd, a.registration_date_time, a.factory_cd, b.machine_name
            from t_vt_moving a
            left join t_vt_machine b on a.machine_serial = b.machine_serial
              where 1=1 ");

            if (!String.IsNullOrEmpty(inVo.MachineSerial))
            {
                sql.Append(" and machine_serial  =:machine_serial");
                sqlParameter.AddParameterString("machine_serial", inVo.MachineSerial);
            }


            sqlCommandAdapter = base.GetDbCommandAdaptor(trxContext, sql.ToString());

            //execute SQL
            IDataReader dataReader = sqlCommandAdapter.ExecuteReader(trxContext, sqlParameter);

            while (dataReader.Read())
            {
                MovingMachineVTVo outVo = new MovingMachineVTVo
                {
                    //MachineId = int.Parse(dataReader["machine_id"].ToString()),
                    //RFId = dataReader["rfid_cd"].ToString(),
                    //MachineCode = dataReader["machine_cd"].ToString(),
                    //MachineName = dataReader["machine_name"].ToString(),
                    //MachineQty = int.Parse(dataReader["machine_qty"].ToString()),
                    //MachineSerial = dataReader["machine_serial"].ToString(),
                    //MachineModel = dataReader["machine_model"].ToString(),
                    //MachineLocation = dataReader["machine_location"].ToString(),
                    //MachineSupplier = dataReader["machine_suppiler"].ToString(),
                    //MachineInvoice = dataReader["machine_invoice"].ToString(),
                    //MachineCostValue = (dataReader["machine_costvalue"].ToString()),
                    //RegistrationUserCode = dataReader["registration_user_cd"].ToString(),
                    //RegistrationDateTime = DateTime.Parse(dataReader["registration_date_time"].ToString()),
                    //TimeCheck = int.Parse(dataReader["time_check_fi"].ToString()),
                    //FactoryCode = dataReader["factory_cd"].ToString(),

                };
                voList.add(outVo);
            }
            dataReader.Close();
            return voList;
        }
    }
}
