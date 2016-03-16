using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class UIManager : MonoBehaviour {


    public Animator StartBtnAnimator;
    public Animator SettingBtnAnimator;
    public Animator SettingDlgAnimator;
    public Animator ContentPnlAnimator;
    public Animator GearImgAnimator;

    public void StartGame()
    {
        SceneManager.LoadScene("RocketMouse");
    }

    public void OpenSettings()
    {
        StartBtnAnimator.SetBool("isHidden", true);
        SettingBtnAnimator.SetBool("isHidden", true);
        SettingDlgAnimator.SetBool("isHidden", false);
    }

    public void CloseSettings()
    {
        StartBtnAnimator.SetBool("isHidden", false);
        SettingBtnAnimator.SetBool("isHidden", false);
        SettingDlgAnimator.SetBool("isHidden", true);
    }

    public void ToggleMenu()
    {
        bool isHidden = ContentPnlAnimator.GetBool("isHidden");
        ContentPnlAnimator.SetBool("isHidden", !isHidden);
        GearImgAnimator.SetBool("isHidden", !isHidden);
    }
}
