using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;
using TMPro;

[RequireComponent(typeof(TrashManager))]
public class TouchSelectionController : MonoBehaviour
{

    [SerializeField] private Camera arCamera;
    TrashManager manager;
    public int score = 0;
    [SerializeField] private TMP_Text text;

    void Awake()
    {
        manager = GetComponent<TrashManager>();
    }

    //erhöt score beim sammeln von müll um 1
    private void ShowScore(int score)
    {
        score += 1;
        text.text = score.ToString();

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
                        ShowScore(score);
                    }
                }
            }

        }
    }
}
