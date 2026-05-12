using UnityEngine;

public class AsteroidController : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Missil"))
        {
            Destroy(gameObject);
        }
    }
}
