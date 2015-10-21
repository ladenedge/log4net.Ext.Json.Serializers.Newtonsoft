
using log4net.ObjectRenderer;
using log4net.Util.Serializer;

namespace log4net.Ext.Json.Serializers.Newtonsoft
{
    public class NewtonsoftFactory : ISerializerFactory
    {
        public ISerializer GetSerializer(object obj, RendererMap map)
        {
            return new NewtonsoftSerializer();
        }
    }
}
