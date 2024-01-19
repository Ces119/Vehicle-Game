using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VehicleCam : MonoBehaviour
{
    public GameObject player;
    private Vector3 offset = new Vector3(0,3,-1);
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Follow the player
        transform.position = player.transform.position + offset;    
    }
}
