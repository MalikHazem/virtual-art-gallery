using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Image : MonoBehaviour
{
    public string url = "https://miro.medium.com/max/980/1*3iesg_sr8kC6NYN2iiFHRQ.png";

    public Renderer thisRenderer;
    internal Color color;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine((IEnumerator)LFLC());
    }
    private IEnumerable LFLC()
    {
        Debug.Log("Loading ....");
        WWW wwwLoader = new WWW(url);
        yield return wwwLoader;

        Debug.Log("Loaded");
        thisRenderer.material.color = Color.white;
        thisRenderer.material.mainTexture = wwwLoader.texture;
    }

}
