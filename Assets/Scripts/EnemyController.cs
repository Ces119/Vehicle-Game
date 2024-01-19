using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    private float speed = 10.0f;

    // Update is called once per frame
    void Update()
    {
        // Move the enemy forward
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
    }
}
