using UnityEngine;

public class MoveLeft : MonoBehaviour
{
    private float speed = 30;
    private PlayerController playercontrollerscript;
    private float leftbound = -15;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        playercontrollerscript = GameObject.Find("Player").GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
        if (playercontrollerscript.gameOver == false)
        {
            transform.Translate(Vector3.left * Time.deltaTime * speed);
        }
        if (transform.position.x < leftbound && gameObject.CompareTag("Obstacle"))
        { 
            Destroy(gameObject);
        }
    }
}
