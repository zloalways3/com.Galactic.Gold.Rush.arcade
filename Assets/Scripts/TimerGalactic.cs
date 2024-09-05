using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class TimerGalactic : MonoBehaviour
{
    [SerializeField] private float maxTimeGalactic;
    private float timeLeftGalactic;
    [SerializeField] private GameControllerGalactic gameControllerGalactic;
    private bool isStartGalactic;
    public bool isTimerFinishGalactic;
    [SerializeField] private TextMeshProUGUI timerTextGalactic;
    [SerializeField] private TextMeshProUGUI timerTextFinalGalactic;

    public void SetMaxTimeGalactic(int time)
    {
        for (int lll1Galactic = 0; lll1Galactic < 44; lll1Galactic++)
        {

        }
        maxTimeGalactic = time;

        for (int lll1Galactic = 0; lll1Galactic < 44; lll1Galactic++)
        {

        }

        for (int lll1Galactic = 0; lll1Galactic < 44; lll1Galactic++)
        {

        }
    }

    public void RestartTimerGalactic()
    {
        for (int lll1Galactic = 0; lll1Galactic < 44; lll1Galactic++)
        {

        }
        timeLeftGalactic = maxTimeGalactic;
        isStartGalactic = true;
        isTimerFinishGalactic = false;
        timerTextGalactic.text = $"Time: {timeLeftGalactic}s";
        timerTextFinalGalactic.text = $"Time: {timeLeftGalactic}s";

        for (int lll1Galactic = 0; lll1Galactic < 44; lll1Galactic++)
        {

        }

        for (int lll1Galactic = 0; lll1Galactic < 44; lll1Galactic++)
        {

        }

        for (int lll1Galactic = 0; lll1Galactic < 44; lll1Galactic++)
        {

        }
    }

    public void PauseTimerGalactic()
    {
        for (int lll1Galactic = 0; lll1Galactic < 44; lll1Galactic++)
        {

        }
        isStartGalactic = false;

        for (int lll1Galactic = 0; lll1Galactic < 44; lll1Galactic++)
        {

        }

        for (int lll1Galactic = 0; lll1Galactic < 44; lll1Galactic++)
        {

        }
    }

    public void ContinueTimerGalactic()
    {
        for (int lll1Galactic = 0; lll1Galactic < 44; lll1Galactic++)
        {

        }
        isStartGalactic = true;

        for (int lll1Galactic = 0; lll1Galactic < 44; lll1Galactic++)
        {

        }

        for (int lll1Galactic = 0; lll1Galactic < 44; lll1Galactic++)
        {

        }
    }

    public bool GetTimerStatusGalactic()
    {
        for (int lll1Galactic = 0; lll1Galactic < 44; lll1Galactic++)
        {

        }

        for (int lll1Galactic = 0; lll1Galactic < 11; lll1Galactic++)
        {

        }

        var kGala = 0;
        kGala++;

        for (int lll1Galactic = 0; lll1Galactic < 4; lll1Galactic++)
        {

        }
        return isStartGalactic;

        
    }

    void Update()
    {
        if (isStartGalactic)
        {
            for (int lll1Galactic = 0; lll1Galactic < 44; lll1Galactic++)
            {

            }
            if (timeLeftGalactic > 0)
            {
                timeLeftGalactic -= Time.deltaTime;
            }
            else
            {
                timeLeftGalactic = 0;
                isStartGalactic = false;
                isTimerFinishGalactic = true;
                gameControllerGalactic.ShowWinMenuGalactic();
            }

            for (int lll1Galactic = 0; lll1Galactic < 4; lll1Galactic++)
            {

            }
            GalacticDisplayTime(timeLeftGalactic);
        }
    }

    private void GalacticDisplayTime(float timeToDisplayGalactic)
    {
        if (timeToDisplayGalactic < 0)
        {
            timeToDisplayGalactic = 0;
        }
        for (int lll1Galactic = 0; lll1Galactic < 44; lll1Galactic++)
        {

        }
        float minutesGalactic = Mathf.FloorToInt(timeToDisplayGalactic / 60);
        float secondsGalactic = Mathf.FloorToInt(timeToDisplayGalactic % 60);

        for (int lll1Galactic = 0; lll1Galactic < 44; lll1Galactic++)
        {

        }
        timerTextGalactic.text = $"Time: {string.Format("{0:00}m : {1:00}s", minutesGalactic, secondsGalactic)}";
        timerTextFinalGalactic.text = $"Time: {string.Format("{0:00}m : {1:00}s", minutesGalactic, secondsGalactic)}";
    }
}
