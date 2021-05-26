using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Classes
{
    public static class JsonOperations
    {
        public static void WritingToJsonMenueNames(string fileLink, List<Menue_Names_obj> listOfObj)
        {
            File.WriteAllText(fileLink, string.Empty);
            for (int i = 0; i < listOfObj.Count; i++)
            {
                File.AppendAllText(fileLink, JsonConvert.SerializeObject(listOfObj[i]));
            }
        }
        public static void ReadJsonMenyaNames(string fileLink, List<Menue_Names_obj> listOfObj)
        {
            JsonTextReader reader = new JsonTextReader(new StreamReader(fileLink));
            reader.SupportMultipleContent = true;
            while (true)
            {
                if (!reader.Read())
                {
                    break;
                }
                JsonSerializer serializer = new JsonSerializer();
                Menue_Names_obj temp = serializer.Deserialize<Menue_Names_obj>(reader);
                listOfObj.Add(temp);
            }
        }
        public static void WritingToJsonMenueFoodPositions(string fileLink, List<MenueFood_position> listOfObj)
        {
            File.WriteAllText(fileLink, string.Empty);
            for (int i = 0; i < listOfObj.Count; i++)
            {
                File.AppendAllText(fileLink, JsonConvert.SerializeObject(listOfObj[i]));
            }
        }
        public static void ReadJsonMenueFoodPositions(string fileLink, List<MenueFood_position> listOfObj)
        {
            JsonTextReader reader = new JsonTextReader(new StreamReader(fileLink));
            reader.SupportMultipleContent = true;
            while (true)
            {
                if (!reader.Read())
                {
                    break;
                }
                JsonSerializer serializer = new JsonSerializer();
                MenueFood_position temp = serializer.Deserialize<MenueFood_position>(reader);
                listOfObj.Add(temp);
            }
        }
    }
}
