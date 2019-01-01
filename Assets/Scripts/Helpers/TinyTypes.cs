using UnityEngine;

public struct Mass {
	private float floatValue;

	public float Float { get { return floatValue; } }


	public Mass(float floatValue) {
		this.floatValue = floatValue;
	}

	public static Mass operator +(Mass value1, Mass value2) {
		return new Mass(value1.floatValue + value2.floatValue);
	}

	public static Mass operator -(Mass value1, Mass value2) {
		return new Mass(value1.floatValue - value2.floatValue);
	}

	public static float operator /(Mass value1, Mass value2) {
		return value1.floatValue / value2.floatValue;
	}

	public static Mass operator *(Mass value, float scale) {
		return new Mass(value.floatValue * scale);
	}

	public static Mass operator *(float scale, Mass value) {
		return new Mass(value.floatValue * scale);
	}

	public static Mass operator /(Mass value, float scale) {
		return new Mass(value.floatValue / scale);
	}

	public static Force operator *(Mass value1, Acceleration value2) {
		return new Force(value1.Float * value2.Vector2);
	}

	public static bool operator <(Mass value1, Mass value2) {
		return value1.floatValue < value2.floatValue;
	}

	public static bool operator >(Mass value1, Mass value2) {
		return value1.floatValue > value2.floatValue;
	}

	public static bool operator <=(Mass value1, Mass value2) {
		return value1.floatValue <= value2.floatValue;
	}

	public static bool operator >=(Mass value1, Mass value2) {
		return value1.floatValue >= value2.floatValue;
	}

	public static bool operator ==(Mass value1, Mass value2) {
		return value1.floatValue == value2.floatValue;
	}

	public static bool operator !=(Mass value1, Mass value2) {
		return value1.floatValue != value2.floatValue;
	}

	public override bool Equals(object obj) {
		return floatValue.Equals(obj);
	}

	public override int GetHashCode() {
		return floatValue.GetHashCode();
	}
}

public struct Time {
	private float floatValue;

	public float Float { get { return floatValue; } }


	public Time(float floatValue) {
		this.floatValue = floatValue;
	}

	public static Time operator +(Time value1, Time value2) {
		return new Time(value1.floatValue + value2.floatValue);
	}

	public static Time operator -(Time value1, Time value2) {
		return new Time(value1.floatValue - value2.floatValue);
	}

	public static float operator /(Time value1, Time value2) {
		return value1.floatValue / value2.floatValue;
	}

	public static Time operator *(Time value, float scale) {
		return new Time(value.floatValue * scale);
	}

	public static Time operator *(float scale, Time value) {
		return new Time(value.floatValue * scale);
	}

	public static Time operator /(Time value, float scale) {
		return new Time(value.floatValue / scale);
	}

	public static float operator *(Time value1, Frequency value2) {
		return value1 *value2;
	}

	public static Frequency operator /(float value1, Time value2) {
		return new Frequency(value1 / value2.Float);
	}

	public static Velocity operator *(Time value1, Acceleration value2) {
		return new Velocity(value1.Float * value2.Vector2);
	}

	public static Position operator *(Time value1, Velocity value2) {
		return new Position(value1.Float * value2.Vector2);
	}

	public static bool operator <(Time value1, Time value2) {
		return value1.floatValue < value2.floatValue;
	}

	public static bool operator >(Time value1, Time value2) {
		return value1.floatValue > value2.floatValue;
	}

	public static bool operator <=(Time value1, Time value2) {
		return value1.floatValue <= value2.floatValue;
	}

	public static bool operator >=(Time value1, Time value2) {
		return value1.floatValue >= value2.floatValue;
	}

	public static bool operator ==(Time value1, Time value2) {
		return value1.floatValue == value2.floatValue;
	}

	public static bool operator !=(Time value1, Time value2) {
		return value1.floatValue != value2.floatValue;
	}

	public override bool Equals(object obj) {
		return floatValue.Equals(obj);
	}

	public override int GetHashCode() {
		return floatValue.GetHashCode();
	}
}

public struct AngularAcceleration {
	private float floatValue;

	public float Float { get { return floatValue; } }


	public AngularAcceleration(float floatValue) {
		this.floatValue = floatValue;
	}

	public static AngularAcceleration operator +(AngularAcceleration value1, AngularAcceleration value2) {
		return new AngularAcceleration(value1.floatValue + value2.floatValue);
	}

	public static AngularAcceleration operator -(AngularAcceleration value1, AngularAcceleration value2) {
		return new AngularAcceleration(value1.floatValue - value2.floatValue);
	}

	public static float operator /(AngularAcceleration value1, AngularAcceleration value2) {
		return value1.floatValue / value2.floatValue;
	}

	public static AngularAcceleration operator *(AngularAcceleration value, float scale) {
		return new AngularAcceleration(value.floatValue * scale);
	}

	public static AngularAcceleration operator *(float scale, AngularAcceleration value) {
		return new AngularAcceleration(value.floatValue * scale);
	}

	public static AngularAcceleration operator /(AngularAcceleration value, float scale) {
		return new AngularAcceleration(value.floatValue / scale);
	}

	public static bool operator <(AngularAcceleration value1, AngularAcceleration value2) {
		return value1.floatValue < value2.floatValue;
	}

	public static bool operator >(AngularAcceleration value1, AngularAcceleration value2) {
		return value1.floatValue > value2.floatValue;
	}

	public static bool operator <=(AngularAcceleration value1, AngularAcceleration value2) {
		return value1.floatValue <= value2.floatValue;
	}

	public static bool operator >=(AngularAcceleration value1, AngularAcceleration value2) {
		return value1.floatValue >= value2.floatValue;
	}

	public static bool operator ==(AngularAcceleration value1, AngularAcceleration value2) {
		return value1.floatValue == value2.floatValue;
	}

	public static bool operator !=(AngularAcceleration value1, AngularAcceleration value2) {
		return value1.floatValue != value2.floatValue;
	}

	public override bool Equals(object obj) {
		return floatValue.Equals(obj);
	}

	public override int GetHashCode() {
		return floatValue.GetHashCode();
	}
}

public struct AngularSpeed {
	private float floatValue;

	public float Float { get { return floatValue; } }


	public AngularSpeed(float floatValue) {
		this.floatValue = floatValue;
	}

	public static AngularSpeed operator +(AngularSpeed value1, AngularSpeed value2) {
		return new AngularSpeed(value1.floatValue + value2.floatValue);
	}

	public static AngularSpeed operator -(AngularSpeed value1, AngularSpeed value2) {
		return new AngularSpeed(value1.floatValue - value2.floatValue);
	}

	public static float operator /(AngularSpeed value1, AngularSpeed value2) {
		return value1.floatValue / value2.floatValue;
	}

	public static AngularSpeed operator *(AngularSpeed value, float scale) {
		return new AngularSpeed(value.floatValue * scale);
	}

	public static AngularSpeed operator *(float scale, AngularSpeed value) {
		return new AngularSpeed(value.floatValue * scale);
	}

	public static AngularSpeed operator /(AngularSpeed value, float scale) {
		return new AngularSpeed(value.floatValue / scale);
	}

	public static bool operator <(AngularSpeed value1, AngularSpeed value2) {
		return value1.floatValue < value2.floatValue;
	}

	public static bool operator >(AngularSpeed value1, AngularSpeed value2) {
		return value1.floatValue > value2.floatValue;
	}

	public static bool operator <=(AngularSpeed value1, AngularSpeed value2) {
		return value1.floatValue <= value2.floatValue;
	}

	public static bool operator >=(AngularSpeed value1, AngularSpeed value2) {
		return value1.floatValue >= value2.floatValue;
	}

	public static bool operator ==(AngularSpeed value1, AngularSpeed value2) {
		return value1.floatValue == value2.floatValue;
	}

	public static bool operator !=(AngularSpeed value1, AngularSpeed value2) {
		return value1.floatValue != value2.floatValue;
	}

	public override bool Equals(object obj) {
		return floatValue.Equals(obj);
	}

	public override int GetHashCode() {
		return floatValue.GetHashCode();
	}
}

public struct Frequency {
	private float floatValue;

	public float Float { get { return floatValue; } }


	public Frequency(float floatValue) {
		this.floatValue = floatValue;
	}

	public static Frequency operator +(Frequency value1, Frequency value2) {
		return new Frequency(value1.floatValue + value2.floatValue);
	}

	public static Frequency operator -(Frequency value1, Frequency value2) {
		return new Frequency(value1.floatValue - value2.floatValue);
	}

	public static float operator /(Frequency value1, Frequency value2) {
		return value1.floatValue / value2.floatValue;
	}

	public static Frequency operator *(Frequency value, float scale) {
		return new Frequency(value.floatValue * scale);
	}

	public static Frequency operator *(float scale, Frequency value) {
		return new Frequency(value.floatValue * scale);
	}

	public static Frequency operator /(Frequency value, float scale) {
		return new Frequency(value.floatValue / scale);
	}

	public static float operator *(Frequency value1, Time value2) {
		return value1 *value2;
	}

	public static Time operator /(float value1, Frequency value2) {
		return new Time(value1 / value2.Float);
	}

	public static bool operator <(Frequency value1, Frequency value2) {
		return value1.floatValue < value2.floatValue;
	}

	public static bool operator >(Frequency value1, Frequency value2) {
		return value1.floatValue > value2.floatValue;
	}

	public static bool operator <=(Frequency value1, Frequency value2) {
		return value1.floatValue <= value2.floatValue;
	}

	public static bool operator >=(Frequency value1, Frequency value2) {
		return value1.floatValue >= value2.floatValue;
	}

	public static bool operator ==(Frequency value1, Frequency value2) {
		return value1.floatValue == value2.floatValue;
	}

	public static bool operator !=(Frequency value1, Frequency value2) {
		return value1.floatValue != value2.floatValue;
	}

	public override bool Equals(object obj) {
		return floatValue.Equals(obj);
	}

	public override int GetHashCode() {
		return floatValue.GetHashCode();
	}
}

public struct Area {
	private float floatValue;

	public float Float { get { return floatValue; } }


	public Area(float floatValue) {
		this.floatValue = floatValue;
	}

	public static Area operator +(Area value1, Area value2) {
		return new Area(value1.floatValue + value2.floatValue);
	}

	public static Area operator -(Area value1, Area value2) {
		return new Area(value1.floatValue - value2.floatValue);
	}

	public static float operator /(Area value1, Area value2) {
		return value1.floatValue / value2.floatValue;
	}

	public static Area operator *(Area value, float scale) {
		return new Area(value.floatValue * scale);
	}

	public static Area operator *(float scale, Area value) {
		return new Area(value.floatValue * scale);
	}

	public static Area operator /(Area value, float scale) {
		return new Area(value.floatValue / scale);
	}

	public static bool operator <(Area value1, Area value2) {
		return value1.floatValue < value2.floatValue;
	}

	public static bool operator >(Area value1, Area value2) {
		return value1.floatValue > value2.floatValue;
	}

	public static bool operator <=(Area value1, Area value2) {
		return value1.floatValue <= value2.floatValue;
	}

	public static bool operator >=(Area value1, Area value2) {
		return value1.floatValue >= value2.floatValue;
	}

	public static bool operator ==(Area value1, Area value2) {
		return value1.floatValue == value2.floatValue;
	}

	public static bool operator !=(Area value1, Area value2) {
		return value1.floatValue != value2.floatValue;
	}

	public override bool Equals(object obj) {
		return floatValue.Equals(obj);
	}

	public override int GetHashCode() {
		return floatValue.GetHashCode();
	}
}

public struct Weight {
	private float floatValue;

	public float Float { get { return floatValue; } }


