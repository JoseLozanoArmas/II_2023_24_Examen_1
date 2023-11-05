using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio5_Listener : MonoBehaviour
{
    public Ejercicio5_Delegate[] ej5;
    public GameObject Zombie;
    public float speed;
    public Vector3 moveDirection;


    void Start() {
        foreach(var iterator in ej5) {
            iterator.MoveSpiders += MoveSpiders;
        }
    }

    private void MoveSpiders() {
        InvokeRepeating("MakeThemMove", 0 , 0.01f);
    }

    private void MakeThemMove() {
        Vector3 direcctionToMove = (Zombie.transform.position - transform.position).normalized; // nos quedamos con la posición del objeto a buscar
        moveDirection = direcctionToMove * speed * Time.deltaTime;
        transform.Translate(moveDirection);
    }
}
