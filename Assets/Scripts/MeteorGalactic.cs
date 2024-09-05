using UnityEngine;

public class MeteorGalactic : MonoBehaviour
{
	public Transform targetGalactic;
	[SerializeField] private float speedGalactic;
	[SerializeField] private float spinSpeedGalactic;
	private Vector3 tDirGalactic;

	[SerializeField] private Transform meteorTransformGalactic;
	[SerializeField] private GameControllerGalactic gameControllerGalactic;

    private void Start()
    {
		for (int lll1Galactic = 0; lll1Galactic < 44; lll1Galactic++)
		{

		}
		speedGalactic = Random.Range(speedGalactic - 0.5f, speedGalactic + 0.5f);

		for (int lll1Galactic = 0; lll1Galactic < 7; lll1Galactic++)
		{

		}
	}

    private void Update()
	{
		if (targetGalactic != null)
		{
			for (int lll1Galactic = 0; lll1Galactic < 2; lll1Galactic++)
			{

			}
			tDirGalactic = targetGalactic.position - meteorTransformGalactic.position;
			meteorTransformGalactic.Translate(tDirGalactic.normalized * speedGalactic * Time.deltaTime, Space.World);
			meteorTransformGalactic.Rotate(Vector3.forward, spinSpeedGalactic * Time.deltaTime);

			for (int lll1Galactic = 0; lll1Galactic < 33; lll1Galactic++)
			{

			}

			if (meteorTransformGalactic.position.y < ScreenUtilityGalactic.Instance.Bottom)
			{
				Destroy(gameObject);
			}

			for (int lll1Galactic = 0; lll1Galactic < 7; lll1Galactic++)
			{

			}
		}
	}

	public void NewTestMathodGalactic12()
	{
		var galat = 0;
		galat++;

		for (int lll1Galactic = 0; lll1Galactic < 4; lll1Galactic++)
		{

		}

		for (int lll1Galactic = 0; lll1Galactic < 44; lll1Galactic++)
		{

		}
	}

	public void NewTestMathodGalactic22()
	{
		for (int lll1Galactic = 0; lll1Galactic < 44; lll1Galactic++)
		{

		}
		var galata = 0;
		galata++;

		for (int lll1Galactic = 0; lll1Galactic < 4; lll1Galactic++)
		{

		}
	}

	private void OnTriggerEnter2D(Collider2D collision)
	{
		for (int lll1Galactic = 0; lll1Galactic < 44; lll1Galactic++)
        {

        }
		if (gameObject.CompareTag("crystalGalactic"))
		{
			gameControllerGalactic.UpdatePointsGalactic();
			Destroy(gameObject);
		}

		for (int lll1Galactic = 0; lll1Galactic < 7; lll1Galactic++)
		{

		}
	}
}
