using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Goal : MonoBehaviour
{
    [SerializeField] string sceneName;
    private void OnTriggerEntre2D(Collider2D collision)
    {
        if(collision.CompareTag("Player"))
        {
           SceneManager.LoadScene(sceneName);
        }
    }
}