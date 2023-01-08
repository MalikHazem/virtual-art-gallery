using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ESC : MonoBehaviour
{
    [SerializeField] public GameObject order;

    [SerializeField] public GameObject search;

    [SerializeField] public GameObject Confirm_sending;
    [SerializeField] public GameObject Confirm_sending2;
    [SerializeField] public GameObject Confirm_sending3;
    [SerializeField] public GameObject Confirm_sending4;
    [SerializeField] public GameObject Confirm_sending5;
    [SerializeField] public GameObject Confirm_sending6;
    [SerializeField] public GameObject Confirm_sending7;
    [SerializeField] public GameObject Confirm_sending8;
    [SerializeField] public GameObject Confirm_sending9;
    [SerializeField] public GameObject Confirm_sending10;
    [SerializeField] public GameObject Confirm_sending11;
    [SerializeField] public GameObject Confirm_sending12;
    [SerializeField] public GameObject Confirm_sending13;
    [SerializeField] public GameObject Confirm_sending14;
    [SerializeField] public GameObject Confirm_sending15;
    [SerializeField] public GameObject Confirm_sending16;
    [SerializeField] public GameObject Confirm_sending17;
    [SerializeField] public GameObject Confirm_sending18;
    [SerializeField] public GameObject Confirm_sending19;
    [SerializeField] public GameObject Confirm_sending20;
    [SerializeField] public GameObject Confirm_sending21;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Esc()
    {
        order.SetActive(false);
    }
    public void Esc2()
    {
        Confirm_sending.SetActive(false);
        Confirm_sending2.SetActive(false);
        Confirm_sending3.SetActive(false);
        Confirm_sending4.SetActive(false);
        Confirm_sending5.SetActive(false);
        Confirm_sending6.SetActive(false);
        Confirm_sending7.SetActive(false);
        Confirm_sending8.SetActive(false);
        Confirm_sending9.SetActive(false);
        Confirm_sending10.SetActive(false);
        Confirm_sending11.SetActive(false);
        Confirm_sending12.SetActive(false);
        Confirm_sending13.SetActive(false);
        Confirm_sending14.SetActive(false);
        Confirm_sending15.SetActive(false);
        Confirm_sending16.SetActive(false);
        Confirm_sending17.SetActive(false);
        Confirm_sending18.SetActive(false);
        Confirm_sending19.SetActive(false);
        Confirm_sending20.SetActive(false);
        Confirm_sending21.SetActive(false);
    }
    public void Esc3()
    {
        search.SetActive(false);
    }
}
