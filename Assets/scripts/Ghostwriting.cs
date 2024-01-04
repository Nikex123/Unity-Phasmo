using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ghostwriting : MonoBehaviour
{
    public emf emf;
    public GameObject BUCH;
    public ghosthandler gh;
    public GameObject Buchwritten;

    private float GhostBuchMin = 1f;
    private float GhostBuchMax = 35f;
    private float Timer = 0;

    private bool BuchWriting = false;

    private void Start()
    {
        Timer = Random.Range(GhostBuchMin, GhostBuchMax);
        BuchWriting = false;
        BUCH.SetActive(false);
    }

    private void Update()
    {
        if(BuchWriting == true)
        {
            Timer -= Time.deltaTime;
        }

        if(Timer < 0)
        {
            Instantiate(Buchwritten, new Vector3(BUCH.transform.position.x, BUCH.transform.position.y, BUCH.transform.position.z), Quaternion.identity);
            Destroy(gameObject);
        }

        if (emf.IstImRaum == true)
        {
            if (Input.GetKey("f"))
            {
                BUCH.SetActive(true);
                if (gh.Mylingactive)
                {
                    BuchWriting=true;
                }
            }
        }
    }
}
