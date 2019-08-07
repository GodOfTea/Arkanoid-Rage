using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelController : MonoBehaviour {

    [SerializeField] int breakableBlocks;

    public void CountBreakableBlocks ()
    {
        breakableBlocks++;
    }

    public void BlcokDestroyed()
    {
        breakableBlocks--;
        if (breakableBlocks <= 0)
            GoToTheNextLvl();
    }

    private void GoToTheNextLvl()
    {
        FindObjectOfType<SceneLoader>().LoadNextScene();
    }
}
