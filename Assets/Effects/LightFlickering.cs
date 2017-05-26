using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightFlickering : MonoBehaviour {

    public float lightIntensity;
    public float flickerIntensity;
    public float lightTime;
    public float flickerTime;
    public int timedecrement;
    public int lightPower;

    System.Random rg;

    Light flashlight;

    void Awake()
    {
        rg = new System.Random();
        flashlight = GetComponent<Light>();
    }

    void Start()
    {
        StartCoroutine(Flicker());
        InvokeRepeating("timeDown", 1, timedecrement);
    }

    IEnumerator Flicker()
    {
        while (true)
        {
            flashlight.intensity = lightIntensity;

            float lightingTime = lightTime + ((float)rg.NextDouble() - 0.5f);
            yield return new WaitForSeconds(lightingTime);

            int flickerCount = rg.Next(4, 9);

            for (int i = 0; i < flickerCount; i++)
            {
                float flickingIntensity = lightIntensity - ((float)rg.NextDouble() * flickerIntensity);
                flashlight.intensity = flickingIntensity;

                float flickingTime = (float)rg.NextDouble() * flickerTime;
                yield return new WaitForSeconds(flickingTime);
            }
        }
    }

    public void timeDown()
    {
        lightPower--;
        lightIntensity = lightIntensity - 0.1f;
        flickerIntensity = (flickerIntensity / 100) + flickerIntensity;
        lightTime = (lightTime / rg.Next(0, 10)) - lightTime;
    }
}
