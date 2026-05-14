using UnityEngine;

public class AutoMoveNaveController : MonoBehaviour
{
    private Teclado teclado;
    void Start()
    {
        teclado = GetComponent<Teclado>();
    }
    // Update is called once per frame
    void Update()
    {
        float dirX = 0f;
        if(teclado.direita)
            dirX += 1f;
        Vector3 pos = transform.position;
        if (dirX == 0)    
            pos.x += 1 * 2.5f * Time.deltaTime;
        else
            pos.x += dirX * 2.5f  * Time.deltaTime;
        transform.position = pos;            
    }
}
