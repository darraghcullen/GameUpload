using System.Collections; 
using System.Collections.Generic;
using UnityEngine;

public class Spawner: MonoBehaviour {

    public GameObject theTarget;
    public int xPos;
    public int zPos;
    public int targetCount;

    void Start () {
        StartCoroutine(TargetDrop());
    }

    IEnumerator TargetDrop()
    {
        while (targetCount < 1)
        {
            xPos = Random.Range(78, 80);
            zPos = Random.Range(69, 71);
            Instantiate(theTarget, new Vector3(xPos, 4, zPos), Quaternion.identity);
            yield return new WaitForSeconds(0.05f);
            targetCount += 1;
        }
    }
}

