using UnityEngine;

public class FaseMusicaController : MonoBehaviour
{
    public AudioClip musicaPrincipal;
    public AudioClip musicaChefao;
    public AudioClip musicaMorte;

    void Start()
    {
        TocarMusicaPrincipal();
    }

    public void TocarMusicaPrincipal()
    {
        AudioManager.Instance.TocarMusica(musicaPrincipal);
    }

    public void TocarMusicaChefao()
    {
        AudioManager.Instance.TocarMusica(musicaChefao);
    }

    public void TocarMusicaMorte()
    {
        AudioManager.Instance.TocarMusica(musicaMorte, false);
    }
}
