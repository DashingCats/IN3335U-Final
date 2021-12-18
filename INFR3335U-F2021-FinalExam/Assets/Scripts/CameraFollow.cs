using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target;
    public Vector3 offset;
    public float smoothSpeed = 0.125f;

    public Joystick rotation;
    private float rotationY, rotationX;
    private void LateUpdate()
    {
        rotationY = rotation.Horizontal;
        //rotationY = Mathf.Clamp(rotationY, -180f, 180f);
        rotationX = rotation.Vertical;
       // rotationX = Mathf.Clamp(rotationX, -180f, 180f);

        transform.position = target.position + offset;
        transform.localRotation = Quaternion.Euler(rotationX*20, rotationY*20, 0f);
    }
}
