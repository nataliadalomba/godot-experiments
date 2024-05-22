using Godot;
using System;

public partial class SpawnMoney : Button {
    Sprite2D coins;

    // Called when the node enters the scene tree for the first time.
    public override void _Ready() {
        coins = SceneFilePath("res://CoinsPile.tscn");
    }

    // Called every frame. 'delta' is the elapsed time since the previous frame.
    public override void _Process(double delta) {
        
    }

    public bool IsButtonClicked() {
        if (this.ButtonPressed)
            
    }
}
