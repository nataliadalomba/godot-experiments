using Godot;
using System;

public partial class SpawnMoney : Button {
	private const string coinsScenePath = "res://Scenes/CoinsPile.tscn";
	private Button button;

	// Called when the node enters the scene tree for the first time.
	public override void _Ready() {
		button = GetNode<Button>("Button");
		button.Connect("pressed", new Callable(this, nameof(OnButtonPressed)));
	}
	
	private void OnButtonPressed() {
		PackedScene coinsScene = (PackedScene) ResourceLoader.Load(coinsScenePath);
		if (coinsScene != null) {
			Node2D sceneInstance = (Node2D) coinsScene.Instantiate();
			//add instantiated scene to the current scene tree as a child of the node running this script
			sceneInstance.Position = new Vector2(54, -56);
			AddChild(sceneInstance);
		} else GD.PrintErr("Failed to load CoinPile Scene!");
	}
}