	public Weight(float floatValue) {
		this.floatValue = floatValue;
	}

	public static Weight operator +(Weight value1, Weight value2) {
		return new Weight(value1.floatValue + value2.floatValue);
	}

	public static Weight operator -(Weight value1, Weight value2) {
		return new Weight(value1.floatValue - value2.floatValue);
	}

	public static float operator /(Weight value1, Weight value2) {
		return value1.floatValue / value2.floatValue;
	}

	public static Weight operator *(Weight value, float scale) {
		return new Weight(value.floatValue * scale);
	}

	public static Weight operator *(float scale, Weight value) {
		return new Weight(value.floatValue * scale);
	}

	public static Weight operator /(Weight value, float scale) {
		return new Weight(value.floatValue / scale);
	}

	public static bool operator <(Weight value1, Weight value2) {
		return value1.floatValue < value2.floatValue;
	}

	public static bool operator >(Weight value1, Weight value2) {
		return value1.floatValue > value2.floatValue;
	}

	public static bool operator <=(Weight value1, Weight value2) {
		return value1.floatValue <= value2.floatValue;
	}

	public static bool operator >=(Weight value1, Weight value2) {
		return value1.floatValue >= value2.floatValue;
	}

	public static bool operator ==(Weight value1, Weight value2) {
		return value1.floatValue == value2.floatValue;
	}

	public static bool operator !=(Weight value1, Weight value2) {
		return value1.floatValue != value2.floatValue;
	}

	public override bool Equals(object obj) {
		return floatValue.Equals(obj);
	}

	public override int GetHashCode() {
		return floatValue.GetHashCode();
	}
}

public struct Impulse {
	private float floatValue;

	public float Float { get { return floatValue; } }


	public Impulse(float floatValue) {
		this.floatValue = floatValue;
	}

	public static Impulse operator +(Impulse value1, Impulse value2) {
		return new Impulse(value1.floatValue + value2.floatValue);
	}

	public static Impulse operator -(Impulse value1, Impulse value2) {
		return new Impulse(value1.floatValue - value2.floatValue);
	}

	public static float operator /(Impulse value1, Impulse value2) {
		return value1.floatValue / value2.floatValue;
	}

	public static Impulse operator *(Impulse value, float scale) {
		return new Impulse(value.floatValue * scale);
	}

	public static Impulse operator *(float scale, Impulse value) {
		return new Impulse(value.floatValue * scale);
	}

	public static Impulse operator /(Impulse value, float scale) {
		return new Impulse(value.floatValue / scale);
	}

	public static bool operator <(Impulse value1, Impulse value2) {
		return value1.floatValue < value2.floatValue;
	}

	public static bool operator >(Impulse value1, Impulse value2) {
		return value1.floatValue > value2.floatValue;
	}

	public static bool operator <=(Impulse value1, Impulse value2) {
		return value1.floatValue <= value2.floatValue;
	}

	public static bool operator >=(Impulse value1, Impulse value2) {
		return value1.floatValue >= value2.floatValue;
	}

	public static bool operator ==(Impulse value1, Impulse value2) {
		return value1.floatValue == value2.floatValue;
	}

	public static bool operator !=(Impulse value1, Impulse value2) {
		return value1.floatValue != value2.floatValue;
	}

	public override bool Equals(object obj) {
		return floatValue.Equals(obj);
	}

	public override int GetHashCode() {
		return floatValue.GetHashCode();
	}
}

public struct MomentOfInertia {
	private float floatValue;

	public float Float { get { return floatValue; } }


	public MomentOfInertia(float floatValue) {
		this.floatValue = floatValue;
	}

	public static MomentOfInertia operator +(MomentOfInertia value1, MomentOfInertia value2) {
		return new MomentOfInertia(value1.floatValue + value2.floatValue);
	}

	public static MomentOfInertia operator -(MomentOfInertia value1, MomentOfInertia value2) {
		return new MomentOfInertia(value1.floatValue - value2.floatValue);
	}

	public static float operator /(MomentOfInertia value1, MomentOfInertia value2) {
		return value1.floatValue / value2.floatValue;
	}

	public static MomentOfInertia operator *(MomentOfInertia value, float scale) {
		return new MomentOfInertia(value.floatValue * scale);
	}

	public static MomentOfInertia operator *(float scale, MomentOfInertia value) {
		return new MomentOfInertia(value.floatValue * scale);
	}

	public static MomentOfInertia operator /(MomentOfInertia value, float scale) {
		return new MomentOfInertia(value.floatValue / scale);
	}

	public static bool operator <(MomentOfInertia value1, MomentOfInertia value2) {
		return value1.floatValue < value2.floatValue;
	}

	public static bool operator >(MomentOfInertia value1, MomentOfInertia value2) {
		return value1.floatValue > value2.floatValue;
	}

	public static bool operator <=(MomentOfInertia value1, MomentOfInertia value2) {
		return value1.floatValue <= value2.floatValue;
	}

	public static bool operator >=(MomentOfInertia value1, MomentOfInertia value2) {
		return value1.floatValue >= value2.floatValue;
	}

	public static bool operator ==(MomentOfInertia value1, MomentOfInertia value2) {
		return value1.floatValue == value2.floatValue;
	}

	public static bool operator !=(MomentOfInertia value1, MomentOfInertia value2) {
		return value1.floatValue != value2.floatValue;
	}

	public override bool Equals(object obj) {
		return floatValue.Equals(obj);
	}

	public override int GetHashCode() {
		return floatValue.GetHashCode();
	}
}

public struct Work {
	private float floatValue;

	public float Float { get { return floatValue; } }


	public Work(float floatValue) {
		this.floatValue = floatValue;
	}

	public static Work operator +(Work value1, Work value2) {
		return new Work(value1.floatValue + value2.floatValue);
	}

	public static Work operator -(Work value1, Work value2) {
		return new Work(value1.floatValue - value2.floatValue);
	}

	public static float operator /(Work value1, Work value2) {
		return value1.floatValue / value2.floatValue;
	}

	public static Work operator *(Work value, float scale) {
		return new Work(value.floatValue * scale);
	}

	public static Work operator *(float scale, Work value) {
		return new Work(value.floatValue * scale);
	}

	public static Work operator /(Work value, float scale) {
		return new Work(value.floatValue / scale);
	}

	public static bool operator <(Work value1, Work value2) {
		return value1.floatValue < value2.floatValue;
	}

	public static bool operator >(Work value1, Work value2) {
		return value1.floatValue > value2.floatValue;
	}

	public static bool operator <=(Work value1, Work value2) {
		return value1.floatValue <= value2.floatValue;
	}

	public static bool operator >=(Work value1, Work value2) {
		return value1.floatValue >= value2.floatValue;
	}

	public static bool operator ==(Work value1, Work value2) {
		return value1.floatValue == value2.floatValue;
	}

	public static bool operator !=(Work value1, Work value2) {
		return value1.floatValue != value2.floatValue;
	}

	public override bool Equals(object obj) {
		return floatValue.Equals(obj);
	}

	public override int GetHashCode() {
		return floatValue.GetHashCode();
	}
}

public struct Angle {
	private float floatValue;

	public float Float { get { return floatValue; } }


	public Angle(float floatValue) {
		this.floatValue = floatValue;
	}

	public static Angle operator +(Angle value1, Angle value2) {
		return new Angle(value1.floatValue + value2.floatValue);
	}

	public static Angle operator -(Angle value1, Angle value2) {
		return new Angle(value1.floatValue - value2.floatValue);
	}

	public static float operator /(Angle value1, Angle value2) {
		return value1.floatValue / value2.floatValue;
	}

	public static Angle operator *(Angle value, float scale) {
		return new Angle(value.floatValue * scale);
	}

	public static Angle operator *(float scale, Angle value) {
		return new Angle(value.floatValue * scale);
	}

	public static Angle operator /(Angle value, float scale) {
		return new Angle(value.floatValue / scale);
	}

	public static bool operator <(Angle value1, Angle value2) {
		return value1.floatValue < value2.floatValue;
	}

	public static bool operator >(Angle value1, Angle value2) {
		return value1.floatValue > value2.floatValue;
	}

	public static bool operator <=(Angle value1, Angle value2) {
		return value1.floatValue <= value2.floatValue;
	}

	public static bool operator >=(Angle value1, Angle value2) {
		return value1.floatValue >= value2.floatValue;
	}

	public static bool operator ==(Angle value1, Angle value2) {
		return value1.floatValue == value2.floatValue;
	}

	public static bool operator !=(Angle value1, Angle value2) {
		return value1.floatValue != value2.floatValue;
	}

	public override bool Equals(object obj) {
		return floatValue.Equals(obj);
	}

	public override int GetHashCode() {
		return floatValue.GetHashCode();
	}
}

public struct PositionX {
	private float floatValue;

	public float Float { get { return floatValue; } }


	public PositionX(float floatValue) {
		this.floatValue = floatValue;
	}

	public static PositionX operator +(PositionX value1, PositionX value2) {
		return new PositionX(value1.floatValue + value2.floatValue);
	}

	public static PositionX operator -(PositionX value1, PositionX value2) {
		return new PositionX(value1.floatValue - value2.floatValue);
	}

	public static float operator /(PositionX value1, PositionX value2) {
		return value1.floatValue / value2.floatValue;
	}

	public static PositionX operator *(PositionX value, float scale) {
		return new PositionX(value.floatValue * scale);
	}

	public static PositionX operator *(float scale, PositionX value) {
		return new PositionX(value.floatValue * scale);
	}

	public static PositionX operator /(PositionX value, float scale) {
		return new PositionX(value.floatValue / scale);
	}

	public static bool operator <(PositionX value1, PositionX value2) {
		return value1.floatValue < value2.floatValue;
	}

	public static bool operator >(PositionX value1, PositionX value2) {
		return value1.floatValue > value2.floatValue;
	}

	public static bool operator <=(PositionX value1, PositionX value2) {
		return value1.floatValue <= value2.floatValue;
	}

	public static bool operator >=(PositionX value1, PositionX value2) {
		return value1.floatValue >= value2.floatValue;
	}

	public static bool operator ==(PositionX value1, PositionX value2) {
		return value1.floatValue == value2.floatValue;
	}

	public static bool operator !=(PositionX value1, PositionX value2) {
		return value1.floatValue != value2.floatValue;
	}

	public override bool Equals(object obj) {
		return floatValue.Equals(obj);
	}

	public override int GetHashCode() {
		return floatValue.GetHashCode();
	}
}

public struct PositionY {
	private float floatValue;

	public float Float { get { return floatValue; } }


	public PositionY(float floatValue) {
		this.floatValue = floatValue;
	}

	public static PositionY operator +(PositionY value1, PositionY value2) {
		return new PositionY(value1.floatValue + value2.floatValue);
	}

	public static PositionY operator -(PositionY value1, PositionY value2) {
		return new PositionY(value1.floatValue - value2.floatValue);
	}

	public static float operator /(PositionY value1, PositionY value2) {
		return value1.floatValue / value2.floatValue;
	}

	public static PositionY operator *(PositionY value, float scale) {
		return new PositionY(value.floatValue * scale);
	}

	public static PositionY operator *(float scale, PositionY value) {
		return new PositionY(value.floatValue * scale);
	}

	public static PositionY operator /(PositionY value, float scale) {
		return new PositionY(value.floatValue / scale);
	}

	public static bool operator <(PositionY value1, PositionY value2) {
		return value1.floatValue < value2.floatValue;
	}

	public static bool operator >(PositionY value1, PositionY value2) {
		return value1.floatValue > value2.floatValue;
	}

	public static bool operator <=(PositionY value1, PositionY value2) {
		return value1.floatValue <= value2.floatValue;
	}

