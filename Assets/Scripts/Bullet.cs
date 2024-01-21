using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    Vector3 Up = Vector3.up;
    public float Speed;
    public GameObject bullet;
    

    

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Up*Speed*Time.deltaTime);
        Destroy(bullet,10);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Alien")
        {
            Destroy(collision.gameObject);
            Debug.Log("Destroyed");
            Destroy(bullet);
            
            
            
        }
    }
}
