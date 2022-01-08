using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Information : MonoBehaviour
{
    Camera Camera;
    public  string productName = "cute blue box";

   public string price = "it's priceless";

    public Text text; 
    private void Update()
    {
        Vector3 namepos = Camera.main.WorldToScreenPoint(this.transform.position);

        text.transform.position = namepos;
    }


}
