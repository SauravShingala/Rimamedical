using OrthoModual.IServices;
using OrthoModual.Models;
using OrthoModual.SqlHandler;
using System.Data;

namespace OrthoModual.Services
{
    public class OrthoFormService : SqlService, IOrthoFormService
    {
        private readonly SqlAccess sqlAccess;
        private readonly IConfiguration configuration;

        public OrthoFormService(IConfiguration configuration)
        {
            sqlAccess = new SqlAccess();
            this.configuration = configuration;
        }

        public IList<KeyValueModel> GetKeyValueList(string keyName)
        {
            IList<KeyValueModel> keyValueModels = new List<KeyValueModel>();
            cmd.Parameters.Clear();

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "dbo.Get_KeyValueList";

            cmd.Parameters.AddWithValue("@KeyName", keyName);

            DataSet res = sqlAccess.ExecuteReaderDataSet(cmd);

            if (res.Tables.Count > 0 && res.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow row in res.Tables[0].Rows)
                {
                    KeyValueModel keyValueModel = new KeyValueModel();

                    keyValueModel.KeyId = Convert.ToInt32(row["KeyId"]);
                    keyValueModel.KeyValue = row["KeyValue"].ToString();

                    keyValueModels.Add(keyValueModel);
                }
            }
            return keyValueModels;
        }

        public int AddOrthoFormDetails(OrthoFormModel orthoFormModel)
        {
            int personalDeatilId = 0;
            cmd.Parameters.Clear();

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "dbo.Add_PersonalDetails";

            cmd.Parameters.AddWithValue("@clientRef", orthoFormModel.persnolDetails.clientRef);
            cmd.Parameters.AddWithValue("@solicitorRef", orthoFormModel.persnolDetails.solicitorRef);
            cmd.Parameters.AddWithValue("@medcoRef", orthoFormModel.persnolDetails.medcoRef);
            cmd.Parameters.AddWithValue("@examinationDate", orthoFormModel.persnolDetails.examinationDate);
            cmd.Parameters.AddWithValue("@title", orthoFormModel.persnolDetails.title);
            cmd.Parameters.AddWithValue("@gender", orthoFormModel.persnolDetails.gender);
            cmd.Parameters.AddWithValue("@firstName", orthoFormModel.persnolDetails.firstName);
            cmd.Parameters.AddWithValue("@lastName", orthoFormModel.persnolDetails.lastName);
            cmd.Parameters.AddWithValue("@middleName", orthoFormModel.persnolDetails.middleName);
            cmd.Parameters.AddWithValue("@accompaniedBy", orthoFormModel.persnolDetails.accompaniedBy);
            cmd.Parameters.AddWithValue("@address", orthoFormModel.persnolDetails.address);
            cmd.Parameters.AddWithValue("@town", orthoFormModel.persnolDetails.town);
            cmd.Parameters.AddWithValue("@dateOfBirth", orthoFormModel.persnolDetails.dateOfBirth);
            cmd.Parameters.AddWithValue("@country", orthoFormModel.persnolDetails.country);
            cmd.Parameters.AddWithValue("@occupation", orthoFormModel.persnolDetails.occupation);
            cmd.Parameters.AddWithValue("@postCode", orthoFormModel.persnolDetails.postCode);
            cmd.Parameters.AddWithValue("@accidentdate", orthoFormModel.persnolDetails.accidentdate);
            cmd.Parameters.AddWithValue("@typeOfIncident", orthoFormModel.persnolDetails.typeOfIncident);
            cmd.Parameters.AddWithValue("@typeOfOccupency", orthoFormModel.persnolDetails.typeOfOccupency);
            cmd.Parameters.AddWithValue("@thirdPartyVehical", orthoFormModel.persnolDetails.thirdPartyVehical);
            cmd.Parameters.AddWithValue("@totalOfOccupant", orthoFormModel.persnolDetails.totalOfOccupant);
            cmd.Parameters.AddWithValue("@isPoliceAttendScene", orthoFormModel.persnolDetails.isPoliceAttendScene);
            cmd.Parameters.AddWithValue("@isVehicalMoving", orthoFormModel.persnolDetails.isVehicalMoving);
            cmd.Parameters.AddWithValue("@vehicalSpeed", orthoFormModel.persnolDetails.vehicalSpeed);
            cmd.Parameters.AddWithValue("@accidentHistory", orthoFormModel.persnolDetails.accidentHistory);
            cmd.Parameters.AddWithValue("@isSeatBeltWearing", orthoFormModel.persnolDetails.isSeatBeltWearing);
            cmd.Parameters.AddWithValue("@seatBeltDescription", orthoFormModel.persnolDetails.seatBeltDescription);
            cmd.Parameters.AddWithValue("@CreatedBy", "Vikesh");
            cmd.Parameters.AddWithValue("@personalDeatilId", personalDeatilId);
            cmd.Parameters["@personalDeatilId"].Direction = ParameterDirection.Output;

            sqlAccess.ExecuteNonQuery(cmd);
            personalDeatilId = (int)cmd.Parameters["@personalDeatilId"].Value;


            // Add 
            cmd.Parameters.Clear();

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "dbo.Add_GivenTreatment";

            cmd.Parameters.AddWithValue("@isPainkiller", orthoFormModel.treatmentGiven.isPainkiller);
            cmd.Parameters.AddWithValue("@painkillerDescription", orthoFormModel.treatmentGiven.painkillerDescription);
            cmd.Parameters.AddWithValue("@isAdvice", orthoFormModel.treatmentGiven.isAdvice);
            cmd.Parameters.AddWithValue("@adviceDescription", orthoFormModel.treatmentGiven.adviceDescription);
            cmd.Parameters.AddWithValue("@isRecomendation", orthoFormModel.treatmentGiven.isRecomendation);
            cmd.Parameters.AddWithValue("@recomendationDescription", orthoFormModel.treatmentGiven.recomendationDescription);
            cmd.Parameters.AddWithValue("@personalDeatilId", personalDeatilId);
            cmd.Parameters.AddWithValue("@createdBy", "Vikesh");

            return personalDeatilId;
        }
    }
}
