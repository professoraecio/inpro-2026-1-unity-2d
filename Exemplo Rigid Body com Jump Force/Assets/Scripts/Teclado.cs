using UnityEngine;
using UnityEngine.InputSystem;
public class Teclado : MonoBehaviour
{    
    public bool cima;
    public bool baixo;
    public bool esquerda;
    public bool direita;
    public bool espaco;

    void Update()
    {
        if (Keyboard.current == null) return;

        cima = Keyboard.current.upArrowKey.isPressed;
        baixo = Keyboard.current.downArrowKey.isPressed;
        esquerda = Keyboard.current.leftArrowKey.isPressed;
        direita = Keyboard.current.rightArrowKey.isPressed;
        espaco = Keyboard.current.spaceKey.isPressed;
    }
}
