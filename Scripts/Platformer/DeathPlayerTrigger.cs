using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathPlayerTrigger : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.TryGetComponent(out Platformer.Player player))
        {
            Debug.Log(collision.gameObject.name + " died!");
            collision.collider.enabled = false;
        }
    }
}
