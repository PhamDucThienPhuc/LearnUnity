using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LosePanel : MonoBehaviour
{
    public void OnClickedRestartButtom()
    {
        if (GameManager.HasInstance)
        {
            GameManager.Instance.RestartGame();
        }
    }
    public void OnClickedExitButtom()
    {
        if (GameManager.HasInstance)
        {
            GameManager.Instance.EndGame();
        }
    }
}
