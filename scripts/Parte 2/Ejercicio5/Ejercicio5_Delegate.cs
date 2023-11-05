using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio5_Delegate : MonoBehaviour
{
    public delegate void CollisionEvent();
    public event CollisionEvent MoveSpiders;
    private void OnCollisionEnter(Collision other) {
        if (other.gameObject.tag != "Zombie") { return; }
        if (other.gameObject.tag == "Zombie") {
            MoveSpiders?.Invoke();
        }
    }
}
