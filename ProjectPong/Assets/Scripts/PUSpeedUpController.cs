using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PUSpeedUpController : MonoBehaviour
{
    public PowerUpManger manager;
    public Collider2D ball;
    public float magnitude;
  
    public void OnTriggerEnter2D(Collider2D collision)
    {   
        if (collision == ball)
        {
            ball.GetComponent<BallController>().ActivetePUSpeedUp(magnitude);
            manager.RemovePowerUp(gameObject);
        } 
    }
}
