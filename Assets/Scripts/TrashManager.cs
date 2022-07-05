using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrashManager : MonoBehaviour
{
    [SerializeField] public GameObject[] prefabs;
    [SerializeField] int maxNumberObjects;

    public int numberOfObjects, rand;
    public GameObject currentPrefab;

    void Awake()
    {
        numberOfObjects = 0;
        randomizePrefab();
    }

    //Reguliert die M�ll Anzahl
    public bool allowMoreObjects()
    {
        if (numberOfObjects < maxNumberObjects)
        {
            return true;
        }
        else
        {
            return false;
        }

    }

    //Zust�ndig f�r zuf�llige Auswahl des M�ll 3D-Objekts
    public void randomizePrefab()
    {
        rand = Random.Range(0, prefabs.Length);

        currentPrefab = prefabs[rand];

    }
}
