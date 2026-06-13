using System.Runtime.InteropServices;

public abstract class VirtualButton
{
	public enum Sensitivity
	{
		HIGH = 0,
		MEDIUM = 1,
		LOW = 2
	}

	[StructLayout((LayoutKind)0, Pack = 1)]
	public struct RectangleData
	{
		public float leftTopX;

		public float leftTopY;

		public float rightBottomX;

		public float rightBottomY;
	}

	public const Sensitivity DEFAULT_SENSITIVITY = Sensitivity.LOW;

	public abstract string Name { get; }

	public abstract int ID { get; }

	public abstract bool Enabled { get; }

	public abstract RectangleData Area { get; }

	public abstract bool SetArea(RectangleData area);

	public abstract bool SetSensitivity(Sensitivity sensitivity);

	public abstract bool SetEnabled(bool enabled);
}
