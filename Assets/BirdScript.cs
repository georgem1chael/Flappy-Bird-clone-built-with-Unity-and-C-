using UnityEngine;

public class BirdScript : MonoBehaviour
{
    public Rigidbody2D rb;
    public float flapSpeed = 12;
    public logicScript logic;
    public bool isDead = false;

    void Start()
    {
        logic = GameObject.FindWithTag("Logic").GetComponent<logicScript>();
    }

    void Update()
    {
        if (isDead) return;

        else // Manual Mode
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                rb.linearVelocity = Vector2.up * flapSpeed;
            }
        }

        // Check if the bird is out of bounds
        if (transform.position.y < -20 || transform.position.y > 20)
        {
            logic.gameOver();
            isDead = true;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        logic.gameOver();
        isDead = true;
    }
}