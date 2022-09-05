using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : CameraController
{

    public float speed;
    public float runSpeed;
    private float applyRunSpeed;

    // Update is called once per frame
    void Update()
    {
        PlayerMoving();
    }

    private void PlayerMoving()
    {

        float vertical = Input.GetAxis("Vertical");
        float horizontal = Input.GetAxis("Horizontal");

        if (vertical != 0 || horizontal != 0)
		{
            transform.Translate(transform.forward * vertical * Time.deltaTime * (speed + applyRunSpeed));
            transform.Translate(transform.right * horizontal * Time.deltaTime * (speed + applyRunSpeed));

            if (Input.GetKey(KeyCode.LeftShift))
            {
                applyRunSpeed = runSpeed;
            }
            else applyRunSpeed = 0;
        }

        yRotSize = Input.GetAxis("Mouse X") + rotSpeed;
        yRot = transform.eulerAngles.y + yRotSize;

        transform.eulerAngles = new Vector3(0, yRot, 0);

    }
}

