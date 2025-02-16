using UnityEngine;

public class MineraiCore : MonoBehaviour
{
    private Player player;

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
        player = collision.GetComponent<Player>();

        player.isCollideMinerai = true;

        player.GagnerMinerai(this.transform.parent.tag);
        Debug.Log("Gagner +1" + this.transform.parent.tag);
    }

    private void OnTriggerStay2D(Collider2D collision)
    {

    }
}
