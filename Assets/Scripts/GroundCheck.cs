using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundCheck : MonoBehaviour
{
    public GameObject Player;
    public string GroundTag;

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.CompareTag(GroundTag))
        {
            Player.GetComponent<PlayerController>().Jumping = false;
        }
    }

    public void OnTriggerExit(Collider collision)
    {
        if (collision.gameObject.CompareTag(GroundTag))
        {
            Player.GetComponent<PlayerController>().Jumping = true;
        }
    }
}
