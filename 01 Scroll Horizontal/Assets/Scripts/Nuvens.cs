using UnityEngine;

public class Nuvens : MonoBehaviour
{
    public float velocidadeAnimacao = 0.1f;
    public Renderer textura; 
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Time.deltaTime = tempo em segundos independente do fps
        // Definir o deslocamento da imagem baseado na velocidade
        Vector2 deslocamentoImagem =
        new Vector2(velocidadeAnimacao * Time.deltaTime, 0);

        // Aplicar a textura baseado no acrescimo do
        // deslocamento da imagem de forma incremental
        textura.material.mainTextureOffset =
        textura.material.mainTextureOffset + deslocamentoImagem;
    }
}
