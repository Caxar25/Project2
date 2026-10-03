using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    public float Interval = 0;

    void Update()
    {
        Interval = Interval + Time.deltaTime;
        if (Interval >= 1)
        {
             // Создаем собаку, нажимая на пробел
            if (Input.GetKeyDown(KeyCode.Space))
            {
                Interval = 0;
                Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
            } 
        }
    }
}
