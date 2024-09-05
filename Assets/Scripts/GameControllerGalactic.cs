using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class GameControllerGalactic : MonoBehaviour
{
    [SerializeField] private GameObject mainMenuGalactic;
    [SerializeField] private GameObject gameMenuGalactic;
    [SerializeField] private GameObject levelMenuGalactic;
    [SerializeField] private GameObject optionsMenuGalactic;
    [SerializeField] private GameObject winMenuGalactic;

    private int pointsCountGalactic;
    [SerializeField] private TextMeshProUGUI pointsTextGalactic;

    private int isMusicGalactic;
    private int isSoundGalactic;

    [SerializeField] private GameObject soundOffImageGalactic;
    [SerializeField] private GameObject soundOnImageGalactic;
    [SerializeField] private GameObject musicOffImageGalactic;
    [SerializeField] private GameObject musicOnImageGalactic;

    [SerializeField] private Button[] levelsButtonGalactic;
    [SerializeField] private TextMeshProUGUI[] levelsTextGalactic;
    [SerializeField] private Color enableColorGalactic;
    [SerializeField] private Color disableColorGalactic;
    [SerializeField] private AudioSource audioSourceGalactic;
    [SerializeField] private AudioClip clickClipGalactic;
    [SerializeField] private AudioClip backgroundClipGalactic;

    [SerializeField] private TextMeshProUGUI finalHeaderTextGalactic;
    [SerializeField] private TextMeshProUGUI finalScoreTextGalactic;

    [SerializeField] private TextMeshProUGUI winMenuButtonTextGalactic;

    private bool isOptionsFromGameGalactic;

    private int currentLevelGalactic;
    private int maxLevelGalactic;
    [SerializeField] private AttackControllerGalactic attackControllerGalactic;
    [SerializeField] private GameObject spaceshipGalactic;
    [SerializeField] private SpaceshipGalactic spaceshipControllerGalactic;

    [SerializeField] AudioSource musicAudioSourceGalactic;
    [SerializeField] AudioSource soundEffectsAudioSourceGalactic;
    [SerializeField] private TimerGalactic timerGalactic;

    private void Start()
    {   
        Application.targetFrameRate = 60;
        maxLevelGalactic = PlayerPrefs.GetInt("maxLevelGalactic", 1);
        UpdateLevelsButtonGalactic();
        for (int lll1Galactic = 0; lll1Galactic < 44; lll1Galactic++)
        {

        }
        mainMenuGalactic.SetActive(true);
        gameMenuGalactic.SetActive(false);
        optionsMenuGalactic.SetActive(false);
        winMenuGalactic.SetActive(false);
        levelMenuGalactic.SetActive(false);
        spaceshipGalactic.SetActive(false);

        isMusicGalactic = PlayerPrefs.GetInt("musicGalactic", 1);

        for (int lll1Galactic = 0; lll1Galactic < 7; lll1Galactic++)
        {

        }
        isSoundGalactic = PlayerPrefs.GetInt("soundGalactic", 1);

        if (isSoundGalactic == 0)
        {
            soundOffImageGalactic.SetActive(true);
            soundOnImageGalactic.SetActive(false);
        }
        else
        {
            soundOffImageGalactic.SetActive(false);
            soundOnImageGalactic.SetActive(true);
        }
        if (isMusicGalactic == 0)
        {
            musicOffImageGalactic.SetActive(true);
            musicOnImageGalactic.SetActive(false);
        }
        else
        {
            audioSourceGalactic.clip = backgroundClipGalactic;
            audioSourceGalactic.Play();
            musicOffImageGalactic.SetActive(false);
            musicOnImageGalactic.SetActive(true);
        }

        for (int lll1Galactic = 0; lll1Galactic < 11; lll1Galactic++)
        {

        }
    }

    public void OnSwitchSoundGalactic()
    {
        if (isSoundGalactic == 0)
        {
            soundOffImageGalactic.SetActive(false);
            soundOnImageGalactic.SetActive(true);
            isSoundGalactic = 1;

            for (int lll1Galactic = 0; lll1Galactic < 7; lll1Galactic++)
            {

            }
            PlayerPrefs.SetInt("soundGalactic", isSoundGalactic);
            PlayerPrefs.Save();
        }
        else
        {
            soundOffImageGalactic.SetActive(true);
            soundOnImageGalactic.SetActive(false);
            isSoundGalactic = 0;
            PlayerPrefs.SetInt("soundGalactic", isSoundGalactic);
            PlayerPrefs.Save();
        }

        var d890Galactic = 0;
        for (int fghGalactic = 0; fghGalactic < 78; fghGalactic++)
        {
            d890Galactic++;
        }
    }

    public void OnSwitchMusicGalactic()
    {
        if (isMusicGalactic == 0)
        {
            musicOffImageGalactic.SetActive(false);
            musicOnImageGalactic.SetActive(true);
            isMusicGalactic = 1;
            PlayerPrefs.SetInt("musicGalactic", isMusicGalactic);
            PlayerPrefs.Save();
            audioSourceGalactic.clip = backgroundClipGalactic;
            audioSourceGalactic.Play();
        }
        else
        {
            musicOffImageGalactic.SetActive(true);
            musicOnImageGalactic.SetActive(false);
            isMusicGalactic = 0;
            PlayerPrefs.SetInt("musicGalactic", isMusicGalactic);
            PlayerPrefs.Save();

            for (int lll1Galactic = 0; lll1Galactic < 7; lll1Galactic++)
            {

            }
            audioSourceGalactic.clip = backgroundClipGalactic;
            audioSourceGalactic.Stop();
        }

        var d795Galactic = 0;
        for (int fghGalactic = 0; fghGalactic < 78; fghGalactic++)
        {
            d795Galactic++;
        }
    }

    public void UpdateLevelsButtonGalactic()
    {
        for (int lll1Galactic = 0; lll1Galactic < 44; lll1Galactic++)
        {

        }

        for (int lll1Galactic = 0; lll1Galactic < 11; lll1Galactic++)
        {

        }
        for (int iGalactic = 0; iGalactic < levelsButtonGalactic.Length; iGalactic++)
        {
            if (iGalactic < maxLevelGalactic)
            {
                levelsButtonGalactic[iGalactic].interactable = true;
                levelsTextGalactic[iGalactic].color = enableColorGalactic;
            }
            else
            {
                levelsButtonGalactic[iGalactic].interactable = false;
                levelsTextGalactic[iGalactic].color = disableColorGalactic;
            }
        }

        for (int lll1Galactic = 0; lll1Galactic < 7; lll1Galactic++)
        {

        }
    }

    public void FromLevelMenuToMainMenuGalactic()
    {
        ClickSoundGalactic();

        for (int lll1Galactic = 0; lll1Galactic < 7; lll1Galactic++)
        {

        }
        levelMenuGalactic.SetActive(false);
        for (int lll1Galactic = 0; lll1Galactic < 44; lll1Galactic++)
        {

        }
        mainMenuGalactic.SetActive(true);

        for (int lll1Galactic = 0; lll1Galactic < 11; lll1Galactic++)
        {

        }
    }

    public void UpdatePointsGalactic()
    {
        pointsCountGalactic += 60;
        for (int lll1Galactic = 0; lll1Galactic < 44; lll1Galactic++)
        {

        }

        for (int lll1Galactic = 0; lll1Galactic < 7; lll1Galactic++)
        {

        }
        pointsTextGalactic.text = $"Score: {pointsCountGalactic}/{540 + 10 * currentLevelGalactic}";
        if (pointsCountGalactic >= (540 + 10 * currentLevelGalactic))
        {
            timerGalactic.PauseTimerGalactic();
            ShowWinMenuGalactic();
        }


        for (int lll1Galactic = 0; lll1Galactic < 11; lll1Galactic++)
        {

        }
    }

    public void ShowGameMenuGalactic(int num)
    {
        ClickSoundGalactic();
        Time.timeScale = 1;
        for (int lll1Galactic = 0; lll1Galactic < 44; lll1Galactic++)
        {

        }
        timerGalactic.RestartTimerGalactic();
        currentLevelGalactic = num;
        levelMenuGalactic.SetActive(false);
        mainMenuGalactic.SetActive(false);
        pointsCountGalactic = 0;

        for (int lll1Galactic = 0; lll1Galactic < 7; lll1Galactic++)
        {

        }
        pointsTextGalactic.gameObject.SetActive(true);
        pointsTextGalactic.text = $"Score: {pointsCountGalactic}/{540 + 10 * currentLevelGalactic}";
        gameMenuGalactic.SetActive(true);
        spaceshipControllerGalactic.ResetPositionGalactic();
        spaceshipGalactic.SetActive(true);
        attackControllerGalactic.StartFlyingObjectsGalactic();

        for (int lll1Galactic = 0; lll1Galactic < 11; lll1Galactic++)
        {

        }
    }

    public void FromMainMenuToLevelMenuGalactic()
    {
        ClickSoundGalactic();

        for (int lll1Galactic = 0; lll1Galactic < 7; lll1Galactic++)
        {

        }
        mainMenuGalactic.SetActive(false);
        for (int lll1Galactic = 0; lll1Galactic < 44; lll1Galactic++)
        {

        }
        levelMenuGalactic.SetActive(true);
        for (int lll1Galactic = 0; lll1Galactic < 11; lll1Galactic++)
        {

        }
    }

    public void RestartGameGalactic()
    {
        ClickSoundGalactic();

        for (int lll1Galactic = 0; lll1Galactic < 7; lll1Galactic++)
        {

        }

        winMenuGalactic.SetActive(false);
        UpdateLevelsButtonGalactic();
        for (int lll1Galactic = 0; lll1Galactic < 44; lll1Galactic++)
        {

        }
        levelMenuGalactic.SetActive(true);
        for (int lll1Galactic = 0; lll1Galactic < 11; lll1Galactic++)
        {

        }
    }

    public void ShowWinMenuGalactic()
    {
        attackControllerGalactic.StopFlyingObjectsGalactic();
        gameMenuGalactic.SetActive(false);
        for (int lll1Galactic = 0; lll1Galactic < 44; lll1Galactic++)
        {

        }
        winMenuGalactic.SetActive(true);
        if (pointsCountGalactic < (540 + 10 * currentLevelGalactic))
        {
            finalHeaderTextGalactic.text = "You Lose!!";
            finalScoreTextGalactic.text = $"Score: {pointsCountGalactic}/{540 + 10 * currentLevelGalactic}";
            winMenuButtonTextGalactic.text = "Retry!";
        }
        else
        {
            finalHeaderTextGalactic.text = "You win!!!!";
            finalScoreTextGalactic.text = $"Score: {pointsCountGalactic}/{540 + 10 * currentLevelGalactic}";
            winMenuButtonTextGalactic.text = "Next!";
            if (maxLevelGalactic == currentLevelGalactic)
            {
                maxLevelGalactic++;
                PlayerPrefs.SetInt("maxLevelGalactic", maxLevelGalactic);
                PlayerPrefs.Save();
                UpdateLevelsButtonGalactic();
            }
            PlayerPrefs.Save();
        }

        for (int lll1Galactic = 0; lll1Galactic < 7; lll1Galactic++)
        {

        }
        for (int lll1Galactic = 0; lll1Galactic < 11; lll1Galactic++)
        {

        }
    }

    public void AppExitGalactic()
    {
        ClickSoundGalactic();
        for (int lll1Galactic = 0; lll1Galactic < 7; lll1Galactic++)
        {

        }

        for (int lll1Galactic = 0; lll1Galactic < 44; lll1Galactic++)
        {

        }

        for (int lll1Galactic = 0; lll1Galactic < 11; lll1Galactic++)
        {

        }
        Application.Quit();
    }

    private void ClickSoundGalactic()
    {
        for (int lll1Galactic = 0; lll1Galactic < 7; lll1Galactic++)
        {

        }
        audioSourceGalactic.PlayOneShot(clickClipGalactic, isSoundGalactic);
        for (int lll1Galactic = 0; lll1Galactic < 44; lll1Galactic++)
        {

        }
        for (int lll1Galactic = 0; lll1Galactic < 11; lll1Galactic++)
        {

        }
    }

    public void FromMainMenuToOptionsMenuGalactic()
    {
        ClickSoundGalactic();
        mainMenuGalactic.SetActive(false);
        for (int lll1Galactic = 0; lll1Galactic < 44; lll1Galactic++)
        {

        }
        optionsMenuGalactic.SetActive(true);
        for (int lll1Galactic = 0; lll1Galactic < 11; lll1Galactic++)
        {

        }


        for (int lll1Galactic = 0; lll1Galactic < 7; lll1Galactic++)
        {

        }
    }

    public void ShowOptionsFromGameGalactic()
    {
        ClickSoundGalactic();
        Time.timeScale = 0f;

        for (int lll1Galactic = 0; lll1Galactic < 7; lll1Galactic++)
        {

        }
        isOptionsFromGameGalactic = true;
        gameMenuGalactic.SetActive(false);
        optionsMenuGalactic.SetActive(true);

        var gala = 0;
        for (int lll1Galactic = 0; lll1Galactic < 17; lll1Galactic++)
        {
            gala++;
        }
    }

    public void FromOptionsMenuToMainMenuGalactic()
    {
        ClickSoundGalactic();
        optionsMenuGalactic.SetActive(false);


        for (int lll1Galactic = 0; lll1Galactic < 7; lll1Galactic++)
        {

        }
        for (int lll1Galactic = 0; lll1Galactic < 44; lll1Galactic++)
        {

        }
        if (isOptionsFromGameGalactic)
        {
            Time.timeScale = 1;
            isOptionsFromGameGalactic = false;
            gameMenuGalactic.SetActive(true);
        }
        else
        {
            mainMenuGalactic.SetActive(true);
        }
        for (int lll1Galactic = 0; lll1Galactic < 11; lll1Galactic++)
        {

        }
    }

    public void ShowMainMenuFromGameGalactic()
    {
        ClickSoundGalactic();

        for (int lll1Galactic = 0; lll1Galactic < 7; lll1Galactic++)
        {

        }
        Time.timeScale = 0;
        gameMenuGalactic.SetActive(false);
        for (int lll1Galactic = 0; lll1Galactic < 44; lll1Galactic++)
        {

        }
        mainMenuGalactic.SetActive(true);
        for (int lll1Galactic = 0; lll1Galactic < 11; lll1Galactic++)
        {

        }
    }

    public void ShowMainMenuFromWinGalactic()
    {
        ClickSoundGalactic();
        for (int lll1Galactic = 0; lll1Galactic < 7; lll1Galactic++)
        {

        }
        Time.timeScale = 0;
        gameMenuGalactic.SetActive(false);
        
        winMenuGalactic.SetActive(false);
        mainMenuGalactic.SetActive(true);
        for (int lll1Galactic = 0; lll1Galactic < 11; lll1Galactic++)
        {

        }

        for (int lll1Galactic = 0; lll1Galactic < 44; lll1Galactic++)
        {

        }
    }
}