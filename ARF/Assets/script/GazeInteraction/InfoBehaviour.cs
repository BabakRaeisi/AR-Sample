 
using UnityEngine;

public class InfoBehaviour : MonoBehaviour
{
    [SerializeField]
    Transform sectionInfo;

    Vector3 desiredScale=Vector3.zero;
    const float SPEED = 6f;

    Gaze gaze;

    private void Awake()
    {
        gaze = FindObjectOfType<Gaze>();
        gaze.infos.Add(this);
    }
    private void Update()
    {
        sectionInfo.localScale = Vector3.Lerp(sectionInfo.localScale, desiredScale, Time.deltaTime * SPEED);
    }


    public void OpenInfo() 
    {
        desiredScale = Vector3.one;

    }

    public void CloseInfo() 
    {
        desiredScale = Vector3.zero; 
    
    }
}
