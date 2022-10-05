using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Block : MonoBehaviour
{

    public int Number;
    private Material _material;    

    public TextMeshPro RandomNumber;

    public int randomCount; // Block`s Lives
      
        

    public int minRandom;
    public int maxRandom;     

    void Start()
    {
        //GameObject go = GameObject.Find("SnakeHead");
        //SnakeController snakeController = go.GetComponent<SnakeController>();
        //int snakeLives = SnakeController.tailObjects;

        randomCount = Random.Range(minRandom, maxRandom);

        RandomNumber.text = randomCount.ToString();

        _material = GetComponentInParent<MeshRenderer>().material;        

    }

    void FixedUpdate()
    {
        _material.SetFloat("Vector1_c9d757926bba47b0af7a9200a5fdb441", randomCount);
    }
            


    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("SnakeHead"))
        {
            for (int i=0; i<randomCount; i++)
            {
                other.GetComponent<SnakeController>().LoseTail();

                GameManager.singleton.AddScore(5);
            }    
            //randomCount - tailObjects;
            

        }
    }
}
