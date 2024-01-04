using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class ghosthandler : MonoBehaviour
{
    public bool ghosteventactive = false;

    public int Ghosts = 4;

    public GameObject Oni;
    public GameObject Shade;
    public GameObject Obake;
    public GameObject Myling;

    public Fingerprints fp;

    public bool Shadeactive = false;
    public bool Oniactive = false;
    public bool Obakeactive = false;
    public bool Mylingactive = false;


    public int activeghost = 0;

    private void Start()
    {
        activeghost = Random.Range(0, Ghosts);

        

        Oni.SetActive(false);
        Shade.SetActive(false);
        Obake.SetActive(false);
        Myling.SetActive(false);

        fp.enabled = false;
    }

    private void Update()
    {
            if (activeghost == 0)
        {
            Oni.SetActive(true);
            Oniactive = true;
            fp.enabled = false;
        }
            if(activeghost == 1)
        {
            Shade.SetActive(true);
            Shadeactive = true;
            fp.enabled = false;
        }
            if(activeghost == 2)
        {
            Obake.SetActive(true);
            Obakeactive = true;
            fp.enabled = true;
        }

        if(activeghost == 3)
        {
            Myling.SetActive(true);
            Mylingactive = true;
            fp.enabled = true;
        }

       

    }
}
