using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float velocidade = 5f;
    public float forcaPulo = 7f;

    private Rigidbody2D rb;
    public bool noChao = false;

    UtilKeyboardInput teclado;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        teclado = GetComponent<UtilKeyboardInput>();
    }

    void Update()
    {
        // Movimento horizontal
        float horizontal = 0.0f;
        if(teclado.esquerda)
            horizontal = -1.0f;
        else
            if(teclado.direita)
                horizontal = 1.0f;

        Vector3 vel = rb.linearVelocity;
        vel.x = horizontal * velocidade;
        rb.linearVelocity = vel;

        // Pulo
        if (teclado.espaco && noChao)
        {
            rb.AddForce(Vector3.up * forcaPulo, ForceMode2D.Impulse);
            noChao = false;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Chao"))
        {
            noChao = true;
        }
    }
}