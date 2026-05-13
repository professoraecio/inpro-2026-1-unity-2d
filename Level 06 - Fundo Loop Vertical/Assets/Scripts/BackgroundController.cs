using UnityEngine;
public class BackgroundController : MonoBehaviour
{
    [SerializeField]
    public float velocidade = 0.8f;
    [SerializeField]
    public int horizontal = 1;
    [SerializeField]
    public int vertical = 0;
    public Renderer render;

    void Start()
    {
        render = GetComponent<Renderer>();
    }
    void Update()
    {
        float tempoDoFrame = Time.deltaTime;
        float dist = velocidade * tempoDoFrame;
        Vector2 offset = Mover(horizontal * dist, vertical * dist);
        render.material.mainTextureOffset += offset;
    }

    private Vector2 Mover(float movimentoX, float movimentoY)
    {
        Vector2 offset;
        offset = new Vector2(movimentoX, movimentoY);
        return offset;
    }
}
