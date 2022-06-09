using System.IO;
using Newtonsoft.Json;

namespace HW_12
{
    public class AlphabetConfigurationService : IAlphabetConfigurationService
    {
        public void SerializeAlphabetConfig(AlphabetConfig alphabetConfig, string jsonFilePath = @"C:\Users\Timmy\OneDrive\Рабочий стол\Module3HW2-Module3HW2\Module3HW2\Module3HW2\Configs\alphabet-config.json")
        {
            string serializedObject = JsonConvert.SerializeObject(alphabetConfig);
            File.WriteAllText(jsonFilePath, serializedObject);
        }

        public AlphabetConfig DeserializeAlphabetConfig(string jsonFilePath = @"C:\Users\Timmy\OneDrive\Рабочий стол\Module3HW2-Module3HW2\Module3HW2\Module3HW2\Configs\alphabet-config.json")
        {
            return JsonConvert.DeserializeObject<AlphabetConfig>(File.ReadAllText(jsonFilePath));
        }
    }
}
