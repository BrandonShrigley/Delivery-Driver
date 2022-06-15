using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision : MonoBehaviour
{
     void OnCollisionEnter2D(Collision2D other) 
    {
        Debug.Log("i hit you haha you're shit");
    }
    private void OnTriggerEnter2D(Collider2D other) {
        Debug.Log("ihit you number2");
    }
}
