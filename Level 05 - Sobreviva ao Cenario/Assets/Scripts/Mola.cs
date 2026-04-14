using UnityEngine;
public class Mola : MonoBehaviour
{
    [SerializeField] private float forcaPulo = 10f;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Rigidbody2D rb = collision.gameObject.GetComponent<Rigidbody2D>();
            if (rb != null)
            {
                // Primeiro objeto colidido : contacts[0]
                // Pegar só o eixo y : normal.y
                // Abaixo do objeto: < -0.5f (0 = lateral) (1 = acima)
                if (collision.contacts[0].normal.y < -0.5f)
                {
                    rb.linearVelocity = Vector2.zero;
                    rb.AddForce(Vector2.up * forcaPulo, ForceMode2D.Impulse);
                }
            }
        }
    }
}