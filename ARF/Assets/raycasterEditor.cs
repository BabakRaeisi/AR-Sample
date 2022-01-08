using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class raycasterEditor : MonoBehaviour
{
    public GameObject Cube;
    public Camera cam;
    public Transform holder;


    public Text name_text, price_text;




    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("0");
            
            Shoot(); }
    }
    public void Shoot()
    {
        Ray ray = cam.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;


        if (Physics.Raycast(ray, out hit))
        {
            Debug.Log("1");
            Debug.Log(hit.transform.tag);
            if (hit.collider.transform != null)
            {
                
                Information info = hit.transform.GetChild(0).GetComponent<Information>();
                price_text.text = info.price;
                name_text.text = info.productName;
            }
        }
    }
}
