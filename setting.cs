using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class setting : MonoBehaviour
{
    public GameObject Control;
    public GameObject Sound;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    public void controlSetting()
    {
        Control.SetActive(true);
        Sound.SetActive(false);
    }
    public void soundSetting()
    {
        Control.SetActive(false);
        Sound.SetActive(true);
    }
}
