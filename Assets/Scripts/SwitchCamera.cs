using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class VehicleCamera : MonoBehaviour
{
    // Variables
    public GameObject cam1;
    public GameObject cam2;
    // cameraswitch 
    private bool camSwitch = false;
    // Start is called before the first frame update
    void Start()
    {
        cam1.SetActive(true);
        cam2.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        // if Press the 1 , change the camera 
        if (Input.GetButtonDown("Key1"))
        {        
            camSwitch = !camSwitch; 
            cam1.SetActive(!camSwitch);
            cam2.SetActive(camSwitch);             
        }
        
    }
}
