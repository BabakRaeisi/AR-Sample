using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;
public class Raycaster : MonoBehaviour
{
    public GameObject Cube;
    public GameObject ArCamera;

    public Transform Holder; 

    public void Shoot() 
    {
        RaycastHit hit;
        if (Physics.Raycast(ArCamera.transform.position, ArCamera.transform.forward, out hit)) 
        {
           
            if (hit.transform)
            {
              GameObject customCube =   Instantiate(Cube, hit.point + new Vector3(0, 0.1f, 0), Quaternion.identity,Holder);
                
            }
        }
    }
}
