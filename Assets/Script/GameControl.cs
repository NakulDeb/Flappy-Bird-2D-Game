using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameControl : MonoBehaviour
{
    public static GameControl instance;
    public GameObject gameOverText;
    public Text scoreText;
    public bool gameOver = false;
    private int score = 0;

    public GameObject coinPrefab;

    // Start is called before the first frame update
    void Awake()
    {
        if(instance == null)
        {
            instance = this;
        }
        else if(instance != this)
        {
            Destroy(gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
 
    }
    public void birdScore()
    {
        score++;
        scoreText.text = "Score: " + score.ToString();
    }

    public void BirdDied()
    {
        gameOverText.SetActive(true);
        gameOver = true;
    }

    public void coinScore()
    {
        score = score + 10;
        scoreText.text = "Score: " + score.ToString();
        GameObject coinObject = Instantiate(coinPrefab);
        coinObject.transform.position = new Vector2(Random.Range(15, 30),Random.Range (-2,5));
        
    }
    public void creatCoin()
    {
        GameObject coinObject = Instantiate(coinPrefab);
        coinObject.transform.position = new Vector2(Random.Range(15, 30), Random.Range(-2, 5));
    }
}

