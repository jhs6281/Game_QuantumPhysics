using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class generator : MonoBehaviour
{
    public GameObject bulletPrefab;
    public float spawnRateMin = 0.5f;
    public float spawnRatemax = 3f;

    Transform target;
    float spawnRate;
    float AfterSpawnTime;
    public bool shootBullet = true;

    // Start is called before the first frame update
    void Start()
    {
        AfterSpawnTime = 0f;
        spawnRate = Random.Range(spawnRateMin, spawnRatemax);
        target = FindObjectOfType<PlayerComtroller>().transform;    
    }

    // Update is called once per frame
    void Update()
    {
        if (shootBullet)
        {
            AfterSpawnTime += Time.deltaTime;

            if (AfterSpawnTime >= spawnRate)
            {
                AfterSpawnTime = 0f;

                GameObject bullet = Instantiate(bulletPrefab, transform.position, transform.rotation);
                bullet.transform.LookAt(target);
                spawnRate = Random.Range(spawnRateMin, spawnRatemax);   
            }
        }

    }

}

