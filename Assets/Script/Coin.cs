using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    public static Coin instance;
    public float interval = 5;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    void Awake()
    {
        if(instance == null)
        {
            instance = this;
        }
 
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.forward * 20 * Time.deltaTime);
        
    }
    public void ds()
    {
        Destroy(gameObject);
    }
}
