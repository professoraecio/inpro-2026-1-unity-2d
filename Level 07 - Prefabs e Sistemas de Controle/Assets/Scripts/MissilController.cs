using Unity.VisualScripting;
using UnityEngine;
public class MissilController : MonoBehaviour
{
    [SerializeField] float velocidade = 2.5f;
    [SerializeField] bool vertical = true;
    [SerializeField] bool horizontal = false;
    void Start()
    {
        Destroy(gameObject,5f); // Auto-destruir
    }

    // Update is called once per frame
    void Update()
    {
        if(vertical)
            transform.Translate(new Vector2(0,velocidade * Time.deltaTime));
        if(horizontal)
            transform.Translate(new Vector2(velocidade * Time.deltaTime,0));
    }
}
