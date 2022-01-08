using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GetCam : MonoBehaviour
{

    Canvas canvas;
  
 
    private void Awake()
    {
        canvas = GetComponent<Canvas>();
        if (canvas!=null)
        {
            canvas.worldCamera = Camera.main;
        }


       
    }

   
}
