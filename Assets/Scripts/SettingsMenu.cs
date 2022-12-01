using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class SettingsMenu : MonoBehaviour
{
    public AudioMixer musicMixer;
    public AudioMixer soundMixer;
    public TMP_Dropdown resolutionDropdown;
    public TMP_Dropdown qualityDropdown;
    public TMP_Dropdown textureDropdown;
    public TMP_Dropdown aaDropdown;
    public Slider volumeSlider;

    float currentVolume;
    Resolution[] resolutions;

    void Start()
    {
        resolutionDropdown.ClearOptions();
        List<string> options = new List<string>();
        resolutions = Screen.resolutions;
        int currentResolutionIndex = 0;

        for (int i = 0; i < resolutions.Length; i++)
        {
            string option = resolutions[i].width + " x " + resolutions[i].height;
            options.Add(option);
            if (resolutions[i].width == Screen.currentResolution.width && resolutions[i].height == Screen.currentResolution.height)
            {
                currentResolutionIndex = i;
            }
        }

        resolutionDropdown.AddOptions(options);
        resolutionDropdown.RefreshShownValue();
        LoadSettings(currentResolutionIndex);
    }

    public void SetVolume(float volume)
    {
        musicMixer.SetFloat("Volume", Mathf.Log10(volume) * 20);
        soundMixer.SetFloat("Volume", Mathf.Log10(volume) * 20);
        currentVolume = volume;
    }

    public void SetFullscreen(bool isFullscreen)
    {
        Screen.fullScreen = isFullscreen;
    }

    public void SetResolution(int resolutionIndex)
    {
        Resolution resolution = resolutions[resolutionIndex];
        Screen.SetResolution(resolution.width, resolution.height, Screen.fullScreen);
    }

    public void SetTextureQuality(int textureIndex)
    {
        QualitySettings.masterTextureLimit = textureIndex;
        qualityDropdown.value = 6;
    }

    public void SetAntiAliasing(int aaIndex)
    {
        QualitySettings.antiAliasing = aaIndex;
        qualityDropdown.value = 6;
    }

    public void SetQuality(int qualityIndex)
    {
        // Sets to default setting if not using any presets
        if (qualityIndex != 6)
        {
            QualitySettings.SetQualityLevel(qualityIndex);
        }

        // Determines Quality Level
        switch (qualityIndex)
        {
            // Very Low
            case 0:
                textureDropdown.value = 3;
                aaDropdown.value = 0;
                break;
            // Low
            case 1:
                textureDropdown.value = 2;
                aaDropdown.value = 0;
                break;
            // Medium
            case 2:
                textureDropdown.value = 1;
                aaDropdown.value = 0;
                break;
            // High
            case 3:
                textureDropdown.value = 0;
                aaDropdown.value = 0;
                break;
            // Very High
            case 4:
                textureDropdown.value = 0;
                aaDropdown.value = 1;
                break;
            // Ultra
            case 5:
                textureDropdown.value = 0;
                aaDropdown.value = 2;
                break;
        }
        qualityDropdown.value = qualityIndex;
    }

    public void SaveSettings()
    {
        PlayerPrefs.SetInt("QualitySettingPreference", qualityDropdown.value);
        PlayerPrefs.SetInt("ResolutionPreference", resolutionDropdown.value);
        PlayerPrefs.SetInt("TextureQualityPreference", textureDropdown.value);
        PlayerPrefs.SetInt("AntiAliasingPreference", aaDropdown.value);
        PlayerPrefs.SetInt("FullscreenPreference", Convert.ToInt32(Screen.fullScreen));
        PlayerPrefs.SetFloat("VolumePreference", currentVolume);
        PlayerPrefs.Save();
    }

    public void LoadSettings(int currentResolutionIndex)
    {
        // Visual Quality Settings
        if (PlayerPrefs.HasKey("QualitySettingPreference"))
        {
            qualityDropdown.value = PlayerPrefs.GetInt("QualitySettingPreference");
        }
        else
        {
            qualityDropdown.value = 3;
        }

        // Resolution Settings
        if (PlayerPrefs.HasKey("ResolutionPreference"))
        {
            resolutionDropdown.value = PlayerPrefs.GetInt("ResolutionPreference");
        }
        else
        {
            resolutionDropdown.value = currentResolutionIndex;
        }
        
        // Texture Quality Settings
        if (PlayerPrefs.HasKey("TextureQualityPreference"))
        {
            textureDropdown.value = PlayerPrefs.GetInt("TextureQualityPreference");
        }
        else
        {
            textureDropdown.value = 0;
        }

        // Anti-Aliasing Settings
        if (PlayerPrefs.HasKey("AntiAliasingPreference"))
        {
            aaDropdown.value = PlayerPrefs.GetInt("AntiAliasingPreference");
        }
        else
        {
            aaDropdown.value = 0;
        }

        // Screen Settings
        if (PlayerPrefs.HasKey("FullscreenPreference"))
        {
            Screen.fullScreen = Convert.ToBoolean(PlayerPrefs.GetInt("FullscreenPreference"));
        }
        else
        {
            Screen.fullScreen = true;
        }

        // Volume Settings
        if (PlayerPrefs.HasKey("VolumePreference"))
        {
            volumeSlider.value = PlayerPrefs.GetFloat("VolumePreference", 0.75f);
        }
        else
        {
            volumeSlider.value = PlayerPrefs.GetFloat("VolumePreference", 0.75f);
        }
    }
}
