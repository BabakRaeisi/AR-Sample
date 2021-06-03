using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;

public class PlacementIndicator : MonoBehaviour
{
    private ARRaycastManager manager;
    public GameObject indicator;
    public GameObject Plate;
    public GameObject ArCamera; 
 
    private void OnEnable()
    {
        manager = FindObjectOfType<ARRaycastManager>();
        indicator = transform.GetChild(0).gameObject;
        indicator.SetActive(false);
    }
    private void Update()
    {
        List<ARRaycastHit> hits = new List<ARRaycastHit>();
        manager.Raycast(new Vector2(Screen.width / 2, Screen.height / 2), hits, TrackableType.Planes);
            // if raycast hits the surface enable indicator on top of the plane ; 
            if (hits.Count > 0)
            {
            transform.position = hits[0].pose.position;
            transform.rotation = hits[0].pose.rotation;

            if (!indicator.activeInHierarchy)
            {
                indicator.SetActive(true);
                if (!Plate.activeInHierarchy)
                {
                    Plate.SetActive(true); 
                }
            }


            Plate.transform.position = indicator.transform.position;
            Plate.transform.rotation = indicator.transform.rotation; 
         
        }
    }
}
