using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoruController : MonoBehaviour
{
    public GameObject[] borus;
    public Transform Spawnpoint;
    public float boruSpeed = 3f;
    void Start()
    {
        StartCoroutine(BoruSpawner());
    }

    IEnumerator BoruSpawner()
    {
        while (true)
        {
            GameObject boru = Instantiate(borus[Random.Range(0, borus.Length)], Spawnpoint.position, Quaternion.identity);

            
            boru.GetComponent<Rigidbody2D>().velocity = Vector2.left * boruSpeed;
            
            yield return new WaitForSeconds(3f);
        }
    }
    
    


}
