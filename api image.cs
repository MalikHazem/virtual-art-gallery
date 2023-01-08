using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;


/*public struct Data
{
    public string title;
    public string url;
}*/


public class apiimage : MonoBehaviour
{

    /*[SerializeField] Text Name;
    [SerializeField] RawImage img;

    string jsonurl = "https://jsonplaceholder.typicode.com/photos/1";
    public string url = "https://jsonplaceholder.typicode.com/photos/1";

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(GetData(jsonurl));
    }

    IEnumerable GetData (string url)
    {
        UnityWebRequest request = UnityWebRequestTexture.GetTexture (url);

        yield return request.Send();

        if(request.isNetworkError)
        {

        }

        else
        {
            Name.text = Data.title;

            StartCoroutine(Getimg(Data.url));
        }
        request.Dispose ();
    }
    IEnumerable Getimg(string url)
    {
        UnityWebRequest request = UnityWebRequestTexture.GetTexture(url);

        yield return request.Send();

        if (request.isNetworkError)
        {

        }

        else
        {
            img.texture = ((DownloadHandlerTexture)request.downloadHandler).texture;
            Texture myTexture = ((DownloadHandlerTexture)request.downloadHandler).texture;
        }
        request.Dispose();
    }*/
}
