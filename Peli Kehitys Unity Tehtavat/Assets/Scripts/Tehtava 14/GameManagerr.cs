using UnityEngine;

public class GameManagerr : MonoBehaviour
{
    void OnEnable()
    {
        PlayerHealth.OnPlayerDied += GameOver;
    }

    void OnDisable()
    {
        PlayerHealth.OnPlayerDied -= GameOver;
    }

    void GameOver()
    {
        Debug.Log("Game Over");
    }
}