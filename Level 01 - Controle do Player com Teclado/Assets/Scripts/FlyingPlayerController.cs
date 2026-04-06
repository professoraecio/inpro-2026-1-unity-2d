using UnityEngine;
public class FlyingPlayerController : MonoBehaviour
{
    // Referência para a classe que monitora o teclado
    private Teclado teclado;
    // Velocidade de movimento da coruja
    [SerializeField]
    private float velocidade = 2.5f;
    [SerializeField]
    private float tempoDoFrame = 0.0f;
    // Executa antes do Start, ideal para pegar componentes
    private void Awake()
    {
        // Procura no mesmo objeto o componente Teclado
        teclado = GetComponent<Teclado>();
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // Guarda o tempo do frame atual
        tempoDoFrame = Time.deltaTime;
        // Calcula quanto o player deve se mover neste frame
        float distanciaMovimento = velocidade * tempoDoFrame;
        // Verifica cada tecla e move o player na direção correspondente
        if (teclado.cima)
            Mover(0, distanciaMovimento);   
        if (teclado.baixo) 
            Mover(0, -distanciaMovimento);
        if (teclado.esquerda)
            Mover(-distanciaMovimento, 0);
        if (teclado.direita)
            Mover(distanciaMovimento, 0); 
    }
    private void Mover(float movimentoX, float movimentoY)
    {
        transform.Translate(new Vector2(movimentoX, movimentoY));
    }
}
