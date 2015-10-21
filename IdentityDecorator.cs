
using log4net.Layout.Decorators;

namespace log4net.Ext.Json.Serializers.Newtonsoft
{
    public class NewtonsoftDecorator : IDecorator
    {
        public object Decorate(object obj)
        {
            return obj;
        }
    }
}
