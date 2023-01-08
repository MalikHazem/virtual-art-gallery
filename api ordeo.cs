using UnityEngine;
using System.Net;
using Newtonsoft.Json;
using System.IO;
using System;

public class apiordeo : MonoBehaviour
{
    public static ApiOrder GetApiOrder(string url)
    {
        HttpWebRequest req = (HttpWebRequest)WebRequest.Create(url);
        HttpWebResponse res = (HttpWebResponse)req.GetResponse();
        StreamReader reader = new StreamReader(res.GetResponseStream());
        string json = reader.ReadToEnd();
        Debug.Log(json);
        return JsonUtility.FromJson<ApiOrder>(json);
    }
}
