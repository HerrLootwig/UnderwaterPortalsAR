using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrashManager : MonoBehaviour
{

    public int numberOfObjects;

    void Awake()
    {
        numberOfObjects = 0;
    }


    public bool allowMoreObjects()
    {
        if(numberOfObjects < 10)
        {
            return true;
        }
        else
        {
            return false;
        }

    }
}