	public static bool operator >=(PositionY value1, PositionY value2) {
		return value1.floatValue >= value2.floatValue;
	}

	public static bool operator ==(PositionY value1, PositionY value2) {
		return value1.floatValue == value2.floatValue;
	}

	public static bool operator !=(PositionY value1, PositionY value2) {
		return value1.floatValue != value2.floatValue;
	}

	public override bool Equals(object obj) {
		return floatValue.Equals(obj);
	}

	public override int GetHashCode() {
		return floatValue.GetHashCode();
	}
}

public struct PositionMagnitude {
	private float floatValue;

	public float Float { get { return floatValue; } }


	public PositionMagnitude(float floatValue) {
		this.floatValue = floatValue;
	}

	public static PositionMagnitude operator +(PositionMagnitude value1, PositionMagnitude value2) {
		return new PositionMagnitude(value1.floatValue + value2.floatValue);
	}

	public static PositionMagnitude operator -(PositionMagnitude value1, PositionMagnitude value2) {
		return new PositionMagnitude(value1.floatValue - value2.floatValue);
	}

	public static float operator /(PositionMagnitude value1, PositionMagnitude value2) {
		return value1.floatValue / value2.floatValue;
	}

	public static PositionMagnitude operator *(PositionMagnitude value, float scale) {
		return new PositionMagnitude(value.floatValue * scale);
	}

	public static PositionMagnitude operator *(float scale, PositionMagnitude value) {
		return new PositionMagnitude(value.floatValue * scale);
	}

	public static PositionMagnitude operator /(PositionMagnitude value, float scale) {
		return new PositionMagnitude(value.floatValue / scale);
	}

	public static PositionMgSq operator *(PositionMagnitude value1, PositionMagnitude value2) {
		return new PositionMgSq(value1.Float * value2.Float);
	}

	public static bool operator <(PositionMagnitude value1, PositionMagnitude value2) {
		return value1.floatValue < value2.floatValue;
	}

	public static bool operator >(PositionMagnitude value1, PositionMagnitude value2) {
		return value1.floatValue > value2.floatValue;
	}

	public static bool operator <=(PositionMagnitude value1, PositionMagnitude value2) {
		return value1.floatValue <= value2.floatValue;
	}

	public static bool operator >=(PositionMagnitude value1, PositionMagnitude value2) {
		return value1.floatValue >= value2.floatValue;
	}

	public static bool operator ==(PositionMagnitude value1, PositionMagnitude value2) {
		return value1.floatValue == value2.floatValue;
	}

	public static bool operator !=(PositionMagnitude value1, PositionMagnitude value2) {
		return value1.floatValue != value2.floatValue;
	}

	public override bool Equals(object obj) {
		return floatValue.Equals(obj);
	}

	public override int GetHashCode() {
		return floatValue.GetHashCode();
	}
}

public struct PositionDot {
	private float floatValue;

	public float Float { get { return floatValue; } }


	public PositionDot(float floatValue) {
		this.floatValue = floatValue;
	}

	public static PositionDot operator +(PositionDot value1, PositionDot value2) {
		return new PositionDot(value1.floatValue + value2.floatValue);
	}

	public static PositionDot operator -(PositionDot value1, PositionDot value2) {
		return new PositionDot(value1.floatValue - value2.floatValue);
	}

	public static float operator /(PositionDot value1, PositionDot value2) {
		return value1.floatValue / value2.floatValue;
	}

	public static PositionDot operator *(PositionDot value, float scale) {
		return new PositionDot(value.floatValue * scale);
	}

	public static PositionDot operator *(float scale, PositionDot value) {
		return new PositionDot(value.floatValue * scale);
	}

	public static PositionDot operator /(PositionDot value, float scale) {
		return new PositionDot(value.floatValue / scale);
	}

	public static bool operator <(PositionDot value1, PositionDot value2) {
		return value1.floatValue < value2.floatValue;
	}

	public static bool operator >(PositionDot value1, PositionDot value2) {
		return value1.floatValue > value2.floatValue;
	}

	public static bool operator <=(PositionDot value1, PositionDot value2) {
		return value1.floatValue <= value2.floatValue;
	}

	public static bool operator >=(PositionDot value1, PositionDot value2) {
		return value1.floatValue >= value2.floatValue;
	}

	public static bool operator ==(PositionDot value1, PositionDot value2) {
		return value1.floatValue == value2.floatValue;
	}

	public static bool operator !=(PositionDot value1, PositionDot value2) {
		return value1.floatValue != value2.floatValue;
	}

	public override bool Equals(object obj) {
		return floatValue.Equals(obj);
	}

	public override int GetHashCode() {
		return floatValue.GetHashCode();
	}
}

public struct PositionMgSq {
	private float floatValue;

	public float Float { get { return floatValue; } }


	public PositionMgSq(float floatValue) {
		this.floatValue = floatValue;
	}

	public static PositionMgSq operator +(PositionMgSq value1, PositionMgSq value2) {
		return new PositionMgSq(value1.floatValue + value2.floatValue);
	}

	public static PositionMgSq operator -(PositionMgSq value1, PositionMgSq value2) {
		return new PositionMgSq(value1.floatValue - value2.floatValue);
	}

	public static float operator /(PositionMgSq value1, PositionMgSq value2) {
		return value1.floatValue / value2.floatValue;
	}

	public static PositionMgSq operator *(PositionMgSq value, float scale) {
		return new PositionMgSq(value.floatValue * scale);
	}

	public static PositionMgSq operator *(float scale, PositionMgSq value) {
		return new PositionMgSq(value.floatValue * scale);
	}

	public static PositionMgSq operator /(PositionMgSq value, float scale) {
		return new PositionMgSq(value.floatValue / scale);
	}

	public static bool operator <(PositionMgSq value1, PositionMgSq value2) {
		return value1.floatValue < value2.floatValue;
	}

	public static bool operator >(PositionMgSq value1, PositionMgSq value2) {
		return value1.floatValue > value2.floatValue;
	}

	public static bool operator <=(PositionMgSq value1, PositionMgSq value2) {
		return value1.floatValue <= value2.floatValue;
	}

	public static bool operator >=(PositionMgSq value1, PositionMgSq value2) {
		return value1.floatValue >= value2.floatValue;
	}

	public static bool operator ==(PositionMgSq value1, PositionMgSq value2) {
		return value1.floatValue == value2.floatValue;
	}

	public static bool operator !=(PositionMgSq value1, PositionMgSq value2) {
		return value1.floatValue != value2.floatValue;
	}

	public override bool Equals(object obj) {
		return floatValue.Equals(obj);
	}

	public override int GetHashCode() {
		return floatValue.GetHashCode();
	}
}

public struct Position {
	private Vector2 Vector2Value;

	public Vector2 Vector2 { get { return Vector2Value; } }

	public static Position down { get { return new Position(Vector2.down); } }
	public static Position left { get { return new Position(Vector2.left); } }
	public static Position right { get { return new Position(Vector2.right); } }
	public static Position up { get { return new Position(Vector2.up); } }
	public static Position negativeInfinity { get { return new Position(Vector2.negativeInfinity); } }
	public static Position positiveInfinity { get { return new Position(Vector2.positiveInfinity); } }
	public static Position one { get { return new Position(Vector2.one); } }
	public static Position zero { get { return new Position(Vector2.zero); } }

	public PositionMagnitude magnitude { get { return new PositionMagnitude(Vector2Value.magnitude); } }
	public Position normalized { get { return new Position(Vector2Value.normalized); } }
	public PositionMgSq sqrMagnitude { get { return new PositionMgSq(Vector2Value.sqrMagnitude); } }
	public PositionX x { get { return new PositionX(Vector2Value.x); } }
	public PositionY y { get { return new PositionY(Vector2Value.y); } }

	public Position(Vector2 Vector2Value) {
		this.Vector2Value = Vector2Value;
	}

	public Position(float x, float y) {
		this.Vector2Value = new Vector2 (x, y);
	}

	public static Position operator +(Position value1, Position value2) {
		return new Position(value1.Vector2Value + value2.Vector2Value);
	}

	public static Position operator -(Position value1, Position value2) {
		return new Position(value1.Vector2Value - value2.Vector2Value);
	}

	public static Position operator *(Position value, float scale) {
		return new Position(value.Vector2Value * scale);
	}

	public static Position operator *(float scale, Position value) {
		return new Position(value.Vector2Value * scale);
	}

	public static Position operator /(Position value, float scale) {
		return new Position(value.Vector2Value / scale);
	}

	public static Position operator -(Position value) {
		return new Position(-value.Vector2Value);
	}

	public static Velocity operator /(Position value1, Time value2) {
		return new Velocity(value1.Vector2 / value2.Float);
	}

	public static bool operator ==(Position value1, Position value2) {
		return value1.Vector2Value == value2.Vector2Value;
	}

	public static bool operator !=(Position value1, Position value2) {
		return value1.Vector2Value != value2.Vector2Value;
	}

	public static Angle Angle(Position from, Position to) {
		return new Angle(Vector2.Angle(from.Vector2, to.Vector2));
	}

	public static Position ClampMagnitude(Position vector, float maxLength) {
		return new Position(Vector2.ClampMagnitude(vector.Vector2, maxLength));
	}

	public static PositionMagnitude Distance(Position a, Position b) {
		return new PositionMagnitude(Vector2.Distance(a.Vector2, b.Vector2));
	}

	public static PositionDot Dot(Position lhs, Position rhs) {
		return new PositionDot(Vector2.Dot(lhs.Vector2, rhs.Vector2));
	}

	public static Position Lerp(Position a, Position b, float t) {
		return new Position(Vector2.Lerp(a.Vector2, b.Vector2, t));
	}

	public static Position LerpUnclamped(Position a, Position b, float t) {
		return new Position(Vector2.LerpUnclamped(a.Vector2, b.Vector2, t));
	}

	public static Position Max(Position lhs, Position rhs) {
		return new Position(Vector2.Max(lhs.Vector2, rhs.Vector2));
	}

	public static Position Min(Position lhs, Position rhs) {
		return new Position(Vector2.Min(lhs.Vector2, rhs.Vector2));
	}

	public static Position MoveTowards(Position current, Position target, float maxDistanceDelta) {
		return new Position(Vector2.MoveTowards(current.Vector2, target.Vector2, maxDistanceDelta));
	}

	public static Position Perpendicular(Position inDirection) {
		return new Position(Vector2.Perpendicular(inDirection.Vector2));
	}

	public static Angle SignedAngle(Position from, Position to) {
		return new Angle(Vector2.SignedAngle(from.Vector2, to.Vector2));
	}

	public void Normalize() {
		Vector2Value.Normalize();
	}

	public void Set(float newX, float newY) {
		Vector2Value.Set(newX, newY);
	}

	public override bool Equals(object obj) {
		return Vector2Value.Equals(obj);
	}

	public override int GetHashCode() {
		return Vector2Value.GetHashCode();
	}
}

public struct VelocityX {
	private float floatValue;

	public float Float { get { return floatValue; } }


	public VelocityX(float floatValue) {
		this.floatValue = floatValue;
	}

	public static VelocityX operator +(VelocityX value1, VelocityX value2) {
		return new VelocityX(value1.floatValue + value2.floatValue);
	}

	public static VelocityX operator -(VelocityX value1, VelocityX value2) {
		return new VelocityX(value1.floatValue - value2.floatValue);
	}

	public static float operator /(VelocityX value1, VelocityX value2) {
		return value1.floatValue / value2.floatValue;
	}

	public static VelocityX operator *(VelocityX value, float scale) {
		return new VelocityX(value.floatValue * scale);
	}

