using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Networking;
using System.Collections;
using System.Net;
using System.IO;

[RequireComponent(typeof(UnityEngine.UI.Image))]
/*[System.ComponentModel.TypeConverter(typeof(System.Drawing.ImageFormatConverter))]
public sealed class ImageFormat*/

public class ImageDownloader : MonoBehaviour
{
    UnityEngine.UI.Image _img;
    /*public string url;*/

    public static ImageDownloader instance;
    void Start()
    {   
        instance = this;
        _img = GetComponent<UnityEngine.UI.Image>();
        /*Download("https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTLcC6A8bvUw8MLl6sZWfyyDCchGQ4IZMVstQ&usqp=CAU");*/
    }

    public void Download(string u)
    {
        StartCoroutine(LoadFromWeb(u));
    }

    public IEnumerator LoadFromWeb(string url)
    {
        UnityWebRequest wr = new UnityWebRequest("http://127.0.0.1:8000/images/"+url);
        DownloadHandlerTexture texDl = new DownloadHandlerTexture(true);
        wr.downloadHandler = texDl;
        yield return wr.SendWebRequest();
        if (!(wr.isNetworkError || wr.isHttpError))
        {
            Texture2D t = texDl.texture;
            Sprite s = Sprite.Create(t, new Rect(0, 0, t.width, t.height),
                                     Vector2.zero, 1f);
            _img.sprite = s;
        }
    }
}