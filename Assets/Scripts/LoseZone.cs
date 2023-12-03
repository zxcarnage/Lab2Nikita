using System;
using UnityEngine;
using UnityEngine.SceneManagement;


public class LoseZone : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.TryGetComponent(out BallMover ball))
            ResetScene();
    }
    
    private void ResetScene()
    {
        SceneManager.LoadScene(0);
    }
}
