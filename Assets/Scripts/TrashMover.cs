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

    GameObject controller;
    

    float randX, randY, randZ;
    Vector3 newDestination, newRotation, moveVector;

    float timer = 0;
    float rotation = 0;

    void Awake()
    {
            controller = GameObject.Find("TrashController");
            generateNewDestination();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(moveVector * Time.deltaTime * moveSpeed, Space.World);
        
        Debug.Log(newDestination);
        Debug.Log(controller.name);

        transform.GetChild(0).rotation = Quaternion.Euler(newRotation * rotateSpeed);
        timer += Time.deltaTime;

        if(timer >= timeToChangeDirection)
        {
            generateNewDestination();
            timer = 0;
        }
        rotation += 0.05f;
        newRotation = new Vector3(transform.rotation.x + rotation, transform.position.y + rotation, transform.rotation.z + rotation);

    }

    void generateNewDestination()
    {
        Vector3 controllerPos = controller.transform.position;

        Vector3 myPosRelativeToController = transform.position - controllerPos;

        randX = Random.Range(minRange, maxRange);
        randY = Random.Range(minRange, maxRange);
        randZ = Random.Range(minRange, maxRange);

        newDestination = new Vector3(randX, randY, randZ);

        moveVector = newDestination - myPosRelativeToController;
    }
    
}
