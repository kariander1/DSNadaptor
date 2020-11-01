using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Text.RegularExpressions;
namespace DSNadaptor
{
    class PVLobject
    {
        public List<PVLobject> data { get; set; }
        public object value { get; set; }
        public string key { get; set; }
        public PVLobject(string key, object value)
        {
            this.key = key;
            this.value = value;
            this.data = null;
        }
        public override string ToString()
        {
            return string.Format("{0} = {1}", key, value);
        }
    }
    class PVLblock
    {
        public string header { get; set; }
        public string trailer{ get; set; }
        public string BlockName { get; set; }
        public List<PVLobject> data { get; set; }
        public int StartOffset { get; set; }
        public PVLblock(string blockName,string header, string trailer)
        {
            this.BlockName = blockName;
            this.header = header;
            this.trailer = trailer;

        }
        public void SubmitData(byte[] data)
        {
            string text = Encoding.Default.GetString(data);
            this.data = PVL.Deserialize(text);
        }
        public override string ToString()
        {
            return string.Format("{0}, Start : {1}, End : {2}", this.BlockName, this.header, this.trailer);
        }
    }
    class PVL
    {

        //   public List<PVLobject> PVLdata { get; set; }
        static char[] array_indetifiers_start = new char[] { '(', '[', '{' };
        static char[] array_indetifiers_end = new char[] { ')', ']', '}' };
        static char[] end_line_characters = new char[] { ';' };
        static string[] pvlObjectsStrings = new string[] { "OBJECT", "GROUP" };
        static char indentCharacter = '\t';
        public PVL()
        {

        }
        public static string Serialize(List<PVLobject> pvlData)
        {
            // string data= null;


            return EncodePVL(pvlData, 0);


        }
        private static string GetIndentation(int depth)
        {
            string indentation = "";
            for (int i = 0; i < depth; i++)
            {
                indentation += indentCharacter;
            }
            return indentation;
        }
        private static string GetEndLineString()
        {
            //TODO finish
            return "\n";
        }
        private static string EncodeObject(object ob)
        {//TODO finish
            if (ob is PVLobject)
            {
                return EncodeObject(((PVLobject)ob).value);
            }
            return ob.ToString();
        }
        private static string EncodePVL(List<PVLobject> pvlData, int depth)
        {
            string dataToReturn = "";
            string indent = GetIndentation(depth);
            foreach (PVLobject pvl in pvlData)
            {
                bool isPVL = pvl.data != null;
                //  Console.WriteLine("{0}={1}", pair.Key, pair.Value);

                dataToReturn += indent + pvl.key + " = ";
                dataToReturn += EncodeObject(pvl.value) + GetEndLineString();

                if (isPVL)
                {

                    dataToReturn += EncodePVL(pvl.data, depth + 1);
                    //  dataToReturn += indent + "END_"+ ob.key + " = " +EncodeObject(ob.value) + GetEndLineString();
                }


            }
            return dataToReturn;


        }
        public static bool isPVLreserved(string key)
        {
            for (int k = 0; k < pvlObjectsStrings.Length; k++)
            {
                string word = pvlObjectsStrings[k];
                if (key.Equals(word) || key.Equals("BEGIN_" + word))
                {
                    // Is PVL object
                    return true;
                    //p.value
                }
            }
            return false;
        }
        //        public Hashtable Deserialize(string[] lines,int currentIndex)
        //        {
        //            Hashtable PVLdata = new Hashtable();
        //            for (int i = currentIndex; i < lines.Length; i++)
        //            {
        //                bool isPVLobeject = false;
        //                string currentLine = lines[i].Trim().TrimEnd(end_line_characters);
        //                string[] splitResults = currentLine.Split('=');
        //                if (splitResults.Length > 1)
        //                {
        //                    string key = splitResults[0].Trim();
        //                    key = key.Split(' ')[key.Split(' ').Length - 1];
        //                    if (key.StartsWith("END"))
        //                        return PVLdata;
        //                    isPVLobeject = isPVLreserved(key);

        //                    //TODO Identify objects/groups

