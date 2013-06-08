using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace SAYQuiltProject.services
{
    public class CServiceByNameFactory
    {
        private CServiceByNameFactory()
        {
        }

        private static CServiceByNameFactory factory = new CServiceByNameFactory();

        public static CServiceByNameFactory GetInstance()
        {
            return factory;
        }

        public ISimpleService GetService(String serviceName)
        {
            // for debug
            // ReadAppSettings();
            // 
            Object obj = null;
            try
            {
                String sImplName = GetImplName(serviceName);
                String sTypeName = sImplName;
                Type objType = Type.GetType(sImplName);
                obj = Activator.CreateInstance(objType);
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception occured: {0}", e);
                throw e;
            }
            return (ISimpleQuiltService)obj;
        }

        private String GetImplName(String serviceName)
        {
            NameValueCollection settings = ConfigurationManager.AppSettings;
            return settings.Get(serviceName);
        }

        private static void ReadAppSettings()
        {
            try
            {
                // Get the AppSettings section.
                NameValueCollection appSettings =
                   ConfigurationManager.AppSettings;

                // Get the AppSettings section elements.
                Console.WriteLine();
                Console.WriteLine("Using AppSettings property.");
                Console.WriteLine("Application settings:");

                if (appSettings.Count == 0)
                {
                    Console.WriteLine("[ReadAppSettings: {0}]",
                    "AppSettings is empty Use GetSection command first.");
                }
                for (int i = 0; i < appSettings.Count; i++)
                {
                    Console.WriteLine("#{0} Key: {1} Value: {2}",
                      i, appSettings.GetKey(i), appSettings[i]);
                }
            }
            catch (ConfigurationErrorsException e)
            {
                Console.WriteLine("[ReadAppSettings: {0}]",
                    e.ToString());
            }
        }


    }
}
