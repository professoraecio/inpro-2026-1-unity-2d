using UnityEngine;

public class PlayerAudioController : MonoBehaviour
{
    private PlayerStatus playerStatus;

    public AudioClip somPulo;
    public AudioClip somMorte;

    void Start()
    {
        playerStatus = GetComponent<PlayerStatus>();

        playerStatus.OnPlayerMorreu += TocarSomMorte;
    }

    public void TocarSomPulo()
    {
        AudioManager.Instance.TocarSFX(somPulo);
    }

    public void TocarSomMorte()
    {
        AudioManager.Instance.TocarSFX(somMorte);
    }
}
