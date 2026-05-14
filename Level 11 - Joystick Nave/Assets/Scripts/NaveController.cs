using System;
using UnityEngine;

public class NaveController : MonoBehaviour
{
    public GameObject missil;
    public GameObject origemDisparo;
    [SerializeField] float cadenciaDisparo = 0.5f;
    [SerializeField] float proximoDisparo = 0.0f;
    //private Teclado teclado;
    private JoystickTeclado joystickTeclado;
    private void Awake()
    {        
        //teclado = GetComponent<Teclado>();
        joystickTeclado = GetComponent<JoystickTeclado>();
    }
    void Start()
    {
        
    }
    void Update()
    {
        ProcessarDisparo();
    }
    void ProcessarDisparo()
    {
        if (joystickTeclado.ataque || joystickTeclado.pulo && Time.time >= proximoDisparo)
        {
            proximoDisparo = Time.time + cadenciaDisparo;
            Instantiate(
                missil,
                new Vector3(
                    origemDisparo.transform.position.x,
                    origemDisparo.transform.position.y,
                    origemDisparo.transform.position.z),
                    Quaternion.identity                
            );
        }
    }
}
