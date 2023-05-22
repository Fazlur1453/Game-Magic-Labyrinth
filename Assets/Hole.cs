using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Hole : MonoBehaviour
{
    [SerializeField] private AudioSource SFX;

    [SerializeField] private AudioSource BGM;

    public UnityEvent OnBallEnter = new UnityEvent();

    private void OnCollisionEnter (Collision other)
    {
        OnTriggerEnter(other.collider);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Ball"))
        {
            OnBallEnter.Invoke();

            SFX.Play();

            BGM.Stop();
        }
        
    }
    

    
}
