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

    //Reguliert die Müll Anzahl
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

    //Zuständig für zufällige Auswahl des Müll 3D-Objekts
    public void randomizePrefab()
    {
        rand = Random.Range(0, prefabs.Length);

        currentPrefab = prefabs[rand];

    }
}
