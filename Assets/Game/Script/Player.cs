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

    public void GagnerMinerai(string typeMineraiIn)
    {
        if (isCollideMinerai)
        {
            if (typeMineraiIn == "Or")
            {
                or++;
            }
            else if (typeMineraiIn == "Pierre")
            {
                pierre++;
            }

            textOr.text = or.ToString();
            textPierre.text = pierre.ToString();
        }
    }
}
