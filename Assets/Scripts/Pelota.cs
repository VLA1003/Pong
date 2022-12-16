using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pelota : MonoBehaviour
{
    [SerializeField]
    Vector3 direccion;

    [SerializeField]
    public float velocidad = 1.5f;

    private void Start()
    {
        direccion = Vector3.right;
        direccion.y = Random.Range(-1, 1);
    }

    private void Update()
    {
        transform.position += direccion * Time.deltaTime * velocidad;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "jugador")
        {
            direccion.x = direccion.x * -1;
        }

        if (collision.gameObject.tag == "borde")
        {
            direccion.y = direccion.y * -1;
        }

        //Debug.Log("La pelota ha chocado con el " + collision.collider.gameObject.name);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        transform.position = Vector3.zero;
        if (collision.gameObject.tag == "porteria1")
        {
            //Debug.Log("¡Gol del jugador 2!");
            Marcador.instance.GolesJugador2();
        }
        if (collision.gameObject.tag == "porteria2")
        {
            //Debug.Log("¡Gol del jugador 1!");
            Marcador.instance.GolesJugador1();
        }
    }
}
