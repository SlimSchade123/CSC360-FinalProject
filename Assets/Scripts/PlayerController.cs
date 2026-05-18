using UnityEngine;
using UnityEngine.InputSystem;

[RequireComponent(typeof(Rigidbody))]
public class PlayerController : MonoBehaviour
{
    [SerializeField] float MovementDistance = 11f;
    [SerializeField] float JumpForce = 5f;
    private Rigidbody rb;
    private bool isGrounded = true;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    public void OnMove(InputValue input)
    {
        float delta = input.Get<Vector2>().x;
        float newX = transform.position.x + (delta * MovementDistance);

        newX = Mathf.Clamp(newX, -MovementDistance, MovementDistance);
        transform.position = new Vector3(newX, transform.position.y, transform.position.z);
    }

    public void OnJump()
    {
        if (isGrounded)
        {
            rb.AddForce(Vector3.up * JumpForce, ForceMode.Impulse);
            isGrounded = false;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = true;
        }
    }
}
