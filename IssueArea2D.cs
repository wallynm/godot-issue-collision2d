using Godot;
using System;
using System.Linq;

public partial class IssueArea2D : Area2D
{
	private Color _pathColor;
	private CollisionPolygon2D _collisionShape;

	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		_pathColor = new Color(0.5f, 0.5f, 0.5f, 0.5f);
		_collisionShape = (CollisionPolygon2D)GetNode("CollisionPolygon2D");
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	}

	public override void _Draw()
	{
		// Godot drawn polyline with option "Editable children" for acess to localPolygon updated values
		Vector2[] localPolygon = _collisionShape.Polygon.ToArray();
		localPolygon = localPolygon.Append(localPolygon[0]).ToArray();
		DrawPolyline(localPolygon, _pathColor, 40f, true);
	}
}
