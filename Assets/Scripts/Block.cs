using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block : MonoBehaviour
{
    public int Number;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("SnakeHead"))
        {
            other.GetComponent<SnakeController>().LoseTail();
            
        }
    }
}
