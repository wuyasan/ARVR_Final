using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;

public class RaycastPlacer : MonoBehaviour
{
    public ARRaycastManager raycastManager;
    public GameObject objectToPlace;
    public GameObject tree1;
    public GameObject tree2;
    public GameObject tree3;
    public Camera arCamera;
    public bool placed = false;

    private List<ARRaycastHit> hits = new List<ARRaycastHit>();
    // Update is called once per frame
    void Update()
    {
        if (ButtonHandler.b1 == 1)
        {
            objectToPlace = tree1;
            ButtonHandler.b1 = 0;
        }
        if (ButtonHandler.b2 == 1)
        {
            objectToPlace = tree2;
            ButtonHandler.b2 = 0;
        }
        if (ButtonHandler.b3 == 1)
        {
            objectToPlace = tree3;
            ButtonHandler.b3 = 0;
        }
        if(BackHandler.pressed == 1)
        {
            Destroy(objectToPlace);
            objectToPlace = null;
            BackHandler.pressed = 0;
            placed = false;
        }

        if (!placed)
        {
            showMaker();
        }
    }

    public void showMaker()
    {
        Ray ray = arCamera.ScreenPointToRay(Input.mousePosition);

        if (Input.touchCount > 0)
        {
            if (Input.GetTouch(0).phase == TouchPhase.Began)
            {
                if (raycastManager.Raycast(ray, hits, TrackableType.Planes))
                {
                    Pose hitPose = hits[0].pose;
                    Instantiate(objectToPlace, hitPose.position, hitPose.rotation);
                    placed = true;
                }
            }
        }
    }
}
