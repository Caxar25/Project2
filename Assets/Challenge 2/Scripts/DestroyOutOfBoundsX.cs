using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBoundsX : MonoBehaviour
{
    private float leftLimit = -49;
    private float bottomLimit = -1;

    void Update()
    {
        // Уничтожаем префаб, если он перешёл левые границы
        if (transform.position.x < leftLimit)
        {
            Destroy(gameObject);
        }
        // Уничтожаем префаб, если он перешёл нижние границы
        else if (transform.position.y < bottomLimit)
        {
            Destroy(gameObject);
        }

    }

}
