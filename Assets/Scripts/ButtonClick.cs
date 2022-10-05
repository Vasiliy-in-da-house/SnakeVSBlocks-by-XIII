using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonClick : MonoBehaviour
{
    public bool Audio;

    public void OnClickEnter()
    {
        GetComponent<AudioSource>().Play();
    }


}

