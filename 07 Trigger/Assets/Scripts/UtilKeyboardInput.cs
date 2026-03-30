using UnityEngine;
using UnityEngine.InputSystem;
public class UtilKeyboardInput : MonoBehaviour
{
    public bool cima = false;
    public bool baixo = false;
    public bool esquerda = false;
    public bool direita = false;
  
    void Update()
    {
        cima = false; baixo = false;
        esquerda = false; direita = false;
        if (Keyboard.current.upArrowKey.isPressed)
            cima = true;
        if (Keyboard.current.downArrowKey.isPressed)
            baixo = true;
        if (Keyboard.current.leftArrowKey.isPressed)
            esquerda = true;
        if (Keyboard.current.rightArrowKey.isPressed)
            direita = true;
    }
}
