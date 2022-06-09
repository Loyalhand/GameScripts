using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;
using UnityEngine.UI;
using TMPro;

public class GameSettings : MonoBehaviour
{
    public AudioMixer audioMixer;

    public TMP_Dropdown resdrop;

    Resolution[] resolutions;

    int resolutionIndex = 0;

    public void setVolume(float volume)
    {
        Debug.Log(volume);
        audioMixer.SetFloat("volume", Mathf.Log10(volume) * 20);
    }

    public void setQuality(int quality)
    {
        QualitySettings.SetQualityLevel(quality);
    }

    public void setFullscreen (bool full)
    {
        Screen.fullScreen = full;
    }

    void Start()
    {
        resolutions = Screen.resolutions;
        resdrop.ClearOptions();
        List<string> options = new List<string>();
        for (int i = 0; i<resolutions.Length; i++)
        {
            string option = resolutions[i].width + " x " + resolutions[i].height + " @ " + resolutions[i].refreshRate + "hz";
            options.Add(option);
            if(resolutions[i].width == Screen.currentResolution.width && 
                resolutions[i].height == Screen.currentResolution.height)
            {
                resolutionIndex = i;
            }
        }
        resdrop.AddOptions(options);
        resdrop.value = resolutionIndex;
        resdrop.RefreshShownValue();
    }

    public void setResolution(int resInd)
    {
        Resolution resolution = resolutions[resolutionIndex];
        Screen.SetResolution(resolution.width, resolution.height, Screen.fullScreen);
    }
}
