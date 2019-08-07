using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlcokController : MonoBehaviour
{
    [SerializeField]
    AudioClip breakSound;

    LevelController levelController;

    private void Start()
    {
        levelController =  FindObjectOfType<LevelController>();
        levelController.CountBreakableBlocks();
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.name == "Ball")
        {
            AudioSource.PlayClipAtPoint(breakSound, Camera.main.transform.position);
            levelController.BlcokDestroyed();
            Destroy(gameObject);
        }
           
    }

}
