using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Platform CurrentPlatform;
    [SerializeField] private float _bounceSpeed;
    [SerializeField] private Rigidbody _rigidbody;
    [SerializeField] private AudioSource _audio;
    [SerializeField] private ParticleSystem _particle;
    
    public Game Game;

    public void ReachFinish()
    {
        Game.OnPlayerReachFinish();
        _rigidbody.velocity = Vector3.zero;
    }

    public void Bounce()
    {
        _rigidbody.velocity = new Vector3(0, _bounceSpeed, 0);
        _audio.Play();
        _particle.Play();
    }

    public void Die()
    {
        Game.OnPlayerDied();
        _rigidbody.velocity = Vector3.zero;
    }
}
