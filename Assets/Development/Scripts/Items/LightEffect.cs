using System.Collections;
using UnityEngine;
using UnityEngine.Rendering.Universal;

public class LightEffect : MonoBehaviour
{
    private Light2D _light2D;
    private IEnumerator lightCoroutine;

    private void Start()
    {
        _light2D = GetComponent<Light2D>();
    }
    public void StartLightEco()
    {
        if (lightCoroutine == null)
        {
            lightCoroutine = lightIntensity();
            StartCoroutine(lightCoroutine);
        }
    }

    public void StopLightEco()
    {
        if (lightCoroutine != null)
        {
            StopCoroutine(lightCoroutine);
            lightCoroutine = null;
            _light2D.intensity = 0.5f;
        }
    }

    private IEnumerator lightIntensity()
    {
        while (true)
        {
            _light2D.intensity = 0.5f;
            yield return new WaitForSeconds(0.3f);
            _light2D.intensity = 2f;
            yield return new WaitForSeconds(0.3f);
        }
    }
}
