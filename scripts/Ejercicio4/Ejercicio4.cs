using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio4 : MonoBehaviour
{
    public GameObject Zombie;
    public GameObject Table;
    public float distanceWithZombie;
    public float distanceWithChair;
    bool pot_flag = true;
    bool chair_flag = true;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(Vector3.Distance(Zombie.transform.position, Table.transform.position));
        if (Vector3.Distance(Zombie.transform.position, Table.transform.position) < distanceWithZombie) {
            if (gameObject.tag == "Pot" && pot_flag == true) {
              Vector3 moveDirecction = GenerateRandomPlace();
              transform.position = moveDirecction;
              pot_flag = false;
            }
            if (gameObject.tag == "Chair" && chair_flag == true) {
                Vector3 moveDirecction = new Vector3(Zombie.transform.position.x - distanceWithChair, Zombie.transform.position.y, Zombie.transform.position.z - distanceWithChair);
                transform.position = moveDirecction;
                chair_flag = false;
            }
        }
        
    }

    private Vector3 GenerateRandomPlace() {
        float new_x = Random.Range(-100.0f, 100.0f);
        float new_y = -157.0f;
        float new_z = Random.Range(-100.0f, 100.0f);
        Vector3 vector = new Vector3(new_x, new_y, new_z);
        return vector;
    }
}
