using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class SceneLoaderByName : MonoBehaviour
{
   
    public void SceneLoader()
    {
        SceneManager.LoadScene("Lv1");
    }
}
