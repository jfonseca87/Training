using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text;
using System.IO;
using System.Diagnostics;

namespace LogErrors.Error_Log
{
    public class ErrorLog
    {
        public void SaveError(object obj, Exception ex)
        {
            string fecha = System.DateTime.Now.ToString("yyyyMMdd");
            string hora = System.DateTime.Now.ToString("HH:mm:ss");
            string path = HttpContext.Current.Request.MapPath("~/log/" + fecha + ".txt");

            //Crea el archivo donde se va a almacenar el error
            StreamWriter nLog = new StreamWriter(path, true);

            //Crea el objeto para poder acceder al error
            StackTrace stackTrace = new StackTrace();
            nLog.WriteLine(obj.GetType().FullName + " " + hora);
            nLog.WriteLine(stackTrace.GetFrame(1).GetMethod().Name + " - " + ex.Message);
            nLog.WriteLine("_ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _");
            nLog.WriteLine("");

            nLog.Flush();
            nLog.Close();
        }
    }
}