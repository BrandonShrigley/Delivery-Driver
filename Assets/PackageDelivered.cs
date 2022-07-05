using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PackageDelivered : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Package")
        {
            Debug.Log("Packaged picked up");
        }
    }
}
