using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;

using UnityEngine;

public class AlienShipspawner : MonoBehaviour
{
    public GameObject AlienShip;

    Vector3 position;

    private void OnEnable()
    {
        StartCoroutine(Spawn());
    }

    



    private IEnumerator Spawn()
    {
        while(enabled)
        {

            position = new Vector3(Random.Range(-7.8f, 7.8f), 4.3f, -1);

            yield return new WaitForSeconds(Random.Range(1, 5));
            Instantiate(AlienShip, position, Quaternion.identity);
            


        }

        
    }
}
