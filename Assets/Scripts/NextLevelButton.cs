using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLevelButton : MonoBehaviour
{
    public void Level(int _sceneNumber)
    {
        SceneManager.LoadScene(_sceneNumber);
    }
}

