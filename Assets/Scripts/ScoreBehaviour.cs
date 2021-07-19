using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreBehaviour : MonoBehaviour
{
    public delegate void ScoreUpOnPass();
    public static event ScoreUpOnPass onCollissionEntered;
    
    private void OnCollisionEnter(Collision collision)
    {
        onCollissionEntered?.Invoke();
    }
}
