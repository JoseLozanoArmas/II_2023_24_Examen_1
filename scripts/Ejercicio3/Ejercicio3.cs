using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio3 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.T) == true) {
            Vector3 moveDirecction = GenerateRandomPlace();
            transform.position = moveDirecction;
        }
    }

    private Vector3 GenerateRandomPlace() {
        float new_x = Random.Range(-100.0f, 200.0f);
        float new_y = -157.0f;
        float new_z = Random.Range(-100.0f, 200.0f);
        Vector3 vector = new Vector3(new_x, new_y, new_z);
        return vector;
    }    
}
