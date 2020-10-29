using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class BGMoving : MonoBehaviour
{


    // Bird bird = new Bird();
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Bird.gameOver == true)
        {
            return;
        }
        if (transform.position.x <= -20.24)
        {
            transform.position = new Vector3(20.24f, 0f, 0f);
            
            GameControl.instance.creatCoin();
            Coin.instance.ds();
        }
        transform.position = Vector2.MoveTowards(transform.position, Vector3.left * 50, 5 * Time.deltaTime);
    }
}
