using UnityEngine;

public class Missil : MonoBehaviour
{
    [SerializeField]
    float velocidade = 2.5f;
    void Start()
    {
        Destroy(gameObject,5f);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(new Vector2(0,velocidade * Time.deltaTime));
    }
}
