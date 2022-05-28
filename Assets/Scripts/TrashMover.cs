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

    void Awake()
    {
        generateNewDestination();
        changeRotation();
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, newDestination, Time.deltaTime * moveSpeed);

        transform.rotation = Quaternion.RotateTowards(transform.rotation, Quaternion.Euler(newRotation), Time.deltaTime * rotateSpeed);

        timer += Time.deltaTime;

        if(timer >= timeToChangeDirection)
        {
            generateNewDestination();
            changeRotation();
        }

        
    }

    void generateNewDestination()
    {
        randX = Random.Range(minRange, maxRange);
        randY = Random.Range(minRange, maxRange);
        randZ = Random.Range(minRange, maxRange);

        newDestination = new Vector3(randX, randY, randZ);
    }

    void changeRotation()
    {
        newRotation = new Vector3(Random.Range(-359, 359), Random.Range(-359, 359), Random.Range(-359, 359));
    }
}
