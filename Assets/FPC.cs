using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FPC : MonoBehaviour
{
    private Rigidbody rb;

    #region Camera Movement Variables
    public Camera playerCamera;
    public float mouseSensitivity = 3f;
    public float maxLookAngle = 90f;
    //Internal Variables
    private float yaw = 0.0f;
    private float pitch = 0.0f;
    #endregion

    #region Movement
    public float moveSpeed = 10f;
    public float maxVelocityChange = 7f;
    public float jumpPower = 17f;
    private bool isGrounded;
    #endregion

    #region Gravity
    public float gravityMultiplier = 10f;
    #endregion

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        #region Camera
        // Camera movement
        yaw = transform.localEulerAngles.y + Input.GetAxis("Mouse X") * mouseSensitivity;
        pitch = pitch - Input.GetAxis("Mouse Y") * mouseSensitivity;
        pitch = Mathf.Clamp(pitch, -maxLookAngle, maxLookAngle);
        transform.localEulerAngles = new Vector3(0, yaw, 0);
        playerCamera.transform.localEulerAngles = new Vector3(pitch, 0, 0);

        // Player movement
        float h = Input.GetAxisRaw("Horizontal");
        float v = Input.GetAxisRaw("Vertical");
        Vector3 movement = new Vector3(h, 0, v).normalized * moveSpeed * Time.deltaTime;
        movement = transform.TransformDirection(movement);
        rb.MovePosition(rb.position + movement);
        #endregion
        #region Jump
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            Jump();
        }
        #endregion

        CheckGround();
    }

    void CheckGround()
    {
        Vector3 origin = new Vector3(transform.position.x, transform.position.y - (transform.localScale.y* .5f), transform.position.z);
        Vector3 direction = transform.TransformDirection(Vector3.down);
        float distance = .75f;

        if(Physics.Raycast(origin, direction, distance))
        {
            isGrounded = true;
        }else
        {
            isGrounded = false;
        }
    }

    void FixedUpdate()
    {
        // Player movement using physics
        Vector3 targetVelocity = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical")) * moveSpeed;
        Vector3 velocityChange = targetVelocity - rb.velocity;
        velocityChange.x = Mathf.Clamp(velocityChange.x, -maxVelocityChange, maxVelocityChange);
        velocityChange.z = Mathf.Clamp(velocityChange.z, -maxVelocityChange, maxVelocityChange);
        velocityChange.y = 0;
        rb.AddForce(velocityChange, ForceMode.VelocityChange);

        // Calculate gravity force
        Vector3 gravity = new Vector3(0, -9.81f, 0);
        float gravityMultiplier = 5f;
        gravity *= gravityMultiplier;
        rb.AddForce(gravity, ForceMode.Acceleration);

        if (rb.velocity.y < 0)
        {
            rb.AddForce(gravity / 10f, ForceMode.Acceleration);
        }
    }
    void Jump()
    {
        rb.AddForce(new Vector3(0, jumpPower, 0), ForceMode.Impulse);
    }
}
