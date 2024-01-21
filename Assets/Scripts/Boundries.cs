using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Boundries : MonoBehaviour
{
    public float min;
    public float max;
    

    // Update is called once per frame
    void Update()
    {
        float newpos = Mathf.Clamp(transform.position.x, min, max);
        transform.position = new Vector2 (newpos,transform.position.y);    
    }
}
