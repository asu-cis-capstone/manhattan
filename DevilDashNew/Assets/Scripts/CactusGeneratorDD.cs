using UnityEngine;
using System.Collections;

public class CactusGeneratorDD : MonoBehaviour {

	public ObjectPoolerDD cactusPool;

	public float distanceBetweenCactus;

	public void SpawnCactus(Vector3 startPosition)
	{
		GameObject cactus1 = cactusPool.GetPooledObject ();
		cactus1.transform.position = startPosition;
		cactus1.SetActive (true);

		/*GameObject cactus2 = cactusPool.GetPooledObject ();
		cactus2.transform.position = new Vector3(startPosition.x - distanceBetweenCactus, startPosition.y, startPosition.z);
		cactus2.SetActive (true);

		GameObject cactus3 = cactusPool.GetPooledObject ();
		cactus3.transform.position = new Vector3(startPosition.x + distanceBetweenCactus, startPosition.y, startPosition.z);
		cactus3.SetActive (true); */
	}
}
