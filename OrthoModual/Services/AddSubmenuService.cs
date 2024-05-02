using Microsoft.AspNetCore.Mvc;
using OrthoModual.Models;
using System.Data;
using OrthoModual.IServices;
using OrthoModual.SqlHandler;

namespace OrthoModual.Services
{
    public class AddSubmenuService : SqlService,IAddSubmenuService
    {
        private readonly SqlAccess sqlAccess;
        private readonly IConfiguration configuration;

        public AddSubmenuService(IConfiguration configuration) 
        {
            sqlAccess = new SqlAccess();
            this.configuration = configuration;
        }

        public bool AddSubMenu(AddSubMenuModel addSubMenuModel)
        {
            bool response = false;
            cmd.Parameters.Clear();

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "dbo.Add_SubMenu";

            cmd.Parameters.AddWithValue("@KeyName", addSubMenuModel.KeyName);
            cmd.Parameters.AddWithValue("@KeyValue", addSubMenuModel.KeyValue);
            cmd.Parameters.AddWithValue("@Response", response);
            cmd.Parameters["@Response"].Direction = ParameterDirection.Output;

            sqlAccess.ExecuteNonQuery(cmd);
            response = (bool)cmd.Parameters["@Response"].Value;

            return response;
        }

        public IList<GetSubMenuModel> GetSubmenu(string keyName)
        {
            IList<GetSubMenuModel> subMenuList = new List<GetSubMenuModel>();
            cmd.Parameters.Clear();

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "dbo.Get_SubMenu";

            cmd.Parameters.AddWithValue("@KeyName", keyName);

            DataSet res =  sqlAccess.ExecuteReaderDataSet(cmd);

            if (res.Tables.Count > 0 && res.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow row in res.Tables[0].Rows)
                {
                    GetSubMenuModel subMenuModel = new GetSubMenuModel();

                    subMenuModel.KeyName = row["KeyName"].ToString();
                    subMenuModel.KeyValue = row["KeyValue"].ToString();
                    
                    subMenuList.Add(subMenuModel);
                }
            }
            return subMenuList;
        }
    }
}
