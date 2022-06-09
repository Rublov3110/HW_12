using System.Collections.Generic;

namespace HW_12
{
    public class AlphabetConfig
    {
        public AlphabetConfig()
        {
            Alphabets = new Dictionary<string, string>();
        }

        public Dictionary<string, string> Alphabets { get; set; }
    }
}