	public static VelocityX operator *(float scale, VelocityX value) {
		return new VelocityX(value.floatValue * scale);
	}

	public static VelocityX operator /(VelocityX value, float scale) {
		return new VelocityX(value.floatValue / scale);
	}

	public static bool operator <(VelocityX value1, VelocityX value2) {
		return value1.floatValue < value2.floatValue;
	}

	public static bool operator >(VelocityX value1, VelocityX value2) {
		return value1.floatValue > value2.floatValue;
	}

	public static bool operator <=(VelocityX value1, VelocityX value2) {
		return value1.floatValue <= value2.floatValue;
	}

	public static bool operator >=(VelocityX value1, VelocityX value2) {
		return value1.floatValue >= value2.floatValue;
	}

	public static bool operator ==(VelocityX value1, VelocityX value2) {
		return value1.floatValue == value2.floatValue;
	}

	public static bool operator !=(VelocityX value1, VelocityX value2) {
		return value1.floatValue != value2.floatValue;
	}

	public override bool Equals(object obj) {
		return floatValue.Equals(obj);
	}

	public override int GetHashCode() {
		return floatValue.GetHashCode();
	}
}

public struct VelocityY {
	private float floatValue;

	public float Float { get { return floatValue; } }


	public VelocityY(float floatValue) {
		this.floatValue = floatValue;
	}

	public static VelocityY operator +(VelocityY value1, VelocityY value2) {
		return new VelocityY(value1.floatValue + value2.floatValue);
	}

	public static VelocityY operator -(VelocityY value1, VelocityY value2) {
		return new VelocityY(value1.floatValue - value2.floatValue);
	}

	public static float operator /(VelocityY value1, VelocityY value2) {
		return value1.floatValue / value2.floatValue;
	}

	public static VelocityY operator *(VelocityY value, float scale) {
		return new VelocityY(value.floatValue * scale);
	}

	public static VelocityY operator *(float scale, VelocityY value) {
		return new VelocityY(value.floatValue * scale);
	}

	public static VelocityY operator /(VelocityY value, float scale) {
		return new VelocityY(value.floatValue / scale);
	}

	public static bool operator <(VelocityY value1, VelocityY value2) {
		return value1.floatValue < value2.floatValue;
	}

	public static bool operator >(VelocityY value1, VelocityY value2) {
		return value1.floatValue > value2.floatValue;
	}

	public static bool operator <=(VelocityY value1, VelocityY value2) {
		return value1.floatValue <= value2.floatValue;
	}

	public static bool operator >=(VelocityY value1, VelocityY value2) {
		return value1.floatValue >= value2.floatValue;
	}

	public static bool operator ==(VelocityY value1, VelocityY value2) {
		return value1.floatValue == value2.floatValue;
	}

	public static bool operator !=(VelocityY value1, VelocityY value2) {
		return value1.floatValue != value2.floatValue;
	}

	public override bool Equals(object obj) {
		return floatValue.Equals(obj);
	}

	public override int GetHashCode() {
		return floatValue.GetHashCode();
	}
}

public struct VelocityMagnitude {
	private float floatValue;

	public float Float { get { return floatValue; } }


	public VelocityMagnitude(float floatValue) {
		this.floatValue = floatValue;
	}

	public static VelocityMagnitude operator +(VelocityMagnitude value1, VelocityMagnitude value2) {
		return new VelocityMagnitude(value1.floatValue + value2.floatValue);
	}

	public static VelocityMagnitude operator -(VelocityMagnitude value1, VelocityMagnitude value2) {
		return new VelocityMagnitude(value1.floatValue - value2.floatValue);
	}

	public static float operator /(VelocityMagnitude value1, VelocityMagnitude value2) {
		return value1.floatValue / value2.floatValue;
	}

	public static VelocityMagnitude operator *(VelocityMagnitude value, float scale) {
		return new VelocityMagnitude(value.floatValue * scale);
	}

	public static VelocityMagnitude operator *(float scale, VelocityMagnitude value) {
		return new VelocityMagnitude(value.floatValue * scale);
	}

	public static VelocityMagnitude operator /(VelocityMagnitude value, float scale) {
		return new VelocityMagnitude(value.floatValue / scale);
	}

	public static VelocityMgSq operator *(VelocityMagnitude value1, VelocityMagnitude value2) {
		return new VelocityMgSq(value1.Float * value2.Float);
	}

	public static bool operator <(VelocityMagnitude value1, VelocityMagnitude value2) {
		return value1.floatValue < value2.floatValue;
	}

	public static bool operator >(VelocityMagnitude value1, VelocityMagnitude value2) {
		return value1.floatValue > value2.floatValue;
	}

	public static bool operator <=(VelocityMagnitude value1, VelocityMagnitude value2) {
		return value1.floatValue <= value2.floatValue;
	}

	public static bool operator >=(VelocityMagnitude value1, VelocityMagnitude value2) {
		return value1.floatValue >= value2.floatValue;
	}

	public static bool operator ==(VelocityMagnitude value1, VelocityMagnitude value2) {
		return value1.floatValue == value2.floatValue;
	}

	public static bool operator !=(VelocityMagnitude value1, VelocityMagnitude value2) {
		return value1.floatValue != value2.floatValue;
	}

	public override bool Equals(object obj) {
		return floatValue.Equals(obj);
	}

	public override int GetHashCode() {
		return floatValue.GetHashCode();
	}
}

public struct VelocityDot {
	private float floatValue;

	public float Float { get { return floatValue; } }


	public VelocityDot(float floatValue) {
		this.floatValue = floatValue;
	}

	public static VelocityDot operator +(VelocityDot value1, VelocityDot value2) {
		return new VelocityDot(value1.floatValue + value2.floatValue);
	}

	public static VelocityDot operator -(VelocityDot value1, VelocityDot value2) {
		return new VelocityDot(value1.floatValue - value2.floatValue);
	}

	public static float operator /(VelocityDot value1, VelocityDot value2) {
		return value1.floatValue / value2.floatValue;
	}

	public static VelocityDot operator *(VelocityDot value, float scale) {
		return new VelocityDot(value.floatValue * scale);
	}

	public static VelocityDot operator *(float scale, VelocityDot value) {
		return new VelocityDot(value.floatValue * scale);
	}

	public static VelocityDot operator /(VelocityDot value, float scale) {
		return new VelocityDot(value.floatValue / scale);
	}

	public static bool operator <(VelocityDot value1, VelocityDot value2) {
		return value1.floatValue < value2.floatValue;
	}

	public static bool operator >(VelocityDot value1, VelocityDot value2) {
		return value1.floatValue > value2.floatValue;
	}

	public static bool operator <=(VelocityDot value1, VelocityDot value2) {
		return value1.floatValue <= value2.floatValue;
	}

	public static bool operator >=(VelocityDot value1, VelocityDot value2) {
		return value1.floatValue >= value2.floatValue;
	}

	public static bool operator ==(VelocityDot value1, VelocityDot value2) {
		return value1.floatValue == value2.floatValue;
	}

	public static bool operator !=(VelocityDot value1, VelocityDot value2) {
		return value1.floatValue != value2.floatValue;
	}

	public override bool Equals(object obj) {
		return floatValue.Equals(obj);
	}

	public override int GetHashCode() {
		return floatValue.GetHashCode();
	}
}

public struct VelocityMgSq {
	private float floatValue;

	public float Float { get { return floatValue; } }


	public VelocityMgSq(float floatValue) {
		this.floatValue = floatValue;
	}

	public static VelocityMgSq operator +(VelocityMgSq value1, VelocityMgSq value2) {
		return new VelocityMgSq(value1.floatValue + value2.floatValue);
	}

	public static VelocityMgSq operator -(VelocityMgSq value1, VelocityMgSq value2) {
		return new VelocityMgSq(value1.floatValue - value2.floatValue);
	}

	public static float operator /(VelocityMgSq value1, VelocityMgSq value2) {
		return value1.floatValue / value2.floatValue;
	}

	public static VelocityMgSq operator *(VelocityMgSq value, float scale) {
		return new VelocityMgSq(value.floatValue * scale);
	}

	public static VelocityMgSq operator *(float scale, VelocityMgSq value) {
		return new VelocityMgSq(value.floatValue * scale);
	}

	public static VelocityMgSq operator /(VelocityMgSq value, float scale) {
		return new VelocityMgSq(value.floatValue / scale);
	}

	public static bool operator <(VelocityMgSq value1, VelocityMgSq value2) {
		return value1.floatValue < value2.floatValue;
	}

	public static bool operator >(VelocityMgSq value1, VelocityMgSq value2) {
		return value1.floatValue > value2.floatValue;
	}

	public static bool operator <=(VelocityMgSq value1, VelocityMgSq value2) {
		return value1.floatValue <= value2.floatValue;
	}

	public static bool operator >=(VelocityMgSq value1, VelocityMgSq value2) {
		return value1.floatValue >= value2.floatValue;
	}

	public static bool operator ==(VelocityMgSq value1, VelocityMgSq value2) {
		return value1.floatValue == value2.floatValue;
	}

	public static bool operator !=(VelocityMgSq value1, VelocityMgSq value2) {
		return value1.floatValue != value2.floatValue;
	}

	public override bool Equals(object obj) {
		return floatValue.Equals(obj);
	}

	public override int GetHashCode() {
		return floatValue.GetHashCode();
	}
}

public struct Velocity {
	private Vector2 Vector2Value;

	public Vector2 Vector2 { get { return Vector2Value; } }

	public static Velocity down { get { return new Velocity(Vector2.down); } }
	public static Velocity left { get { return new Velocity(Vector2.left); } }
	public static Velocity right { get { return new Velocity(Vector2.right); } }
	public static Velocity up { get { return new Velocity(Vector2.up); } }
	public static Velocity negativeInfinity { get { return new Velocity(Vector2.negativeInfinity); } }
	public static Velocity positiveInfinity { get { return new Velocity(Vector2.positiveInfinity); } }
	public static Velocity one { get { return new Velocity(Vector2.one); } }
	public static Velocity zero { get { return new Velocity(Vector2.zero); } }

	public VelocityMagnitude magnitude { get { return new VelocityMagnitude(Vector2Value.magnitude); } }
	public Velocity normalized { get { return new Velocity(Vector2Value.normalized); } }
	public VelocityMgSq sqrMagnitude { get { return new VelocityMgSq(Vector2Value.sqrMagnitude); } }
	public VelocityX x { get { return new VelocityX(Vector2Value.x); } }
	public VelocityY y { get { return new VelocityY(Vector2Value.y); } }

	public Velocity(Vector2 Vector2Value) {
		this.Vector2Value = Vector2Value;
	}

	public Velocity(float x, float y) {
		this.Vector2Value = new Vector2 (x, y);
	}

	public static Velocity operator +(Velocity value1, Velocity value2) {
		return new Velocity(value1.Vector2Value + value2.Vector2Value);
	}

	public static Velocity operator -(Velocity value1, Velocity value2) {
		return new Velocity(value1.Vector2Value - value2.Vector2Value);
	}

	public static Velocity operator *(Velocity value, float scale) {
		return new Velocity(value.Vector2Value * scale);
	}

	public static Velocity operator *(float scale, Velocity value) {
		return new Velocity(value.Vector2Value * scale);
	}

	public static Velocity operator /(Velocity value, float scale) {
		return new Velocity(value.Vector2Value / scale);
	}

	public static Velocity operator -(Velocity value) {
		return new Velocity(-value.Vector2Value);
	}

	public static Acceleration operator /(Velocity value1, Time value2) {
		return new Acceleration(value1.Vector2 / value2.Float);
	}

