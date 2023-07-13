using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PlayerInventory : MonoBehaviour

{
    public float gettingSize = 0.1f;
    //karakterin zulasýndaki top sayýsýný bildiriyor
    public int NumberOfBalls { get; private set; }

    public UnityEvent<PlayerInventory> OnBallCollected;

    public void BallCollected()
    {
        NumberOfBalls++;
        OnBallCollected.Invoke(this); // Top toplandýðýnda OnBallCollected olayýný tetikler ve bu PlayerInventory örneðini iletir
        Vector3 newSize = transform.localScale + new Vector3(gettingSize, gettingSize, gettingSize); // Karakterin ölçeðini büyütür
        transform.localScale = newSize;
    }

}
