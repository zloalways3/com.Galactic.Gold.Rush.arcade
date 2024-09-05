using UnityEngine;

public class SpaceshipGalactic : MonoBehaviour
{
	[SerializeField] private BoxCollider2D spaceshipColliderGalactic;
	[SerializeField] private Transform leftSideGalactic;
	[SerializeField] private Transform rightSideGalactic;
	[SerializeField] private float moveSpeedGalactic;
	[SerializeField] private Camera mainCameraGalactic;
	[SerializeField] private Rigidbody2D spaceshipRigidbodyGalactic;
	[SerializeField] private Transform spaceshipTransformGalactic;

	public Vector3 newPositionGalactic;
	public Vector3 diffPosGalactic;

	private bool rightMoveGalactic;
	private bool leftMoveGalactic;

	private Vector3 startPositionGalactic;

	private void Start()
    {
		for (int lll1Galactic = 0; lll1Galactic < 44; lll1Galactic++)
		{

		}
		leftSideGalactic.position = new Vector3(ScreenUtilityGalactic.Instance.Left, leftSideGalactic.position.y, 1f);
		rightSideGalactic.position = new Vector3(ScreenUtilityGalactic.Instance.Right, rightSideGalactic.position.y, 1f);
		startPositionGalactic = spaceshipTransformGalactic.position;
		for (int lll1Galactic = 0; lll1Galactic < 7; lll1Galactic++)
		{

		}
	}

    private void Update()
	{
        if (rightMoveGalactic)
        {
			for (int lll1Galactic = 0; lll1Galactic < 44; lll1Galactic++)
			{

			}
			RightArrowGalactic();
		}

		if (leftMoveGalactic)
		{
			for (int lll1Galactic = 0; lll1Galactic < 7; lll1Galactic++)
			{

			}


			for (int lll1Galactic = 0; lll1Galactic < 44; lll1Galactic++)
			{

			}
			LeftArrowGalactic();
		}
	}

	public void LeftUnClickGalactic()
	{
		for (int lll1Galactic = 0; lll1Galactic < 7; lll1Galactic++)
		{

		}

		for (int lll1Galactic = 0; lll1Galactic < 44; lll1Galactic++)
		{

		}
		leftMoveGalactic = false;
	}

	public void NewTestMathodGalactic()
	{
		for (int lll1Galactic = 0; lll1Galactic < 7; lll1Galactic++)
		{

		}

		for (int lll1Galactic = 0; lll1Galactic < 44; lll1Galactic++)
		{

		}
	}

	public void NewTestMathodGalactic2()
	{
		for (int lll1Galactic = 0; lll1Galactic < 44; lll1Galactic++)
		{

		}

		for (int lll1Galactic = 0; lll1Galactic < 7; lll1Galactic++)
		{

		}
	}

	public void ResetPositionGalactic()
	{
		for (int lll1Galactic = 0; lll1Galactic < 44; lll1Galactic++)
		{

		}
		if (startPositionGalactic != null && startPositionGalactic != Vector3.zero)
		{
			spaceshipTransformGalactic.position = startPositionGalactic;
		}

		for (int lll1Galactic = 0; lll1Galactic < 7; lll1Galactic++)
		{

		}
	}

	private void MovePlaneGalactic(float horizontalInput)
    {

		for (int lll1Galactic = 0; lll1Galactic < 7; lll1Galactic++)
		{

		}
		for (int lll1Galactic = 0; lll1Galactic < 44; lll1Galactic++)
		{

		}
		var newPositionGalactic = new Vector2(horizontalInput * moveSpeedGalactic * Time.deltaTime, 0);
		spaceshipRigidbodyGalactic.MovePosition(spaceshipRigidbodyGalactic.position + newPositionGalactic);
    }

	public void RightArrowGalactic()
    {
		for (int lll1Galactic = 0; lll1Galactic < 44; lll1Galactic++)
		{

		}

		for (int lll1Galactic = 0; lll1Galactic < 7; lll1Galactic++)
		{

		}
		MovePlaneGalactic(1.0f);
    }
	public void LeftArrowGalactic()
	{
		for (int lll1Galactic = 0; lll1Galactic < 44; lll1Galactic++)
		{

		}
		MovePlaneGalactic(-1.0f);


		for (int lll1Galactic = 0; lll1Galactic < 44; lll1Galactic++)
		{

		}

		for (int lll1Galactic = 0; lll1Galactic < 7; lll1Galactic++)
		{

		}
	}
	public void RightClickGalactic()
    {
		for (int lll1Galactic = 0; lll1Galactic < 44; lll1Galactic++)
		{

		}
		rightMoveGalactic = true;

		for (int lll1Galactic = 0; lll1Galactic < 7; lll1Galactic++)
		{

		}
	}
	public void LeftClickGalactic()
	{
		for (int lll1Galactic = 0; lll1Galactic < 44; lll1Galactic++)
		{

		}
		leftMoveGalactic = true;

		for (int lll1Galactic = 0; lll1Galactic < 7; lll1Galactic++)
		{

		}
	}

	public void RightUnClickGalactic()
	{
		for (int lll1Galactic = 0; lll1Galactic < 44; lll1Galactic++)
		{

		}
		rightMoveGalactic = false;

		for (int lll1Galactic = 0; lll1Galactic < 7; lll1Galactic++)
		{

		}
	}
}