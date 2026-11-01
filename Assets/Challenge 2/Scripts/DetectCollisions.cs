using System.Collections;
using System.Collections.Generic;
using Unity.Collections.Tests.CoreCLR.TestJobs;
using Unity.VisualScripting;
using UnityEngine;

public class DetectCollisions : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Dog")
        {
            GameObject gameManager = GameObject.Find("GameManager");
            GameManager gameManagerScript = gameManager.GetComponent<GameManager>();
            gameManagerScript.ScaleDog = gameManagerScript.ScaleDog + 4;
            GameObject dog = other.gameObject;
            dog.transform.localScale = new Vector3(gameManagerScript.ScaleDog,gameManagerScript.ScaleDog,gameManagerScript.ScaleDog);    
        }
        Destroy(gameObject);
    }
}
