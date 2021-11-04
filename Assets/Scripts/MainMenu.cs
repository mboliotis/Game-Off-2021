using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{


    [SerializeField] Image playButtonImage;
    [SerializeField] Sprite play1;
    [SerializeField] Sprite play2;
    [SerializeField] AudioSource bugSquish;

    public void OnButtonDownBugSwap()
    {
        bugSquish.time = 0.4f;
        playButtonImage.sprite = play2;
        bugSquish.Play();
    }

    public void OnButtonUpBugSwap()
    {
        playButtonImage.sprite = play1;
    }

}
