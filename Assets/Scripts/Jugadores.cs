using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jugadores : MonoBehaviour
{
    [SerializeField]
    KeyCode botonArriba;
    [SerializeField]
    KeyCode botonbajo;
    [SerializeField]
    public float velocidadJugador = 5f;

    private void Update()
    {
        if (Input.GetKey(botonArriba))
        {
            transform.position += Vector3.up * Time.deltaTime * velocidadJugador;
        }

        if (Input.GetKey(botonbajo))
        {
            transform.position += Vector3.down * Time.deltaTime * velocidadJugador;
        }
    }
}
