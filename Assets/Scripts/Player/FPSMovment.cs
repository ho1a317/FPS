using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FPSMovment : MonoBehaviour
{
    public float spid = 5f;
    public float graviti = - 9.8f;

    private CharacterController characterController;

    private void Start()
    {
        characterController = GetComponent<CharacterController>();
        if(characterController != null )
        {
            Debug.Log("NULL");
        }
    }

    private void Update()
    {
        float deltaX = Input.GetAxis("Horizontal") * spid;
        float deltaZ = Input.GetAxis("Vertical") * spid;
        Vector3 movement = new Vector3(deltaX, 0, deltaZ);
        movement = Vector3.ClampMagnitude(movement, spid);
        movement.y = graviti;

        movement *= Time.deltaTime;
        movement = transform.TransformDirection(movement);
        characterController.Move(movement);
    }
}
