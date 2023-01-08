using Newtonsoft.Json.Linq;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;

public class Order : MonoBehaviour
{
    public string url;
    public string url2;
    string url3;

    public string urlOrder = "http://127.0.0.1:8000/api/Order/store";

    public Api p;
    public ApiOrder d;

    public Button buttonsearch;

    string json = General.CurrentUser;

    public Text name_user;
    public Text id_painting;
    public Text p_name;
    public Text price_order;
    public Text date_order;

    [SerializeField] public GameObject order;
    [SerializeField] public GameObject Confirm_sending;

    [SerializeField] InputField inputsearch;

    // Start is called before the first frame update
    void Start()
    {
        Button btn = buttonsearch.GetComponent<Button>();
        btn.onClick.AddListener(onclick);

        string json = General.CurrentUser;
        ApiUsers U = JsonUtility.FromJson<ApiUsers>(json);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Esc();
        }
    }

    void onclick()
    {
        url3 = url;
        url = url2 + inputsearch.text;
    }

    public void OnButtonClicked()
    {
        Confirm_sending.SetActive(true);
    }

    public void OnButtonClicked2()
    {
        StartCoroutine(reqOrder(urlOrder, url, url3));
    }

    void orderData(string u)
    {
        ApiUsers U = JsonUtility.FromJson<ApiUsers>(json);
        url = u;
        d = apiordeo.GetApiOrder(u);
        name_user.text = U.first_name + " " + U.last_name;
        id_painting.text = d.painting_id;
        p_name.text = d.p_name;
        price_order.text = '$' + d.price;
        date_order.text = d.date;
    }

    IEnumerator reqOrder(string u, string u2, string u3)
    {
        ApiUsers U = JsonUtility.FromJson<ApiUsers>(json);

        p = api.GetApi(u2);

        if (p == null)
        {
            u2 = u3;
            p = api.GetApi(u2);
        }

        WWWForm form = new WWWForm();
        form.AddField("user_id", U.id);
        form.AddField("painting_id", p.id);
        form.AddField("payment", "ßÇÔ");
        form.AddField("price", p.price);
        UnityWebRequest w = UnityWebRequest.Post(u, form);
        yield return w.Send();

        if (w.isNetworkError)
        {
            Debug.Log(w.error);
        }
        else
        {
            /*Debug.Log("Form upload complete!");*/

            order.SetActive(true);
            Confirm_sending.SetActive(false);

            orderData(u2);
        }
    }
    public void Esc()
    {
        order.SetActive(false);
    }
    public void Esc2()
    {
        Confirm_sending.SetActive(false);
    }
}
