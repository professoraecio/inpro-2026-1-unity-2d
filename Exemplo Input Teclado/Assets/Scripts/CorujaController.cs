using UnityEngine;

public class CorujaController : MonoBehaviour
{
    Teclado teclado;
    private float velocidade = 2.5f;
    void Awake()
    {
        teclado = GetComponent<Teclado>();
    }

    // Update is called once per frame
    void Update()
    {
        float tempoEntreFrames = Time.deltaTime;
        // tempoEntreFrames entra como fator multiplicativo 
        // para aumentar ou diminuir a velocidade
        float distancia = velocidade * tempoEntreFrames;

        if (teclado.cima)
            Mover(0, distancia);
        if (teclado.baixo)
            Mover(0, -distancia);
        if (teclado.esquerda)
            Mover(-distancia, 0);
        if (teclado.direita)
            Mover(distancia, 0);
    }

    void Mover(float x, float y)
    {
        transform.Translate(new Vector3(x, y, 0));
    }
}
