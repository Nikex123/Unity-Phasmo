using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fingerprints : MonoBehaviour
{
    public GameObject fingerprint1;

    public float fingerprintdurability = 15f;

    private float timer;

    public void FingerprintsAction()
    {
        fingerprint1.SetActive(true);
        timer = fingerprintdurability;

    }

    private void Start()
    {
        fingerprint1.SetActive(false);
        timer = 0;
    }

    public void Update()
    {
        timer -= Time.deltaTime;

        if (timer < 0)
        {
            fingerprint1.SetActive(false);
        }
    }
}
