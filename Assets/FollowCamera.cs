using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{

    //Camera position should be the same as the cars position
    [SerializeField] GameObject deliveryCar;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = deliveryCar.transform.position + new Vector3 (0,0,-10);
    }
}
