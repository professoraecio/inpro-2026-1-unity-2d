using UnityEngine;

public class LimitePlayerCameraMovel : MonoBehaviour
{
    private Rigidbody2D rb;

    [SerializeField] private Camera cameraPrincipal;
    [SerializeField] private float margem = 0.5f;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        if (cameraPrincipal == null)
        {
            cameraPrincipal = Camera.main;
        }
    }

    void FixedUpdate()
    {
        Vector2 pos = rb.position;

        float alturaCamera = cameraPrincipal.orthographicSize;
        float larguraCamera = alturaCamera * cameraPrincipal.aspect;

        float limiteMinX = cameraPrincipal.transform.position.x - larguraCamera + margem;
        float limiteMaxX = cameraPrincipal.transform.position.x + larguraCamera - margem;
        float limiteMinY = cameraPrincipal.transform.position.y - alturaCamera + margem;
        float limiteMaxY = cameraPrincipal.transform.position.y + alturaCamera - margem;

        pos.x = Mathf.Clamp(pos.x, limiteMinX, limiteMaxX);
        pos.y = Mathf.Clamp(pos.y, limiteMinY, limiteMaxY);

        rb.position = pos;
    }
}