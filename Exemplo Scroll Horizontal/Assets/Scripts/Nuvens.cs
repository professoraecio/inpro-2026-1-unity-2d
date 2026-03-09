using UnityEngine;

public class Nuvens : MonoBehaviour
{
    [SerializeField] private float velocidadeX = 0.2f;
    [SerializeField] private float velocidadeY = 0f;

    private Renderer rend;
    private Vector2 offsetAtual;

    void Start()
    {
        rend = GetComponent<Renderer>();
    }

    void Update()
    {
        offsetAtual.x += velocidadeX * Time.deltaTime;
        offsetAtual.y += velocidadeY * Time.deltaTime;

        rend.material.mainTextureOffset = offsetAtual;
    }
}