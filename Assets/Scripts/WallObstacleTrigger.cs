using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallObstacleTrigger : MonoBehaviour
{

    [SerializeField] private GameObject LosePanel;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("SnakeHead"))
        {
            LosePanel.SetActive(true);            
            other.GetComponent<GameManager>().EndGame();
            Debug.Log("Game Over");

        }
    }
}
