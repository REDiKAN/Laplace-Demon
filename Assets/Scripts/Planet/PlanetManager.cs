using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlanetManager : MonoBehaviour
{
    const float gravituConst = 0.67f;
    [SerializeField] public GameObject[] affectors;
    Rigidbody2D body;
    float dist;
    uint i;

    private void Start()
    {
        body = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        for (int i = 0; i < affectors.Length; i++)
        {
            dist = Vector2.Distance(transform.position, affectors[i].transform.position);
            body.AddForce(((affectors[i].transform.position - transform.position) / dist) * 
                (body.mass * affectors[i].GetComponent<Rigidbody2D>().mass * gravituConst) / (dist * dist + 1));
        }
    }
}
