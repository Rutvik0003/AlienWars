using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Timer : MonoBehaviour
{
    public TextMeshProUGUI time;
    
    public float timeelapsed;

    private void Start()
    {
       
    }
    // Update is called once per frame
    void Update()
    {
        timeelapsed += Time.deltaTime;
        int min = Mathf.FloorToInt(timeelapsed / 60);
        int sec = Mathf.FloorToInt(timeelapsed % 60);
        time.text = string.Format("{0:00},{1:00}", min,sec);
       
    }
}
