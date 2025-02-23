
namespace Common
{
    [System.Serializable]
    public class BaseMessage<T>
    {
    
        public bool Success;
        public string Message;
        public T data;
    }
}
