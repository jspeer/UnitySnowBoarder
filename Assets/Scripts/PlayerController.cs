using System.Runtime.InteropServices;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class PlayerController : MonoBehaviour
{
    [Header("Player Movement Parameters")]
    [SerializeField] float torqueAmount = 1f;
    [SerializeField] float boostSpeed = 30f;
    [SerializeField] float baseSpeed = 20f;
    private Rigidbody2D rigidBody;
    private SurfaceEffector2D surfaceEffector;

    void Start()
    {
        // Get the rigid body so we can manipulate the rotation and add torque
        rigidBody = GetComponent<Rigidbody2D>();
        // Get the surface effector
        surfaceEffector = FindObjectOfType<SurfaceEffector2D>();
    }

    void Update()
    {
        RotatePlayer();
        RespondToBoost();
    }

    private void RespondToBoost()
    {
        if (Input.GetKey(KeyCode.UpArrow)) {                    // Up Arrow
            surfaceEffector.speed = boostSpeed;                 // Boost Speed
        } else {                                                // Otherwise
            surfaceEffector.speed = baseSpeed;                  // Normal Speed
        }
    }

    private void RotatePlayer()
    {
        if (Input.GetKey(KeyCode.LeftArrow)) {                  // Left Arrow
            rigidBody.AddTorque(torqueAmount * Time.deltaTime); // + Torque
        } else if (Input.GetKey(KeyCode.RightArrow)) {          // Right Arrow
            rigidBody.AddTorque(-torqueAmount * Time.deltaTime);// - Torque
        }
    }
}
