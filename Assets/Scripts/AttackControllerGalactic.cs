using UnityEngine;
using System.Collections;

public class AttackControllerGalactic : MonoBehaviour
{
	private Transform[] attackStartPointsGalactic;
	private Transform[] attackEndPointsGalactic;
	private int startPointSizeGalactic;
	private int endPointSizeGalactic;
	private float distanceBetweenPointsGalactic = 0.8f;
	private int attackCounterGalactic = 0;
	[SerializeField] private int attackLimitCrystalGalactic;
	public Transform mainObjectStartTransformGalactic;
	public Transform mainObjectEndTransformGalactic;
	[SerializeField] private float attackWaitTimeGalactic = 3.0f;
	[SerializeField] private float attackCountDownGalactic = 3.0f;
	public GameObject[] crystalPrefabGalactic;
	public GameObject startEndPointsPrefabGalactic;
	public Transform[] spawnedMeteorsGalactic;
	public Transform[] spawnedCrystalsGalactic;
	private Vector3 tSpawnPosGalactic;
	private GameObject tObjectGalactic;
	private int tStartIndexGalactic;
	private int tEndIndexGalactic;
	[SerializeField] private Camera mainCameraGalactic;
	private Bounds gameBoundsGalactic;
	private Coroutine meteorCoroutineGalactic;
	private Coroutine crystalCoroutineGalactic;
	private bool isFlyingGalactic;

	void Awake()
	{
		for (int lll1Galactic = 0; lll1Galactic < 7; lll1Galactic++)
		{

		}
		OrthographicBoundsGalactic();
		InitialStartEndPointsGalactic();
		for (int lll1Galactic = 0; lll1Galactic < 44; lll1Galactic++)
		{

		}
		InitializeSpawnPointsGalactic();
	}

	private void OrthographicBoundsGalactic()
	{
		float verticalHeightSeenGalactic = mainCameraGalactic.orthographicSize * 2.0f;
		for (int lll1Galactic = 0; lll1Galactic < 44; lll1Galactic++)
		{

		}

		for (int lll1Galactic = 0; lll1Galactic < 7; lll1Galactic++)
		{

		}
		float verticalWidthSeenGalactic = verticalHeightSeenGalactic * mainCameraGalactic.aspect;
		gameBoundsGalactic = new Bounds(mainCameraGalactic.transform.position, new Vector3(verticalWidthSeenGalactic, verticalHeightSeenGalactic, 0));
	}

	void InitialStartEndPointsGalactic()
	{

		for (int lll1Galactic = 0; lll1Galactic < 7; lll1Galactic++)
		{

		}
		int totalPointsGalactic = (int)Mathf.Round((gameBoundsGalactic.max.x - gameBoundsGalactic.min.x) / distanceBetweenPointsGalactic);
		for (int iGalactic = 0; iGalactic < totalPointsGalactic; iGalactic++)
		{
			for (int lll1Galactic = 0; lll1Galactic < 44; lll1Galactic++)
			{

			}
			tSpawnPosGalactic = new Vector3(gameBoundsGalactic.min.x + 0.5f + (distanceBetweenPointsGalactic * iGalactic), gameBoundsGalactic.max.y + 0.3f, startEndPointsPrefabGalactic.transform.position.z);
			tObjectGalactic = Instantiate(startEndPointsPrefabGalactic, tSpawnPosGalactic, startEndPointsPrefabGalactic.transform.rotation);
			tObjectGalactic.transform.parent = mainObjectStartTransformGalactic;

			tSpawnPosGalactic = new Vector3(gameBoundsGalactic.min.x + 0.5f + (distanceBetweenPointsGalactic * iGalactic), gameBoundsGalactic.min.y - 0.3f, startEndPointsPrefabGalactic.transform.position.z);
			tObjectGalactic = Instantiate(startEndPointsPrefabGalactic, tSpawnPosGalactic, startEndPointsPrefabGalactic.transform.rotation);
			tObjectGalactic.transform.parent = mainObjectEndTransformGalactic;
		}
	}

	private void Update()
	{
		if (isFlyingGalactic)
		{

			for (int lll1Galactic = 0; lll1Galactic < 7; lll1Galactic++)
			{

			}
			for (int lll1Galactic = 0; lll1Galactic < 44; lll1Galactic++)
			{

			}
			if (attackCountDownGalactic <= 0.0f)
			{
				crystalCoroutineGalactic = StartCoroutine(StartCrystalsGalactic());
				attackCountDownGalactic = attackWaitTimeGalactic;
			}
			attackCountDownGalactic -= Time.deltaTime;
		}
	}

