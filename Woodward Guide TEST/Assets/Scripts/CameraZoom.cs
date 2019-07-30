using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraZoom : MonoBehaviour
{
    public float zoomSpeed = 20;

    public Camera camera;

    private void Update()
    {
        float scroll = Input.GetAxis("Mouse ScrollWheel");
        if(scroll != 0.0f)
            //camera.fieldOfView += scroll * zoomSpeed;
            transform.Translate(0, scroll * zoomSpeed, scroll * zoomSpeed, Space.World);
    }
}
