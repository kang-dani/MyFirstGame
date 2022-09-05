using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    protected float rotSpeed;
    protected float xRot = 0.0f;
    protected float yRot = 0.0f;
    protected float xRotSize;
    protected float yRotSize;
 
    // Update is called once per frame
    void Update()
    {
        Rotate();

    }

    protected void Rotate()
    { 
        xRotSize = -Input.GetAxis("Mouse Y") + rotSpeed;
        xRot = Mathf.Clamp(xRot + xRotSize, -45, 80);
        yRotSize = Input.GetAxis("Mouse X") + rotSpeed;
		yRot = transform.eulerAngles.y + yRotSize;

        transform.eulerAngles = new Vector3(xRot, yRot, 0);
    }
}
