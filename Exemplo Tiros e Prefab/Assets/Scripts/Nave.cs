using UnityEngine;

public class Nave : MonoBehaviour
{
    [Header("Tiro")]
    [SerializeField] public GameObject missil;
    [SerializeField] public GameObject origemMissil;
    [SerializeField] public float intervaloTiro = 1f; // diferença de 1 segundo por tiro
    [SerializeField] public float tempoProximoTiro = 0f;
    [Header("Movimento")]
    [SerializeField] public float velocidade = 6f;
    [SerializeField] private UtilScreenBoundsLimiter bounds;
    UtilKeyboardInput utilKeyboardInput;
    void Start()
    {
        if(bounds == null) bounds = GetComponent<UtilScreenBoundsLimiter>();
        utilKeyboardInput = GetComponent<UtilKeyboardInput>();

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void ProcessarMovimento()
    {
        float dirX = 0f;
        float dirY = 0f;
        if(utilKeyboardInput.leftPressed) dirX -= 1f;
        if(utilKeyboardInput.rightPressed) dirX += 1f;
        if(utilKeyboardInput.upPressed) dirY += 1f;
        if(utilKeyboardInput.downPressed) dirY -= 1f;
        Vector3 pos = transform.position;
        pos.x += dirX * velocidade * Time.deltaTime;
        pos.y += dirY * velocidade * Time.deltaTime;
        transform.position = pos;
        if(bounds != null) transform.position = bounds.GetCoordenadasLimite(pos);
    }

    void ProcessarTiro()
    {
        if (utilKeyboardInput.spacePressed && Time.time >= tempoProximoTiro)
        {
            tempoProximoTiro = Time.time + intervaloTiro;
            Instantiate(missil,
                new Vector3(
                    origemMissil.transform.position.x,
                    origemMissil.transform.position.y,
                    origemMissil.transform.position.z),
                    Quaternion.identity
                );
                // Quaternion.identity = rotação nula
        }
    }

}
