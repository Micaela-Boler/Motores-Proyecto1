using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCamera : MonoBehaviour
{

    public Transform playerPosition; // posición del jugador

    public float distance; // Distancia entre el jugador y la cámara
    //private float angle; //àngulo de la cámara


    void Start()
    {
        
    }

    
    void LateUpdate()
    {
        transform.position = playerPosition.position + new Vector3(0,0, - distance); // actualizamos la posición del player
    }
}
