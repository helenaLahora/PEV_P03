using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleIntensity : MonoBehaviour
{
    public ParticleSystem particleSystem;
    public float minIntensity = 0.1f;
    public float maxIntensity = 1.0f;

    private float currentIntensity;

    private void Start()
    {
        currentIntensity = particleSystem.emission.rateOverTime.constant;
    }

    private void Update()
    {
        // Obtén el valor de entrada del usuario (por ejemplo, mediante un slider)
        float inputIntensity = GetInputIntensity();

        // Ajusta el valor de intensidad dentro del rango mínimo y máximo
        currentIntensity = Mathf.Lerp(minIntensity, maxIntensity, inputIntensity);

        // Actualiza la intensidad de las partículas
        ParticleSystem.EmissionModule emission = particleSystem.emission;
        emission.rateOverTime = currentIntensity;
    }

    private float GetInputIntensity()
    {
        // Implementa la lógica para obtener el valor de entrada del usuario.
        // Esto podría ser mediante un slider UI, una entrada de teclado o cualquier otro método de tu elección.
        // Devuelve un valor normalizado entre 0 y 1 que representa la intensidad deseada.
        // Por ejemplo, si usas un Slider UI, puedes usar slider.value.normalized.
        return 0.5f; // Valor de ejemplo, reemplázalo con tu propia lógica de entrada.
    }
}
