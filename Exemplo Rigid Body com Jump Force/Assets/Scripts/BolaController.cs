using UnityEngine;

public class BolaController : MonoBehaviour
{
    // Referência para a classe de entrada (seu Teclado)
    private Teclado teclado;

    // Referência para o Rigidbody2D da bolinha
    private Rigidbody2D rb;

    // Velocidade horizontal
    [SerializeField]
    private float velocidade = 5f;

    // Força do pulo
    [SerializeField]
    private float forcaPulo = 20f;

    // Controle se está no chão
    private bool noChao = false;

    void Awake()
    {
        teclado = GetComponent<Teclado>();
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        // =========================
        // MOVIMENTO HORIZONTAL
        // =========================
        float movimentoHorizontal = 0f;

        if (teclado.esquerda)
            movimentoHorizontal = -1f;

        if (teclado.direita)
            movimentoHorizontal = 1f;

        rb.linearVelocity = new Vector2(
            movimentoHorizontal * velocidade,
            rb.linearVelocity.y
        );

        // =========================
        // PULO
        // =========================
        if (teclado.espaco && noChao)
        {
            rb.AddForce(Vector2.up * forcaPulo, ForceMode2D.Impulse);
            noChao = false;
        }
    }

    // Detecta colisão com o chão
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Chao"))
        {
            noChao = true;
        }
    }

    // Detecta quando sai do chão
    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Chao"))
        {
            noChao = false;
        }
    }
}