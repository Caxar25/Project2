using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    public float Interval = 0;
    private bool isCamera1 = true;
    [SerializeField] private float speed;
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
                GameObject dog = Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
                
            } 
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector3.right * Time.deltaTime * speed);  
        }
        if (Input.GetKey(KeyCode.A))
        {
                transform.Translate(Vector3.left * Time.deltaTime * speed);  
        }
        if (Input.GetKeyDown(KeyCode.C))
        {
            if (isCamera1 == true)
            {
                isCamera1 = false;
                camera2.SetActive(true);
                camera1.SetActive(false);
            } 
            else
            {
                isCamera1 = true;
                camera2.SetActive(false);
                camera1.SetActive(true);
            }   
        }
    }
}
