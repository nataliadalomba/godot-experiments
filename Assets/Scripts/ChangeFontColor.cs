using Godot;

public partial class ChangeFontColor : RichTextLabel {

    // Exported property
    [Export(PropertyHint.ColorNoAlpha)]
    public Color textColor { get; set; }

    public override void _Ready() {
        // Set the modulation color
        Modulate = textColor;

        // Equivalent to `pass` in GDScript (nothing else to do here)
    }
}
