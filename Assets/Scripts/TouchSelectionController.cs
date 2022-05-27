using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;

public class TouchSelectionController : MonoBehaviour
{

    [SerializeField] private Camera arCamera;


    // Start is called before the first frame update
    void Start()
    {
        
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
                    }
                }
            }

        }
    }
}
