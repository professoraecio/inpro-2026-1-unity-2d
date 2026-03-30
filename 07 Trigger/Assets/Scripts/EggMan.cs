using UnityEngine;

public class EggMan : MonoBehaviour
{
    UtilKeyboardInput teclado;
    [SerializeField]
    public float velocidade = 2.5f;
    
    void Start()
    {
        teclado = GetComponent<UtilKeyboardInput>();
    }
    
    void Update()
    {
        float deslocamento = velocidade * Time.deltaTime;
        if(teclado.cima)        
            transform.Translate(Mover(0,deslocamento));        
        if(teclado.baixo)        
            transform.Translate(Mover(0,-deslocamento));        
        if(teclado.esquerda)        
            transform.Translate(Mover(-deslocamento,0));        
        if(teclado.direita)        
            transform.Translate(Mover(deslocamento,0));        
    }

    private Vector3 Mover(float x, float y)
    {
        return new Vector3(x, y, 0);
    }
}
