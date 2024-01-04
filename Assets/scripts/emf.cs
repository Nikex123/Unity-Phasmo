using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class emf : MonoBehaviour
{
    public Material red;
    public Material green;
    public MeshRenderer mr;
    public ghosthandler gh;
    private bool IstImRaum = false;

    private void Start()
    {
        mr.material = red;
        IstImRaum = false; 
    }

    private void Update()
    {
        if(IstImRaum == true)
        {
            if(gh.ghosteventactive == true)
            {
                mr.material = green;
            }
            if(gh.ghosteventactive == false) 
            {
                mr.material = red;
            }
        }
        if(IstImRaum == false)
        {
            mr.material = red;
        }
    }

    void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.tag == "ghostroom")
        {
            IstImRaum = true;
        }
    }
    private void OnTriggerExit(Collider collider)
    {
        if (collider.gameObject.tag == "ghostroom")
        {
            IstImRaum = false;
        }
    }
}
