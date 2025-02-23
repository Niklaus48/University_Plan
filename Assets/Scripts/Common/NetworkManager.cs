using System;
using System.Collections;
using Common.Interfaces;
using Newtonsoft.Json;
using UnityEngine;
using UnityEngine.Networking;

namespace Common
{
    public class NetworkManager : INetworkManager
    {
        #region Remote

        public IEnumerator _SendRequestGet<T>(string Addres, Action<BaseMessage<T>> result)
        {
            Debug.Log("Send request to : " + Addres);
            UnityWebRequest www = UnityWebRequest.Get(Addres);

            yield return www.SendWebRequest();

            Debug.Log("Server response : " + www.downloadHandler.text);
            BaseMessage<T> r = JsonConvert.DeserializeObject<BaseMessage<T>>(www.downloadHandler.text);

            if (r == null)
                r = new BaseMessage<T>();

            if (www.result != UnityWebRequest.Result.Success)
            {
                r.Message = www.error;
                Debug.LogError("Failed to get data, Reason : " + www.error);
            }

            result.Invoke(r);
        }

        #endregion
    }
}