﻿namespace Snake;

public class Coordinate
{
	private readonly int x;
	private readonly int y;

	public int X => x;
	public int Y => y;

	public Coordinate(int x, int y)
	{
		this.x = x;
		this.y = y;
	}
}
