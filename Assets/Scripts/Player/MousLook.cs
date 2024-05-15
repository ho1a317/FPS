using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MousLook : MonoBehaviour
{
    public enum RorationAxes
    {
        XandY,
        X,
        Y
    }

    public RorationAxes axes = RorationAxes.XandY;
    public float rotationSpeedHor = 5.0f;
    public float rotationSpeedVer = 5.0f;

    public float maxVer = 45.0f;
    public float minVer = -45.0f;

    private float rotationX = 0;

    private Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();

        if(rb != null)
        {
            rb.freezeRotation = true;
        }
    }

    private void Update()
    {
        //Проверка оси движений
        if(axes == RorationAxes.XandY)
        {
            rotationX -= Input.GetAxis("Mouse Y") * rotationSpeedVer;
            rotationX = Mathf.Clamp(rotationX, minVer, maxVer);

            float delta = Input.GetAxis("Mouse X") * rotationSpeedHor;
            float rotationY = transform.localEulerAngles.y + delta;
            
            transform.localEulerAngles = new Vector3(rotationX, rotationY, 0);
        }
        else if(axes == RorationAxes.X)
        {
            transform.Rotate(0, Input.GetAxis("Mouse X") * rotationSpeedHor, 0);
        }
        else if( axes == RorationAxes.Y)
        {
            rotationX -= Input.GetAxis("Mouse Y") * rotationSpeedVer;
            rotationX = Mathf.Clamp(rotationX,minVer,maxVer);

            float rotationY = transform.localEulerAngles.y;

            transform.localEulerAngles = new Vector3(rotationX, rotationY, 0);

        }
    }


}
