using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using UnityEngine;

public class BulletSpawner : MonoBehaviour
{
    public GameObject bullet;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Space))
        {
            Instantiate(bullet, transform.position, Quaternion.identity);
        }
            
    }

    
}
