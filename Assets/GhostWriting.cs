using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class GhostWriting : MonoBehaviour
{
    public emf emf;

    private void Update()
    {
        if(emf.IstImRaum == true)
        {
            if (Input.GetKey("F"))
            {

            }
        }
    }
}
