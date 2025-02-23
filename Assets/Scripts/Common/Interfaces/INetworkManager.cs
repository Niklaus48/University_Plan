using System;
using System.Collections;

namespace Common.Interfaces
{
    public interface INetworkManager
    {
        IEnumerator _SendRequestGet<T>(string Addres, Action<BaseMessage<T>> result);
    }
}