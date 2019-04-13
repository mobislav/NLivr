using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace NLivr
{
    public class Validator
    {
        private Validator()
        {
            
        }

        public static Validator Create(string rules)
        {
            if (rules == null) throw new ArgumentNullException(nameof(rules));

            try
            {
                var  jobject = JObject.Parse(rules);
            }
            catch (JsonReaderException exception)
            {
                throw new ArgumentException(nameof(rules), exception);
            }
            return  new Validator();
        }
    }
}
