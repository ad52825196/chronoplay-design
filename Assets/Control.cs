using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Control : MonoBehaviour {

	public void LoadScene(string name) {
        SceneManager.LoadScene(name);
    }

    public void Exit() {
        Application.Quit();
    }
}
