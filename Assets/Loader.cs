using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public static class Loader 
{
    // Start is called before the first frame update
    public enum Scene
    {
        SampleScene,
        Level2,
    }

    // Update is called once per frame
    public static void Load(Scene scene)
    {
        SceneManager.LoadScene(Scene.Level2.ToString());

    }
}
