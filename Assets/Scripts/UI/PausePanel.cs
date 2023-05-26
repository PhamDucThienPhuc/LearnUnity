using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PausePanel : MonoBehaviour
{
    public void OnClickedSettingButtom()
    {
        if (UIManager.HasInstance)
        {
            UIManager.Instance.ActiveSettingPanel(true);
            UIManager.Instance.ActivePausePanel(false);
        }
    }
    public void OnClickedResumeButtom()
    {
        if (GameManager.HasInstance && UIManager.HasInstance)
        {
            GameManager.Instance.ResumeGame();
            UIManager.Instance.ActivePausePanel(false);
        }
    }
    public void OnClickedQuitButtom()
    {
        if (GameManager.HasInstance)
        {
            GameManager.Instance.EndGame();
        }
    }
}
