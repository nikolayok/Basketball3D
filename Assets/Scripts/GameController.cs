using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    [SerializeField] private Ball _ball;
    [SerializeField] private float _resetTimer = 1f;

    private void OnEnable()
    {
        _ball.ThrowEvent += ThrowListener;
    }

    private void OnDisable()
    {
        _ball.ThrowEvent -= ThrowListener;
    }

    private void ThrowListener()
    {
        Invoke("ReloadScene", _resetTimer);
    }

    private void ReloadScene()
    {
        SceneManager.LoadScene("Game");
    }
}
