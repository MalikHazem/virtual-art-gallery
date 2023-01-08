using UnityEngine;
using System.Net;
using System.IO;

public class api : MonoBehaviour
{
    public static Api GetApi(string url)
    {
        HttpWebRequest req = (HttpWebRequest)WebRequest.Create(url);
        HttpWebResponse res = (HttpWebResponse)req.GetResponse();
        StreamReader reader = new StreamReader(res.GetResponseStream());
        string json = reader.ReadToEnd();
        return JsonUtility.FromJson<Api>(json);
    }
}
