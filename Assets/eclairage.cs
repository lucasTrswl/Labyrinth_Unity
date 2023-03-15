using UnityEngine;

public class DynamicLighting : MonoBehaviour
{
    public Light[] lights;
    public Color baseColor;
    public float maxIntensity = 1f;
    public float minIntensity = 0.2f;
    public float flickerSpeed = 0.1f;
    public float flickerIntensity = 0.2f;

    private Transform player;
    private float distance;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }

    void Update()
    {
        distance = Vector3.Distance(player.position, transform.position);

        // Modifier la couleur et l'intensité de la lumière en fonction de la distance du joueur
        foreach (Light light in lights)
        {
            float intensity = Mathf.Lerp(maxIntensity, minIntensity, distance / 20f);
            light.intensity = intensity;

            float flicker = Random.Range(-flickerIntensity, flickerIntensity);
            light.color = baseColor + new Color(flicker, flicker, flicker);
        }
    }
}
