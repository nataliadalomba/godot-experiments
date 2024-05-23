using Godot;

public partial class SpawnMoney : Button {
	private PackedScene coinPileScene = GD.Load<PackedScene>("res://Scenes/CoinPile.tscn");

	// Called when the node enters the scene tree for the first time.
	public override void _Ready() {
		if (coinPileScene == null) {
			GD.PrintErr(nameof(coinPileScene) + " did not load!");
			return;
		}
		Connect("pressed", new Callable(this, nameof(OnButtonPressed)));
	}
	
	private void OnButtonPressed() {
		Node2D coinInstance = (Node2D) coinPileScene.Instantiate();
		coinInstance.Position = new Vector2(54, -56);
		AddChild(coinInstance, true);
	}
}
