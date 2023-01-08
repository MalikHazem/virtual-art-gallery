using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Register : MonoBehaviour
{
    public GameObject login;
    public GameObject register;
    public GameObject logo1;
    public GameObject logo2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Login_ul()
    {
        login.SetActive(true);
        register.SetActive(false);
        logo1.SetActive(true);
        logo2.SetActive(false);
    }
    public void Register_ul()
    {
        login.SetActive(false);
        register.SetActive(true);
        logo1.SetActive(false);
        logo2.SetActive(true);
    }
}
