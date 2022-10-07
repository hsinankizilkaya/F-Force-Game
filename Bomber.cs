using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bomber : MonoBehaviour
{
    public float time;
    public GameObject SpawnThis;
    public GameObject SpawnThis2;
    public GameObject SpawnThis3;

    void Start()
    {
        StartCoroutine(SpawnObject(time));    
    }
    

    public IEnumerator SpawnObject(float time)
    {
        while(true)
        {
        Instantiate(SpawnThis, new Vector3(Random.Range(10,590),Random.Range(130,150),Random.Range(10,590)), Quaternion.identity);
        yield return new WaitForSeconds(time);

        Instantiate(SpawnThis2, new Vector3(Random.Range(10,590),Random.Range(130,150),Random.Range(10,590)), Quaternion.identity);
        yield return new WaitForSeconds(time);

        Instantiate(SpawnThis3, new Vector3(Random.Range(10,590),Random.Range(130,150),Random.Range(10,590)), Quaternion.identity);
        yield return new WaitForSeconds(time);
        }     
    }

}
