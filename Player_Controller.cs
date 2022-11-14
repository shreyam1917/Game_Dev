using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Controller : MonoBehaviour
{
    CharacterController capsule_controller;
    public float movement_speed;
    public float gravity = 9.8f;
    float yMovement;
    // Start is called before the first frame update
    void Start()
    {
        capsule_controller = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal")*movement_speed;
        float vertical = Input.GetAxis("Vertical") * movement_speed;

        capsule_controller.Move(transform.forward * vertical + transform.right * horizontal);

        if(capsule_controller.isGrounded)
        {
            yMovement = 0;
        }
        else
        {
            yMovement -= gravity;
            capsule_controller.Move(new Vector3(0, yMovement, 0));
        }
    }
}
