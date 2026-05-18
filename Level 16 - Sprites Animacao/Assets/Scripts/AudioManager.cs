using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public static AudioManager Instance;

    public AudioSource musicaSource;
    public AudioSource sfxSource;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void TocarMusica(AudioClip musica, bool loop = true)
    {
        if (musicaSource.clip == musica)
            return;

        musicaSource.clip = musica;
        musicaSource.loop = loop;
        musicaSource.Play();
    }

    public void PararMusica()
    {
        musicaSource.Stop();
    }

    public void TocarSFX(AudioClip sfx)
    {
        sfxSource.PlayOneShot(sfx);
    }
}
