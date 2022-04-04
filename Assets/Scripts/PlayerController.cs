using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float f_HorizontalInput;
    private float f_VerticalInput;

    private float f_ProjectileSpeed = .5f;
    private float f_RotationSpeed = 90f;  
    private float f_VerticalMoveSpeed = 2f;

    public GameObject o_Bullet;
    public GameObject o_Earth;

    private void Update()
    {
        Movement();
        Fire();
    }

    private void Movement()
    {
        // get player's keyboard/controller inputs
        f_HorizontalInput = Input.GetAxis("Horizontal");
        f_VerticalInput = Input.GetAxis("Vertical");

        // handle player's horizontal movement and rotation around Earth (this movement is limited by collidable gameobjects hidden in the scene)
        transform.RotateAround(o_Earth.transform.position, new Vector3(0, 0, f_HorizontalInput), f_RotationSpeed * Time.deltaTime);

        // handle player's vertical movement
        transform.Translate(Vector2.up * f_VerticalInput * f_VerticalMoveSpeed * Time.deltaTime);
    }

    private void Fire()
    {
        // get player's keyboard/controller inputs
        if (Input.GetButtonDown("Fire1") || Input.GetKeyDown(KeyCode.Space))
        {
            // create bullet and store a reference to it for later work...
            Rigidbody2D projectileRigidBody = Instantiate(o_Bullet, transform.position, transform.rotation).GetComponent<Rigidbody2D>();

            // add force to the rigidbody reference...propelling it in the direction of Earth
            projectileRigidBody.AddForce(-transform.position * f_ProjectileSpeed, ForceMode2D.Impulse);
        }
    }
}
