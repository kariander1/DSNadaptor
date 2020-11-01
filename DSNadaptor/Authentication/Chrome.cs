using System;
using System.Text;
using System.IO;
using System.Data.SQLite;

namespace DSNadaptor
{
    public class Chrome
    {

        public static string GetChromeCookiePath()
        {
            string s = Environment.GetFolderPath(
                Environment.SpecialFolder.LocalApplicationData);
            s += @"\Google\Chrome\User Data\Default\cookies";

            if (!File.Exists(s))
                return string.Empty;

            return s;
        }

        public static bool GetCookie_Chrome(string strHost, string strField, ref string Value)
        {
            Value = string.Empty;
            bool fRtn = false;
            string strPath, strDb;

            // Check to see if Chrome Installed
            strPath = GetChromeCookiePath();
            if (string.Empty == strPath) // Nope, perhaps another browser
                return false;

            try
            {
                strDb = "Data Source=" + strPath + ";pooling=false";

                using (SQLiteConnection conn = new SQLiteConnection(strDb))
                {
                    using (SQLiteCommand cmd = conn.CreateCommand())
                    {
                        cmd.CommandText = "SELECT encrypted_value FROM cookies WHERE host_key LIKE '%" +
                            strHost + "%' AND name LIKE '%" + strField + "%';";

                        conn.Open();
                        //  cmd.ExecuteNonQuery();

                        using (SQLiteDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                byte[] entropy = null;
                                byte[] temp = (byte[])reader[0];
                                if (Config.debugLevel == DebugLevel.FULL)
                                    File.WriteAllBytes(@".\bytes", temp);
                               
                                Value = new UTF8Encoding(true).GetString(DPAPI.Decrypt(temp, entropy, out Value));
                                // Value = reader[0]

                                //if (!Value.Equals(string.Empty))
                                //{
                                //    fRtn = true;
                                //    break;
                                //}
                            }
                        }
                        conn.Close();
                    }
                }
            }
            catch (Exception e)
            {
                Value = string.Empty;
                fRtn = false;


            }
            return fRtn;
        }
    }
}
