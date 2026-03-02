using UnityEngine;

public class Player : MonoBehaviour
{
    UtilKeyboardInput utilKeyboardInput;
    private float velocidade = 2.5f;
    void Awake()
    {
        utilKeyboardInput =
            GetComponent<UtilKeyboardInput>();
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (utilKeyboardInput.upPressed)
            transform.Translate(
                new Vector3(0, velocidade * Time.deltaTime, 0)
            );
        if (utilKeyboardInput.downPressed)
            transform.Translate(
                new Vector3(0, -velocidade * Time.deltaTime, 0)
            );
        if (utilKeyboardInput.leftPressed)
            transform.Translate(
                new Vector3(-velocidade * Time.deltaTime, 0, 0)
            );
        if (utilKeyboardInput.rightPressed)
            transform.Translate(
                new Vector3(velocidade * Time.deltaTime, 0, 0)
            );
    }
}
