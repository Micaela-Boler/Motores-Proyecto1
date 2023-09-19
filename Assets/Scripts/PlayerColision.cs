using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class Colision : MonoBehaviour
{
    int puntos;
    int cantidadDePuntos;

    [SerializeField] TextMeshProUGUI puntosInterfaz;


    void updateScore()
    {
        puntosInterfaz.text = puntos.ToString() + "/" + cantidadDePuntos.ToString();
    }


    private void OnCollisionEnter(Collision miCollision)
    {
        if (miCollision.gameObject.CompareTag("Coleccionable"))
        {
            Destroy(miCollision.gameObject);

            puntos++;
            updateScore();
        }

        if (miCollision.gameObject.CompareTag("Enemigo"))
            SceneManager.LoadScene(0);
    }


    void Start()
    {
        cantidadDePuntos = GameObject.FindGameObjectsWithTag("Coleccionable").Length;
        updateScore();
    }
}
