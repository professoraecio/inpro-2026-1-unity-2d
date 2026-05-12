using UnityEngine;

public class Argola : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            KnucklesController player =
                collision.GetComponent<KnucklesController>();

            player.argolas++;

            Destroy(gameObject);
        }
    }
}
