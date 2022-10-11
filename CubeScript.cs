using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("SPAWN");
    }

    // Update is called once per frame
    void Update()
    {
         float step = Spawner.speed * Time.deltaTime;
         transform.position = Vector3.MoveTowards(transform.position, Spawner.target, step);
        if (transform.position.x >= Spawner.target.x)
        {
            Destroy(gameObject);
        }
    }
}
