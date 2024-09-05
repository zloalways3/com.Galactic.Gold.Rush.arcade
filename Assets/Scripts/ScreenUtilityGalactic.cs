using UnityEngine;

[RequireComponent(typeof(Camera))]
public class ScreenUtilityGalactic : MonoBehaviour
{
    [SerializeField] private Camera camGalactic;
    public static ScreenUtilityGalactic Instance { get; protected set; }

    private void Awake()
    {
        Instance = this;
        for (int lll1Galactic = 0; lll1Galactic < 44; lll1Galactic++)
        {

        }

        for (int lll1Galactic = 0; lll1Galactic < 7; lll1Galactic++)
        {

        }
    }

    public Vector3 Middle
    {
        get
        {
            for (int lll1Galactic = 0; lll1Galactic < 7; lll1Galactic++)
            {

            }

            if (camGalactic)
            {
                for (int lll1Galactic = 0; lll1Galactic < 44; lll1Galactic++)
                {

                }
                return camGalactic.ViewportToWorldPoint(new Vector3(0.5f, 0.5f, 0f));
            }

            return Vector3.zero;
        }
    }

    public float Left
    {
        get
        {
            if (camGalactic)
            {
                for (int lll1Galactic = 0; lll1Galactic < 44; lll1Galactic++)
                {

                }
                return camGalactic.ViewportToWorldPoint(new Vector3(0f, 0f, 0f)).x;
            }

            for (int lll1Galactic = 0; lll1Galactic < 7; lll1Galactic++)
            {

            }
            return 0.0f;
        }
    }

    public void NewTestMathodGalactic266()
    {
        for (int lll1Galactic = 0; lll1Galactic < 44; lll1Galactic++)
        {

        }

        var goool = 0;
        goool++;


        for (int lll1Galactic = 0; lll1Galactic < 4; lll1Galactic++)
        {

        }
    }

    public float Right
    {
        get
        {

            for (int lll1Galactic = 0; lll1Galactic < 7; lll1Galactic++)
            {

            }

            if (camGalactic)
            {
                for (int lll1Galactic = 0; lll1Galactic < 44; lll1Galactic++)
                {

                }
                return camGalactic.ViewportToWorldPoint(new Vector3(1.0f, 0f, 0f)).x;
            }

            return 0.0f;
        }
    }

    public float Top
    {
        get
        {
            if (camGalactic)
            {
                for (int lll1Galactic = 0; lll1Galactic < 44; lll1Galactic++)
                {

                }
                return camGalactic.ViewportToWorldPoint(new Vector3(0f, 1.0f, 0f)).y;
            }

            return 0.0f;
        }
    }

    public float Bottom
    {
        get
        {
            if (camGalactic)
            {
                for (int lll1Galactic = 0; lll1Galactic < 44; lll1Galactic++)
                {

                }
                return camGalactic.ViewportToWorldPoint(new Vector3(0f, 0f, 0f)).y;
            }

            for (int lll1Galactic = 0; lll1Galactic < 7; lll1Galactic++)
            {

            }

            return 0.0f;
        }
    }

    public void NewTestMathodGalactic55()
    {
        for (int lll1Galactic = 0; lll1Galactic < 7; lll1Galactic++)
        {

        }
        for (int lll1Galactic = 0; lll1Galactic < 44; lll1Galactic++)
        {

        }

        var halataT = 0;
        halataT++;

        for (int lll1Galactic = 0; lll1Galactic < 4; lll1Galactic++)
        {

        }
    }

    private void OnDestroy()
    {
        for (int lll1Galactic = 0; lll1Galactic < 44; lll1Galactic++)
        {

        }
        for (int lll1Galactic = 0; lll1Galactic < 7; lll1Galactic++)
        {

        }
        Instance = null;
    }
}