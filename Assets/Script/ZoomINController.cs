using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class ZoomINController : MonoBehaviour
{
    public Collider bola;
    public CameraController cameraController;
    public float length;

    private void OnTriggerEnter(Collider other) 
    {
        if (other == bola)
        {
            cameraController.FollowTarget(bola.transform, length);
        }
    }
}
