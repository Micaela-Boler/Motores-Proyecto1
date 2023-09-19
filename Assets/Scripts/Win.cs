using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class Win : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI pantallaVictoria;

    private void OnCollisionEnter(Collision collision)
    {
        if (!collision.gameObject.CompareTag("Jugador")) return;
        pantallaVictoria.enabled = true;
        Time.timeScale = 0;
    }


    void Start()
    {
        pantallaVictoria.enabled = false;
    }


    void Update()
    {
        if (!Input.GetMouseButtonDown(0)) return;
        Time.timeScale = 1;
        SceneManager.LoadScene(0);
    }
}