	public static Position operator *(Velocity value1, Time value2) {
		return new Position(value1.Vector2 * value2.Float);
	}

	public static bool operator ==(Velocity value1, Velocity value2) {
		return value1.Vector2Value == value2.Vector2Value;
	}

	public static bool operator !=(Velocity value1, Velocity value2) {
		return value1.Vector2Value != value2.Vector2Value;
	}

	public static Angle Angle(Velocity from, Velocity to) {
		return new Angle(Vector2.Angle(from.Vector2, to.Vector2));
	}

	public static Velocity ClampMagnitude(Velocity vector, float maxLength) {
		return new Velocity(Vector2.ClampMagnitude(vector.Vector2, maxLength));
	}

	public static VelocityMagnitude Distance(Velocity a, Velocity b) {
		return new VelocityMagnitude(Vector2.Distance(a.Vector2, b.Vector2));
	}

	public static VelocityDot Dot(Velocity lhs, Velocity rhs) {
		return new VelocityDot(Vector2.Dot(lhs.Vector2, rhs.Vector2));
	}

	public static Velocity Lerp(Velocity a, Velocity b, float t) {
		return new Velocity(Vector2.Lerp(a.Vector2, b.Vector2, t));
	}

	public static Velocity LerpUnclamped(Velocity a, Velocity b, float t) {
		return new Velocity(Vector2.LerpUnclamped(a.Vector2, b.Vector2, t));
	}

	public static Velocity Max(Velocity lhs, Velocity rhs) {
		return new Velocity(Vector2.Max(lhs.Vector2, rhs.Vector2));
	}

	public static Velocity Min(Velocity lhs, Velocity rhs) {
		return new Velocity(Vector2.Min(lhs.Vector2, rhs.Vector2));
	}

	public static Velocity MoveTowards(Velocity current, Velocity target, float maxDistanceDelta) {
		return new Velocity(Vector2.MoveTowards(current.Vector2, target.Vector2, maxDistanceDelta));
	}

	public static Velocity Perpendicular(Velocity inDirection) {
		return new Velocity(Vector2.Perpendicular(inDirection.Vector2));
	}

	public static Angle SignedAngle(Velocity from, Velocity to) {
		return new Angle(Vector2.SignedAngle(from.Vector2, to.Vector2));
	}

	public void Normalize() {
		Vector2Value.Normalize();
	}

	public void Set(float newX, float newY) {
		Vector2Value.Set(newX, newY);
	}

	public override bool Equals(object obj) {
		return Vector2Value.Equals(obj);
	}

	public override int GetHashCode() {
		return Vector2Value.GetHashCode();
	}
}

public struct AccelerationX {
	private float floatValue;

	public float Float { get { return floatValue; } }


	public AccelerationX(float floatValue) {
		this.floatValue = floatValue;
	}

	public static AccelerationX operator +(AccelerationX value1, AccelerationX value2) {
		return new AccelerationX(value1.floatValue + value2.floatValue);
	}

	public static AccelerationX operator -(AccelerationX value1, AccelerationX value2) {
		return new AccelerationX(value1.floatValue - value2.floatValue);
	}

	public static float operator /(AccelerationX value1, AccelerationX value2) {
		return value1.floatValue / value2.floatValue;
	}

	public static AccelerationX operator *(AccelerationX value, float scale) {
		return new AccelerationX(value.floatValue * scale);
	}

	public static AccelerationX operator *(float scale, AccelerationX value) {
		return new AccelerationX(value.floatValue * scale);
	}

	public static AccelerationX operator /(AccelerationX value, float scale) {
		return new AccelerationX(value.floatValue / scale);
	}

	public static bool operator <(AccelerationX value1, AccelerationX value2) {
		return value1.floatValue < value2.floatValue;
	}

	public static bool operator >(AccelerationX value1, AccelerationX value2) {
		return value1.floatValue > value2.floatValue;
	}

	public static bool operator <=(AccelerationX value1, AccelerationX value2) {
		return value1.floatValue <= value2.floatValue;
	}

	public static bool operator >=(AccelerationX value1, AccelerationX value2) {
		return value1.floatValue >= value2.floatValue;
	}

	public static bool operator ==(AccelerationX value1, AccelerationX value2) {
		return value1.floatValue == value2.floatValue;
	}

	public static bool operator !=(AccelerationX value1, AccelerationX value2) {
		return value1.floatValue != value2.floatValue;
	}

	public override bool Equals(object obj) {
		return floatValue.Equals(obj);
	}

	public override int GetHashCode() {
		return floatValue.GetHashCode();
	}
}

public struct AccelerationY {
	private float floatValue;

	public float Float { get { return floatValue; } }


	public AccelerationY(float floatValue) {
		this.floatValue = floatValue;
	}

	public static AccelerationY operator +(AccelerationY value1, AccelerationY value2) {
		return new AccelerationY(value1.floatValue + value2.floatValue);
	}

	public static AccelerationY operator -(AccelerationY value1, AccelerationY value2) {
		return new AccelerationY(value1.floatValue - value2.floatValue);
	}

	public static float operator /(AccelerationY value1, AccelerationY value2) {
		return value1.floatValue / value2.floatValue;
	}

	public static AccelerationY operator *(AccelerationY value, float scale) {
		return new AccelerationY(value.floatValue * scale);
	}

	public static AccelerationY operator *(float scale, AccelerationY value) {
		return new AccelerationY(value.floatValue * scale);
	}

	public static AccelerationY operator /(AccelerationY value, float scale) {
		return new AccelerationY(value.floatValue / scale);
	}

	public static bool operator <(AccelerationY value1, AccelerationY value2) {
		return value1.floatValue < value2.floatValue;
	}

	public static bool operator >(AccelerationY value1, AccelerationY value2) {
		return value1.floatValue > value2.floatValue;
	}

	public static bool operator <=(AccelerationY value1, AccelerationY value2) {
		return value1.floatValue <= value2.floatValue;
	}

	public static bool operator >=(AccelerationY value1, AccelerationY value2) {
		return value1.floatValue >= value2.floatValue;
	}

	public static bool operator ==(AccelerationY value1, AccelerationY value2) {
		return value1.floatValue == value2.floatValue;
	}

	public static bool operator !=(AccelerationY value1, AccelerationY value2) {
		return value1.floatValue != value2.floatValue;
	}

	public override bool Equals(object obj) {
		return floatValue.Equals(obj);
	}

	public override int GetHashCode() {
		return floatValue.GetHashCode();
	}
}

public struct AccelerationMagnitude {
	private float floatValue;

	public float Float { get { return floatValue; } }


	public AccelerationMagnitude(float floatValue) {
		this.floatValue = floatValue;
	}

	public static AccelerationMagnitude operator +(AccelerationMagnitude value1, AccelerationMagnitude value2) {
		return new AccelerationMagnitude(value1.floatValue + value2.floatValue);
	}

	public static AccelerationMagnitude operator -(AccelerationMagnitude value1, AccelerationMagnitude value2) {
		return new AccelerationMagnitude(value1.floatValue - value2.floatValue);
	}

	public static float operator /(AccelerationMagnitude value1, AccelerationMagnitude value2) {
		return value1.floatValue / value2.floatValue;
	}

	public static AccelerationMagnitude operator *(AccelerationMagnitude value, float scale) {
		return new AccelerationMagnitude(value.floatValue * scale);
	}

	public static AccelerationMagnitude operator *(float scale, AccelerationMagnitude value) {
		return new AccelerationMagnitude(value.floatValue * scale);
	}

	public static AccelerationMagnitude operator /(AccelerationMagnitude value, float scale) {
		return new AccelerationMagnitude(value.floatValue / scale);
	}

	public static AccelerationMgSq operator *(AccelerationMagnitude value1, AccelerationMagnitude value2) {
		return new AccelerationMgSq(value1.Float * value2.Float);
	}

	public static bool operator <(AccelerationMagnitude value1, AccelerationMagnitude value2) {
		return value1.floatValue < value2.floatValue;
	}

	public static bool operator >(AccelerationMagnitude value1, AccelerationMagnitude value2) {
		return value1.floatValue > value2.floatValue;
	}

	public static bool operator <=(AccelerationMagnitude value1, AccelerationMagnitude value2) {
		return value1.floatValue <= value2.floatValue;
	}

	public static bool operator >=(AccelerationMagnitude value1, AccelerationMagnitude value2) {
		return value1.floatValue >= value2.floatValue;
	}

	public static bool operator ==(AccelerationMagnitude value1, AccelerationMagnitude value2) {
		return value1.floatValue == value2.floatValue;
	}

	public static bool operator !=(AccelerationMagnitude value1, AccelerationMagnitude value2) {
		return value1.floatValue != value2.floatValue;
	}

	public override bool Equals(object obj) {
		return floatValue.Equals(obj);
	}

	public override int GetHashCode() {
		return floatValue.GetHashCode();
	}
}

public struct AccelerationDot {
	private float floatValue;

	public float Float { get { return floatValue; } }


	public AccelerationDot(float floatValue) {
		this.floatValue = floatValue;
	}

	public static AccelerationDot operator +(AccelerationDot value1, AccelerationDot value2) {
		return new AccelerationDot(value1.floatValue + value2.floatValue);
	}

	public static AccelerationDot operator -(AccelerationDot value1, AccelerationDot value2) {
		return new AccelerationDot(value1.floatValue - value2.floatValue);
	}

	public static float operator /(AccelerationDot value1, AccelerationDot value2) {
		return value1.floatValue / value2.floatValue;
	}

	public static AccelerationDot operator *(AccelerationDot value, float scale) {
		return new AccelerationDot(value.floatValue * scale);
	}

	public static AccelerationDot operator *(float scale, AccelerationDot value) {
		return new AccelerationDot(value.floatValue * scale);
	}

	public static AccelerationDot operator /(AccelerationDot value, float scale) {
		return new AccelerationDot(value.floatValue / scale);
	}

	public static bool operator <(AccelerationDot value1, AccelerationDot value2) {
		return value1.floatValue < value2.floatValue;
	}

	public static bool operator >(AccelerationDot value1, AccelerationDot value2) {
		return value1.floatValue > value2.floatValue;
	}

	public static bool operator <=(AccelerationDot value1, AccelerationDot value2) {
		return value1.floatValue <= value2.floatValue;
	}

	public static bool operator >=(AccelerationDot value1, AccelerationDot value2) {
		return value1.floatValue >= value2.floatValue;
	}

	public static bool operator ==(AccelerationDot value1, AccelerationDot value2) {
		return value1.floatValue == value2.floatValue;
	}

	public static bool operator !=(AccelerationDot value1, AccelerationDot value2) {
		return value1.floatValue != value2.floatValue;
	}

	public override bool Equals(object obj) {
		return floatValue.Equals(obj);
	}

	public override int GetHashCode() {
		return floatValue.GetHashCode();
	}
}

public struct AccelerationMgSq {
	private float floatValue;

	public float Float { get { return floatValue; } }


	public AccelerationMgSq(float floatValue) {
		this.floatValue = floatValue;
	}

	public static AccelerationMgSq operator +(AccelerationMgSq value1, AccelerationMgSq value2) {
		return new AccelerationMgSq(value1.floatValue + value2.floatValue);
	}

	public static AccelerationMgSq operator -(AccelerationMgSq value1, AccelerationMgSq value2) {
		return new AccelerationMgSq(value1.floatValue - value2.floatValue);
	}

	public static float operator /(AccelerationMgSq value1, AccelerationMgSq value2) {
		return value1.floatValue / value2.floatValue;
	}

	public static AccelerationMgSq operator *(AccelerationMgSq value, float scale) {
		return new AccelerationMgSq(value.floatValue * scale);
	}

