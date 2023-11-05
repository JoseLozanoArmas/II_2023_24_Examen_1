using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio2 : MonoBehaviour
{
    public float speed;
    public float forwardSpeed;
    public Vector3 moveDirecction;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalMovement = Input.GetAxis("Horizontal");
        float verticalMovement = Input.GetAxis("Vertical");
        moveDirecction = new Vector3(horizontalMovement * speed * 0.1f, 0, 0);
        transform.Translate(moveDirecction);
        Vector3 forwardDirecction = -transform.forward;
        forwardDirecction.Normalize();
        Vector3 desplazamiento = forwardDirecction * forwardSpeed * Time.deltaTime;
        transform.Translate(desplazamiento);
    }
}
