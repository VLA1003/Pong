using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Marcador : MonoBehaviour
{
    public static Marcador instance;

    [SerializeField]
    TextMeshProUGUI resultadoJugador1, resultadoJugador2;

    public int golesJugador1, golesJugador2;

    private void Awake()
    {
        if (Marcador.instance == null)
        {
            Marcador.instance = this;
        }
        else
        {
            Destroy(this);
        }
    }

    private void Start()
    {
        golesJugador1 = 0;
        golesJugador2 = 0;
    }

    public void GolesJugador1()
    {
        golesJugador1++;
        resultadoJugador1.text = golesJugador1.ToString();
    }

    public void GolesJugador2()
    {
        golesJugador2++;
        resultadoJugador2.text = golesJugador2.ToString();
    }
}
