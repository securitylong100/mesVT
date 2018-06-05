﻿using Com.Nidec.Mes.Common.Basic.MachineMaintenance.Vo;
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
    public class AddAssetDao : AbstractDataAccessObject
    {
        public override ValueObject Execute(TransactionContext trxContext, ValueObject vo)
        {
            AssetVo inVo = (AssetVo)vo;
            StringBuilder sql = new StringBuilder();
            sql.Append("insert into m_asset(asset_cd,asset_no, asset_name, asset_model, asset_supplier, asset_invoice, asset_life,acquistion_date, acquistion_cost, asset_serial, asset_type,  registration_user_cd, registration_date_time, factory_cd) ");
            sql.Append("values(:asset_cd,:asset_no, :asset_name, :asset_model, :asset_supplier, :asset_invoice, :asset_life, :acquistion_date, :acquistion_cost, :asset_serial, :asset_type, :registration_user_cd,now(), :factory_cd)");
            
            //create command
            DbCommandAdaptor sqlCommandAdapter = base.GetDbCommandAdaptor(trxContext, sql.ToString());

            //create parameter
            DbParameterList sqlParameter = sqlCommandAdapter.CreateParameterList();
            sqlParameter.AddParameterString("asset_cd", inVo.AssetCode);
            sqlParameter.AddParameterInteger("asset_no", inVo.AssetNo);
            sqlParameter.AddParameterString("asset_name", inVo.AssetName);
            sqlParameter.AddParameterString("asset_model", inVo.AssetModel);
            sqlParameter.AddParameterString("asset_supplier", inVo.AssetSuppiler);
            sqlParameter.AddParameterString("asset_invoice", inVo.AssetInvoice);
            sqlParameter.AddParameterString("asset_serial", inVo.AssetSerial);
            sqlParameter.AddParameter("asset_life", inVo.AssetLife);
            sqlParameter.AddParameterDateTime("acquistion_date", inVo.AcquistionDate);
            sqlParameter.AddParameter("acquistion_cost", inVo.AcquistionCost);
            sqlParameter.AddParameterString("asset_type", inVo.AssetType);
            sqlParameter.AddParameterString("factory_cd", inVo.FactoryCode);
            sqlParameter.AddParameterString("registration_user_cd", inVo.RegistrationUserCode);
            sqlParameter.AddParameterDateTime("registration_date_time", inVo.RegistrationDateTime);
            //execute SQL

            AssetVo outVo = new AssetVo
            {
                AffectedCount = sqlCommandAdapter.ExecuteNonQuery(sqlParameter)
            };

            return outVo;
        }
    }
}
