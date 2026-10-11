using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    public float Interval = 0;
    [SerializeField] private GameObject camera1; 
    [SerializeField] private GameObject camera2; 

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
        if (Input.GetKeyDown(KeyCode.C))
        {
            camera2.SetActive(true);
            camera1.SetActive(false);
        }
    }
}
