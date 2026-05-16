using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class HUDController : MonoBehaviour
{
    [SerializeField] private PlayerStatus playerStatus;
    [SerializeField] private Image barraVida;
    [SerializeField] private TMP_Text textoVidas;

    private void Start()
    {
        if (playerStatus == null)
        {
            playerStatus = FindAnyObjectByType<PlayerStatus>();
        }

        playerStatus.OnHpChanged += AtualizarBarraVida;
        playerStatus.OnVidasChanged += AtualizarVidas;

        AtualizarBarraVida(playerStatus.HP);
        AtualizarVidas(playerStatus.Vidas);
    }

    private void AtualizarBarraVida(float hp)
    {
        barraVida.fillAmount = hp / 100f;
    }

    private void AtualizarVidas(int vidas)
    {
        textoVidas.text = "" + vidas;
    }

    private void OnDestroy()
    {
        if (playerStatus != null)
        {
            playerStatus.OnHpChanged -= AtualizarBarraVida;
            playerStatus.OnVidasChanged -= AtualizarVidas;
        }
    }
}