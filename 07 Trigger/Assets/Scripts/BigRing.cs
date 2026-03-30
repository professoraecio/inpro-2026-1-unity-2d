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
        
        if(animaisFuriosos)
        {
            sonic.gameObject.transform.Rotate(Roll(1000));
            tails.gameObject.transform.Rotate(Roll(50));
            knuckles.gameObject.transform.Rotate(Roll(400));
        }
    }

    private Vector3 Roll(float r)
    {
        float speed = Time.deltaTime;
        return new Vector3(0, 0, r * speed);
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
