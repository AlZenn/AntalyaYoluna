using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarSpawner : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject[] stars;
    public float x1, x2;
    void Start()
    {
        x1 = transform.position.y - GetComponent<BoxCollider2D>().bounds.size.y / 2f;
        x2 = transform.position.y + GetComponent<BoxCollider2D>().bounds.size.y / 2f;
        
        StartCoroutine(Clone(3f)); // fonskiyon adı ve kaç sn de çağırılacağı
    }

    IEnumerator Clone(float time)
    {
        yield return new WaitForSeconds(time);
        Instantiate(stars[Random.Range(0, stars.Length)],
            new Vector3(transform.position.x,Random.Range(x1,x2),transform.position.z),
            Quaternion.identity);
        
        StartCoroutine(Clone(8f)); 
    }
}
