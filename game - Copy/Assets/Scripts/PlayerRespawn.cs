using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRespawn : MonoBehaviour
{

    public Transform currentCheckpoint;
    private Health playerHealth;


    private void Awake()
    {
        playerHealth = GetComponent<Health>();
    }

    void Respawn()
    {
        if (playerHealth.currentHealth <= 0)
        transform.position = currentCheckpoint.position;
        playerHealth.Respawn();
    }
    

   

}