        //                    bool isArray = false;
        //                    string potential_value = splitResults[1].Trim();
        //                    if (isPVLobeject)
        //                    {
        //                        //  DictionaryEntry d = new DictionaryEntry(key, potential_value);
        //                        PVLobject d = new PVLobject();
        //                        d.key = key;
        //                        d.value = potential_value;
        //                        Hashtable tempDate = Deserialize(lines,i+1);
        //                        PVLdata.Add(d, tempDate);
        //                        i += tempDate.Count+1;
        //                        continue;
        //                    }
        //                    else
        //                    {
        //                        PVLdata.Add(key, null);

        //                        for (int j = 0; j < array_indetifiers_start.Length; j++)
        //                        {
        //                            char start = array_indetifiers_start[j];
        //                            char end = array_indetifiers_end[j];
        //                            if (potential_value.StartsWith(start.ToString()) && potential_value.EndsWith(end.ToString()))
        //                            {
        //                                string[] array_elements = potential_value.TrimStart(start).TrimEnd(end).Split(new[] { ',' });
        //                                for (int k = 0; k < array_elements.Length; k++)
        //                                {
        //                                    array_elements[k] = array_elements[k].Trim();
        //                                }
        //                                PVLdata[key] = array_elements;
        //                                isArray = true;
        //                                break;
        //                            }
        //                        }
        //                        if (!isArray)
        //                        {
        //                            PVLdata[key] = potential_value;
        //                        }
        //                    }

        //                }

        //            }
        //            return PVLdata;
        //        }
        //        public Hashtable Deserialize(string text)
        //        {

        //            PVLdata = new Hashtable();

        //             string[] lines= Regex.Split(text, "\r\n|\r|\n|;");

        //            return (this.PVLdata = Deserialize(lines, 0));
        ////PVLdata;
        //        }

        public static List<PVLobject> Deserialize(string text)
        {
            Queue<string> newLines = new Queue<string>();
            string[] lines = Regex.Split(text, "\r\n|\r|\n|;");
            foreach (string line in lines)
            {
                newLines.Enqueue(line);
            }
            return Deserialize(newLines);
        }

        public static List<PVLobject> Deserialize(Queue<string> lines)

        {
            List<PVLobject> pvlList = new List<PVLobject>();
            while (lines.Count > 0)
            {
                bool isPVLobeject = false;
                string currentLine = lines.Dequeue();
                string[] splitResults = currentLine.Split('=');
                if (splitResults.Length > 1)
                {
                    string key = splitResults[0].Trim();
                    key = key.Split(' ')[key.Split(' ').Length - 1];


                    string[] faultyText = key.Split(pvlObjectsStrings, StringSplitOptions.RemoveEmptyEntries);
                    if(faultyText.Length>0 && faultyText[0]!=key && !faultyText[0].StartsWith("END"))
                       key = key.Replace(faultyText[0], "");
                    string potential_value = splitResults[1].Trim();
                    PVLobject tempPvl = new PVLobject(key, potential_value);

                    if (key.StartsWith("END"))
                    {
                        pvlList.Add(tempPvl);
                        return pvlList;
                    }
                        

                    isPVLobeject = isPVLreserved(key);
                    //TODO Identify objects/groups
                    if (isPVLobeject)
                        tempPvl.data = Deserialize(lines);
                    bool isArray = false;



                    for (int j = 0; j < array_indetifiers_start.Length; j++)
                    {
                        char start = array_indetifiers_start[j];
                        char end = array_indetifiers_end[j];
                        if (potential_value.StartsWith(start.ToString()) && potential_value.EndsWith(end.ToString()))
                        {
                            string[] array_elements = potential_value.TrimStart(start).TrimEnd(end).Split(new[] { ',' });
                            for (int k = 0; k < array_elements.Length; k++)
                            {
                                array_elements[k] = array_elements[k].Trim();
                            }
                            tempPvl.value = array_elements;
                            isArray = true;
                            break;
                        }
                    }
                    if (!isArray)
                    {
                        tempPvl.value = potential_value;
                    }
                    pvlList.Add(tempPvl);
                }


            }

            return pvlList;
        }
    }
}
