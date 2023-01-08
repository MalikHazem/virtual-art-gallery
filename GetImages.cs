using UnityEngine;
using System.Net;
using System.IO;

public class GetImages : MonoBehaviour
{
    public static ApiPainting1 GetApi1(string url)
    {
        HttpWebRequest req = (HttpWebRequest)WebRequest.Create(url);
        HttpWebResponse res = (HttpWebResponse)req.GetResponse();
        StreamReader reader = new StreamReader(res.GetResponseStream());
        string json = reader.ReadToEnd();
        return JsonUtility.FromJson<ApiPainting1>(json);
    }
    public static ApiPainting2 GetApi2(string url)
    {
        HttpWebRequest req = (HttpWebRequest)WebRequest.Create(url);
        HttpWebResponse res = (HttpWebResponse)req.GetResponse();
        StreamReader reader = new StreamReader(res.GetResponseStream());
        string json = reader.ReadToEnd();
        return JsonUtility.FromJson<ApiPainting2>(json);
    }
    public static ApiPainting3 GetApi3(string url)
    {
        HttpWebRequest req = (HttpWebRequest)WebRequest.Create(url);
        HttpWebResponse res = (HttpWebResponse)req.GetResponse();
        StreamReader reader = new StreamReader(res.GetResponseStream());
        string json = reader.ReadToEnd();
        return JsonUtility.FromJson<ApiPainting3>(json);
    }
    public static ApiPainting4 GetApi4(string url)
    {
        HttpWebRequest req = (HttpWebRequest)WebRequest.Create(url);
        HttpWebResponse res = (HttpWebResponse)req.GetResponse();
        StreamReader reader = new StreamReader(res.GetResponseStream());
        string json = reader.ReadToEnd();
        return JsonUtility.FromJson<ApiPainting4>(json);
    }
    public static ApiPainting5 GetApi5(string url)
    {
        HttpWebRequest req = (HttpWebRequest)WebRequest.Create(url);
        HttpWebResponse res = (HttpWebResponse)req.GetResponse();
        StreamReader reader = new StreamReader(res.GetResponseStream());
        string json = reader.ReadToEnd();
        return JsonUtility.FromJson<ApiPainting5>(json);
    }
    public static ApiPainting6 GetApi6(string url)
    {
        HttpWebRequest req = (HttpWebRequest)WebRequest.Create(url);
        HttpWebResponse res = (HttpWebResponse)req.GetResponse();
        StreamReader reader = new StreamReader(res.GetResponseStream());
        string json = reader.ReadToEnd();
        return JsonUtility.FromJson<ApiPainting6>(json);
    }
    public static ApiPainting7 GetApi7(string url)
    {
        HttpWebRequest req = (HttpWebRequest)WebRequest.Create(url);
        HttpWebResponse res = (HttpWebResponse)req.GetResponse();
        StreamReader reader = new StreamReader(res.GetResponseStream());
        string json = reader.ReadToEnd();
        return JsonUtility.FromJson<ApiPainting7>(json);
    }
    public static ApiPainting8 GetApi8(string url)
    {
        HttpWebRequest req = (HttpWebRequest)WebRequest.Create(url);
        HttpWebResponse res = (HttpWebResponse)req.GetResponse();
        StreamReader reader = new StreamReader(res.GetResponseStream());
        string json = reader.ReadToEnd();
        return JsonUtility.FromJson<ApiPainting8>(json);
    }
    public static ApiPainting9 GetApi9(string url)
    {
        HttpWebRequest req = (HttpWebRequest)WebRequest.Create(url);
        HttpWebResponse res = (HttpWebResponse)req.GetResponse();
        StreamReader reader = new StreamReader(res.GetResponseStream());
        string json = reader.ReadToEnd();
        return JsonUtility.FromJson<ApiPainting9>(json);
    }
    public static ApiPainting10 GetApi10(string url)
    {
        HttpWebRequest req = (HttpWebRequest)WebRequest.Create(url);
        HttpWebResponse res = (HttpWebResponse)req.GetResponse();
        StreamReader reader = new StreamReader(res.GetResponseStream());
        string json = reader.ReadToEnd();
        return JsonUtility.FromJson<ApiPainting10>(json);
    }
    public static ApiPainting11 GetApi11(string url)
    {
        HttpWebRequest req = (HttpWebRequest)WebRequest.Create(url);
        HttpWebResponse res = (HttpWebResponse)req.GetResponse();
        StreamReader reader = new StreamReader(res.GetResponseStream());
        string json = reader.ReadToEnd();
        return JsonUtility.FromJson<ApiPainting11>(json);
    }
    public static ApiPainting12 GetApi12(string url)
    {
        HttpWebRequest req = (HttpWebRequest)WebRequest.Create(url);
        HttpWebResponse res = (HttpWebResponse)req.GetResponse();
        StreamReader reader = new StreamReader(res.GetResponseStream());
        string json = reader.ReadToEnd();
        return JsonUtility.FromJson<ApiPainting12>(json);
    }
    public static ApiPainting13 GetApi13(string url)
    {
        HttpWebRequest req = (HttpWebRequest)WebRequest.Create(url);
        HttpWebResponse res = (HttpWebResponse)req.GetResponse();
        StreamReader reader = new StreamReader(res.GetResponseStream());
        string json = reader.ReadToEnd();
        return JsonUtility.FromJson<ApiPainting13>(json);
    }
    public static ApiPainting14 GetApi14(string url)
    {
        HttpWebRequest req = (HttpWebRequest)WebRequest.Create(url);
        HttpWebResponse res = (HttpWebResponse)req.GetResponse();
        StreamReader reader = new StreamReader(res.GetResponseStream());
        string json = reader.ReadToEnd();
        return JsonUtility.FromJson<ApiPainting14>(json);
    }
    public static ApiPainting15 GetApi15(string url)
    {
        HttpWebRequest req = (HttpWebRequest)WebRequest.Create(url);
        HttpWebResponse res = (HttpWebResponse)req.GetResponse();
        StreamReader reader = new StreamReader(res.GetResponseStream());
        string json = reader.ReadToEnd();
        return JsonUtility.FromJson<ApiPainting15>(json);
    }
    public static ApiPainting16 GetApi16(string url)
    {
        HttpWebRequest req = (HttpWebRequest)WebRequest.Create(url);
        HttpWebResponse res = (HttpWebResponse)req.GetResponse();
        StreamReader reader = new StreamReader(res.GetResponseStream());
        string json = reader.ReadToEnd();
        return JsonUtility.FromJson<ApiPainting16>(json);
    }
    public static ApiPainting17 GetApi17(string url)
    {
        HttpWebRequest req = (HttpWebRequest)WebRequest.Create(url);
        HttpWebResponse res = (HttpWebResponse)req.GetResponse();
        StreamReader reader = new StreamReader(res.GetResponseStream());
        string json = reader.ReadToEnd();
        return JsonUtility.FromJson<ApiPainting17>(json);
    }
    public static ApiPainting18 GetApi18(string url)
    {
        HttpWebRequest req = (HttpWebRequest)WebRequest.Create(url);
        HttpWebResponse res = (HttpWebResponse)req.GetResponse();
        StreamReader reader = new StreamReader(res.GetResponseStream());
        string json = reader.ReadToEnd();
        return JsonUtility.FromJson<ApiPainting18>(json);
    }
    public static ApiPainting19 GetApi19(string url)
    {
        HttpWebRequest req = (HttpWebRequest)WebRequest.Create(url);
        HttpWebResponse res = (HttpWebResponse)req.GetResponse();
        StreamReader reader = new StreamReader(res.GetResponseStream());
        string json = reader.ReadToEnd();
        return JsonUtility.FromJson<ApiPainting19>(json);
    }
    public static ApiPainting20 GetApi20(string url)
    {
        HttpWebRequest req = (HttpWebRequest)WebRequest.Create(url);
        HttpWebResponse res = (HttpWebResponse)req.GetResponse();
        StreamReader reader = new StreamReader(res.GetResponseStream());
        string json = reader.ReadToEnd();
        return JsonUtility.FromJson<ApiPainting20>(json);
    }
    public static ApiPainting21 GetApi21(string url)
    {
        HttpWebRequest req = (HttpWebRequest)WebRequest.Create(url);
        HttpWebResponse res = (HttpWebResponse)req.GetResponse();
        StreamReader reader = new StreamReader(res.GetResponseStream());
        string json = reader.ReadToEnd();
        return JsonUtility.FromJson<ApiPainting21>(json);
    }
}

