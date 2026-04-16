using UnityEngine;
public class BackgroundController : MonoBehaviour
{
    public bool vertical = true;
    public bool horizontal = false;
    [SerializeField]
    public float velocidade = 0.8f;
    public Renderer render;
    Vector2 offset;
    float deslocamento;
    void Start()
    {
        render = GetComponent<Renderer>();
    }
    void Update()
    {
        deslocamento = velocidade * Time.deltaTime;
        if(vertical)
            offset = new Vector2(0,deslocamento);
        if(horizontal)
            offset = new Vector2(deslocamento,0);
        render.material.mainTextureOffset += offset;
    }
}
