using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JatakaCore.Factory
{
    public class URLInfo
    {

        public static string GetDataBaseConnectionString()
        {

            try
            {

                //var appSettingsJson = ApiBootstrapper.AppSettingsJson.GetAppSettings();
                //var connString = appSettingsJson["LocalStory"];
                var connString = "Data Source=HOME\\MSSQLSERVER1;Initial Catalog=rfletcher_stories;Integrated Security=True;";

                //string connString = ConfigurationManager.ConnectionStrings["LocalStory"].ToString();
                return connString;

            }

            catch
            {
                //return "Data Source=184.168.194.78;Initial Catalog=rfletcher_evolution;User Id=rfletcher;Password=Barbara_1;";
                return "Data Source=HOME\\MSSQLSERVER1;Initial Catalog=rfletcher_stories;Integrated Security=True;";

            }
        }


    }
}