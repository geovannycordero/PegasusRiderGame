using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class RandomObjectSpawner : MonoBehaviour {
  public GameObject arrow;
  public GameObject lightning;
  public GameObject tornado;

  private float timeBetweenArrowSpawns;
  private float timeBetweenThunderSpawns;
  private float timeBetweenTornadosSpawns;

  // Time to decrease when there is a level up
  public Vector2[] initialPositions;
  public int maxPauseTimeArrow;
  public int minPauseTimeArrow;
  public int maxPauseTimeThunder;
  public int minPauseTimeThunder;
  public int initialDistanceArrowLightning;

  // Start is called before the first frame update
  void Start() {
    int randomNumber = Random.Range(0, 2);
    if (randomNumber == 0) {
      timeBetweenArrowSpawns = Random.Range(minPauseTimeArrow, maxPauseTimeArrow) + initialDistanceArrowLightning;
    } else {
      timeBetweenThunderSpawns = Random.Range(minPauseTimeArrow, maxPauseTimeArrow) + initialDistanceArrowLightning;
    }

    timeBetweenTornadosSpawns = 5f;
  }

  void Update() {
    timeBetweenArrowSpawns -= Time.deltaTime;
    timeBetweenThunderSpawns -= Time.deltaTime;
    timeBetweenTornadosSpawns -= Time.deltaTime;

    if (timeBetweenArrowSpawns <= 0) {
      int randomNumber = Random.Range(0, initialPositions.Length);
      Instantiate(arrow, initialPositions[randomNumber], Quaternion.identity);
      timeBetweenArrowSpawns = Random.Range(minPauseTimeArrow, maxPauseTimeArrow);
    }
    else if (timeBetweenThunderSpawns <= 0) {
      int randomNumber = Random.Range(0, initialPositions.Length);
      Instantiate(lightning, initialPositions[randomNumber], Quaternion.identity);
      timeBetweenThunderSpawns = Random.Range(minPauseTimeThunder, maxPauseTimeThunder);
    } else {
      timeBetweenArrowSpawns -= Time.deltaTime;
      timeBetweenThunderSpawns -= Time.deltaTime;
    }
    if ( timeBetweenTornadosSpawns <= 0 )
    {
      //Change values to parameters
      int randomNumber = Random.Range(0, initialPositions.Length);
      Instantiate(tornado, initialPositions[randomNumber], Quaternion.identity);
      timeBetweenTornadosSpawns = Random.Range(0, 5);
    }
  }
}
