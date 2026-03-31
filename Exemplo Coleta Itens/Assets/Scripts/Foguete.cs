using UnityEngine;

public class Foguete : MonoBehaviour
{
    [Header("Movimento")]
    [SerializeField]
    float velocidade = 6f;
    [SerializeField]
    UtilScreenBoundsLimiter bounds;// deve ficar anexado a câmera
    UtilKeyboardInput teclado;
    void Start()
    {
        if(bounds == null)
            bounds = GetComponent<UtilScreenBoundsLimiter>();
        teclado = GetComponent<UtilKeyboardInput>();
    }

    // Update is called once per frame
    void Update()
    {
        float deslocamento = velocidade * Time.deltaTime;
        if(teclado.cima)
            transform.Translate(Mover(0,deslocamento));
        if(teclado.baixo)
            transform.Translate(Mover(0,-deslocamento));
        if(teclado.esquerda)
            transform.Translate(Mover(-deslocamento,0));
        if(teclado.direita)
            transform.Translate(Mover(deslocamento,0));
    }

    private Vector3 Mover(float x,float y)
    {
        return new Vector3(x,y,0);
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("NaveInimiga"))
            Destroy(collision.gameObject);
    }
}
