using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation; 

public class MyRaycast : MonoBehaviour
{
    public ARRaycastManager manager;
    public GameObject []objects;
    public Camera cam;
    public GameObject instance;
    private List<ARRaycastHit> hits = new List<ARRaycastHit>(); 
    // Update is called once per frame
    void Update()
    {
        if (manager == null)
            return;
        if (cam == null)
            return; 
        if(Input.GetMouseButtonDown(0))
        {
            Ray ray = cam.ScreenPointToRay(Input.mousePosition);
           
            if (manager.Raycast(ray, hits))
            {
                Pose pp = hits[0].pose;
                if (instance==null)
                {
                    instance = Instantiate<GameObject>(objects[0], pp.position, pp.rotation);
                }
                else
                {
                    instance.transform.SetPositionAndRotation(pp.position, pp.rotation); 
                }
            
            
            }

        }
    }

    public void blue_box() 
    {

        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = cam.ScreenPointToRay(Input.mousePosition);
             
            if (manager.Raycast(ray, hits))
            {
                        
            }

        }


    }
}
