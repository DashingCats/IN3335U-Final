using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public Joystick joystick;
    public Rigidbody rb;
    public GameObject player;

    float horizontalInput = 0f;
    float verticalInput = 0f;

    void Update()
    {
        horizontalInput = joystick.Horizontal;
        verticalInput = joystick.Vertical;

        rb.velocity = new Vector3(horizontalInput * 5f, 0f, verticalInput *5f);
        player.transform.LookAt(player.transform.position + new Vector3(horizontalInput, 0f, verticalInput));
    }

}
