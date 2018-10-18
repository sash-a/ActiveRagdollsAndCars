using Unity.Mathematics;
using UnityEngine;
using static Unity.Mathematics.math;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody rb;

    public float speed;
    public float lookSens;

    public float camRotLimitX = 90f;
    private float camRotationX;
    private float currentCamRotX = 0f;

    [SerializeField] private Camera cam;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        rotate();
        move();
    }

    void move()
    {
        var x = Input.GetAxis("Horizontal");
        var y = Input.GetAxis("Vertical");
        var velocity = (x * transform.right + y * transform.forward).normalized * speed;

        rb.MovePosition(rb.position + velocity * Time.fixedDeltaTime);
    }

    void rotate()
    {
        var y = new float3(0, Input.GetAxis("Mouse X"), 0) * lookSens * Time.fixedDeltaTime;
        float x = Input.GetAxis("Mouse Y") * lookSens * Time.fixedDeltaTime;

        // Rotating player around y
        rb.MoveRotation(rb.rotation * Quaternion.Euler(y));
        // Rotating cam around the x axis
        currentCamRotX -= x;
        currentCamRotX = Mathf.Clamp(currentCamRotX, -camRotLimitX + 15, camRotLimitX - 30);
        cam.transform.localEulerAngles = new float3(currentCamRotX, 0, 0);
    }
}