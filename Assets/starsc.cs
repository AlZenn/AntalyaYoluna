using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class starsc : MonoBehaviour
{
    // Start is called before the first frame update
    public float lifetime = 8f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        lifetime = lifetime - Time.deltaTime;
        Debug.Log(lifetime);
        if (lifetime <= 0)
        {
            Destroy(gameObject);
        }
    }
}
