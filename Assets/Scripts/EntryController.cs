using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EntryController : MonoBehaviour
{
    [SerializeField] GameObject sphere;
    private bool insidePortal = false;
    private void OnTriggerEnter(Collider other)
    {
        
        if (other.gameObject.CompareTag("MainCamera") && insidePortal)
        {
            sphere.layer = 10;
            Debug.Log("exit");

        }

        if (other.gameObject.CompareTag("MainCamera") && !insidePortal)
        {
            sphere.layer = 0;
            Debug.Log("entry");
        }

        if (other.gameObject.CompareTag("MainCamera"))
        {
            insidePortal = !insidePortal;
        }


    }
    //private void OnTriggerExit(Collider other)
    //{
    //    if (other.gameObject.CompareTag("MainCamera") && insidePortal)
    //    {
    //        sphere.layer = 10;
    //        insidePortal = false;
    //    }
    //}





}
