using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Networking;
using System.Net;
using System.IO;

public class rayPainting : MonoBehaviour
{
    public Camera cam;
    public Camera cam2;

    public Vector3 direction = -Vector3.up;

    public float rayDistance;

    public GameObject canpainting;
    public GameObject canpainting2;
    public GameObject canpainting3;
    public GameObject canpainting4;
    public GameObject canpainting5;
    public GameObject canpainting6;
    public GameObject canpainting7;
    public GameObject canpainting8;
    public GameObject canpainting9;
    public GameObject canpainting10;
    public GameObject canpainting11;
    public GameObject canpainting12;
    public GameObject canpainting13;
    public GameObject canpainting14;
    public GameObject canpainting15;
    public GameObject canpainting16;
    public GameObject canpainting17;
    public GameObject canpainting18;
    public GameObject canpainting19;
    public GameObject canpainting20;
    public GameObject canpainting21;

    [SerializeField] public GameObject pressF;
    [SerializeField] public GameObject p1;
    [SerializeField] public GameObject p2;
    [SerializeField] public GameObject canvas;

    void Start()
    {
        /*GetComponent<playermov>().enabled = false;
        GetComponent<MouseLook>().enabled = false;*/
        /*StartCoroutine((IEnumerator)LFLC());*/
        looking();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            Pickup();
        }
    }

    void Pickup()
    {
        RaycastHit hit;
        //Ray ray = cam.ScreenPointToRay(Input.mousePosition);
        Ray ray = cam.ViewportPointToRay(new Vector3(0.5f, 0.5f, 0));
        Debug.DrawRay(transform.position, -direction, Color.gray, 10);
        if (Physics.Raycast(ray, out hit, rayDistance))
        {
            #region show
            if (hit.collider.tag == "Painting")
            {
                canpainting.SetActive(true);
            }
            else if (hit.collider.tag == "Painting2")
            {
                canpainting2.SetActive(true);
            }
            else if (hit.collider.tag == "Painting3")
            {
                canpainting3.SetActive(true);
            }
            else if (hit.collider.tag == "Painting4")
            {
                canpainting4.SetActive(true);
            }
            else if (hit.collider.tag == "Painting5")
            {
                canpainting5.SetActive(true);
            }
            else if (hit.collider.tag == "Painting6")
            {
                canpainting6.SetActive(true);
            }
            else if (hit.collider.tag == "Painting7")
            {
                canpainting7.SetActive(true);
            }
            else if (hit.collider.tag == "Painting8")
            {
                canpainting8.SetActive(true);
            }
            else if (hit.collider.tag == "Painting9")
            {
                canpainting9.SetActive(true);
            }
            else if (hit.collider.tag == "Painting10")
            {
                canpainting10.SetActive(true);
            }
            else if (hit.collider.tag == "Painting11")
            {
                canpainting11.SetActive(true);
            }
            else if (hit.collider.tag == "Painting12")
            {
                canpainting12.SetActive(true);
            }
            else if (hit.collider.tag == "Painting13")
            {
                canpainting13.SetActive(true);
            }
            else if (hit.collider.tag == "Painting14")
            {
                canpainting14.SetActive(true);
            }
            else if (hit.collider.tag == "Painting15")
            {
                canpainting15.SetActive(true);
            }
            else if (hit.collider.tag == "Painting16")
            {
                canpainting16.SetActive(true);
            }
            else if (hit.collider.tag == "Painting17")
            {
                canpainting17.SetActive(true);
            }
            else if (hit.collider.tag == "Painting18")
            {
                canpainting18.SetActive(true);
            }
            else if (hit.collider.tag == "Painting19")
            {
                canpainting19.SetActive(true);
            }
            else if (hit.collider.tag == "Painting20")
            {
                canpainting20.SetActive(true);
            }
            else if (hit.collider.tag == "Painting21")
            {
                canpainting21.SetActive(true);
            }
            else
            {
                canpainting.SetActive(false);
                canpainting2.SetActive(false);
                canpainting3.SetActive(false);
                canpainting4.SetActive(false);
                canpainting5.SetActive(false);
                canpainting6.SetActive(false);
                canpainting7.SetActive(false);
                canpainting8.SetActive(false);
                canpainting9.SetActive(false);
                canpainting10.SetActive(false);
                canpainting11.SetActive(false);
                canpainting12.SetActive(false);
                canpainting13.SetActive(false);
                canpainting14.SetActive(false);
                canpainting15.SetActive(false);
                canpainting16.SetActive(false);
                canpainting17.SetActive(false);
                canpainting18.SetActive(false);
                canpainting19.SetActive(false);
                canpainting20.SetActive(false);
                canpainting21.SetActive(false);
            }
            #endregion
        }
    }

    private void looking()
    {
        RaycastHit hit;
        //Ray ray = cam.ScreenPointToRay(Input.mousePosition);
        Ray ray = cam.ViewportPointToRay(new Vector3(0.5f, 0.5f, 0));

        if (Physics.Raycast(ray, out hit, rayDistance))
        {
            /* #region pressFtrue
             *//*print(hit.collider.tag);*//*
             if (hit.collider.tag == "Painting")
             {
                 pressF.SetActive(true);
             }
             *//*else if (hit.collider.tag == "Painting2")
             {
                 pressF.SetActive(true);
             }
             else if (hit.collider.tag == "Painting3")
             {
                 pressF.SetActive(true);
             }
             else if (hit.collider.tag == "Painting4")
             {
                 pressF.SetActive(true);
             }
             else if (hit.collider.tag == "Painting5")
             {
                 pressF.SetActive(true);
             }
             else if (hit.collider.tag == "Painting6")
             {
                 pressF.SetActive(true);
             }
             else if (hit.collider.tag == "Painting7")
             {
                 pressF.SetActive(true);
             }
             else if (hit.collider.tag == "Painting8")
             {
                 pressF.SetActive(true);
             }
             else if (hit.collider.tag == "Painting9")
             {
                 pressF.SetActive(true);
             }
             else if (hit.collider.tag == "Painting10")
             {
                 pressF.SetActive(true);
             }
             else if (hit.collider.tag == "Painting11")
             {
                 pressF.SetActive(true);
             }
             else if (hit.collider.tag == "Painting12")
             {
                 pressF.SetActive(true);
             }
             else if (hit.collider.tag == "Painting13")
             {
                 pressF.SetActive(true);
             }
             else if (hit.collider.tag == "Painting14")
             {
                 pressF.SetActive(true);
             }
             else if (hit.collider.tag == "Painting15")
             {
                 pressF.SetActive(true);
             }
             else if (hit.collider.tag == "Painting16")
             {
                 pressF.SetActive(true);
             }
             else if (hit.collider.tag == "Painting17")
             {
                 pressF.SetActive(true);
             }
             else if (hit.collider.tag == "Painting18")
             {
                 pressF.SetActive(true);
             }
             else if (hit.collider.tag == "Painting19")
             {
                 pressF.SetActive(true);
             }
             else if (hit.collider.tag == "Painting20")
             {
                 pressF.SetActive(true);
             }
             else if (hit.collider.tag == "Painting21")
             {
                 pressF.SetActive(true);
             }*//*
             #endregion
             #region pressFfalse
             else
             {
                 pressF.SetActive(false);
             }
             #endregion*/
        }
    }

    /*public void Esc()
    {
        #region Esc
        canpainting.SetActive(false);
        canpainting2.SetActive(false);
        canpainting3.SetActive(false);
        canpainting4.SetActive(false);
        canpainting5.SetActive(false);
        canpainting6.SetActive(false);
        canpainting7.SetActive(false);
        canpainting8.SetActive(false);
        canpainting9.SetActive(false);
        canpainting10.SetActive(false);
        canpainting11.SetActive(false);
        canpainting12.SetActive(false);
        canpainting13.SetActive(false);
        canpainting14.SetActive(false);
        canpainting15.SetActive(false);
        canpainting16.SetActive(false);
        canpainting17.SetActive(false);
        canpainting18.SetActive(false);
        canpainting19.SetActive(false);
        canpainting20.SetActive(false);
        canpainting21.SetActive(false);
        #endregion
    }*/
    public void Player1()
    {
        cam2.enabled = false;
        cam.enabled = true;
        p1.SetActive(true);
        p2.SetActive(false);
        canvas.SetActive(false);
    }

    public void Player2()
    {
        cam2.enabled = false;
        cam.enabled = true;
        p1.SetActive(false);
        p2.SetActive(true);
        canvas.SetActive(false);
    }
}
