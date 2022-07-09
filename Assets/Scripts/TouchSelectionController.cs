using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;
using TMPro;

[RequireComponent(typeof(TrashManager))]
public class TouchSelectionController : MonoBehaviour
{

    [SerializeField] private Camera arCamera;
    [SerializeField] private ScoreHandler scoreHandler;
    TrashManager manager;


    void Awake()
    {
        manager = GetComponent<TrashManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);

            if (touch.phase == TouchPhase.Began)
            {
                //erstellt Ray von Kamera in Tipp Richtung
                Ray ray = arCamera.ScreenPointToRay(touch.position);
                RaycastHit hitObject;

                //Wenn der Ray Müll trifft, wird Score hochgezählt und das Objekt zerstört
                if (Physics.Raycast(ray, out hitObject))
                {
                    GameObject hitGameObject = hitObject.transform.gameObject;
                    if (hitGameObject.tag.Equals("Destructable"))
                    {
                        Destroy(hitGameObject);
                        manager.numberOfObjects--;
                        scoreHandler.ShowScore();
                    }
                }
            }

        }
    }
}
