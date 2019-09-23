using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Number : MonoBehaviour {
    public GameObject keypad;
    /////// set VR here
    /// for now mouse click
   /* private void OnMouseDown()
    {
        keypad.GetComponent<Code>().Receiver(gameObject);
    }*/
    private void OnCollisionEnter(Collision collision)
    {
        keypad.GetComponent<Code>().Receiver(gameObject);
    }
}
