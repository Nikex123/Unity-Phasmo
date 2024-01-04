using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ghostroomdetect : MonoBehaviour
{
    public Material red;
    public Material green;
    public MeshRenderer mr;

    private void Start()
    {
        mr.material = red;
    }

    void OnTriggerEnter(Collider collider)
    {
        if(collider.gameObject.tag == "ghostroom")
        {
            mr.material = green;
        }
        
    }
    private void OnTriggerExit(Collider collider)
    {
        if(collider.gameObject.tag == "ghostroom")
        {
            mr.material = red;
        }
    }
}
