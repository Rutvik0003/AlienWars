using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShip : MonoBehaviour
{
    
    Vector3 Right = Vector3.right;
    Vector3 Left = Vector3.left;
    public float Speed;

    // Update is called once per frame
    public void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(Left * Speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(Right * Speed * Time.deltaTime);
        }
    }

   
}
