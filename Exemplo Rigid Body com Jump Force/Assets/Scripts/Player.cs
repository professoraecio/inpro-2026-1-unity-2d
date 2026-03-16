using UnityEngine;

public class Player : MonoBehaviour
{
    
    public float forcaPulo = 0.04f;
    public float forcaHorizontal = 0.002f;
    public Transform checadorDeChao;
    public LayerMask camadaChao;

    private Rigidbody2D rb;
    public int pulosRestantes = 1;
    public bool noChao;
    UtilKeyboardInput utilKeyboardInput;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        utilKeyboardInput = GetComponent<UtilKeyboardInput>();
    }

    // Update is called once per frame
    void Update()
    {
        noChao = Physics2D.OverlapCircle(checadorDeChao.position,0.1f,camadaChao);
        if(noChao) pulosRestantes = 1;

        float direcao = 0f;
        if(utilKeyboardInput.leftPressed) direcao = -1f;
        if(utilKeyboardInput.rightPressed) direcao = 1f;

        if(utilKeyboardInput.spacePressed && pulosRestantes > 0)
        {
            rb.linearVelocity = new Vector2(rb.linearVelocity.x,0);
            Vector2 forca = 
                new Vector2(direcao * forcaHorizontal,forcaPulo);
            rb.AddForce(forca);
            pulosRestantes--;
        }
        if(utilKeyboardInput.leftPressed || utilKeyboardInput.rightPressed)
        {
            rb.linearVelocity = new Vector2(rb.linearVelocity.x,0);
            Vector2 forca = 
                new Vector2(direcao * forcaHorizontal,0.0f);
            rb.AddForce(forca);
        }
        
    }
}
