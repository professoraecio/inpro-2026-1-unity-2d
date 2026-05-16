using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float velocidade = 5f;
    public float forcaPulo = 9f;

    private Rigidbody2D rb;
    public bool noChao = false;

    Teclado teclado;
    JoystickTeclado joystickTeclado;
    PlayerInput playerInput;
    private float horizontal;

    private PlayerAudioController audioController;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        teclado = GetComponent<Teclado>();
        joystickTeclado = GetComponent<JoystickTeclado>();
        playerInput = GetComponent<PlayerInput>();

        audioController = GetComponent<PlayerAudioController>();
    }

    void Update()
    {
        // Movimento horizontal (input)
        if (playerInput.esquerda)
            horizontal = -1f;
        else if (playerInput.direita)
            horizontal = 1f;
        else
            horizontal = 0f;

        // Pulo
        if (playerInput.pulo && noChao)
        {
            audioController.TocarSomPulo();
            rb.AddForce(Vector2.up * forcaPulo, ForceMode2D.Impulse);
            noChao = false;
        }
    }

    void FixedUpdate()
    {
        Vector2 vel = rb.linearVelocity;
        vel.x = horizontal * velocidade;
        rb.linearVelocity = vel;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Chao"))
        {
            noChao = true;
        }
    }
}