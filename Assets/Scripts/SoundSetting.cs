
using UnityEngine;
using UnityEngine.Audio;
using Slider = UnityEngine.UI.Slider;

public class SoundSetting : MonoBehaviour
{
    [SerializeField] Slider soundSlider;
    [SerializeField] AudioMixer masterMixer;


    private void Start()
    {
        SetVolume(PlayerPrefs.GetFloat("SavedMasterVolume", 0));
    }

    public void SetVolume(float value)
    {
        if (value < 1)
        {
            value = .001f;
        }

        RefreshSlider(value);
        PlayerPrefs.SetFloat("SavedMasterVolume", value);
        masterMixer.SetFloat("MasterVolume", Mathf.Log10(value / 100) * 20f);
    }


    public void SetVolumeFromSlider()
    {
        SetVolume(soundSlider.value);
    }
    public void RefreshSlider(float value)
    {
        soundSlider.value = value;
    }
}
