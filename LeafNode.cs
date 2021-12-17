using System;

public class LeafNode {
	public string name;
	public int distance;
	public bool calCheck;
	public LeafNode nextLeafNode;
	public LeafNode(string nameValue,int distanceValue)
	{
		name = nameValue;
		distance = distanceValue;
		nextLeafNode = null;
		calCheck = false;
	}
	
}
