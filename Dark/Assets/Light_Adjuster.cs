using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Light_Adjuster : MonoBehaviour
{
    public Light my_light;

    // Range Variables
    public bool change_range = false;
    public float range_speed = 1.0f;
    public float max_range = 10.0f;

    //Intensity Variables
    public bool change_intensity = false;
    public float range_intensity = 1.0f;
    public float max_intensity = 10.0f;

    float start_time;
  
    // Start is called before the first frame update
    void Start()
    {
        my_light = GetComponent<Light>();
        start_time = Time.time;
        
    }

    // Update is called once per frame
    void Update()
    {
        if (change_range)
        { 
            my_light.range = Mathf.PingPong(Time.time * range_speed, max_range);
        }

        if (change_intensity)
        {
            my_light.range = Mathf.PingPong(Time.time * range_intensity, max_intensity);
        }

    }
}
