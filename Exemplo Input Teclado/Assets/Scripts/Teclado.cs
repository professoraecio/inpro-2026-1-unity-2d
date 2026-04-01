using UnityEngine;
using UnityEngine.InputSystem;
public class Teclado : MonoBehaviour
{
    public bool cima { get; private set; }
    public bool baixo { get; private set; }
    public bool esquerda { get; private set; }
    public bool direita { get; private set; }

    void Update()
    {
        if (Keyboard.current == null) return;

        cima = Keyboard.current.upArrowKey.isPressed;
        baixo = Keyboard.current.downArrowKey.isPressed;
        esquerda = Keyboard.current.leftArrowKey.isPressed;
        direita = Keyboard.current.rightArrowKey.isPressed;
    }
}
