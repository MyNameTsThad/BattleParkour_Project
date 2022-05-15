using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MissileLauncher : MonoBehaviour
{
    public float spawnRate = 3f;
    public GameObject MissileToSpawn;
    public float offset;
    public bool offsetMode;
    
    void Update()
    {
        //StartCoroutine(SpawnMissile(MissileToSpawn, spawnRate, offsetMode, offset));
        if (Input.GetKeyDown(KeyCode.K))
        {
            SpawnMissile(MissileToSpawn, spawnRate, offsetMode, offset);
        }
    }
    //public IEnumerator SpawnMissile(GameObject Missile, float RateInSeconds, bool offsetMode, float offset)
    //{
        //if (offsetMode == true) // X axis
        //{
            //Instantiate(Missile, transform.position + new Vector3(offset, transform.position.y, 0f), transform.rotation);
        //}else if (offsetMode == false){ // Y axis
            //Instantiate(Missile, transform.position + new Vector3(transform.position.x, offset, 0f), transform.rotation);
        //}

       //yield return new WaitForSeconds(RateInSeconds);
    //}

    public void SpawnMissile(GameObject Missile, float RateInSeconds, bool offsetMode, float offset)
    {
        if (offsetMode == true) // X axis
        {
        Instantiate(Missile, transform.position + new Vector3(offset, transform.position.y, 0f), transform.rotation);
        }else if (offsetMode == false){ // Y axis
        Instantiate(Missile, transform.position + new Vector3(transform.position.x, offset, 0f), transform.rotation);
        }
    }
}
