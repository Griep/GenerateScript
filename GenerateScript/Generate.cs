﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenerateScript
{
    public class Generate
    {
        public void GenerateMethod(string TO, string Dev, string Stg, string Live)
        {
            string rollout;
            string rollback;
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

            rollout = RolloutScript(Live);
            rollback = RollbackScript(Live);

            System.IO.StreamWriter fileRollout = new System.IO.StreamWriter("C:\\Users\\connor-griep\\Desktop\\TestFolder\\" + rollout);
            System.IO.StreamWriter fileRollback = new System.IO.StreamWriter("C:\\Users\\connor-griep\\Desktop\\TestFolder\\" + rollback);

            fileRollout.WriteLine(line);
            fileRollback.WriteLine(line);

            fileRollout.Close();
            fileRollback.Close();

        }

        public string RolloutScript(string Server)
        {
            Server = Server + ".rollout.sql";
            return Server;
        }
        public string RollbackScript(string Server)
        {
            Server = Server + ".rollback.sql";
            return Server;
        }

    }
}
