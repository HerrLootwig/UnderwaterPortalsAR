using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrashManager : MonoBehaviour
{
    [SerializeField] public GameObject prefab;
    [SerializeField] int maxNumberObjects;

    public int numberOfObjects;

    void Awake()
    {
        numberOfObjects = 0;
    }


    public bool allowMoreObjects()
    {
        if(numberOfObjects < maxNumberObjects)
        {
            return true;
        }
        else
        {
            return false;
        }

    }
}
