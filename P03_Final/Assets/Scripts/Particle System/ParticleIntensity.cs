using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleIntensity : MonoBehaviour
{
    [SerializeField] private new ParticleSystem[] particleSystem;
    public float valor;

    private void Start()
    {
        Intensity(valor);
    }

    public void OnOff(float rate)
    {
        foreach (ParticleSystem particle in particleSystem)
        {
            ParticleSystem.EmissionModule emission;
            emission = particle.emission;
            emission.rateOverTime = rate;
        }
    }

    public void Intensity(float intens)
    {
        foreach (ParticleSystem particle in particleSystem)
        {
            ParticleSystem.EmissionModule emission;
            emission = particle.emission;
            emission.rateOverTime = intens;
        }
    }

}
