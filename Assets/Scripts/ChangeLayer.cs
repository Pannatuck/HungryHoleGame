using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeLayer : MonoBehaviour
{
    public int LayerOnEnter; // When object enters hole (OjbectInHole layer)
    public int LayerOnExit; // When object exits hole (OjbectOnTable layer)

    private void OnTriggerEnter(Collider other)
    {
        //if (other.gameObject.tag == "Player")
        //{
            other.gameObject.layer = LayerOnEnter; // this is the layer in Unity DROPDOWN LIST IN EDITOR
        //}
    }
    
    private void OnTriggerExit(Collider other)
    {
        //if (other.gameObject.tag == "Player")
        //{
            other.gameObject.layer = LayerOnExit; // this is the layer in Unity DROPDOWN LIST IN EDITOR
        //}
    }
}
