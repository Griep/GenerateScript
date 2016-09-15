using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace GenerateScript
{
    public class Generate
    {
        public void GenerateMethod(string TO, string Dev, string Stg, string Live)
        {
            
            string line = "--Rollout for TO #" + TO + " \n"
                        + "--Run this script on '" + Dev + "', '" + Stg + "', '" + Live + "' \n\n"
                        + "IF @@SERVERNAME NOT IN('" + Dev + "', '" + Stg + "', '" + Live + "') \n"
                        + "    BEGIN \n"
                        + "            RAISERROR('Script is not valid on this server.  Please verify rollout instructions.', 16, 1); \n"
                        + "            SET NOEXEC ON; \n"
                        + "    END; \n"
                        + "GO \n\n"
                        + "SET ANSI_NULLS ON; \n"
                        + "SET ANSI_PADDING ON; \n"
                        + "SET QUOTED_IDENTIFIER ON; \n"
                        + "SET XACT_ABORT ON; \n";

            line = line.Replace("@\n", System.Environment.NewLine);

            
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            Directory.CreateDirectory(path + "\\ScriptFolder");

            StreamWriter fileRollout = new StreamWriter(path + "\\ScriptFolder\\" + Live + ".rollout.sql");
            StreamWriter fileRollback = new StreamWriter(path + "\\ScriptFolder\\" + Live + ".rollback.sql");

            fileRollout.WriteLine(line);
            fileRollback.WriteLine(line);

            fileRollout.Close();
            fileRollback.Close();

        }


    }
}
