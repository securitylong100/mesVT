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
    public class SearchMachineNewDao : AbstractDataAccessObject
    {
        public override ValueObject Execute(TransactionContext trxContext, ValueObject vo)
        {
            MaintenanceMachineVTVo inVo = (MaintenanceMachineVTVo)vo;
            StringBuilder sql = new StringBuilder();
            ValueObjectList<MaintenanceMachineVTVo> voList = new ValueObjectList<MaintenanceMachineVTVo>();
            //create command
            DbCommandAdaptor sqlCommandAdapter = base.GetDbCommandAdaptor(trxContext, sql.ToString());
            //Bàn Giao
            //Mượn
            //Trả
            //Thuê
            //create parameter
            DbParameterList sqlParameter = sqlCommandAdapter.CreateParameterList();

            sql.Append(@"select * from t_vt_maintenance ");


           
            sqlCommandAdapter = base.GetDbCommandAdaptor(trxContext, sql.ToString());

            //execute SQL
            //IDataReader dataReader = sqlCommandAdapter.ExecuteReader(trxContext, sqlParameter);
            DataSet ds = sqlCommandAdapter.ExecuteDataSet(sqlParameter);


            MaintenanceMachineVTVo outVo = new MaintenanceMachineVTVo
            {
                dt = ds.Tables[0]
                    };
            return outVo;
                
            }
          
 
    }
}
