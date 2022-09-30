using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class Block : MonoBehaviour
{
    private Material _material;    

    public TextMeshPro RandomNumber;

    public int randomCount; // Block`s Lives    

    public int minRandom;
    public int maxRandom;     

    void Start()
    {
        randomCount = Random.Range(minRandom, maxRandom);

        RandomNumber.text = randomCount.ToString();

        _material = GetComponentInParent<MeshRenderer>().material;        

    }

    void FixedUpdate()
    {
        _material.SetFloat("Vector1_681b2c29e9794d4e95087443f34586bc", randomCount);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("SnakeHead"))
        {
            other.GetComponent<SnakeController>().LoseTail();
            
        }
    }
}
