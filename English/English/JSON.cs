using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization.Json;
using System.IO;

namespace English
{
    public static class JSON
    {
        public static void LoadFromFile(string filename, ref List<Words> words)
        {
            try
            {
                DataContractJsonSerializer ser = new DataContractJsonSerializer(typeof(List<Words>));
                var fileText = File.ReadAllText(filename);
                MemoryStream stream1 = new MemoryStream(Encoding.UTF8.GetBytes(fileText));

                words = new List<Words>();
                words = (List<Words>)ser.ReadObject(stream1);
                words.Sort((x, y) =>
                        x.TimeToRemember.CompareTo(y.TimeToRemember));
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.ToString());
                words = new List<Words>();
                words.Add(new Words(    "example",
                                        "пример",
                                        Config.GetUnixTime() + 30,
                                        0,0,0
                                    )
                         );
                SaveToFile(Config.json_fileName, ref words);
            }
        }


        public static void SaveToFile(string filename, ref List<Words> words)
        {
            try
            {
                MemoryStream stream1 = new MemoryStream();
                DataContractJsonSerializer ser = new DataContractJsonSerializer(typeof(List<Words>));

                ser.WriteObject(stream1, words);
                stream1.Position = 0;
                //StreamReader sr = new StreamReader(stream1);sr.ReadToEnd()

                File.WriteAllBytes(filename, stream1.ToArray());
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.ToString());
            }
        }


    }
}
