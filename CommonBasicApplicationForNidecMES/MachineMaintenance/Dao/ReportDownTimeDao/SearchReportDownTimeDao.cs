﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Com.Nidec.Mes.Framework;
using Com.Nidec.Mes.Common.Basic.MachineMaintenance.Vo;
using Com.Nidec.Mes.Common.Basic.MachineMaintenance.Cbm;
using System.Data;

namespace Com.Nidec.Mes.Common.Basic.MachineMaintenance.Dao
{
    class SearchReportDownTimeDao : AbstractDataAccessObject
    {
        public override ValueObject Execute(TransactionContext trxContext, ValueObject vo)
        {
            ReportDownTimeVo inVo = (ReportDownTimeVo)vo;
            StringBuilder sql = new StringBuilder();
            ValueObjectList<ReportDownTimeVo> voList = new ValueObjectList<ReportDownTimeVo>();
            //create command
            DbCommandAdaptor sqlCommandAdapter = base.GetDbCommandAdaptor(trxContext, sql.ToString());

            //create parameter
            DbParameterList sqlParameter = sqlCommandAdapter.CreateParameterList();
            sql.Append(@"SELECT a.downtime_report_id, d.model_cd, f.process_name, h.line_cd, i.machine_name, k.defective_reason_name, o.prodution_work_content_name, a.time_to, a.time_from , a.registration_user_cd,a.remarks
from t_downtime_report a 
left join m_model d on a.model_id = d.model_id 
left join m_process f on a.process_id = f.process_id 
left join m_line h on a.line_id = h.line_id 
left join m_machine i on i.machine_id = a.machine_id 
left join m_defective_reason k on k.defective_reason_id = a.defective_reason_id 
left join m_prodution_work_content o on o.prodution_work_content_id = a.prodution_work_content_id where ");


            sql.Append(@"time_from >:starttime and  time_from <:endtime");
            sqlParameter.AddParameterDateTime("starttime", inVo.TimeFrom);
            sqlParameter.AddParameterDateTime("endtime", inVo.TimeTo.AddDays(1));

            if (!String.IsNullOrEmpty(inVo.ModelCode))
            {
                sql.Append(" and model_cd =:model_cd ");
                sqlParameter.AddParameterString("model_cd", inVo.ModelCode);
            }
            if (!String.IsNullOrEmpty(inVo.ProcessName))
            {
                sql.Append(" and process_name =:process_name ");
                sqlParameter.AddParameterString("process_name", inVo.ProcessName);
            }
            if (!String.IsNullOrEmpty(inVo.LineCode))
            {
                sql.Append(" and line_cd =:line_cd ");
                sqlParameter.AddParameterString("line_cd", inVo.LineCode);
            }
            if (!String.IsNullOrEmpty(inVo.MachineName))
            {
                sql.Append(" and machine_name =:machine_name ");
                sqlParameter.AddParameterString("machine_name", inVo.MachineName);
            }

            if (!String.IsNullOrEmpty(inVo.DefectiveReasonName))
            {
                sql.Append(" and defective_reason_name = :defective_reason_name ");
                sqlParameter.AddParameterString("defective_reason_name", inVo.DefectiveReasonName);
            }
            if (!String.IsNullOrEmpty(inVo.ProductionWorkContentName))
            {
                sql.Append(" and prodution_work_content_name=  :prodution_work_content_name ");
                sqlParameter.AddParameterString("prodution_work_content_name", inVo.ProductionWorkContentName);
            }


            sqlCommandAdapter = base.GetDbCommandAdaptor(trxContext, sql.ToString());



            //execute SQL
            IDataReader dataReader = sqlCommandAdapter.ExecuteReader(trxContext, sqlParameter);

            while (dataReader.Read())
            {
                ReportDownTimeVo outVo = new ReportDownTimeVo
                {
                    //  , h., i., k., o.prodution_work_content_name
                    DowntimeReportId = int.Parse(dataReader["downtime_report_id"].ToString()),
                    ModelCode = dataReader["model_cd"].ToString(),
                    ProcessName = dataReader["process_name"].ToString(),
                    LineCode = dataReader["line_cd"].ToString(),
                    MachineName = dataReader["machine_name"].ToString(),
                    DefectiveReasonName = dataReader["defective_reason_name"].ToString(),
                    ProductionWorkContentName = dataReader["prodution_work_content_name"].ToString(),
                    TimeTo = DateTime.Parse(dataReader["time_to"].ToString()),
                    TimeFrom = DateTime.Parse(dataReader["time_from"].ToString()),
                    Remakes = dataReader["remarks"].ToString(),
                    RegistrationUserCode = dataReader["registration_user_cd"].ToString()
                };
                voList.add(outVo);
            }
            dataReader.Close();
            return voList;
        }
    }
}
