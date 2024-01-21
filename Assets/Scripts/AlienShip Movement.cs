using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AlienShipMovement : MonoBehaviour
{
    Vector3 AShip = Vector3.down;
    public float Speed;

    // Update is called once per frame
    void Update()
    {
        transform.Translate(AShip*Speed *Time.deltaTime);
        Destroy(gameObject , 20);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Player" || collision.gameObject.tag == "End")
        {
            SceneManager.LoadScene(2);
        }

        
    }
}
