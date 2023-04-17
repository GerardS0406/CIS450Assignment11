/*
 * Gerard Lamoureux
 * CoinCollection
 * Assignment 11
 * Handles the coin collection and spawning another coin
 */

using UnityEngine;

public class CoinCollection : MonoBehaviour
{
    public GameObject coinPrefab;
    public Transform[] spawnPoints;
    private int _lastSpawnIndex = -1;

    public void CollectCoin(GameObject coin)
    {
        Destroy(coin);
    }

    public void SpawnCoin()
    {
        int randomIndex = Random.Range(0, spawnPoints.Length);
        while(randomIndex == _lastSpawnIndex)
        {
            randomIndex = Random.Range(0, spawnPoints.Length);
        }
        Instantiate(coinPrefab, spawnPoints[randomIndex].position, Quaternion.identity);
        _lastSpawnIndex = randomIndex;
    }
}