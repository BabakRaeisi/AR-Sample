using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class raycasterEditor : MonoBehaviour
{
    public GameObject Cube;
    public Camera cam;
    public Transform holder; 

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        { Shoot(); }
    }
    public void Shoot()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;


        if (Physics.Raycast(ray, out hit))
        {
            if (hit.transform)
            {
                Instantiate(Cube, hit.point + new Vector3(0,1f,0), Quaternion.identity, holder);
            }
        }
    }
}
