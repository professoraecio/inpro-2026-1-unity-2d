using UnityEngine;

public class LimitesTela : MonoBehaviour
{
    private Camera cam;
    private float metadeLargura;
    private float metadeAltura;
    void Start()
    {
        cam = Camera.main;
        var rend = GetComponentInChildren<Renderer>();
        if (rend != null)
        {
            metadeLargura = rend.bounds.extents.x;
            metadeAltura = rend.bounds.extents.y;
        }
        else
        {
            metadeLargura = 0.5f;
            metadeAltura = 0.5f;
        }
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 pos = transform.position;
        if (cam != null)
        {
            // Definir limites da Câmera (limitar o movimento)
            float dist = Mathf.Abs(cam.transform.position.z - pos.z);
            // Limites bordas horizontais
            Vector3 bordaEsq = cam.ViewportToWorldPoint(new Vector3(0f, 0.5f, dist));
            Vector3 bordaDir = cam.ViewportToWorldPoint(new Vector3(1f, 0.5f, dist));
            // Limites bordas verticais
            Vector3 bordaInf = cam.ViewportToWorldPoint(new Vector3(0.5f, 0f, dist));
            Vector3 bordaSup = cam.ViewportToWorldPoint(new Vector3(0.5f, 1f, dist));
            // Limitar eixos X e Y
            pos.x = Mathf.Clamp(pos.x, bordaEsq.x + metadeLargura, bordaDir.x - metadeLargura);
            pos.y = Mathf.Clamp(pos.y, bordaInf.y + metadeAltura, bordaSup.y - metadeAltura);
        }
        transform.position = pos;
    }
}
