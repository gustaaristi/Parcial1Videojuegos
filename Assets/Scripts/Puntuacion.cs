using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class Puntuacion : MonoBehaviour
{
    private int puntuacion = 0;
    public TextMesh marcador;
    // Start is called before the first frame update
    void Start()
    {
        ActualizarMarcado();
    }

   
    

    public void IncrementarPuntos(Notification notification)
    {
        int puntosAIncrementar = (int)notification.data;
        puntuacion += puntosAIncrementar;
        ActualizarMarcado();

    }

    void ActualizarMarcado()
    {
        marcador.text = puntuacion.ToString();
    }
}
