using UnityEngine;

public class BackgroundLoop : MonoBehaviour
{
    public Transform background1;
    public Transform background2;
    public float speed = 2f;

    private float spriteWidth;

    void Start()
    {
        // Pega a largura do sprite em unidades do mundo
        SpriteRenderer sr = background1.GetComponent<SpriteRenderer>();
        spriteWidth = sr.bounds.size.x;
        print(spriteWidth);
        // Garante que o segundo fundo fique exatamente ao lado do primeiro
        background2.position = new Vector3(
            background1.position.x + spriteWidth,
            background1.position.y,
            background1.position.z
        );
    }

    // Update is called once per frame
    void Update()
    {
        // Move os dois fundos para a esquerda
        background1.Translate(Vector3.left * speed * Time.deltaTime);
        background2.Translate(Vector3.left * speed * Time.deltaTime);

        // Se o background1 saiu totalmente da esquerda, joga ele para a direita do background2
        if (background1.position.x <= -spriteWidth)
        {
            background1.position = new Vector3(
                background2.position.x + spriteWidth,
                background1.position.y,
                background1.position.z
            );
        }

        // Se o background2 saiu totalmente da esquerda, joga ele para a direita do background1
        if (background2.position.x <= -spriteWidth)
        {
            background2.position = new Vector3(
                background1.position.x + spriteWidth,
                background2.position.y,
                background2.position.z
            );
        }
    }
}
