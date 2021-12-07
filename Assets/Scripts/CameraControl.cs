using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour {
    
    //Public Data
    public Camera mainCam;
    public int yRotationSpeed = 10;

    public Camera selectedRoomCam;

    //Private Data
    private Vector3 previousPosition;
    private float mousePosition;

    void Update()
    {
        //Right mouse look around depending on how far you are from the 0 of the screen
        mousePosition = (Mathf.Clamp(Input.mousePosition.x, 0, Screen.width) - (Screen.width * 0.5f)) / (Screen.width * 0.5f) * -1;

        if (Input.GetMouseButtonDown(1)) previousPosition = mainCam.ScreenToViewportPoint(Input.mousePosition);
        if (Input.GetMouseButton(1)) LookAround();

        //Select items

        //Zoom in and out with the camera using the scrolling wheel

        //Pick up and drop items.
    }

    void LookAround()
    {
        Vector3 direction = previousPosition - mainCam.ScreenToViewportPoint(Input.mousePosition);

        mainCam.transform.RotateAround(new Vector3(), new Vector3(0, 1, 0), mousePosition * yRotationSpeed * Time.deltaTime);

        previousPosition = mainCam.ScreenToWorldPoint(Input.mousePosition);
    }

    //Checks the mouse posistion on in the 3D world
    void SelectItem() 
    { 
    
    }

    void Zoom() 
    { 
    
    }

    void Pickup() 
    { 
    
    }
}
