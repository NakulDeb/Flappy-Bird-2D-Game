using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinMV : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Bird.gameOver == true)
        {
            return;
        }
        if (transform.position.x <= -20.24)
        {
            transform.position = new Vector3(20.24f, 0f, 0f);
        }
        transform.position = Vector2.MoveTowards(transform.position, Vector3.left * 50, 5 * Time.deltaTime);
    }
}
