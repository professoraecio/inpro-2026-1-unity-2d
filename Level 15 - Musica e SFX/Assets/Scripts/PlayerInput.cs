using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    private Teclado teclado;
    private Joystick joystick;
    private TouchTela touchTela;
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
        touchTela = GetComponent<TouchTela>();
    }

    // Update is called once per frame
    void Update()
    {
        cima = teclado.cima || joystick.cima || touchTela.cima ? true : false;
        baixo = teclado.baixo || joystick.baixo || touchTela.baixo ? true : false;
        esquerda = teclado.esquerda || joystick.esquerda || touchTela.esquerda ? true : false;
        direita = teclado.direita || joystick.direita || touchTela.direita ? true : false;
        pulo = teclado.espaco || joystick.x_a || touchTela.pulo ? true : false;
        ataque = teclado.x || joystick.quadrado_x || touchTela.pulo ? true : false;
    }
}
