using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class LevelTraversal : MonoBehaviour
{
    public Animator transition;

    //[SerializeField] private AudioSource click;

    public void LevelNav(string levelName)
    {
        //Time.timeScale = 1f;
        //if (soundOn)
            //click.Play();
        StartCoroutine(LoadLevel(levelName));
    }
    public void FirstLevel()
    {
        FindObjectOfType<GameController>().ResetController();
        Debug.Log("tried");
        StartCoroutine(LoadLevel("GunSelection"));
    }


    public void SettingSelect()
    {
        StartCoroutine(LoadLevel("Settings"));
    }

    public void MainMenuSelect()
    {
        StartCoroutine(LoadLevel("StartMenu"));
    }

    public void Quit()
    {
        Application.Quit();
    }

    IEnumerator LoadLevel(string LevelName)
    {
        transition.SetBool("Start",true);
        yield return new WaitForSeconds(0.6f);
        SceneManager.LoadScene(LevelName);
    }
}
