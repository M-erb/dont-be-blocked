using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {

	bool gameHasEnded = false;
	public float restartDelay = 2f;
	public Text messageBoard;
	public GameObject completeLevelUI;

	public void CompleteLevel () {
		completeLevelUI.SetActive(true);
	}
	
	public void EndGame (string message) {
		if (message.Length <= 0) {
			message = "You've been BLOCKED FOO!";
		}

		if (gameHasEnded == false) {
			// End the game
			gameHasEnded = true;
			Debug.Log(message);
			messageBoard.text = message;

			// Restart game
			Invoke("Restart", restartDelay);
		}
	}

	void Restart() {
		SceneManager.LoadScene(SceneManager.GetActiveScene().name);
	}

}
