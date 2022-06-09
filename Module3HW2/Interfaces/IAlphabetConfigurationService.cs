namespace HW_12
{
    public interface IAlphabetConfigurationService
    {
        public void SerializeAlphabetConfig(AlphabetConfig alphabetConfig, string jsonFilePath);
        public AlphabetConfig DeserializeAlphabetConfig(string jsonFilePath);
    }
}
