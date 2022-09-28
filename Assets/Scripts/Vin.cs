using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vin : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        GameManager.singleton.NextLevel();
    }
}
