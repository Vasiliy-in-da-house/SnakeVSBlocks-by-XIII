using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Finish : MonoBehaviour
{
    [SerializeField] private GameObject WinPanel;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("SnakeHead"))
        {
            WinPanel.SetActive(true);
            other.GetComponent<GameManager>().EndGame();
            Debug.Log("You Win!");
        }
    }
}