	public static AccelerationMgSq operator *(float scale, AccelerationMgSq value) {
		return new AccelerationMgSq(value.floatValue * scale);
	}

	public static AccelerationMgSq operator /(AccelerationMgSq value, float scale) {
		return new AccelerationMgSq(value.floatValue / scale);
	}

	public static bool operator <(AccelerationMgSq value1, AccelerationMgSq value2) {
		return value1.floatValue < value2.floatValue;
	}

	public static bool operator >(AccelerationMgSq value1, AccelerationMgSq value2) {
		return value1.floatValue > value2.floatValue;
	}

	public static bool operator <=(AccelerationMgSq value1, AccelerationMgSq value2) {
		return value1.floatValue <= value2.floatValue;
	}

	public static bool operator >=(AccelerationMgSq value1, AccelerationMgSq value2) {
		return value1.floatValue >= value2.floatValue;
	}

	public static bool operator ==(AccelerationMgSq value1, AccelerationMgSq value2) {
		return value1.floatValue == value2.floatValue;
	}

	public static bool operator !=(AccelerationMgSq value1, AccelerationMgSq value2) {
		return value1.floatValue != value2.floatValue;
	}

	public override bool Equals(object obj) {
		return floatValue.Equals(obj);
	}

	public override int GetHashCode() {
		return floatValue.GetHashCode();
	}
}

public struct Acceleration {
	private Vector2 Vector2Value;

	public Vector2 Vector2 { get { return Vector2Value; } }

	public static Acceleration down { get { return new Acceleration(Vector2.down); } }
	public static Acceleration left { get { return new Acceleration(Vector2.left); } }
	public static Acceleration right { get { return new Acceleration(Vector2.right); } }
	public static Acceleration up { get { return new Acceleration(Vector2.up); } }
	public static Acceleration negativeInfinity { get { return new Acceleration(Vector2.negativeInfinity); } }
	public static Acceleration positiveInfinity { get { return new Acceleration(Vector2.positiveInfinity); } }
	public static Acceleration one { get { return new Acceleration(Vector2.one); } }
	public static Acceleration zero { get { return new Acceleration(Vector2.zero); } }

	public AccelerationMagnitude magnitude { get { return new AccelerationMagnitude(Vector2Value.magnitude); } }
	public Acceleration normalized { get { return new Acceleration(Vector2Value.normalized); } }
	public AccelerationMgSq sqrMagnitude { get { return new AccelerationMgSq(Vector2Value.sqrMagnitude); } }
	public AccelerationX x { get { return new AccelerationX(Vector2Value.x); } }
	public AccelerationY y { get { return new AccelerationY(Vector2Value.y); } }

	public Acceleration(Vector2 Vector2Value) {
		this.Vector2Value = Vector2Value;
	}

	public Acceleration(float x, float y) {
		this.Vector2Value = new Vector2 (x, y);
	}

	public static Acceleration operator +(Acceleration value1, Acceleration value2) {
		return new Acceleration(value1.Vector2Value + value2.Vector2Value);
	}

	public static Acceleration operator -(Acceleration value1, Acceleration value2) {
		return new Acceleration(value1.Vector2Value - value2.Vector2Value);
	}

	public static Acceleration operator *(Acceleration value, float scale) {
		return new Acceleration(value.Vector2Value * scale);
	}

	public static Acceleration operator *(float scale, Acceleration value) {
		return new Acceleration(value.Vector2Value * scale);
	}

	public static Acceleration operator /(Acceleration value, float scale) {
		return new Acceleration(value.Vector2Value / scale);
	}

	public static Acceleration operator -(Acceleration value) {
		return new Acceleration(-value.Vector2Value);
	}

	public static Force operator *(Acceleration value1, Mass value2) {
		return new Force(value1.Vector2 * value2.Float);
	}

	public static Velocity operator *(Acceleration value1, Time value2) {
		return new Velocity(value1.Vector2 * value2.Float);
	}

	public static bool operator ==(Acceleration value1, Acceleration value2) {
		return value1.Vector2Value == value2.Vector2Value;
	}

	public static bool operator !=(Acceleration value1, Acceleration value2) {
		return value1.Vector2Value != value2.Vector2Value;
	}

	public static Angle Angle(Acceleration from, Acceleration to) {
		return new Angle(Vector2.Angle(from.Vector2, to.Vector2));
	}

	public static Acceleration ClampMagnitude(Acceleration vector, float maxLength) {
		return new Acceleration(Vector2.ClampMagnitude(vector.Vector2, maxLength));
	}

	public static AccelerationMagnitude Distance(Acceleration a, Acceleration b) {
		return new AccelerationMagnitude(Vector2.Distance(a.Vector2, b.Vector2));
	}

	public static AccelerationDot Dot(Acceleration lhs, Acceleration rhs) {
		return new AccelerationDot(Vector2.Dot(lhs.Vector2, rhs.Vector2));
	}

	public static Acceleration Lerp(Acceleration a, Acceleration b, float t) {
		return new Acceleration(Vector2.Lerp(a.Vector2, b.Vector2, t));
	}

	public static Acceleration LerpUnclamped(Acceleration a, Acceleration b, float t) {
		return new Acceleration(Vector2.LerpUnclamped(a.Vector2, b.Vector2, t));
	}

	public static Acceleration Max(Acceleration lhs, Acceleration rhs) {
		return new Acceleration(Vector2.Max(lhs.Vector2, rhs.Vector2));
	}

	public static Acceleration Min(Acceleration lhs, Acceleration rhs) {
		return new Acceleration(Vector2.Min(lhs.Vector2, rhs.Vector2));
	}

	public static Acceleration MoveTowards(Acceleration current, Acceleration target, float maxDistanceDelta) {
		return new Acceleration(Vector2.MoveTowards(current.Vector2, target.Vector2, maxDistanceDelta));
	}

	public static Acceleration Perpendicular(Acceleration inDirection) {
		return new Acceleration(Vector2.Perpendicular(inDirection.Vector2));
	}

	public static Angle SignedAngle(Acceleration from, Acceleration to) {
		return new Angle(Vector2.SignedAngle(from.Vector2, to.Vector2));
	}

	public void Normalize() {
		Vector2Value.Normalize();
	}

	public void Set(float newX, float newY) {
		Vector2Value.Set(newX, newY);
	}

	public override bool Equals(object obj) {
		return Vector2Value.Equals(obj);
	}

	public override int GetHashCode() {
		return Vector2Value.GetHashCode();
	}
}

public struct ForceX {
	private float floatValue;

	public float Float { get { return floatValue; } }


	public ForceX(float floatValue) {
		this.floatValue = floatValue;
	}

	public static ForceX operator +(ForceX value1, ForceX value2) {
		return new ForceX(value1.floatValue + value2.floatValue);
	}

	public static ForceX operator -(ForceX value1, ForceX value2) {
		return new ForceX(value1.floatValue - value2.floatValue);
	}

	public static float operator /(ForceX value1, ForceX value2) {
		return value1.floatValue / value2.floatValue;
	}

	public static ForceX operator *(ForceX value, float scale) {
		return new ForceX(value.floatValue * scale);
	}

	public static ForceX operator *(float scale, ForceX value) {
		return new ForceX(value.floatValue * scale);
	}

	public static ForceX operator /(ForceX value, float scale) {
		return new ForceX(value.floatValue / scale);
	}

	public static bool operator <(ForceX value1, ForceX value2) {
		return value1.floatValue < value2.floatValue;
	}

	public static bool operator >(ForceX value1, ForceX value2) {
		return value1.floatValue > value2.floatValue;
	}

	public static bool operator <=(ForceX value1, ForceX value2) {
		return value1.floatValue <= value2.floatValue;
	}

	public static bool operator >=(ForceX value1, ForceX value2) {
		return value1.floatValue >= value2.floatValue;
	}

	public static bool operator ==(ForceX value1, ForceX value2) {
		return value1.floatValue == value2.floatValue;
	}

	public static bool operator !=(ForceX value1, ForceX value2) {
		return value1.floatValue != value2.floatValue;
	}

	public override bool Equals(object obj) {
		return floatValue.Equals(obj);
	}

	public override int GetHashCode() {
		return floatValue.GetHashCode();
	}
}

public struct ForceY {
	private float floatValue;

	public float Float { get { return floatValue; } }


	public ForceY(float floatValue) {
		this.floatValue = floatValue;
	}

	public static ForceY operator +(ForceY value1, ForceY value2) {
		return new ForceY(value1.floatValue + value2.floatValue);
	}

	public static ForceY operator -(ForceY value1, ForceY value2) {
		return new ForceY(value1.floatValue - value2.floatValue);
	}

	public static float operator /(ForceY value1, ForceY value2) {
		return value1.floatValue / value2.floatValue;
	}

	public static ForceY operator *(ForceY value, float scale) {
		return new ForceY(value.floatValue * scale);
	}

	public static ForceY operator *(float scale, ForceY value) {
		return new ForceY(value.floatValue * scale);
	}

	public static ForceY operator /(ForceY value, float scale) {
		return new ForceY(value.floatValue / scale);
	}

	public static bool operator <(ForceY value1, ForceY value2) {
		return value1.floatValue < value2.floatValue;
	}

	public static bool operator >(ForceY value1, ForceY value2) {
		return value1.floatValue > value2.floatValue;
	}

	public static bool operator <=(ForceY value1, ForceY value2) {
		return value1.floatValue <= value2.floatValue;
	}

	public static bool operator >=(ForceY value1, ForceY value2) {
		return value1.floatValue >= value2.floatValue;
	}

	public static bool operator ==(ForceY value1, ForceY value2) {
		return value1.floatValue == value2.floatValue;
	}

	public static bool operator !=(ForceY value1, ForceY value2) {
		return value1.floatValue != value2.floatValue;
	}

	public override bool Equals(object obj) {
		return floatValue.Equals(obj);
	}

	public override int GetHashCode() {
		return floatValue.GetHashCode();
	}
}

public struct ForceMagnitude {
	private float floatValue;

	public float Float { get { return floatValue; } }


	public ForceMagnitude(float floatValue) {
		this.floatValue = floatValue;
	}

	public static ForceMagnitude operator +(ForceMagnitude value1, ForceMagnitude value2) {
		return new ForceMagnitude(value1.floatValue + value2.floatValue);
	}

	public static ForceMagnitude operator -(ForceMagnitude value1, ForceMagnitude value2) {
		return new ForceMagnitude(value1.floatValue - value2.floatValue);
	}

	public static float operator /(ForceMagnitude value1, ForceMagnitude value2) {
		return value1.floatValue / value2.floatValue;
	}

	public static ForceMagnitude operator *(ForceMagnitude value, float scale) {
		return new ForceMagnitude(value.floatValue * scale);
	}

	public static ForceMagnitude operator *(float scale, ForceMagnitude value) {
		return new ForceMagnitude(value.floatValue * scale);
	}

	public static ForceMagnitude operator /(ForceMagnitude value, float scale) {
		return new ForceMagnitude(value.floatValue / scale);
	}

	public static ForceMgSq operator *(ForceMagnitude value1, ForceMagnitude value2) {
		return new ForceMgSq(value1.Float * value2.Float);
	}

	public static bool operator <(ForceMagnitude value1, ForceMagnitude value2) {
		return value1.floatValue < value2.floatValue;
	}

	public static bool operator >(ForceMagnitude value1, ForceMagnitude value2) {
		return value1.floatValue > value2.floatValue;
	}

	public static bool operator <=(ForceMagnitude value1, ForceMagnitude value2) {
		return value1.floatValue <= value2.floatValue;
	}

