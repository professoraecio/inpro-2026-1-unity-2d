using UnityEngine;
using UnityEngine.InputSystem;
public class MainCamera : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Keyboard.current.upArrowKey.wasReleasedThisFrame)
            Debug.Log("Jogador soltou a seta CIMA");
        if (Keyboard.current.downArrowKey.wasReleasedThisFrame)
            Debug.Log("Jogador soltou a seta BAIXO");
        if (Keyboard.current.leftArrowKey.wasPressedThisFrame)
            Debug.Log("Jogador pressionou a seta ESQUERDA");
        if (Keyboard.current.rightArrowKey.wasPressedThisFrame)
            Debug.Log("Jogador pressionou a seta DIREITA");
        if (Keyboard.current.wKey.isPressed)
            Debug.Log("Jogador está pressionando a tecla 'W'");
        if(Keyboard.current.sKey.isPressed)
            Debug.Log("Jogador está pressionando a tecla 'S'");
    }
}
