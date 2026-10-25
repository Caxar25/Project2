using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForwardX : MonoBehaviour
{
    public float speed;
    public int dogSize;
    void Start()
    {
        transform.localScale = new Vector3(dogSize,dogSize,dogSize);   
    }

    void Update()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }
}
