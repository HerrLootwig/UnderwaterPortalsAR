using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;

[RequireComponent(typeof(TrashManager))]
public class TouchSelectionController : MonoBehaviour
{

    [SerializeField] private Camera arCamera;
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

            if(touch.phase == TouchPhase.Began)
            {
                Ray ray = arCamera.ScreenPointToRay(touch.position);
                RaycastHit hitObject;
                if(Physics.Raycast(ray, out hitObject))
                {
                    GameObject hitGameObject = hitObject.transform.gameObject;
                    if(hitGameObject.tag.Equals("Destructable"))
                    {
                        Destroy(hitGameObject);
                        manager.numberOfObjects--;
                    }
                }
            }

        }
    }
}
