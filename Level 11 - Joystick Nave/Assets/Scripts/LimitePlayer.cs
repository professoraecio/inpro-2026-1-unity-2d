using UnityEngine;

public class LimitePlayer : MonoBehaviour
{
    private Rigidbody2D rb;

    [SerializeField] private float limiteX = 8f;
    [SerializeField] private float limiteY = 3.5f;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        Vector2 pos = rb.position;

        // Trava posição dentro dos limites
        pos.x = Mathf.Clamp(pos.x, -limiteX, limiteX);
        pos.y = Mathf.Clamp(pos.y, -limiteY, limiteY);

        rb.position = pos;

        // Se bateu no limite X, zera velocidade horizontal
        if (pos.x <= -limiteX || pos.x >= limiteX)
        {
            rb.linearVelocity = new Vector2(0, rb.linearVelocity.y);
        }

        // Se bateu no limite Y, zera velocidade vertical
        if (pos.y <= -limiteY || pos.y >= limiteY)
        {
            rb.linearVelocity = new Vector2(rb.linearVelocity.x, 0);
        }
    }
}