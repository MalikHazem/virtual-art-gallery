using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Sign : MonoBehaviour
{
    public InputField inputFirst_name;
    public InputField inputLast_name;
    public InputField inputEmail;
    public InputField inputPassword;
    public InputField inputpassword_confirmation;
    public InputField inputphone;
    public static string first_name;
    public static string last_name;
    public static string email;
    public static string password;
    public static string password_confirmation;
    public static string phone;

    public Button button;

    string UserURL1 = "http://127.0.0.1:8000/api/auth/signup";
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Button_Click1()
    {
        StartCoroutine(LoginData(inputFirst_name, inputLast_name, inputEmail, inputPassword, inputpassword_confirmation, inputphone));
    }

    IEnumerator LoginData(InputField inputFirst_name, InputField inputLast_name, InputField inputEmail, InputField inputPassword, InputField inputpassword_confirmation, InputField inputphone)
    {
        WWWForm form = new WWWForm();
        form.AddField("first_name", inputFirst_name.text);
        form.AddField("last_name", inputLast_name.text);
        form.AddField("email", inputEmail.text);
        form.AddField("password", inputPassword.text);
        form.AddField("password_confirmation", inputpassword_confirmation.text);
        form.AddField("phone", 9876); /*inputphone.text*/
        UnityWebRequest www = UnityWebRequest.Post(UserURL1, form);
        www.SetRequestHeader("Content-Type", "application/json");
        www.SetRequestHeader("X-Requested-With", "XMLHttpRequest");
        string str = System.Text.Encoding.Default.GetString(www.downloadHandler.data);
        Debug.Log(str);
        yield return www.Send();
        if (www.isNetworkError)
        {
            Debug.Log(www.error);
        }
        else
        {
            Debug.Log("Successfully created user!");
            SceneManager.LoadScene("main");
        }
    }
}
