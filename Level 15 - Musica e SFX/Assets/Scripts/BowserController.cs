using UnityEngine;

public class BowserController : MonoBehaviour
{    
    private FaseMusicaController faseMusicaController;
    
    void Start()
    {
        faseMusicaController = FindAnyObjectByType<FaseMusicaController>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            faseMusicaController.TocarMusicaChefao();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
