using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5f;

    public Rigidbody2D rb;
    public Animator animator;

    Vector2 movement;

    public Joystick movementJoystick;

    public GameObject joystick;

    private void Start()
    {
        //if (Application.platform == RuntimePlatform.Android)
        //{
        //    joystick.SetActive(true);
        //}
        //else
        //{
        //    joystick.SetActive(false);
        //}
    }

    void Update()
    {
        //movement.x = Input.GetAxisRaw("Horizontal");
        //movement.y = Input.GetAxisRaw("Vertical");

        movement.x = movementJoystick.Direction.x;
        movement.y = movementJoystick.Direction.y;

        //animator.SetFloat("Horizontal", movement.x);
        //animator.SetFloat("Vertical", movement.y);
        //animator.SetFloat("Speed", movement.sqrMagnitude);
    }

    void FixedUpdate()
    {
        if (movementJoystick.Direction.y != 0)
        {
            //rb.linearVelocity = new Vector2(movementJoystick.Direction.x * moveSpeed, movementJoystick.Direction.y * moveSpeed);
            rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);
        }
        else
        {
            rb.linearVelocity = Vector2.zero;
        }
        
        
        //if (Application.platform == RuntimePlatform.Android)
        //{
        //}
        //else
        //{
        //    rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);
        //}
    }
}
