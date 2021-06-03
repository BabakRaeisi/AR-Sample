using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 

public class Plateraycast : MonoBehaviour
{
    public GameObject plate;
    public GameObject ArCamera;
    public Button button;
    public Transform Holder; 
    private void Start()
    {
        button = gameObject.GetComponent<Button>();
    
    }
    public void Shoot()
    {
        RaycastHit hit;
        if (Physics.Raycast(ArCamera.transform.position, ArCamera.transform.forward, out hit))
        {
            if (hit.transform)
            {
                
                Instantiate(plate, hit.point + new Vector3(0, 0.1f, 0), Quaternion.identity , Holder);
                
            }
        }

       

    }
    public void activate() 
    {
        if (button.interactable == true)
        {
            button.interactable = false;
        }
        else { button.interactable = true; }
    }
}
