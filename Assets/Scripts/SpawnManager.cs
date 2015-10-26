﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class SpawnManager : MonoBehaviour {
    private bool spawn= true;
    public int maxPlatforms = 100;
    public GameObject platform;
    public float horizontalMin;
    public float horizontalMax;
    public float verticalMin;
    public float verticalMax;
    public GameObject Bird1;
    public GameObject Bird2;
    public GameObject Bird3;
    public GameObject Bird4;

    public Vector3 spawnValues;
    public int hazardCount;
    public float spawnWait;
    public float startWait;
    public float waveWait;


    public Text scoreText;
    public Text restartText;
    public Text gameOverText;
    public Text Timer;
    public int time;

    private bool gameOver;
    private bool restart;
    private int score;
    private bool bird = false;


    private Vector2 originPosition;

    // Use this for initialization
    void Start () {
        originPosition = new Vector2(0, -5);
        Spawn();
        StartCoroutine(SpawnWaves());
    }
	

    void Spawn()
    {
         for (int i = 0; i < maxPlatforms; i++)
        //if(spawn)
        {
            Vector2 randomPosition = originPosition + new Vector2(Random.Range(horizontalMin, horizontalMax), 0);
            Instantiate(platform, randomPosition, Quaternion.identity);
        //    Instantiate(Bird1, randomPosition, Quaternion.identity);
          //  Instantiate(Bird2, randomPosition, Quaternion.identity);
          //  Instantiate(Bird3, randomPosition, Quaternion.identity);
         //   Instantiate(Bird4, randomPosition, Quaternion.identity);
            originPosition = randomPosition;
        }
    }


    IEnumerator SpawnWaves()
    {
        yield return new WaitForSeconds(startWait);
        while (true)
        {
            /*
            if (bird == false)
            {

                temphazard = hazard;
                bird = true;
            }
            else if (bird == true)
            {

                temphazard = hazard3;
                bird = false;
            }
            */
            for (int i = 0; i < hazardCount; i++)
            {


                Vector3 spawnPosition1 = new Vector3(spawnValues.x, Random.Range(-spawnValues.y, spawnValues.y), spawnValues.z);
                Vector3 spawnPosition2 = new Vector3(spawnValues.x, Random.Range(-spawnValues.y, spawnValues.y), spawnValues.z);
                Vector3 spawnPosition3 = new Vector3(spawnValues.x, Random.Range(-spawnValues.y, spawnValues.y), spawnValues.z);
                Vector3 spawnPosition4 = new Vector3(spawnValues.x, Random.Range(-spawnValues.y, spawnValues.y), spawnValues.z);

                // Debug.Log("spawn pos"+spawnPosition.x);

                // Debug.Log("spawn pos"+spawnPosition.x);


                // Debug.Log("spawn pos"+spawnPosition.x);


                // Debug.Log("spawn pos"+spawnPosition.x);
                Quaternion spawnRotation = Quaternion.identity;

                Instantiate(Bird1, spawnPosition1, spawnRotation);
                Instantiate(Bird2, spawnPosition2, spawnRotation);
                Instantiate(Bird3, spawnPosition3, spawnRotation);
                Instantiate(Bird4, spawnPosition4, spawnRotation);

                yield return new WaitForSeconds(spawnWait);
            }
            yield return new WaitForSeconds(waveWait);

            if (gameOver)
            {
                restartText.text = "Press 'R' for Restart";
                restart = true;
                break;
            }
        }
    }

    // Update is called once per frame
    void Update () {
     //   Spawn();
    }


    //updates the score
    public void AddScore(int newScoreValue)
    {
        score += newScoreValue;
        UpdateScore();
    }


    //Displays the new score to the UI
    void UpdateScore()
    {
        scoreText.text = "Score: " + score;
    }


    //Sets game as ended
    public void GameOver()
    {
        gameOverText.text = "Game Over!";
        gameOver = true;
    }
}
