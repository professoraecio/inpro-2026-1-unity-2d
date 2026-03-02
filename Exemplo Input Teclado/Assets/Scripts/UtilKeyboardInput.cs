using UnityEngine;
using UnityEngine.InputSystem;
public class UtilKeyboardInput : MonoBehaviour
{
    public bool upPressed = false;
    public bool downPressed = false;
    public bool leftPressed = false;
    public bool rightPressed = false;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        upPressed = false;
        downPressed = false;
        leftPressed = false;
        rightPressed = false;
        if (Keyboard.current.upArrowKey.isPressed)
            upPressed = true;
        if (Keyboard.current.downArrowKey.isPressed)
            downPressed = true;
        if (Keyboard.current.leftArrowKey.isPressed)
            leftPressed = true;
        if (Keyboard.current.rightArrowKey.isPressed)
            rightPressed = true;
    }
}
