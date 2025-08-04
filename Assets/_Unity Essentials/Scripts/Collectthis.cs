using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectthis : MonoBehaviour
{
    
    
    public float rotationSpeed;
    public GameObject onCollectEffect;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, rotationSpeed, 0);
    }
    public void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);      
    }

}
