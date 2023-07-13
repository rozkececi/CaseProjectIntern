using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        PlayerInventory playerInventory = other.GetComponent<PlayerInventory>();


        if(playerInventory != null) // Eðer tetikleyiciyle çarpýþan nesne bir PlayerInventory bileþenine sahipse
        {
            playerInventory.BallCollected(); // PlayerInventory bileþenindeki BallCollected metodunu çaðýrarak top toplama iþlemini gerçekleþtirir.
            gameObject.SetActive(false); // Tetikleyici nesneyi devre dýþý býrakýr.
        }
    }
    }

