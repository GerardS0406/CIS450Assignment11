/*
 * Gerard Lamoureux
 * PlayerMovement
 * Assignment 11
 * Handles the player movement
 */

using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 5f;
    public float jumpForce = 10f;
    private Rigidbody2D rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    public void Move(float horizontalInput)
    {
        rb.velocity = new Vector2(horizontalInput * speed, rb.velocity.y);
    }

    public void Jump()
    {
        rb.AddForce(new Vector2(0, jumpForce), ForceMode2D.Impulse);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Coin"))
            GameController.Instance.CollectCoin(collision.gameObject);
            
    }
}
