using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour {

    public GameObject[] Enemies;
    public Vector3 spawnValue;
    public float spawnWait;
    public float spawnMostWait;
    public float spawnLeasWait;
    public int startWait;
    public bool stop;

    int randomEnemy;

    void Start()
    {
        StartCoroutine(waitSpawner());
    }
    void update()
    {
        spawnWait = Random.Range(spawnLeasWait, spawnMostWait);

    }
    IEnumerator waitSpawner()
    {
        yield return new WaitForSeconds(startWait);

        while (!stop)
        {
            randomEnemy = Random.Range(0, 2);
            Vector3 spawnPosition = new Vector3(Random.Range(spawnValue.x, spawnValue.y), 1, Random.Range(spawnValue.z, spawnValue.z));
            Instantiate(Enemies[randomEnemy], spawnPosition + transform.TransformPoint(0, 0, 0), gameObject.transform.rotation);
            Enemies[randomEnemy].transform.tag = "Enemy";
            yield return new WaitForSeconds(spawnWait);
            Destroy(gameObject);
        }

    }
}
