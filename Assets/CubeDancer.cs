using System;
using UnityEngine;

public class CubeDancer : MonoBehaviour
{
    private float finalSize;
    public float shrinkSpeed = 3;
    public float size = 5;
    public float power = 3;

    public AudioVisualizer visualizer;
    
    public void Update()
    {
        var musicPower = (1 + MathF.Pow(visualizer.average, power) * size);

        if (musicPower > finalSize)
        {
            finalSize = musicPower;
        }
        else
        {
            finalSize -= shrinkSpeed * Time.deltaTime;
        }
        
        transform.localScale = Vector3.one * finalSize;
        
        transform.Rotate(musicPower,musicPower,musicPower);
    }
}
