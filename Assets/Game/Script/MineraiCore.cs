using UnityEngine;

public class MineraiCore : MonoBehaviour
{
    private Player playerScript;
    private PlayerMovement playerMovementScript;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Entrée de " + collision.name);

        playerScript = collision.GetComponent<Player>();
        playerMovementScript = collision.GetComponent<PlayerMovement>();

        playerScript.isCollideMinerai = true;
        playerScript.currentMinableObject = this.transform.parent.gameObject;
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (! playerScript.isMoving)
        {
            playerMovementScript.animator.SetBool("isMining", true);
        }
        else
        {
            playerMovementScript.animator.SetBool("isMining", false);
        }
    }

}
