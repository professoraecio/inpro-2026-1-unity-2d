using UnityEngine;

public class UtilScreenBoundsLimiter : MonoBehaviour
{
    [Header("Referências")]
    [SerializeField] private Camera camera;
    [SerializeField] private Renderer referenciaTamanho;

    [Header("Padding (Margem)")]
    [SerializeField] private float paddingX = 0f;
    [SerializeField] private float paddingY = 0f;

    [SerializeField] private float metadeLargura = 0f;
    [SerializeField] private float metadeAltura = 0f;

    void Awake()
    {
        if(camera == null) camera = Camera.main;
        if(referenciaTamanho != null)
        {
            var extends = referenciaTamanho.bounds.extents;
            metadeLargura = extends.x + paddingX;
            metadeAltura = extends.y + paddingY;
        }
        else
        {
            metadeLargura = 0.5f + paddingX;
            metadeAltura = 0.5f + paddingY;
        }
    }

    public Vector3 GetCoordenadasLimite(Vector3 pos)
    {
        if(camera == null) return pos;
        float dist = Mathf.Abs(camera.transform.position.z - pos.z);
        // Calcular bordas esquerda e direita
        Vector3 bordaEsq = camera.ViewportToWorldPoint(new Vector3(0f,0.5f,dist));
        Vector3 bordaDir = camera.ViewportToWorldPoint(new Vector3(1f,0.5f,dist));
        // Calcular borda superior e inferior
        Vector3 bordaInf = camera.ViewportToWorldPoint(new Vector3(0.5f,0f,dist));
        Vector3 bordaSup = camera.ViewportToWorldPoint(new Vector3(0.5f,1f,dist));
        // Calcular coordenas x e y limites navegáveis
        pos.x = Mathf.Clamp(pos.x,bordaEsq.x + metadeLargura, bordaDir.x - metadeLargura);
        pos.x = Mathf.Clamp(pos.y,bordaInf.y + metadeAltura, bordaSup.y - metadeAltura);
        return pos;
    }

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
