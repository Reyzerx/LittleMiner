using TMPro;
using UnityEngine;

public class Player : MonoBehaviour
{
    public int or;
    public TMP_Text textOr;

    public int pierre;
    public TMP_Text textPierre;

    public bool isCollideMinerai = false;
    public bool isMining = false;
    public bool isMoving = false;

    public GameObject currentMinableObject;

    public Vector2 lookDirection;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        textOr.text = "0";
        textPierre.text = "0";
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void GagnerMinerai()
    {
        if (isCollideMinerai)
        {
            if(currentMinableObject != null)
            {
                if (currentMinableObject.tag == "Or")
                {
                    or++;
                }
                else if (currentMinableObject.tag == "Pierre")
                {
                    pierre++;
                }

                this.GetComponent<PlayerMovement>().animator.SetBool("isMining", false);
                Destroy(currentMinableObject);
            }
        }

        textOr.text = or.ToString();
        textPierre.text = pierre.ToString();
    }
}
