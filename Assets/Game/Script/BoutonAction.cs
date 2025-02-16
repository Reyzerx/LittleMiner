using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class BoutonAction : MonoBehaviour
{
    public Player player;
    public PlayerMovement playerMovement;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void LoadNextScene()
    {
        SceneManager.LoadScene("Game");
    }

    public void OpenMenu(GameObject panelIn)
    {
        if (panelIn.activeSelf)
        {
            panelIn.SetActive(false);
        }
        else
        {
            panelIn.SetActive(true);
        }
    }

    public void RetourMenu()
    {
        SceneManager.LoadScene("SampleScene");
    }

    public void QuitterLeJeu()
    {
        Application.Quit();
    }

    public void PointerDownHold()
    {
        player.isMining = true;
        playerMovement.animator.SetBool("isMining", true);
    }
    public void PointerUp()
    {
        player.isMining = false;
        playerMovement.animator.SetBool("isMining", false);
    }
}
