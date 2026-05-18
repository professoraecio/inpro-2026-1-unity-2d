using UnityEngine;
using UnityEngine.EventSystems;

public class BotaoTouch : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    public bool pressionado = false;

    public void OnPointerDown(PointerEventData eventData)
    {
        pressionado = true;
        Debug.Log("Botão pressionado");
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        pressionado = false;
        Debug.Log("Botão solto");
    }
}