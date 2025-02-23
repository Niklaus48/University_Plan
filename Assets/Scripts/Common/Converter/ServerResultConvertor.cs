
using Newtonsoft.Json;

namespace Common
{
    internal class ServerResultConvertor
    {
        public static BaseMessage<T> ConvertToServerResult<T>(string json)
        {
            return JsonConvert.DeserializeObject<BaseMessage<T>>(json);
        }

    }
}
