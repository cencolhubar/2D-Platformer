using UnityEngine;
using System.Collections;

public class DeathTrigger : MonoBehaviour {
    private SpawnManager gameController;
    // Use this for initialization
    void Start () {

	}
	
	// Update is called once per frame
	void Update () {

        //Gets a reference to game controller so the score can be updated 
        GameObject gameControllerObject = GameObject.FindWithTag("GameController");
        if (gameControllerObject != null)
        {
            gameController = gameControllerObject.GetComponent<SpawnManager>();
        }
        if (gameController == null)
        {
            Debug.Log("Cannot find 'GameController' Script");
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {

        
        
        if (other.gameObject.CompareTag("Player"))
        {
            gameController.lives--;
            gameController.UpdateLives();
            if (gameController.lives > 0) {

                GameObject player = other.gameObject;

                player.GetComponent<Transform>().position = new Vector3(0,10, 0);

           }
            if (gameController.lives == 0)
            {
                gameController.GameOver();
                

            }
        }
    }
}
