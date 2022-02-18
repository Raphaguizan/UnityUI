using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(ParticleSystem))]
public class ParticleClick : MonoBehaviour
{
    private ParticleSystem _particleSystem;

    private void Awake()
    {
        _particleSystem = GetComponent<ParticleSystem>();
    }

    private void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            _particleSystem.transform.position = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            _particleSystem.Play();
        }
    }
}