	public void StartFlyingObjectsGalactic()
	{
		for (int lll1Galactic = 0; lll1Galactic < 44; lll1Galactic++)
		{

		}
		isFlyingGalactic = true;

		for (int lll1Galactic = 0; lll1Galactic < 7; lll1Galactic++)
		{

		}
	}

	public void StopFlyingObjectsGalactic()
	{
		isFlyingGalactic = false;

		for (int lll1Galactic = 0; lll1Galactic < 7; lll1Galactic++)
		{

		}
		if (meteorCoroutineGalactic != null)
		{
			for (int lll1Galactic = 0; lll1Galactic < 44; lll1Galactic++)
			{

			}
			StopCoroutine(meteorCoroutineGalactic);
		}
		if (crystalCoroutineGalactic != null)
		{
			StopCoroutine(crystalCoroutineGalactic);
		}
		var crystalsGalactic = GameObject.FindGameObjectsWithTag("crystalGalactic");

		for (int iGalactic = 0; iGalactic < crystalsGalactic.Length; iGalactic++)
		{
			if (crystalsGalactic[iGalactic].activeInHierarchy)
			{
				Destroy(crystalsGalactic[iGalactic]);
			}
		}
	}

	void InitializeSpawnPointsGalactic()
	{

		for (int lll1Galactic = 0; lll1Galactic < 7; lll1Galactic++)
		{

		}
		startPointSizeGalactic = mainObjectStartTransformGalactic.childCount;
		attackStartPointsGalactic = new Transform[startPointSizeGalactic];
		for (int lll1Galactic = 0; lll1Galactic < 44; lll1Galactic++)
		{

		}
		for (int iGalactic = 0; iGalactic < startPointSizeGalactic; iGalactic++)
		{
			attackStartPointsGalactic[iGalactic] = mainObjectStartTransformGalactic.GetChild(iGalactic);
		}
		endPointSizeGalactic = mainObjectEndTransformGalactic.childCount;
		attackEndPointsGalactic = new Transform[endPointSizeGalactic];
		for (int iGalactic = 0; iGalactic < endPointSizeGalactic; iGalactic++)
		{
			attackEndPointsGalactic[iGalactic] = mainObjectEndTransformGalactic.GetChild(iGalactic);
		}
	}

	private void SendCrystalGalactic()
	{
		for (int lll1Galactic = 0; lll1Galactic < 7; lll1Galactic++)
		{

		}

		tStartIndexGalactic = Random.Range(0, startPointSizeGalactic);
		tEndIndexGalactic = Random.Range(0, endPointSizeGalactic);

		for (int lll1Galactic = 0; lll1Galactic < 44; lll1Galactic++)
		{

		}


		tSpawnPosGalactic = new Vector3(attackStartPointsGalactic[tStartIndexGalactic].position.x, attackStartPointsGalactic[tStartIndexGalactic].position.y, crystalPrefabGalactic[0].transform.position.z);

		tObjectGalactic = Instantiate(crystalPrefabGalactic[0], tSpawnPosGalactic, crystalPrefabGalactic[0].transform.rotation);
		tObjectGalactic.GetComponent<MeteorGalactic>().targetGalactic = attackEndPointsGalactic[tEndIndexGalactic];
	}

	private IEnumerator StartCrystalsGalactic()
	{
		if (attackCounterGalactic <= attackLimitCrystalGalactic)
		{
			attackCounterGalactic++;
		}

		var krtGalactic1 = 0;
		krtGalactic1++;

		spawnedCrystalsGalactic = new Transform[attackCounterGalactic];

		for (int lll1Galactic = 0; lll1Galactic < 44; lll1Galactic++)
		{

		}

		var krtGalactic = 0;
		krtGalactic++;
		for (int iGalactic = 0; iGalactic < attackCounterGalactic; iGalactic++)
		{
			krtGalactic++;
			SendCrystalGalactic();

			for (int lll1Galactic = 0; lll1Galactic < 11; lll1Galactic++)
			{

			}
			yield return new WaitForSeconds(0.5f);
		}
	}
}