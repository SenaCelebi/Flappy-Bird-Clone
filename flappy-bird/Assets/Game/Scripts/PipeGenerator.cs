using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeGenerator : MonoBehaviour
{
    [SerializeField] GameObject pipesPrefab;
    private int time = 200;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        time++;
        if(time >= 100)
        {
            time = 0;
            GameObject pipe = Instantiate(pipesPrefab, new Vector2(pipesPrefab.transform.position.x, pipesPrefab.transform.position.y + Random.Range(-2, 2)), pipesPrefab.transform.rotation);
            Destroy(pipe, 5);
        }
        
        
    }
}
