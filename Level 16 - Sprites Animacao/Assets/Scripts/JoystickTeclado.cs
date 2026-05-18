using UnityEngine;

public class JoystickTeclado : MonoBehaviour
{
    private Teclado teclado;
    private Joystick joystick;
    public bool cima;
    public bool baixo;
    public bool esquerda;
    public bool direita;
    public bool pulo;
    public bool ataque;
    void Start()
    {
        teclado = GetComponent<Teclado>();
        joystick = GetComponent<Joystick>();
    }

    // Update is called once per frame
    void Update()
    {
        cima = teclado.cima || joystick.cima ? true : false;
        baixo = teclado.baixo || joystick.baixo ? true : false;
        esquerda = teclado.esquerda || joystick.esquerda ? true : false;
        direita = teclado.direita || joystick.direita ? true : false;
        pulo = teclado.espaco || joystick.x_a ? true : false;
        ataque = teclado.x || joystick.quadrado_x ? true : false;
    }
}
