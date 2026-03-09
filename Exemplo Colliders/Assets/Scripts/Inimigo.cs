using UnityEngine;
using System.Collections;

public class Inimigo : MonoBehaviour
{
    [Header("Configuração do movimento")]
    public float velocidade = 2f;   // Velocidade de movimento
    private Vector2 direcaoAtual;   // Direção que o inimigo está se movendo
    private Rigidbody2D rb;         // Para mover fisicamente o inimigo
    public string direcao = "";

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        StartCoroutine(MovimentoAleatorio());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void FixedUpdate()
    {
        // Aplica movimento constante na direção escolhida
        rb.linearVelocity = direcaoAtual * velocidade;
    }

    IEnumerator MovimentoAleatorio()
    {
        while (true) // Loop infinito até o inimigo ser destruído
        {
            // Sorteia um número de 0 a 3 para escolher a direção
            int sorteio = Random.Range(0, 4);

            switch (sorteio)
            {
                case 0: direcaoAtual = Vector2.up; direcao = "Cima"; break;     // Cima
                case 1: direcaoAtual = Vector2.down; direcao = "Baixo"; break;   // Baixo
                case 2: direcaoAtual = Vector2.left; direcao = "Esquerda"; break;   // Esquerda
                case 3: direcaoAtual = Vector2.right; direcao = "Direita"; break;  // Direita
            }

            // Espera 4 segundos antes de mudar a direção
            yield return new WaitForSeconds(3f);
        }
    }
}