	public static bool operator >=(ForceMagnitude value1, ForceMagnitude value2) {
		return value1.floatValue >= value2.floatValue;
	}

	public static bool operator ==(ForceMagnitude value1, ForceMagnitude value2) {
		return value1.floatValue == value2.floatValue;
	}

	public static bool operator !=(ForceMagnitude value1, ForceMagnitude value2) {
		return value1.floatValue != value2.floatValue;
	}

	public override bool Equals(object obj) {
		return floatValue.Equals(obj);
	}

	public override int GetHashCode() {
		return floatValue.GetHashCode();
	}
}

public struct ForceDot {
	private float floatValue;

	public float Float { get { return floatValue; } }


	public ForceDot(float floatValue) {
		this.floatValue = floatValue;
	}

	public static ForceDot operator +(ForceDot value1, ForceDot value2) {
		return new ForceDot(value1.floatValue + value2.floatValue);
	}

	public static ForceDot operator -(ForceDot value1, ForceDot value2) {
		return new ForceDot(value1.floatValue - value2.floatValue);
	}

	public static float operator /(ForceDot value1, ForceDot value2) {
		return value1.floatValue / value2.floatValue;
	}

	public static ForceDot operator *(ForceDot value, float scale) {
		return new ForceDot(value.floatValue * scale);
	}

	public static ForceDot operator *(float scale, ForceDot value) {
		return new ForceDot(value.floatValue * scale);
	}

	public static ForceDot operator /(ForceDot value, float scale) {
		return new ForceDot(value.floatValue / scale);
	}

	public static bool operator <(ForceDot value1, ForceDot value2) {
		return value1.floatValue < value2.floatValue;
	}

	public static bool operator >(ForceDot value1, ForceDot value2) {
		return value1.floatValue > value2.floatValue;
	}

	public static bool operator <=(ForceDot value1, ForceDot value2) {
		return value1.floatValue <= value2.floatValue;
	}

	public static bool operator >=(ForceDot value1, ForceDot value2) {
		return value1.floatValue >= value2.floatValue;
	}

	public static bool operator ==(ForceDot value1, ForceDot value2) {
		return value1.floatValue == value2.floatValue;
	}

	public static bool operator !=(ForceDot value1, ForceDot value2) {
		return value1.floatValue != value2.floatValue;
	}

	public override bool Equals(object obj) {
		return floatValue.Equals(obj);
	}

	public override int GetHashCode() {
		return floatValue.GetHashCode();
	}
}

public struct ForceMgSq {
	private float floatValue;

	public float Float { get { return floatValue; } }


	public ForceMgSq(float floatValue) {
		this.floatValue = floatValue;
	}

	public static ForceMgSq operator +(ForceMgSq value1, ForceMgSq value2) {
		return new ForceMgSq(value1.floatValue + value2.floatValue);
	}

	public static ForceMgSq operator -(ForceMgSq value1, ForceMgSq value2) {
		return new ForceMgSq(value1.floatValue - value2.floatValue);
	}

	public static float operator /(ForceMgSq value1, ForceMgSq value2) {
		return value1.floatValue / value2.floatValue;
	}

	public static ForceMgSq operator *(ForceMgSq value, float scale) {
		return new ForceMgSq(value.floatValue * scale);
	}

	public static ForceMgSq operator *(float scale, ForceMgSq value) {
		return new ForceMgSq(value.floatValue * scale);
	}

	public static ForceMgSq operator /(ForceMgSq value, float scale) {
		return new ForceMgSq(value.floatValue / scale);
	}

	public static bool operator <(ForceMgSq value1, ForceMgSq value2) {
		return value1.floatValue < value2.floatValue;
	}

	public static bool operator >(ForceMgSq value1, ForceMgSq value2) {
		return value1.floatValue > value2.floatValue;
	}

	public static bool operator <=(ForceMgSq value1, ForceMgSq value2) {
		return value1.floatValue <= value2.floatValue;
	}

	public static bool operator >=(ForceMgSq value1, ForceMgSq value2) {
		return value1.floatValue >= value2.floatValue;
	}

	public static bool operator ==(ForceMgSq value1, ForceMgSq value2) {
		return value1.floatValue == value2.floatValue;
	}

	public static bool operator !=(ForceMgSq value1, ForceMgSq value2) {
		return value1.floatValue != value2.floatValue;
	}

	public override bool Equals(object obj) {
		return floatValue.Equals(obj);
	}

	public override int GetHashCode() {
		return floatValue.GetHashCode();
	}
}

public struct Force {
	private Vector2 Vector2Value;

	public Vector2 Vector2 { get { return Vector2Value; } }

	public static Force down { get { return new Force(Vector2.down); } }
	public static Force left { get { return new Force(Vector2.left); } }
	public static Force right { get { return new Force(Vector2.right); } }
	public static Force up { get { return new Force(Vector2.up); } }
	public static Force negativeInfinity { get { return new Force(Vector2.negativeInfinity); } }
	public static Force positiveInfinity { get { return new Force(Vector2.positiveInfinity); } }
	public static Force one { get { return new Force(Vector2.one); } }
	public static Force zero { get { return new Force(Vector2.zero); } }

	public ForceMagnitude magnitude { get { return new ForceMagnitude(Vector2Value.magnitude); } }
	public Force normalized { get { return new Force(Vector2Value.normalized); } }
	public ForceMgSq sqrMagnitude { get { return new ForceMgSq(Vector2Value.sqrMagnitude); } }
	public ForceX x { get { return new ForceX(Vector2Value.x); } }
	public ForceY y { get { return new ForceY(Vector2Value.y); } }

	public Force(Vector2 Vector2Value) {
		this.Vector2Value = Vector2Value;
	}

	public Force(float x, float y) {
		this.Vector2Value = new Vector2 (x, y);
	}

	public static Force operator +(Force value1, Force value2) {
		return new Force(value1.Vector2Value + value2.Vector2Value);
	}

	public static Force operator -(Force value1, Force value2) {
		return new Force(value1.Vector2Value - value2.Vector2Value);
	}

	public static Force operator *(Force value, float scale) {
		return new Force(value.Vector2Value * scale);
	}

	public static Force operator *(float scale, Force value) {
		return new Force(value.Vector2Value * scale);
	}

	public static Force operator /(Force value, float scale) {
		return new Force(value.Vector2Value / scale);
	}

	public static Force operator -(Force value) {
		return new Force(-value.Vector2Value);
	}

	public static Acceleration operator /(Force value1, Mass value2) {
		return new Acceleration(value1.Vector2 / value2.Float);
	}

	public static bool operator ==(Force value1, Force value2) {
		return value1.Vector2Value == value2.Vector2Value;
	}

	public static bool operator !=(Force value1, Force value2) {
		return value1.Vector2Value != value2.Vector2Value;
	}

	public static Angle Angle(Force from, Force to) {
		return new Angle(Vector2.Angle(from.Vector2, to.Vector2));
	}

	public static Force ClampMagnitude(Force vector, float maxLength) {
		return new Force(Vector2.ClampMagnitude(vector.Vector2, maxLength));
	}

	public static ForceMagnitude Distance(Force a, Force b) {
		return new ForceMagnitude(Vector2.Distance(a.Vector2, b.Vector2));
	}

	public static ForceDot Dot(Force lhs, Force rhs) {
		return new ForceDot(Vector2.Dot(lhs.Vector2, rhs.Vector2));
	}

	public static Force Lerp(Force a, Force b, float t) {
		return new Force(Vector2.Lerp(a.Vector2, b.Vector2, t));
	}

	public static Force LerpUnclamped(Force a, Force b, float t) {
		return new Force(Vector2.LerpUnclamped(a.Vector2, b.Vector2, t));
	}

	public static Force Max(Force lhs, Force rhs) {
		return new Force(Vector2.Max(lhs.Vector2, rhs.Vector2));
	}

	public static Force Min(Force lhs, Force rhs) {
		return new Force(Vector2.Min(lhs.Vector2, rhs.Vector2));
	}

	public static Force MoveTowards(Force current, Force target, float maxDistanceDelta) {
		return new Force(Vector2.MoveTowards(current.Vector2, target.Vector2, maxDistanceDelta));
	}

	public static Force Perpendicular(Force inDirection) {
		return new Force(Vector2.Perpendicular(inDirection.Vector2));
	}

	public static Angle SignedAngle(Force from, Force to) {
		return new Angle(Vector2.SignedAngle(from.Vector2, to.Vector2));
	}

	public void Normalize() {
		Vector2Value.Normalize();
	}

	public void Set(float newX, float newY) {
		Vector2Value.Set(newX, newY);
	}

	public override bool Equals(object obj) {
		return Vector2Value.Equals(obj);
	}

	public override int GetHashCode() {
		return Vector2Value.GetHashCode();
	}
}

public struct MomentumX {
	private float floatValue;

	public float Float { get { return floatValue; } }


	public MomentumX(float floatValue) {
		this.floatValue = floatValue;
	}

	public static MomentumX operator +(MomentumX value1, MomentumX value2) {
		return new MomentumX(value1.floatValue + value2.floatValue);
	}

	public static MomentumX operator -(MomentumX value1, MomentumX value2) {
		return new MomentumX(value1.floatValue - value2.floatValue);
	}

	public static float operator /(MomentumX value1, MomentumX value2) {
		return value1.floatValue / value2.floatValue;
	}

	public static MomentumX operator *(MomentumX value, float scale) {
		return new MomentumX(value.floatValue * scale);
	}

	public static MomentumX operator *(float scale, MomentumX value) {
		return new MomentumX(value.floatValue * scale);
	}

	public static MomentumX operator /(MomentumX value, float scale) {
		return new MomentumX(value.floatValue / scale);
	}

	public static bool operator <(MomentumX value1, MomentumX value2) {
		return value1.floatValue < value2.floatValue;
	}

	public static bool operator >(MomentumX value1, MomentumX value2) {
		return value1.floatValue > value2.floatValue;
	}

	public static bool operator <=(MomentumX value1, MomentumX value2) {
		return value1.floatValue <= value2.floatValue;
	}

	public static bool operator >=(MomentumX value1, MomentumX value2) {
		return value1.floatValue >= value2.floatValue;
	}

	public static bool operator ==(MomentumX value1, MomentumX value2) {
		return value1.floatValue == value2.floatValue;
	}

	public static bool operator !=(MomentumX value1, MomentumX value2) {
		return value1.floatValue != value2.floatValue;
	}

	public override bool Equals(object obj) {
		return floatValue.Equals(obj);
	}

	public override int GetHashCode() {
		return floatValue.GetHashCode();
	}
}

public struct MomentumY {
	private float floatValue;

	public float Float { get { return floatValue; } }


	public MomentumY(float floatValue) {
		this.floatValue = floatValue;
	}

	public static MomentumY operator +(MomentumY value1, MomentumY value2) {
		return new MomentumY(value1.floatValue + value2.floatValue);
	}

	public static MomentumY operator -(MomentumY value1, MomentumY value2) {
		return new MomentumY(value1.floatValue - value2.floatValue);
	}

	public static float operator /(MomentumY value1, MomentumY value2) {
		return value1.floatValue / value2.floatValue;
	}

	public static MomentumY operator *(MomentumY value, float scale) {
		return new MomentumY(value.floatValue * scale);
	}

	public static MomentumY operator *(float scale, MomentumY value) {
		return new MomentumY(value.floatValue * scale);
	}

	public static MomentumY operator /(MomentumY value, float scale) {
		return new MomentumY(value.floatValue / scale);
	}

	public static bool operator <(MomentumY value1, MomentumY value2) {
		return value1.floatValue < value2.floatValue;
	}

	public static bool operator >(MomentumY value1, MomentumY value2) {
		return value1.floatValue > value2.floatValue;
	}

