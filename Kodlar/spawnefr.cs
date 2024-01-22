using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnefr : MonoBehaviour
{
    public birdy birdScript;

    public GameObject borular;

    public float height;

    public float time;
    private void Start()
    {
        StartCoroutine(SpawnObject (time));
    }

   
    void Update()
    {
        
    }
    public IEnumerator SpawnObject (float time)
    {
        while (!birdScript.isDead)
        {


            Instantiate (borular, new Vector3 (3, Random.Range(-height, height), 0), Quaternion.identity);

            yield return new WaitForSeconds(1f);
        }
        
    }

}
