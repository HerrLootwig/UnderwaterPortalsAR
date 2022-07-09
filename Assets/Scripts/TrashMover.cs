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
    Vector3 newDestination, newRotation, moveVector;

    float timer = 0;
    float rotation = 0;

    void Start()
    {
        generateNewDestination();
    }

    // Update is called once per frame
    void Update()
    {
        //Bewegung mit Einberechunung der Delta Time damit Fps-Unabhängigkeit gegeben ist
        transform.Translate(moveVector * Time.deltaTime * moveSpeed, Space.World);

        //Rotation des Müllstücks
        transform.GetChild(0).rotation = Quaternion.Euler(newRotation * rotateSpeed);

        //Zeit rauf rechnen
        timer += Time.deltaTime;

        //Nach bestimmter Zeit zufälliger Richtungswechsel
        if (timer >= timeToChangeDirection)
        {
            generateNewDestination();
            timer = 0;
        }

        rotation += 0.05f;
        newRotation = new Vector3(transform.rotation.x + rotation, transform.position.y + rotation, transform.rotation.z + rotation);

    }
    
    //Neues Ziel für Müllstück berechnen
    void generateNewDestination()
    {
        Vector3 controllerPos = transform.parent.position;


        Vector3 myPosRelativeToController = transform.position - controllerPos;

        randX = Random.Range(minRange, maxRange);
        randY = Random.Range(minRange, maxRange);
        randZ = Random.Range(minRange, maxRange);

        newDestination = new Vector3(randX, randY, randZ);

        moveVector = newDestination - myPosRelativeToController;
    }

}
