using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR; 

public class Test : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] string[] NAme;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {foreach (int names in name)
        {
            NAme = XRSettings.supportedDevices;
            Debug.Log("LoadedDevice :" + names);
        }
    }
}
