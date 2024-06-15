using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class PlayerMove : MonoBehaviour {


	public float movespeed;
	public List<Coin> coinObject;
	public List<Transform> treeObject;
	public Text scoreText;
	int coinCount;


	// Update is called once per frame
	void Update () 
	{
		MovePlayer();

		HandleCoinPick();

		if(Input.GetKeyDown(KeyCode.Space))
        {
			HandleTreePickUp();
		}
		

	}

    private void HandleTreePickUp()
    {
       for(int i=0;i<treeObject.Count;i++)
        {
			Transform treeTransformObject = treeObject[i];
			float treeCoinDistance=0.5f;

			if(Vector3.Distance(transform.position,treeTransformObject.transform.position)<treeCoinDistance)
            {

				switch( treeTransformObject.name)
                {
					case "Tree 2 coin":

                        {
							AddScore();
							AddScore();
						}
						break;
					case "Tree 3 coin":

						{
							AddScore();
							AddScore();
							AddScore();
						}
						break;
					default:
                        {
							Debug.Log("NoCoins");
                        }
						break;


				}
            }
        }
    }

    void MovePlayer()
    {
		if(Input.GetKey(KeyCode.W)|| Input.GetKeyDown(KeyCode.UpArrow))
        {
			transform.position += new Vector3(0, +1, 0) * movespeed;
        }
		if (Input.GetKey(KeyCode.S) || Input.GetKeyDown(KeyCode.DownArrow))
		{
			transform.position += new Vector3(0, -1, 0) * movespeed;
		}
		if (Input.GetKey(KeyCode.A) || Input.GetKeyDown(KeyCode.LeftArrow))
		{
			transform.position += new Vector3(-1, 0, 0) * movespeed;
		}
		if (Input.GetKey(KeyCode.D) || Input.GetKeyDown(KeyCode.RightArrow))
		{
			transform.position += new Vector3(+1, 0, 0) * movespeed;
		}
	}


	void HandleCoinPick()
    {

		foreach(Coin coin in coinObject)
        {
			if (coin != null)
			{
				float coinDistanceCheck = 0.5f;

				if (Vector3.Distance(transform.position, coin.transform.position) < coinDistanceCheck)
				{
					coin.DestroyCoin();
					AddScore();

				}
			}
        }
    }


	void AddScore()
    {
		coinCount++;
		scoreText.text = coinCount.ToString();
    }
}
