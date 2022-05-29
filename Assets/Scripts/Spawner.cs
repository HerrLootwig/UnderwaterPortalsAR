using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] GameObject prefab;

    [SerializeField] float maxRange;
    [SerializeField] float minRange;
    [SerializeField] int spawnTime;

    float randX, randY, randZ;
    Vector3 newPos;

    float timer = 0;

    int numberOfObjects;

    private void Awake()
    {
        createObject();
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime; 

        if(timer >= spawnTime)
        {
            createObject();
        }

    }

    Vector3 generateNewPos()
    {
        randX = Random.Range(minRange, maxRange);
        randY = Random.Range(minRange, maxRange);
        randZ = Random.Range(minRange, maxRange);

        newPos = new Vector3(randX, randY, randZ);

        return newPos;
    }

    void createObject()
    {
        Vector3 spawnPos = generateNewPos();

        Instantiate(prefab, spawnPos, Quaternion.identity);

        timer = 0;
    }
}
