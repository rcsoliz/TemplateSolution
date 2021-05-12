using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassTemplates
{
    public class AssemblyData
    {
        public string proccessdDataResult { get; set; }
        public string proccessdDataPrimaryKeyResult { get; set; }

        public void GetData(object maxId, int range, ref DataSet returnedDataSet)
        {
            SqlDataAdapter objDataAdapter = new SqlDataAdapter();
            objDataAdapter.Fill(returnedDataSet, "tableName");
        }

        public void ProcessdData(object primaryKey)
        {
            if (primaryKey != null)
            {
                proccessdDataResult = "1000000"; //2021-01-01
            }
        }

        public void ExecuteData(object primaryKey, string proccessdData)
        {
            proccessdDataPrimaryKeyResult = "1000000"; //2021-01-01
        }

    }
}
