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
        // Obt�n el valor de entrada del usuario (por ejemplo, mediante un slider)
        float inputIntensity = GetInputIntensity();

        // Ajusta el valor de intensidad dentro del rango m�nimo y m�ximo
        currentIntensity = Mathf.Lerp(minIntensity, maxIntensity, inputIntensity);

        // Actualiza la intensidad de las part�culas
        ParticleSystem.EmissionModule emission = particleSystem.emission;
        emission.rateOverTime = currentIntensity;
    }

    private float GetInputIntensity()
    {
        // Implementa la l�gica para obtener el valor de entrada del usuario.
        // Esto podr�a ser mediante un slider UI, una entrada de teclado o cualquier otro m�todo de tu elecci�n.
        // Devuelve un valor normalizado entre 0 y 1 que representa la intensidad deseada.
        // Por ejemplo, si usas un Slider UI, puedes usar slider.value.normalized.
        return 0.5f; // Valor de ejemplo, reempl�zalo con tu propia l�gica de entrada.
    }
}
