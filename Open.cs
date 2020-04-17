using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Open : MonoBehaviour
{
    [SerializeField]
    GameObject switchOff;
    [SerializeField]
    GameObject switchOn;
    //door starts closed
    public bool isOn = false;
    public bool OpenDoor = true;
    private void Start()
    {
        gameObject.GetComponent<SpriteRenderer>().sprite = switchOff.GetComponent<SpriteRenderer>().sprite;
    }
    //trigger sets door open
    private void OnTriggerEnter2D(Collider2D collision)
    {
        gameObject.GetComponent<SpriteRenderer>().sprite = switchOn.GetComponent<SpriteRenderer>().sprite;

        isOn = true;
    }
}
