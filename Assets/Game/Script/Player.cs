using TMPro;
using UnityEngine;

public class Player : MonoBehaviour
{
    public int or;
    public TMP_Text textOr;

    public int pierre;
    public TMP_Text textPierre;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void gagnerMinerai(string typeMineraiIn)
    {
        if(typeMineraiIn == "Or")
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
