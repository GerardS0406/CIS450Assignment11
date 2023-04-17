/*
 * Gerard Lamoureux
 * GameManager
 * Assignment 11
 * Handles the GameManager for the Facade Pattern
 */

using UnityEngine;

public class GameController : MonoBehaviour
{
    public PlayerMovement playerMovement;
    public CoinCollection coinCollection;
    public ScoreManager scoreManager;
    public static GameController Instance;

    private void Awake()
    {
        Instance = this;
    }

    private void Start()
    {
        coinCollection.SpawnCoin();
    }

    private void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        playerMovement.Move(horizontalInput);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            playerMovement.Jump();
        }

        if (Input.GetKeyDown(KeyCode.R))
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene(UnityEngine.SceneManagement.SceneManager.GetActiveScene().buildIndex);
        }
    }

    public void CollectCoin(GameObject coin)
    {
        coinCollection.CollectCoin(coin);
        scoreManager.IncrementScore(1);
        coinCollection.SpawnCoin();
    }
}
