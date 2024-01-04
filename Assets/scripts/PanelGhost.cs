
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelGhost : MonoBehaviour
{

    public GameObject panel;

    private bool turnedOn = true;

    // Start is called before the first frame update
    void Start()
    {
        panel.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("j"))
        {
            if (turnedOn == false)
            {
                panel.gameObject.SetActive(true);
                turnedOn = true;
            }

            if(turnedOn == true)
            {
                panel.gameObject.SetActive(false);
                turnedOn= false;
            }
        }
    }
}
