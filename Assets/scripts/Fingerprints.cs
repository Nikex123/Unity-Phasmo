using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fingerprints : MonoBehaviour
{
    public MeshRenderer mr;

    public float fingerprintdurability = 15f;

    private float timer;

    public void FingerprintsAction()
    {
        mr.enabled = true;
        timer = fingerprintdurability;

    }

    private void Start()
    {
        mr.enabled = false;
        timer = 0;
    }

    public void Update()
    {
        timer -= Time.deltaTime;

        if (timer < 0)
        {
            mr.enabled = false;
        }
    }
}
