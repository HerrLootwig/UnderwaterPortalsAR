using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrashMover : MonoBehaviour
{
    [SerializeField] float moveSpeed;
    [SerializeField] float maxRange;
    [SerializeField] float minRange;
    [SerializeField] int timeToChangeDirection;
    [SerializeField] float rotateSpeed;

    float randX, randY, randZ;
    Vector3 newDestination, newRotation;

    float timer = 0;
    float rotation = 0;

    void Awake()
    {
        generateNewDestination();
    }

    // Update is called once per frame
    void Update()
    {
         transform.Translate(newDestination * Time.deltaTime * moveSpeed, Space.World);
        
        Debug.Log(newDestination);

        transform.rotation = Quaternion.Euler(newRotation * rotateSpeed);
        timer += Time.deltaTime;

        if(timer >= timeToChangeDirection)
        {
            generateNewDestination();
            timer = 0;
        }
        //rotate();
        rotation += 0.05f;
        newRotation = new Vector3(transform.rotation.x + rotation, transform.position.y + rotation, transform.rotation.z + rotation);

    }

    void generateNewDestination()
    {
        randX = Random.Range(minRange, maxRange);
        randY = Random.Range(minRange, maxRange);
        randZ = Random.Range(minRange, maxRange);

        newDestination = new Vector3(randX, randY, randZ);
    }
    void rotate()
    {
        rotation += 0.05f;
        newRotation = new Vector3(transform.rotation.x + rotation, transform.position.y + rotation, transform.rotation.z + rotation);
    }
}
