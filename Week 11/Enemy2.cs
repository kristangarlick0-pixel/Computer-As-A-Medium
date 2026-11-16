using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy2 : MonoBehaviour
{
    void Start()
    {

    }

    void Update()
    {
        // Move downward
        transform.Translate(new Vector3(0, -1, 0) * Time.deltaTime * 2f);

        // Move side to side
        transform.Translate(new Vector3(Mathf.Sin(Time.time * 3f), 0, 0) * Time.deltaTime * 2f);

        // Destroy when it leaves the screen
        if (transform.position.y < -6.5f)
        {
            Destroy(this.gameObject);
        }
    }
}