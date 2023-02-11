using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundCheck : MonoBehaviour
{
    public GameObject Player;
    public string GroundTag;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag(GroundTag))
        {
            Player.GetComponent<PlayerController>().Jumping = false;
        }
    }

    public void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag(GroundTag))
        {
            Player.GetComponent<PlayerController>().Jumping = true;
        }
    }
}
