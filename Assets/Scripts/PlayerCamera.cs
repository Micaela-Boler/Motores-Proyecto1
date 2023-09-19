using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCamera : MonoBehaviour
{

    public Transform playerPosition; // posici�n del jugador

    public float distance; // Distancia entre el jugador y la c�mara
    //private float angle; //�ngulo de la c�mara


    void Start()
    {
        
    }

    
    void LateUpdate()
    {
        transform.position = playerPosition.position + new Vector3(0,0, - distance); // actualizamos la posici�n del player
    }
}
