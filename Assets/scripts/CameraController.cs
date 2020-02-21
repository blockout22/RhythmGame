using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    //float speed = 100f;
    [Range(0.01f, 10f)]
    public float sensitivity = 1.25f;
    float deltaX = 0f;
    float deltaY = 0f;

    Vector3 cameraAngle = new Vector3(0, 0, 0);
    Vector3 lastMousePos = new Vector3();

    bool mouseGrabbed = false;

    // Update is called once per frame
    void Update()
    {
        calcDelta();
        if (mouseGrabbed)
        {
            rotateCameraView();
        }

        if (Input.GetKeyDown("g"))
        {
            if (mouseGrabbed)
            {
                mouseGrabbed = false;
                Cursor.lockState = CursorLockMode.None;
            }
            else
            {
                mouseGrabbed = true;
                Cursor.lockState = CursorLockMode.Locked;
            }
        }
    }

    void rotateCameraView()
    {
        cameraAngle.y += Input.GetAxis("Mouse X") * sensitivity;
        cameraAngle.x -= Input.GetAxis("Mouse Y") * sensitivity;

        if (cameraAngle.x >= 90)
        {
            cameraAngle.x = 90;
        }
        else if (cameraAngle.x <= -90)
        {
            cameraAngle.x = -90;
        }
        transform.eulerAngles = cameraAngle;
    }

    void calcDelta()
    {
        deltaX = Input.mousePosition.x - lastMousePos.x;
        deltaY = Input.mousePosition.y - lastMousePos.y;
        lastMousePos = Input.mousePosition;
    }
}
