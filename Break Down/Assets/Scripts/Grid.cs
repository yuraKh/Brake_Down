using UnityEngine;
using System.Collections;

public class Grid : MonoBehaviour {
	
	public GameObject sprite;
	float cellSize = 10f;
	
	static public GameObject [,] grid = new GameObject [6,10];
	
	void Start () 
	{
		//x=Mathf.Abs (-1.1f);
		float xPos = -30f;
		for(int x = 0; x < 6; x++)
		{
			float yPos = -15f;
			for(int y = 0; y < 10; y++)
			{
				GameObject spriteGrid = (GameObject)Instantiate(sprite);
				spriteGrid.transform.position = new Vector3(spriteGrid.transform.position.x + xPos, spriteGrid.transform.position.y + yPos, spriteGrid.transform.position.z);
				spriteGrid.transform.name = "Square" + x + " " +y;
				grid[x,y] = spriteGrid;
				//Debug.Log (xPos + "xPos" + yPos + "yPos");
				
				yPos += cellSize;
				
			}
			xPos += cellSize;
			
		}
		
	}
	
	void Update () 
	{
	}
	
}