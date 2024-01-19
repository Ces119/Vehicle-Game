using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    // Variables
    private float timeShots;
    private float startTimeShots = 2.0f;
    private float speed = 10.0f;
    public GameObject barrel;
    // Start is called before the first frame update
    void Start()
    {        
        // To determine how many seconds throw the barrels
        timeShots = startTimeShots;
    }

    // Update is called once per frame
    void Update()
    {
        // Move the enemy forward
        transform.Translate(Vector3.forward * Time.deltaTime * speed);

         // To determine how many seconds throw the barrels
        if (timeShots <= 0)
        {
            Instantiate(barrel, transform.position, Quaternion.identity);
            timeShots = startTimeShots;
        }
        else
        {
            timeShots -= Time.deltaTime;   
        }


    }
}
