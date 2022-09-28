using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodRandom : MonoBehaviour
{
    public float XSize = 13.5f;
    public float ZSize = 50f;

    public GameObject foodPrefab;

    public Vector3 currentPosition;

    public GameObject currentFood;
    
    
    void AddNewFood()
    {
        RandomPosition();
        currentFood = GameObject.Instantiate(foodPrefab, currentPosition, Quaternion.identity) as GameObject;
    }

    void RandomPosition()
    {
        currentPosition = new Vector3(Random.Range(XSize * -1, XSize), 0.5f, Random.Range(ZSize, ZSize + 400));

    }

    
    void Update()
    {
        if (!currentFood)
        {
            AddNewFood();
        }
        else
        {
            return;
        }
    }
}
