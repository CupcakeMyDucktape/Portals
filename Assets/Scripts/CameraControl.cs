using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour {
    public Camera cam;

    private Vector3 previousPosition;

    public int yRotationSpeed = 10;

    private float mousePosition;

    void Update()
    {
        //Right mouse look around the plane
        mousePosition = (Mathf.Clamp(Input.mousePosition.x, 0, Screen.width) - (Screen.width * 0.5f)) / (Screen.width * 0.5f) * -1;

        if (Input.GetMouseButtonDown(1)) previousPosition = cam.ScreenToViewportPoint(Input.mousePosition);

        if (Input.GetMouseButton(1)) LookAround();

        //Zoom in and out with the camera using the scrolling wheel

        //Pick up and drop items.
    }

    void LookAround()
    {
        Vector3 direction = previousPosition - cam.ScreenToViewportPoint(Input.mousePosition);

        cam.transform.RotateAround(new Vector3(), new Vector3(0, 1, 0), mousePosition * yRotationSpeed * Time.deltaTime);

        previousPosition = cam.ScreenToWorldPoint(Input.mousePosition);

    }
}
