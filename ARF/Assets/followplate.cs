using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class followplate : MonoBehaviour
{
    public GameObject plate;
    Vector3 pos;

    // Update is called once per frame


    private void OnEnable()
    {
        pos = new Vector3(0,0.1f,0); 
    }
    void Update()
    {
        gameObject.transform.position = plate.transform.position + pos; 
        
    }
}
