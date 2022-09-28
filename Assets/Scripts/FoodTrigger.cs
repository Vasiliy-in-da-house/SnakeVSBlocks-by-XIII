using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodTrigger : MonoBehaviour
{
  void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("SnakeHead"))
        {
            other.GetComponent<SnakeController>().AddTail();
            Destroy(gameObject);
        }
    }   
}
