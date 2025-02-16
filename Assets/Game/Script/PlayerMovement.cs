using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5f;

    public Rigidbody2D rb;
    public Animator animator;

    Vector2 movement;

    public Joystick movementJoystick;

    public GameObject joystick;

    public bool isControlEnabled = true;

    private void Start()
    {

    }

    void Update()
    {
        //movement.x = Input.GetAxisRaw("Horizontal");
        //movement.y = Input.GetAxisRaw("Vertical");

        movement.x = movementJoystick.Direction.x;
        movement.y = movementJoystick.Direction.y;

        animator.SetFloat("Horizontal", movement.x);
        animator.SetFloat("Vertical", movement.y);
        animator.SetFloat("Speed", movement.sqrMagnitude);

        //var pour garder la direction après avoir marché
        if (movement.x > 0.01 || movement.x < -0.01
            || movement.y > 0.01 || movement.y < -0.01)
        {
            animator.SetFloat("LastHorizontal", movement.x);
            animator.SetFloat("LastVertical", movement.y);
        }
    }

    void FixedUpdate()
    {
        if (isControlEnabled)
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

        }
    }

    public void EnabledControl(bool value)
    {
        isControlEnabled = value;
    }
}
