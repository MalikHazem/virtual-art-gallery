using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class loadImage : MonoBehaviour
{
    public string url = "https://miro.medium.com/max/980/1*3iesg_sr8kC6NYN2iiFHRQ.png";

    public RawImage RawImage;
    // Start is called before the first frame update
    void Start()
    {
        /*StartCoroutine(loadimage(url));*/
    }

    private void StartCoroutine(IEnumerable enumerable)
    {
        throw new NotImplementedException();
    }

    IEnumerable loadimage(string ImageUrl)
    {
        WWW www = new WWW(ImageUrl);
        yield return www;
        if (www.error == null)
        {
            Texture2D texture = www.texture;
            RawImage.texture = texture;
        }
        else
        {
            Debug.Log("you it's loser");
        }
    }
}