	public static bool operator <=(MomentumY value1, MomentumY value2) {
		return value1.floatValue <= value2.floatValue;
	}

	public static bool operator >=(MomentumY value1, MomentumY value2) {
		return value1.floatValue >= value2.floatValue;
	}

	public static bool operator ==(MomentumY value1, MomentumY value2) {
		return value1.floatValue == value2.floatValue;
	}

	public static bool operator !=(MomentumY value1, MomentumY value2) {
		return value1.floatValue != value2.floatValue;
	}

	public override bool Equals(object obj) {
		return floatValue.Equals(obj);
	}

	public override int GetHashCode() {
		return floatValue.GetHashCode();
	}
}

public struct MomentumMagnitude {
	private float floatValue;

	public float Float { get { return floatValue; } }


	public MomentumMagnitude(float floatValue) {
		this.floatValue = floatValue;
	}

	public static MomentumMagnitude operator +(MomentumMagnitude value1, MomentumMagnitude value2) {
		return new MomentumMagnitude(value1.floatValue + value2.floatValue);
	}

	public static MomentumMagnitude operator -(MomentumMagnitude value1, MomentumMagnitude value2) {
		return new MomentumMagnitude(value1.floatValue - value2.floatValue);
	}

	public static float operator /(MomentumMagnitude value1, MomentumMagnitude value2) {
		return value1.floatValue / value2.floatValue;
	}

	public static MomentumMagnitude operator *(MomentumMagnitude value, float scale) {
		return new MomentumMagnitude(value.floatValue * scale);
	}

	public static MomentumMagnitude operator *(float scale, MomentumMagnitude value) {
		return new MomentumMagnitude(value.floatValue * scale);
	}

	public static MomentumMagnitude operator /(MomentumMagnitude value, float scale) {
		return new MomentumMagnitude(value.floatValue / scale);
	}

	public static MomentumMgSq operator *(MomentumMagnitude value1, MomentumMagnitude value2) {
		return new MomentumMgSq(value1.Float * value2.Float);
	}

	public static bool operator <(MomentumMagnitude value1, MomentumMagnitude value2) {
		return value1.floatValue < value2.floatValue;
	}

	public static bool operator >(MomentumMagnitude value1, MomentumMagnitude value2) {
		return value1.floatValue > value2.floatValue;
	}

	public static bool operator <=(MomentumMagnitude value1, MomentumMagnitude value2) {
		return value1.floatValue <= value2.floatValue;
	}

	public static bool operator >=(MomentumMagnitude value1, MomentumMagnitude value2) {
		return value1.floatValue >= value2.floatValue;
	}

	public static bool operator ==(MomentumMagnitude value1, MomentumMagnitude value2) {
		return value1.floatValue == value2.floatValue;
	}

	public static bool operator !=(MomentumMagnitude value1, MomentumMagnitude value2) {
		return value1.floatValue != value2.floatValue;
	}

	public override bool Equals(object obj) {
		return floatValue.Equals(obj);
	}

	public override int GetHashCode() {
		return floatValue.GetHashCode();
	}
}

public struct MomentumDot {
	private float floatValue;

	public float Float { get { return floatValue; } }


	public MomentumDot(float floatValue) {
		this.floatValue = floatValue;
	}

	public static MomentumDot operator +(MomentumDot value1, MomentumDot value2) {
		return new MomentumDot(value1.floatValue + value2.floatValue);
	}

	public static MomentumDot operator -(MomentumDot value1, MomentumDot value2) {
		return new MomentumDot(value1.floatValue - value2.floatValue);
	}

	public static float operator /(MomentumDot value1, MomentumDot value2) {
		return value1.floatValue / value2.floatValue;
	}

	public static MomentumDot operator *(MomentumDot value, float scale) {
		return new MomentumDot(value.floatValue * scale);
	}

	public static MomentumDot operator *(float scale, MomentumDot value) {
		return new MomentumDot(value.floatValue * scale);
	}

	public static MomentumDot operator /(MomentumDot value, float scale) {
		return new MomentumDot(value.floatValue / scale);
	}

	public static bool operator <(MomentumDot value1, MomentumDot value2) {
		return value1.floatValue < value2.floatValue;
	}

	public static bool operator >(MomentumDot value1, MomentumDot value2) {
		return value1.floatValue > value2.floatValue;
	}

	public static bool operator <=(MomentumDot value1, MomentumDot value2) {
		return value1.floatValue <= value2.floatValue;
	}

	public static bool operator >=(MomentumDot value1, MomentumDot value2) {
		return value1.floatValue >= value2.floatValue;
	}

	public static bool operator ==(MomentumDot value1, MomentumDot value2) {
		return value1.floatValue == value2.floatValue;
	}

	public static bool operator !=(MomentumDot value1, MomentumDot value2) {
		return value1.floatValue != value2.floatValue;
	}

	public override bool Equals(object obj) {
		return floatValue.Equals(obj);
	}

	public override int GetHashCode() {
		return floatValue.GetHashCode();
	}
}

public struct MomentumMgSq {
	private float floatValue;

	public float Float { get { return floatValue; } }


	public MomentumMgSq(float floatValue) {
		this.floatValue = floatValue;
	}

	public static MomentumMgSq operator +(MomentumMgSq value1, MomentumMgSq value2) {
		return new MomentumMgSq(value1.floatValue + value2.floatValue);
	}

	public static MomentumMgSq operator -(MomentumMgSq value1, MomentumMgSq value2) {
		return new MomentumMgSq(value1.floatValue - value2.floatValue);
	}

	public static float operator /(MomentumMgSq value1, MomentumMgSq value2) {
		return value1.floatValue / value2.floatValue;
	}

	public static MomentumMgSq operator *(MomentumMgSq value, float scale) {
		return new MomentumMgSq(value.floatValue * scale);
	}

	public static MomentumMgSq operator *(float scale, MomentumMgSq value) {
		return new MomentumMgSq(value.floatValue * scale);
	}

	public static MomentumMgSq operator /(MomentumMgSq value, float scale) {
		return new MomentumMgSq(value.floatValue / scale);
	}

	public static bool operator <(MomentumMgSq value1, MomentumMgSq value2) {
		return value1.floatValue < value2.floatValue;
	}

	public static bool operator >(MomentumMgSq value1, MomentumMgSq value2) {
		return value1.floatValue > value2.floatValue;
	}

	public static bool operator <=(MomentumMgSq value1, MomentumMgSq value2) {
		return value1.floatValue <= value2.floatValue;
	}

	public static bool operator >=(MomentumMgSq value1, MomentumMgSq value2) {
		return value1.floatValue >= value2.floatValue;
	}

	public static bool operator ==(MomentumMgSq value1, MomentumMgSq value2) {
		return value1.floatValue == value2.floatValue;
	}

	public static bool operator !=(MomentumMgSq value1, MomentumMgSq value2) {
		return value1.floatValue != value2.floatValue;
	}

	public override bool Equals(object obj) {
		return floatValue.Equals(obj);
	}

	public override int GetHashCode() {
		return floatValue.GetHashCode();
	}
}

public struct Momentum {
	private Vector2 Vector2Value;

	public Vector2 Vector2 { get { return Vector2Value; } }

	public static Momentum down { get { return new Momentum(Vector2.down); } }
	public static Momentum left { get { return new Momentum(Vector2.left); } }
	public static Momentum right { get { return new Momentum(Vector2.right); } }
	public static Momentum up { get { return new Momentum(Vector2.up); } }
	public static Momentum negativeInfinity { get { return new Momentum(Vector2.negativeInfinity); } }
	public static Momentum positiveInfinity { get { return new Momentum(Vector2.positiveInfinity); } }
	public static Momentum one { get { return new Momentum(Vector2.one); } }
	public static Momentum zero { get { return new Momentum(Vector2.zero); } }

	public MomentumMagnitude magnitude { get { return new MomentumMagnitude(Vector2Value.magnitude); } }
	public Momentum normalized { get { return new Momentum(Vector2Value.normalized); } }
	public MomentumMgSq sqrMagnitude { get { return new MomentumMgSq(Vector2Value.sqrMagnitude); } }
	public MomentumX x { get { return new MomentumX(Vector2Value.x); } }
	public MomentumY y { get { return new MomentumY(Vector2Value.y); } }

	public Momentum(Vector2 Vector2Value) {
		this.Vector2Value = Vector2Value;
	}

	public Momentum(float x, float y) {
		this.Vector2Value = new Vector2 (x, y);
	}

	public static Momentum operator +(Momentum value1, Momentum value2) {
		return new Momentum(value1.Vector2Value + value2.Vector2Value);
	}

	public static Momentum operator -(Momentum value1, Momentum value2) {
		return new Momentum(value1.Vector2Value - value2.Vector2Value);
	}

	public static Momentum operator *(Momentum value, float scale) {
		return new Momentum(value.Vector2Value * scale);
	}

	public static Momentum operator *(float scale, Momentum value) {
		return new Momentum(value.Vector2Value * scale);
	}

	public static Momentum operator /(Momentum value, float scale) {
		return new Momentum(value.Vector2Value / scale);
	}

	public static Momentum operator -(Momentum value) {
		return new Momentum(-value.Vector2Value);
	}

	public static bool operator ==(Momentum value1, Momentum value2) {
		return value1.Vector2Value == value2.Vector2Value;
	}

	public static bool operator !=(Momentum value1, Momentum value2) {
		return value1.Vector2Value != value2.Vector2Value;
	}

	public static Angle Angle(Momentum from, Momentum to) {
		return new Angle(Vector2.Angle(from.Vector2, to.Vector2));
	}

	public static Momentum ClampMagnitude(Momentum vector, float maxLength) {
		return new Momentum(Vector2.ClampMagnitude(vector.Vector2, maxLength));
	}

	public static MomentumMagnitude Distance(Momentum a, Momentum b) {
		return new MomentumMagnitude(Vector2.Distance(a.Vector2, b.Vector2));
	}

	public static MomentumDot Dot(Momentum lhs, Momentum rhs) {
		return new MomentumDot(Vector2.Dot(lhs.Vector2, rhs.Vector2));
	}

	public static Momentum Lerp(Momentum a, Momentum b, float t) {
		return new Momentum(Vector2.Lerp(a.Vector2, b.Vector2, t));
	}

	public static Momentum LerpUnclamped(Momentum a, Momentum b, float t) {
		return new Momentum(Vector2.LerpUnclamped(a.Vector2, b.Vector2, t));
	}

	public static Momentum Max(Momentum lhs, Momentum rhs) {
		return new Momentum(Vector2.Max(lhs.Vector2, rhs.Vector2));
	}

	public static Momentum Min(Momentum lhs, Momentum rhs) {
		return new Momentum(Vector2.Min(lhs.Vector2, rhs.Vector2));
	}

	public static Momentum MoveTowards(Momentum current, Momentum target, float maxDistanceDelta) {
		return new Momentum(Vector2.MoveTowards(current.Vector2, target.Vector2, maxDistanceDelta));
	}

	public static Momentum Perpendicular(Momentum inDirection) {
		return new Momentum(Vector2.Perpendicular(inDirection.Vector2));
	}

	public static Angle SignedAngle(Momentum from, Momentum to) {
		return new Angle(Vector2.SignedAngle(from.Vector2, to.Vector2));
	}

	public void Normalize() {
		Vector2Value.Normalize();
	}

	public void Set(float newX, float newY) {
		Vector2Value.Set(newX, newY);
	}

	public override bool Equals(object obj) {
		return Vector2Value.Equals(obj);
	}

	public override int GetHashCode() {
		return Vector2Value.GetHashCode();
	}
}