using UnityEngine;
public class PlataformaQueSome : MonoBehaviour
{
    public float tempoParaSumir = 1f;
    private bool jogadorSaiu = false;
    private bool entrouPorCima = false;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            // Verifica se o player veio de cima
            if (collision.contacts[0].normal.y < -0.5f)
            {
                entrouPorCima = true;
            }
        }
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player") && !jogadorSaiu && entrouPorCima)
        {
            print("saiu da plataforma por cima");

            jogadorSaiu = true;
            Invoke(nameof(Sumir), tempoParaSumir);
        }
    }
    private void Sumir()
    {
        gameObject.SetActive(false);
    }
}