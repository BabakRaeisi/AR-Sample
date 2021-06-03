using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation; 

public class ControlPlanes : MonoBehaviour
{
    public ARPlaneManager manager;
    public followplate flw; 
   
    public void OnValueChanged(bool isOn)
    {
        VisualizePlanes(isOn);
      
    }

    private void VisualizePlanes(bool active)
    {
        manager.enabled = active;
        flw.enabled = active; 
        foreach (ARPlane plane in manager.trackables)
        {
            plane.gameObject.SetActive(active);
        }
    }
}
