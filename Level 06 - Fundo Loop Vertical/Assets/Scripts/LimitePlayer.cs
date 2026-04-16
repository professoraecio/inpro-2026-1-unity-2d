using UnityEngine;
public class LimitePlayer : MonoBehaviour
{
    private Rigidbody2D rb;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    void FixedUpdate()
    {
        Vector2 pos = rb.position;              // Controle x/y min/max
        pos.x = pos.x <= -8 ? -8 : pos.x;       // Controle x min/max
        pos.x = pos.x >= 8 ? 8 : pos.x;         // Controle x min/max
        pos.y = pos.y <= -3.5f ? -3.5f : pos.y; // Controle y min/max
        pos.y = pos.y >= 3.5f ? 3.5f : pos.y;   // Controle y min/max
        rb.position = pos;                      // Controle x/y min/max
    }
}