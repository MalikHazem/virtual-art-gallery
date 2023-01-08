using System;
using System.Collections;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Net;
using System.IO;

public class Login1 : MonoBehaviour
{
    public InputField inputEmail;
    /*public InputField inputEmail1;*/
    public InputField inputPassword;
    public static string email;
    public static string password;
    public static string remember_me;

    public Button button;

    string UserURL1 = "http://127.0.0.1:8000/api/auth/login";
    public void Button_Click1()
    {
        StartCoroutine(LoginData(inputEmail, inputPassword));
    }

    /*IEnumerator Login()
    {
        WWWForm form = new WWWForm();
        form.AddField("email", inputEmail.text);
        form.AddField("password", inputPassword.text);
        WWW www = new WWW("http://127.0.0.1:8000/api/auth/login");
        yield return www;
        if (www.text[0] == '0')
        {

        }
    }

    public void Submit()
    {
        button.interactable = (inputEmail.text.Length >= 8 && inputPassword.text.Length >= 8);
    }*/

    IEnumerator LoginData(InputField inputEmail, InputField inputPassword)
    {
        WWWForm form = new WWWForm();
        form.AddField("email", inputEmail.text);
        form.AddField("password", inputPassword.text);
        /*UnityWebRequest www =UnityWebRequest.Post(UserURL1, form);
        www.SetRequestHeader("Content-Type", "application/json");
        www.SetRequestHeader("X-Requested-With", "XMLHttpRequest");
        string str = System.Text.Encoding.Default.GetString(www.downloadHandler.data);*/
        WWW www = new WWW(UserURL1, form);
        yield return www;
        if (www.text.Length == 0)
        {
            Debug.Log("User Login Failed.");
        }
        else
        {
            /*string json = reader.ReadToEnd();
            return JsonUtility.FromJson<Api>(json);*/
            string json = www.text;
            General.CurrentUser = json;
            SceneManager.LoadScene("main");
            /*ApiUsers U = JsonUtility.FromJson<ApiUsers>(json);*/
            //newVar = General.CurrentUser;
        }
        DontDestroyOnLoad(this.gameObject);
        /*if (www.isNetworkError)
        {
            Debug.Log(www.error);
        }
        else
        {
            Debug.Log("Successfully created user!");
            SceneManager.LoadScene("main");
        }*/
    }   
}

