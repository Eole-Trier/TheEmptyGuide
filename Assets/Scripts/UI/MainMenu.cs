using Com.EliottTan.SceneTransitions;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    [SerializeField] Button play, setting, quit, credit;

    // Start is called before the first frame update
    private void Awake()
    {
        play.onClick.AddListener(PlayButton);
    }

    void PlayButton()
    {
        TransitionManager.ChangeScene(1);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.O))
        {
            SoundManager.Instance.PlaySFX(SoundManager.Instance._sfxSucces, transform.position);
        }
    }
}
