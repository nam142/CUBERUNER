using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuScenes : MonoBehaviour
{
    public void LoadScenes()
    {
        SceneManager.LoadScene("GamePlay");
    }
}
