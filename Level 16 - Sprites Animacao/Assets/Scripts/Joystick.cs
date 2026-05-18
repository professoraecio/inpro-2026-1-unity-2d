using NUnit.Framework;
using UnityEngine;
using UnityEngine.InputSystem;
public class Joystick : MonoBehaviour
{
    private float deadzone = 0.1f;
    [Header("Movimento")]
    public bool cima = false;
    public bool baixo = false;
    public bool esquerda = false;
    public bool direita = false;
    [Header("Botões")]
    public bool l1_lb = false;
    public bool l2_lt = false;
    public bool r1_rb = false;
    public bool r2_rt = false;
    public bool x_a = false;
    public bool o_b = false;
    public bool quadrado_x = false;
    public bool triangulo_y = false;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        cima = false;
        baixo = false;
        esquerda = false;
        direita = false;
        l1_lb = false;
        l2_lt = false;
        r1_rb = false;
        r2_rt = false;
        x_a = false;
        o_b = false;
        quadrado_x = false;
        triangulo_y = false;
        float dirX = 0f;
        float dirY = 0f;

        // Controle direções
        var gp = Gamepad.current;
        if (gp != null)
        {
            Vector2 stick = gp.leftStick.ReadValue();
            // Pressionou acima do deadzone
            if (Mathf.Abs(stick.x) > deadzone) dirX += stick.x;
            if (Mathf.Abs(stick.y) > deadzone) dirY += stick.y;
            if (gp.dpad.left.isPressed) dirX -= 1f;
            if (gp.dpad.right.isPressed) dirX += 1f;
            if (gp.dpad.up.isPressed) dirY += 1f;
            if (gp.dpad.down.isPressed) dirY -= 1f;
        }

        // Set cima/baixo/esq/dir pressionados
        // Se passar do mínimo vira -1, se passar do máximo vira 1
        dirX = Mathf.Clamp(dirX, -1f, 1f);
        dirY = Mathf.Clamp(dirY, -1f, 1f);
        if (dirX > deadzone)
            direita = true;
        if (dirX < deadzone * -1)
            esquerda = true;
        if (dirY > deadzone)
            cima = true;
        if (dirY < deadzone * -1)
            baixo = true;

        if (gp != null)
        {
            // Mapeamento de botões pressionados
            l1_lb = gp.leftShoulder.isPressed ? true : false;
            l2_lt = gp.leftTrigger.isPressed ? true : false;

            r1_rb = gp.rightShoulder.isPressed ? true : false;
            r2_rt = gp.rightTrigger.isPressed ? true : false;

            x_a = gp.buttonSouth.isPressed ? true : false;
            o_b = gp.buttonEast.isPressed ? true : false;
            quadrado_x = gp.buttonWest.isPressed ? true : false;
            triangulo_y = gp.buttonNorth.isPressed ? true : false;
        }


    }
}
