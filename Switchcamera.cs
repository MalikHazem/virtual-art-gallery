using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switchcamera : MonoBehaviour
{

    public int camNum;

    public GameObject fpscam;
    public GameObject tpscam;
    public GameObject fps;
    public GameObject tps;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            if (camNum == 1)
            {
                camNum = 0;
            }
            else camNum += 1;
        }
        SwitchCam();
    }

    void SwitchCam()
    {
        if (camNum == 0)
        {
            fpscam.SetActive(true);
            tpscam.SetActive(false);
            fps.SetActive(true);
            tps.SetActive(false);
        }
        if (camNum == 1)
        {
            fpscam.SetActive(false);
            tpscam.SetActive(true);
            fps.SetActive(false);
            tps.SetActive(true);
        }
    }
}
