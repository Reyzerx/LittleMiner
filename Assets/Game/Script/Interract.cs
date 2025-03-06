using UnityEngine;

public class Interract : MonoBehaviour
{

    [SerializeField]
    private float interactRange = 0.9f;
    [SerializeField]
    private LayerMask layerMask;
    [SerializeField]
    private Player playerScript;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        playerScript = this.transform.parent.GetComponent<Player>();
    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit2D hit = Physics2D.Raycast(this.transform.position, playerScript.lookDirection, interactRange);

        Debug.DrawRay(this.transform.position, playerScript.lookDirection * interactRange, Color.red);

        if (Physics2D.Raycast(this.transform.position, playerScript.lookDirection, interactRange))
        {
            //Debug.Log("touche");
            if (hit.transform.CompareTag("Pierre") || hit.transform.CompareTag("Or"))
            {
                playerScript.isCollideMinerai = true;
                playerScript.currentMinableObject = hit.transform.gameObject;
            }
        }
        else
        {
            playerScript.isCollideMinerai = false;
            playerScript.currentMinableObject = null;
        }
    }
}
