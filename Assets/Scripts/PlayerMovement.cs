using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class circulo : MonoBehaviour
{
    [Header("Ejes de movimientos")]
    private float horizontalInput;
    private float verticalInput;
    private Vector3 vectorMovement;

    //[Header("AddForce")]
    //public Rigidbody _rb;
    //private float force;

    [Header("Velocidad de movimientos")]
    public float speed;


    void Update()
    {
        /*
       if (Input.GetKey(KeyCode.W))
           transform.Translate(Vector3.forward * Time.deltaTime * speed);

       if (Input.GetKey(KeyCode.S))
           transform.Translate(Vector3.back * Time.deltaTime * speed);

       if (Input.GetKey(KeyCode.D))
       transform.Translate(Vector3.right * Time.deltaTime * speed);

       if (Input.GetKey(KeyCode.A))
       transform.Translate(Vector3.left * Time.deltaTime * speed);
       */

        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");
        vectorMovement = new Vector3(horizontalInput, 0f, verticalInput);

        vectorMovement.Normalize(); // cuando nos movemos en diagonal no va más rápido

        transform.Translate(vectorMovement * Time.deltaTime * speed);

        //_rb.AddForce(vectorMovement.normalized * speed * force, ForceMode.Force);
    }
}
