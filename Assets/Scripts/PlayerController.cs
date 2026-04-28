using UnityEngine;
using UnityEngine.InputSystem;

[RequireComponent(typeof(Rigidbody))]
public class PlayerController : MonoBehaviour
{
    [SerializeField] float MovementDistance = 4f;
    private Rigidbody rb;
    private bool isGrounded = true;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    public void OnMove(InputValue input)
    {
        
        Vector2 delta = input.Get<Vector2>();
        if (Mathf.Abs(transform.position.x + delta.x * MovementDistance) <= 4) transform.position += new Vector3(delta.x, 0, 0) * MovementDistance;
    }

    public void OnJump()
    {
        if (isGrounded)
        {
            Debug.Log("Jumping");
            rb.AddForce(Vector3.up * 5f, ForceMode.Impulse);
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
