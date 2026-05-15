using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class TouchTela : MonoBehaviour
{
    public bool esquerda = false;
    public bool direita = false;
    public bool cima = false;
    public bool baixo = false;
    public bool pulo = false;

    public Button esquerdaButton;
    public Button direitaButton;
    public Button cimaButton;
    public Button baixoButton;
    public Button puloButton;
    
    void Start()
    {
        AdicionarEventos(esquerdaButton,
            () => esquerda = true,
            () => esquerda = false);

        AdicionarEventos(direitaButton,
            () => direita = true,
            () => direita = false);

        AdicionarEventos(cimaButton,
            () => cima = true,
            () => cima = false);

        AdicionarEventos(baixoButton,
            () => baixo = true,
            () => baixo = false);

        AdicionarEventos(puloButton,
            () => pulo = true,
            () => pulo = false);
    }

    void AdicionarEventos(Button botao,
            UnityEngine.Events.UnityAction pressionar,
            UnityEngine.Events.UnityAction soltar)
    {
        EventTrigger trigger = botao.gameObject.AddComponent<EventTrigger>();

        // Pointer Down
        EventTrigger.Entry down = new EventTrigger.Entry();
        down.eventID = EventTriggerType.PointerDown;
        down.callback.AddListener((eventData) => pressionar());

        // Pointer Up
        EventTrigger.Entry up = new EventTrigger.Entry();
        up.eventID = EventTriggerType.PointerUp;
        up.callback.AddListener((eventData) => soltar());

        trigger.triggers.Add(down);
        trigger.triggers.Add(up);
    }

}
