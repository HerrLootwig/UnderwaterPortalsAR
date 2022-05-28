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
        changeRotation();
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.Equals(newDestination))
        {
            generateNewDestination();
        }
        else
        {
            //transform.position = Vector3.MoveTowards(transform.position, newDestination, Time.deltaTime * moveSpeed);
            transform.Translate(newDestination * Time.deltaTime * moveSpeed);
        }

        //transform.rotation = Quaternion.RotateTowards(transform.rotation, Quaternion.Euler(newRotation), Time.deltaTime * rotateSpeed);

        Debug.Log(newDestination);

        transform.GetChild(0).rotation = Quaternion.Euler(newRotation);
        timer += Time.deltaTime;

        if(timer >= timeToChangeDirection)
        {
            generateNewDestination();
            changeRotation();
           
        }
        rotate();


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
        //newRotation = new Vector3(Random.Range(-359, 359), Random.Range(-359, 359), Random.Range(-359, 359));
        newRotation = new Vector3(transform.rotation.x, Random.Range(-359, 359), transform.rotation.z);

    }

    void rotate()
    {
        rotation += 0.05f;
        newRotation = new Vector3(transform.rotation.x + rotation, transform.position.y + rotation, transform.rotation.z + rotation);
    }
}
