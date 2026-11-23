using UnityEngine;

public class Coin : MonoBehaviour
{
    public float lifetime = 3f;

    void Start()
    {
        Destroy(gameObject, lifetime);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            FindObjectOfType<ScoreManager>().AddScore(1);
            Destroy(gameObject);
        }
    }
}