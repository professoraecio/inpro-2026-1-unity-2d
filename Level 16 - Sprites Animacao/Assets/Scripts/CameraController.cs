using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform player;
    [SerializeField] bool cameraLivre = false;
    public float minY = 0f;
    public float minX = 0f;
    [SerializeField] private float toleranciaY = 2f;

    void FixedUpdate()
    {
        if (cameraLivre == false)
        {
            float alvoX = Mathf.Max(player.position.x, minX);
            // Começa usando o Y atual da câmera
            float alvoY = transform.position.y;
            // Só sobe se o player passar da tolerância
            if (player.position.y > transform.position.y + toleranciaY)
                alvoY = player.position.y - toleranciaY;
            // Só desce se cair muito
            if (player.position.y < transform.position.y - toleranciaY)
                alvoY = player.position.y + toleranciaY;
            alvoY = Mathf.Max(alvoY, minY);
            Vector3 alvo = new Vector3(alvoX, alvoY, transform.position.z);
            transform.position =
                Vector3.Lerp(transform.position, alvo, 0.1f);
        }
        else
        {
            transform.position =
                Vector2.Lerp(transform.position, player.position, 0.1f);
        }
    }
}