using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawning : MonoBehaviour
{
    public GameObject[] enemies;
    public Vector2 spawnValues;
    public float spawningWaitTime;
    public float spawnMaxWait;
    public float spawnMinWait;
    public int startWait;
    int randSpawn;
    Vector2 spawnPos;
    public GameObject spawnPosObject;


    void Start()
    {
        spawnPos.x = spawnPosObject.transform.position.x;
        spawnPos.y = spawnPosObject.transform.position.y;
        StartCoroutine(Spawner());
    }

    // Update is called once per frame
    void Update()
    {
        spawningWaitTime = Random.Range(spawnMinWait, spawnMaxWait);
    }
    IEnumerator Spawner()
    {
        yield return new WaitForSeconds(startWait);
        while (true)
        {
            randSpawn = Random.Range(0, 2);
            Instantiate(enemies[0], spawnPos, gameObject.transform.rotation);
            yield return new WaitForSeconds(spawningWaitTime);
            
        }
    }
}
