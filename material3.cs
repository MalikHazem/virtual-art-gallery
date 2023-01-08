using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Networking;

public class material3 : MonoBehaviour
{
    public string url;
    public string url2;
    string url3;

    public ApiPainting3 p;

    public Renderer rend;

    public Button buttonsearch;

    [SerializeField] public GameObject search;
    [SerializeField] public GameObject loc_map;

    [SerializeField] InputField inputsearch;

    // Start is called before the first frame update
    void Start()
    {
        rend = GetComponent<Renderer>();

        Button btn = buttonsearch.GetComponent<Button>();
        btn.onClick.AddListener(delegate { onclick(); });

        //����� ����� �� ���� resources        
        /*Texture main = Resources.Load<Texture>("2");*/

        //����� �������� �� ���������        
        rend.material.EnableKeyword("_NORMALMAP");
        rend.material.EnableKeyword("_METALLICGLOSSMAP");
        rend.material.EnableKeyword("_HEIGHTMAP");
        rend.material.EnableKeyword("_OCCLUSION");
        rend.material.EnableKeyword("_DETAILMASK");
        rend.material.EnableKeyword("_EMISSION");

        StartCoroutine(GetText(url));
    }

    // Update is called once per frame
    void Update()
    {

    }
    void onclick()
    {
        StopCoroutine(GetText(url));
        url3 = url;
        url = url2 + inputsearch.text;
        p = GetImages.GetApi3(url);
        if (p == null)
        {
            /*loc_map.SetActive(true);*/
            url = url3;
        }
        else
        {
            /*loc_map.SetActive(false);*/
        }
        StartCoroutine(GetText(url));
    }
    IEnumerator GetText(string url)
    {
        p = GetImages.GetApi3(url);
        using (UnityWebRequest uwr = UnityWebRequestTexture.GetTexture("http://127.0.0.1:8000/images/" + p.image))
        {
            yield return uwr.SendWebRequest();

            if (uwr.result != UnityWebRequest.Result.Success)
            {
                Debug.Log(uwr.error);
            }
            else
            {
                // Get downloaded asset bundle
                var texture = DownloadHandlerTexture.GetContent(uwr);

                //Albedo �����
                rend.material.SetTexture("_MainTex", texture);
                //Normal �����
                rend.material.SetTexture("_BumpMap", texture);
                //Metallic �����
                rend.material.SetTexture("_MetallicGlossMap", texture);
                //HEIGHT �����
                rend.material.SetTexture("_ParallaxMap", texture);
                //OCCLUSION �����
                rend.material.SetTexture("_OcclusionMap", texture);
                //DETAILMASK �����
                rend.material.SetTexture("_DetailMask", texture);
                //EMISSION �����
                rend.material.SetTexture("_EmissionMap", texture);
                //EMISSION COLOR �����
                rend.material.SetColor("_EmissionColor", Color.white);
                //DetailAlbedo �����
                rend.material.SetTexture("_DetailAlbedoMap", texture);
                //DetailNormal �����
                rend.material.SetTexture("_DetailNormalMap", texture);
            }
        }
    }
}
