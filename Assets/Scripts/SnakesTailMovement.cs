using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnakesTailMovement : MonoBehaviour
{
    
    public float moveSpeed;    

    public Vector3 tailTarget;

    public int index;

    public GameObject tailTargetObj;

    public SnakeController mainSnake;

    void Start()
    {        
        mainSnake = GameObject.FindGameObjectWithTag("SnakeHead").GetComponent<SnakeController>();
        moveSpeed = mainSnake.runSpeed;
        tailTargetObj = mainSnake.tailObjects[mainSnake.tailObjects.Count - 2];
        index = mainSnake.tailObjects.IndexOf(gameObject);

    }
    
    void Update()
    {
        tailTarget = tailTargetObj.transform.position;      
        transform.LookAt(tailTarget);
        transform.position = Vector3.Lerp(transform.position,tailTarget,Time.deltaTime * moveSpeed); 
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("SnakeHead"))
        {
            if(index > 2)
            {
                other.GetComponent<GameManager>().EndGame();
                Debug.Log("Game Over");               
            }
        }
    }
}
