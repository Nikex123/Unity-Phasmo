using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraHolder : MonoBehaviour
{
    public Transform cameraposition;

 
    void Update()
    {
        transform.position = cameraposition.position;
    }
}
