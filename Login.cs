using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Login : MonoBehaviour
{

    [SerializeField] InputField username;
    [SerializeField] InputField password;

    [SerializeField] Text errorMassages;
    [SerializeField] Text user;

    [SerializeField] GameObject progressCircle;
    [SerializeField] GameObject welcomePanel;

    [SerializeField] Button loginButton;

    [SerializeField] string url = "https://usersgroup.tk/api/login";
    
    WWWForm form;

    public void OnLoginButtonClicked()
    {
        loginButton.interactable = false;
        progressCircle.SetActive(true);
        StartCoroutine(LoginUser());
    }
    IEnumerator LoginUser()
    {
        form = new WWWForm();
        form.AddField("email", username.text);
        form.AddField("password", password.text);
        
        WWW w = new WWW (url, form);
        yield return w;

        if(w.error != null)
        {
            errorMassages.text = "404 not found!";
        }
        else
        {
            if (w.isDone)
            {
                if(w.text.Contains ("error  "))
                {
                    errorMassages.text = "invalid username or password!";
                }
                else
                {
                    welcomePanel.SetActive(true);
                    user.text = username.text;
                }
            }
        }
        loginButton.interactable = true;
        progressCircle.SetActive(false);
        w.Dispose ();
    }
}
