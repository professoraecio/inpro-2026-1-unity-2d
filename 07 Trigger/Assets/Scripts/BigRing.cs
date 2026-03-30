using UnityEngine;

public class BigRing : MonoBehaviour
{
    bool animaisFuriosos = false;
    public GameObject sonic,tails,knuckles;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float speed = Time.deltaTime;
        if(animaisFuriosos)
        {
            sonic.gameObject.transform.Rotate(Roll(1000 * speed));
            tails.gameObject.transform.Rotate(Roll(50 * speed));
            knuckles.gameObject.transform.Rotate(Roll(400 * speed));
        }
    }

    private Vector3 Roll(float r)
    {
        return new Vector3(0, 0, r);
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("EggMan"))
            animaisFuriosos = true;
    }
    void OnTriggerExit2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("EggMan"))
            animaisFuriosos = false;
    }
}
