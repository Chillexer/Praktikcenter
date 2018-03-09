using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

    bool GameHasEnded = false;

    public float RestartDelay = 1f;
    //Brugt til kalde Restart metoden når spillet er tabt
	public void EndGame ()
    {
        if (GameHasEnded == false)
        {
            GameHasEnded = true;
            Debug.Log("Game over!!");
            Invoke("Restart", RestartDelay);
        }
    }
    //Brugt til at genstarte spil
    void Restart ()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
