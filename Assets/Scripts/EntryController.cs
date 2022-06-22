using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EntryController : MonoBehaviour
{
    GameObject sphere;
    GameObject trashController;
    
    private void OnTriggerEnter(Collider other)
    {
         if (other.gameObject.CompareTag("Leave"))
         {
            //Finde die zum Portal gehörige Sphere, um die Ansicht umschalten zu können
             sphere = other.transform.parent.parent.GetChild(0).gameObject;
             sphere.layer = 10;
             Debug.Log("exit");

            //Deaktiviere das Spawnen und Verteilen vom Müll im richtigen Portal
             trashController = other.transform.parent.parent.GetChild(2).gameObject;
             trashController.SetActive(false);

            //Der Leave-Collider wird deaktiviert 
            BoxCollider leave = other.gameObject.GetComponent<BoxCollider>();
            leave.isTrigger = false;

            //Der Enter-Collider wird aktiviert
            BoxCollider enter = other.transform.parent.parent.GetChild(1).GetChild(3).GetComponent<BoxCollider>();
            enter.isTrigger = true;

            //Der Infobutton wird deaktiviert
            GameObject.Find("Canvas").transform.GetChild(3).gameObject.SetActive(false);
            //Info Panel wird ausgeblendet
            GameObject.Find("Canvas").transform.GetChild(2).gameObject.SetActive(false);



        }

         if (other.gameObject.CompareTag("Enter"))
         {
            //Finde die zum Portal gehörige Sphere, um die Ansicht umschalten zu können
             sphere = other.transform.parent.parent.GetChild(0).gameObject;
             sphere.layer = 0;

            //Aktiviere das Spawnen und Verteilen vom Müll im richtigen Portal
            trashController = other.transform.parent.parent.GetChild(2).gameObject;
            trashController.SetActive(true);

            //Der Enter-Collider wird deaktiviert 
            BoxCollider enter = other.gameObject.GetComponent<BoxCollider>();
            enter.isTrigger = false;

            //Der Leave-Collider wird aktiviert
            BoxCollider leave = other.transform.parent.parent.GetChild(1).GetChild(2).GetComponent<BoxCollider>();
            leave.isTrigger = true;

            switch (sphere.name)
            {
                case "Sphere1":
                    GameObject.Find("Canvas").GetComponent<UIAutomatic>().chooseText(1);
                    break;
                case "Sphere2":
                    GameObject.Find("Canvas").GetComponent<UIAutomatic>().chooseText(2);
                    break;
                case "Sphere3":
                    GameObject.Find("Canvas").GetComponent<UIAutomatic>().chooseText(3);
                    break;
                case "Sphere4":
                    GameObject.Find("Canvas").GetComponent<UIAutomatic>().chooseText(4);
                    break;
            }

            //Der Infobutton wird aktiviert
            GameObject.Find("Canvas").transform.GetChild(3).gameObject.SetActive(true);
        }


        

    }

    /*private void Update()
    {
        if ((transform.position.x >= portal1.x ||
            transform.position.x <= portal3.x ||
            transform.position.z >= portal2.z ||
            transform.position.z <= portal4.z) && !insidePortal)
        {
            sphere.layer = 0;
            Debug.Log("entry");

            trashController.SetActive(true);
            insidePortal = true;
        }

        if ((transform.position.x <= portal1.x ||
            transform.position.x >= portal3.x ||
            transform.position.z <= portal2.z ||
            transform.position.z >= portal4.z) && insidePortal)
        {
            sphere.layer = 10;
            Debug.Log("exit");

            trashController.SetActive(false);
            insidePortal = false;
        }

        if((transform.position.x >= portal1.x) && !insidePortal)
        {
            sphere = GameObject.Find("Sphere1");
            sphere.layer = 0;
            Debug.Log("entry");

            trashController.SetActive(true);
            insidePortal = true;
        }

        if ((transform.position.x >= portal1.x) && !insidePortal)
        {
            sphere = GameObject.Find("Sphere1");
            sphere.layer = 0;
            Debug.Log("entry");

            trashController.SetActive(true);
            insidePortal = true;
        }

    }*/
    //private void OnTriggerExit(Collider other)
    //{
    //    if (other.gameObject.CompareTag("MainCamera") && insidePortal)
    //    {
    //        sphere.layer = 10;
    //        insidePortal = false;
    //    }
    //}





}
