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
            GameObject dog = other.gameObject;
            MoveForwardX MFX = dog.GetComponent<MoveForwardX>();
            MFX.dogSize = MFX.dogSize + 30;
            dog.transform.localScale = dog.transform.localScale + new Vector3(MFX.dogSize,MFX.dogSize,MFX.dogSize);    
        }
        Destroy(gameObject);
    }
}
