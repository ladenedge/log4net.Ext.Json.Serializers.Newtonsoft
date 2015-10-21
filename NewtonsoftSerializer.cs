
using log4net.Util.Serializer;
using Newtonsoft.Json;

namespace log4net.Ext.Json.Serializers.Newtonsoft
{
    public class NewtonsoftSerializer : ISerializer
    {
        public object Serialize(object obj)
        {
            return JsonConvert.SerializeObject(obj);
        }
    }
}
