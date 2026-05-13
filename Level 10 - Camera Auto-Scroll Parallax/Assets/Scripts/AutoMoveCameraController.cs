using UnityEngine;
public class AutoMoveCameraController : MonoBehaviour
{
    public float velocidade = 2.5f;
    public float tempoDoFrame = 0.0f;
    [SerializeField]
    public int horizontal = 1;
    [SerializeField]
    public int vertical = 0;
    void Update()
    {
        tempoDoFrame = Time.deltaTime;
        float dist = velocidade * tempoDoFrame;
        Mover(horizontal * dist, vertical * dist);
    }
    private void Mover(float movimentoX, float movimentoY)
    {
        transform.Translate(new Vector2(movimentoX, movimentoY));
    }
}
