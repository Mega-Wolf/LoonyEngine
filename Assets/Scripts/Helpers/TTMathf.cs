using UnityEngine;

public static class TTMathf {
	public static Mass Clamp01(Mass value) {
		return new Mass(Mathf.Clamp01(value.Float));
	}

	public static Mass Min(Mass a, Mass b) {
		return new Mass(Mathf.Min(a.Float, b.Float));
	}

	public static Mass Max(Mass a, Mass b) {
		return new Mass(Mathf.Max(a.Float, b.Float));
	}

	public static Mass Clamp(Mass value, Mass min, Mass max) {
		return new Mass(Mathf.Clamp(value.Float, min.Float, max.Float));
	}

	public static Mass Lerp(Mass a, Mass b, float t) {
		return new Mass(Mathf.Lerp(a.Float, b.Float, t));
	}

	public static Mass LerpUnclamped(Mass a, Mass b, float t) {
		return new Mass(Mathf.LerpUnclamped(a.Float, b.Float, t));
	}

	public static Time Clamp01(Time value) {
		return new Time(Mathf.Clamp01(value.Float));
	}

	public static Time Min(Time a, Time b) {
		return new Time(Mathf.Min(a.Float, b.Float));
	}

	public static Time Max(Time a, Time b) {
		return new Time(Mathf.Max(a.Float, b.Float));
	}

	public static Time Clamp(Time value, Time min, Time max) {
		return new Time(Mathf.Clamp(value.Float, min.Float, max.Float));
	}

	public static Time Lerp(Time a, Time b, float t) {
		return new Time(Mathf.Lerp(a.Float, b.Float, t));
	}

	public static Time LerpUnclamped(Time a, Time b, float t) {
		return new Time(Mathf.LerpUnclamped(a.Float, b.Float, t));
	}

	public static AngularAcceleration Clamp01(AngularAcceleration value) {
		return new AngularAcceleration(Mathf.Clamp01(value.Float));
	}

	public static AngularAcceleration Min(AngularAcceleration a, AngularAcceleration b) {
		return new AngularAcceleration(Mathf.Min(a.Float, b.Float));
	}

	public static AngularAcceleration Max(AngularAcceleration a, AngularAcceleration b) {
		return new AngularAcceleration(Mathf.Max(a.Float, b.Float));
	}

	public static AngularAcceleration Clamp(AngularAcceleration value, AngularAcceleration min, AngularAcceleration max) {
		return new AngularAcceleration(Mathf.Clamp(value.Float, min.Float, max.Float));
	}

	public static AngularAcceleration Lerp(AngularAcceleration a, AngularAcceleration b, float t) {
		return new AngularAcceleration(Mathf.Lerp(a.Float, b.Float, t));
	}

	public static AngularAcceleration LerpUnclamped(AngularAcceleration a, AngularAcceleration b, float t) {
		return new AngularAcceleration(Mathf.LerpUnclamped(a.Float, b.Float, t));
	}

	public static AngularSpeed Clamp01(AngularSpeed value) {
		return new AngularSpeed(Mathf.Clamp01(value.Float));
	}

	public static AngularSpeed Min(AngularSpeed a, AngularSpeed b) {
		return new AngularSpeed(Mathf.Min(a.Float, b.Float));
	}

	public static AngularSpeed Max(AngularSpeed a, AngularSpeed b) {
		return new AngularSpeed(Mathf.Max(a.Float, b.Float));
	}

	public static AngularSpeed Clamp(AngularSpeed value, AngularSpeed min, AngularSpeed max) {
		return new AngularSpeed(Mathf.Clamp(value.Float, min.Float, max.Float));
	}

	public static AngularSpeed Lerp(AngularSpeed a, AngularSpeed b, float t) {
		return new AngularSpeed(Mathf.Lerp(a.Float, b.Float, t));
	}

	public static AngularSpeed LerpUnclamped(AngularSpeed a, AngularSpeed b, float t) {
		return new AngularSpeed(Mathf.LerpUnclamped(a.Float, b.Float, t));
	}

	public static Frequency Clamp01(Frequency value) {
		return new Frequency(Mathf.Clamp01(value.Float));
	}

	public static Frequency Min(Frequency a, Frequency b) {
		return new Frequency(Mathf.Min(a.Float, b.Float));
	}

	public static Frequency Max(Frequency a, Frequency b) {
		return new Frequency(Mathf.Max(a.Float, b.Float));
	}

	public static Frequency Clamp(Frequency value, Frequency min, Frequency max) {
		return new Frequency(Mathf.Clamp(value.Float, min.Float, max.Float));
	}

	public static Frequency Lerp(Frequency a, Frequency b, float t) {
		return new Frequency(Mathf.Lerp(a.Float, b.Float, t));
	}

	public static Frequency LerpUnclamped(Frequency a, Frequency b, float t) {
		return new Frequency(Mathf.LerpUnclamped(a.Float, b.Float, t));
	}

	public static Area Clamp01(Area value) {
		return new Area(Mathf.Clamp01(value.Float));
	}

	public static Area Min(Area a, Area b) {
		return new Area(Mathf.Min(a.Float, b.Float));
	}

	public static Area Max(Area a, Area b) {
		return new Area(Mathf.Max(a.Float, b.Float));
	}

	public static Area Clamp(Area value, Area min, Area max) {
		return new Area(Mathf.Clamp(value.Float, min.Float, max.Float));
	}

	public static Area Lerp(Area a, Area b, float t) {
		return new Area(Mathf.Lerp(a.Float, b.Float, t));
	}

	public static Area LerpUnclamped(Area a, Area b, float t) {
		return new Area(Mathf.LerpUnclamped(a.Float, b.Float, t));
	}

	public static Weight Clamp01(Weight value) {
		return new Weight(Mathf.Clamp01(value.Float));
	}

	public static Weight Min(Weight a, Weight b) {
		return new Weight(Mathf.Min(a.Float, b.Float));
	}

	public static Weight Max(Weight a, Weight b) {
		return new Weight(Mathf.Max(a.Float, b.Float));
	}

	public static Weight Clamp(Weight value, Weight min, Weight max) {
		return new Weight(Mathf.Clamp(value.Float, min.Float, max.Float));
	}

	public static Weight Lerp(Weight a, Weight b, float t) {
		return new Weight(Mathf.Lerp(a.Float, b.Float, t));
	}

	public static Weight LerpUnclamped(Weight a, Weight b, float t) {
		return new Weight(Mathf.LerpUnclamped(a.Float, b.Float, t));
	}

	public static Impulse Clamp01(Impulse value) {
		return new Impulse(Mathf.Clamp01(value.Float));
	}

	public static Impulse Min(Impulse a, Impulse b) {
		return new Impulse(Mathf.Min(a.Float, b.Float));
	}

	public static Impulse Max(Impulse a, Impulse b) {
		return new Impulse(Mathf.Max(a.Float, b.Float));
	}

	public static Impulse Clamp(Impulse value, Impulse min, Impulse max) {
		return new Impulse(Mathf.Clamp(value.Float, min.Float, max.Float));
	}

	public static Impulse Lerp(Impulse a, Impulse b, float t) {
		return new Impulse(Mathf.Lerp(a.Float, b.Float, t));
	}

	public static Impulse LerpUnclamped(Impulse a, Impulse b, float t) {
		return new Impulse(Mathf.LerpUnclamped(a.Float, b.Float, t));
	}

	public static MomentOfInertia Clamp01(MomentOfInertia value) {
		return new MomentOfInertia(Mathf.Clamp01(value.Float));
	}

	public static MomentOfInertia Min(MomentOfInertia a, MomentOfInertia b) {
		return new MomentOfInertia(Mathf.Min(a.Float, b.Float));
	}

	public static MomentOfInertia Max(MomentOfInertia a, MomentOfInertia b) {
		return new MomentOfInertia(Mathf.Max(a.Float, b.Float));
	}

	public static MomentOfInertia Clamp(MomentOfInertia value, MomentOfInertia min, MomentOfInertia max) {
		return new MomentOfInertia(Mathf.Clamp(value.Float, min.Float, max.Float));
	}

	public static MomentOfInertia Lerp(MomentOfInertia a, MomentOfInertia b, float t) {
		return new MomentOfInertia(Mathf.Lerp(a.Float, b.Float, t));
	}

	public static MomentOfInertia LerpUnclamped(MomentOfInertia a, MomentOfInertia b, float t) {
		return new MomentOfInertia(Mathf.LerpUnclamped(a.Float, b.Float, t));
	}

	public static Work Clamp01(Work value) {
		return new Work(Mathf.Clamp01(value.Float));
	}

	public static Work Min(Work a, Work b) {
		return new Work(Mathf.Min(a.Float, b.Float));
	}

	public static Work Max(Work a, Work b) {
		return new Work(Mathf.Max(a.Float, b.Float));
	}

	public static Work Clamp(Work value, Work min, Work max) {
		return new Work(Mathf.Clamp(value.Float, min.Float, max.Float));
	}

	public static Work Lerp(Work a, Work b, float t) {
		return new Work(Mathf.Lerp(a.Float, b.Float, t));
	}

	public static Work LerpUnclamped(Work a, Work b, float t) {
		return new Work(Mathf.LerpUnclamped(a.Float, b.Float, t));
	}

	public static Angle Clamp01(Angle value) {
		return new Angle(Mathf.Clamp01(value.Float));
	}

	public static Angle Min(Angle a, Angle b) {
		return new Angle(Mathf.Min(a.Float, b.Float));
	}

	public static Angle Max(Angle a, Angle b) {
		return new Angle(Mathf.Max(a.Float, b.Float));
	}

	public static Angle Clamp(Angle value, Angle min, Angle max) {
		return new Angle(Mathf.Clamp(value.Float, min.Float, max.Float));
	}

	public static Angle Lerp(Angle a, Angle b, float t) {
		return new Angle(Mathf.Lerp(a.Float, b.Float, t));
	}

	public static Angle LerpUnclamped(Angle a, Angle b, float t) {
		return new Angle(Mathf.LerpUnclamped(a.Float, b.Float, t));
	}

	public static float Sin(Angle f) {
		return Mathf.Sin(f.Float);
	}

	public static float Cos(Angle f) {
		return Mathf.Cos(f.Float);
	}

	public static float Tan(Angle f) {
		return Mathf.Tan(f.Float);
	}

	public static Angle Asin(float f) {
		return new Angle(Mathf.Asin(f));
	}

	public static Angle Acos(float f) {
		return new Angle(Mathf.Acos(f));
	}

	public static Angle Atan(float f) {
		return new Angle(Mathf.Atan(f));
	}

	public static Angle DeltaAngle(Angle current, Angle target) {
		return new Angle(Mathf.DeltaAngle(current.Float, target.Float));
	}

	public static Angle LerpAngle(Angle a, Angle b, float t) {
		return new Angle(Mathf.LerpAngle(a.Float, b.Float, t));
	}

	public static Angle Atan2(float y, float x) {
		return new Angle(Mathf.Atan2(y, x));
	}

	public static PositionX Clamp01(PositionX value) {
		return new PositionX(Mathf.Clamp01(value.Float));
	}

	public static PositionX Min(PositionX a, PositionX b) {
		return new PositionX(Mathf.Min(a.Float, b.Float));
	}

	public static PositionX Max(PositionX a, PositionX b) {
		return new PositionX(Mathf.Max(a.Float, b.Float));
	}

	public static PositionX Clamp(PositionX value, PositionX min, PositionX max) {
		return new PositionX(Mathf.Clamp(value.Float, min.Float, max.Float));
	}

	public static PositionX Lerp(PositionX a, PositionX b, float t) {
		return new PositionX(Mathf.Lerp(a.Float, b.Float, t));
	}

	public static PositionX LerpUnclamped(PositionX a, PositionX b, float t) {
		return new PositionX(Mathf.LerpUnclamped(a.Float, b.Float, t));
	}

	public static PositionY Clamp01(PositionY value) {
		return new PositionY(Mathf.Clamp01(value.Float));
	}

	public static PositionY Min(PositionY a, PositionY b) {
		return new PositionY(Mathf.Min(a.Float, b.Float));
	}

	public static PositionY Max(PositionY a, PositionY b) {
		return new PositionY(Mathf.Max(a.Float, b.Float));
	}

	public static PositionY Clamp(PositionY value, PositionY min, PositionY max) {
		return new PositionY(Mathf.Clamp(value.Float, min.Float, max.Float));
	}

	public static PositionY Lerp(PositionY a, PositionY b, float t) {
		return new PositionY(Mathf.Lerp(a.Float, b.Float, t));
	}

	public static PositionY LerpUnclamped(PositionY a, PositionY b, float t) {
		return new PositionY(Mathf.LerpUnclamped(a.Float, b.Float, t));
	}

	public static PositionMagnitude Clamp01(PositionMagnitude value) {
		return new PositionMagnitude(Mathf.Clamp01(value.Float));
	}

	public static PositionMagnitude Min(PositionMagnitude a, PositionMagnitude b) {
		return new PositionMagnitude(Mathf.Min(a.Float, b.Float));
	}

	public static PositionMagnitude Max(PositionMagnitude a, PositionMagnitude b) {
		return new PositionMagnitude(Mathf.Max(a.Float, b.Float));
	}

	public static PositionMagnitude Clamp(PositionMagnitude value, PositionMagnitude min, PositionMagnitude max) {
		return new PositionMagnitude(Mathf.Clamp(value.Float, min.Float, max.Float));
	}

	public static PositionMagnitude Lerp(PositionMagnitude a, PositionMagnitude b, float t) {
		return new PositionMagnitude(Mathf.Lerp(a.Float, b.Float, t));
	}

	public static PositionMagnitude LerpUnclamped(PositionMagnitude a, PositionMagnitude b, float t) {
		return new PositionMagnitude(Mathf.LerpUnclamped(a.Float, b.Float, t));
	}

	public static PositionDot Clamp01(PositionDot value) {
		return new PositionDot(Mathf.Clamp01(value.Float));
	}

	public static PositionDot Min(PositionDot a, PositionDot b) {
		return new PositionDot(Mathf.Min(a.Float, b.Float));
	}

	public static PositionDot Max(PositionDot a, PositionDot b) {
		return new PositionDot(Mathf.Max(a.Float, b.Float));
	}

	public static PositionDot Clamp(PositionDot value, PositionDot min, PositionDot max) {
		return new PositionDot(Mathf.Clamp(value.Float, min.Float, max.Float));
	}

	public static PositionDot Lerp(PositionDot a, PositionDot b, float t) {
		return new PositionDot(Mathf.Lerp(a.Float, b.Float, t));
	}

	public static PositionDot LerpUnclamped(PositionDot a, PositionDot b, float t) {
		return new PositionDot(Mathf.LerpUnclamped(a.Float, b.Float, t));
	}

	public static PositionMgSq Clamp01(PositionMgSq value) {
		return new PositionMgSq(Mathf.Clamp01(value.Float));
	}

	public static PositionMgSq Min(PositionMgSq a, PositionMgSq b) {
		return new PositionMgSq(Mathf.Min(a.Float, b.Float));
	}

	public static PositionMgSq Max(PositionMgSq a, PositionMgSq b) {
		return new PositionMgSq(Mathf.Max(a.Float, b.Float));
	}

	public static PositionMgSq Clamp(PositionMgSq value, PositionMgSq min, PositionMgSq max) {
		return new PositionMgSq(Mathf.Clamp(value.Float, min.Float, max.Float));
	}

	public static PositionMgSq Lerp(PositionMgSq a, PositionMgSq b, float t) {
		return new PositionMgSq(Mathf.Lerp(a.Float, b.Float, t));
	}

	public static PositionMgSq LerpUnclamped(PositionMgSq a, PositionMgSq b, float t) {
		return new PositionMgSq(Mathf.LerpUnclamped(a.Float, b.Float, t));
	}

	public static VelocityX Clamp01(VelocityX value) {
		return new VelocityX(Mathf.Clamp01(value.Float));
	}

	public static VelocityX Min(VelocityX a, VelocityX b) {
		return new VelocityX(Mathf.Min(a.Float, b.Float));
	}

	public static VelocityX Max(VelocityX a, VelocityX b) {
		return new VelocityX(Mathf.Max(a.Float, b.Float));
	}

	public static VelocityX Clamp(VelocityX value, VelocityX min, VelocityX max) {
		return new VelocityX(Mathf.Clamp(value.Float, min.Float, max.Float));
	}

	public static VelocityX Lerp(VelocityX a, VelocityX b, float t) {
		return new VelocityX(Mathf.Lerp(a.Float, b.Float, t));
	}

	public static VelocityX LerpUnclamped(VelocityX a, VelocityX b, float t) {
		return new VelocityX(Mathf.LerpUnclamped(a.Float, b.Float, t));
	}

	public static VelocityY Clamp01(VelocityY value) {
		return new VelocityY(Mathf.Clamp01(value.Float));
	}

	public static VelocityY Min(VelocityY a, VelocityY b) {
		return new VelocityY(Mathf.Min(a.Float, b.Float));
	}

	public static VelocityY Max(VelocityY a, VelocityY b) {
		return new VelocityY(Mathf.Max(a.Float, b.Float));
	}

	public static VelocityY Clamp(VelocityY value, VelocityY min, VelocityY max) {
		return new VelocityY(Mathf.Clamp(value.Float, min.Float, max.Float));
	}

	public static VelocityY Lerp(VelocityY a, VelocityY b, float t) {
		return new VelocityY(Mathf.Lerp(a.Float, b.Float, t));
	}

	public static VelocityY LerpUnclamped(VelocityY a, VelocityY b, float t) {
		return new VelocityY(Mathf.LerpUnclamped(a.Float, b.Float, t));
	}

	public static VelocityMagnitude Clamp01(VelocityMagnitude value) {
		return new VelocityMagnitude(Mathf.Clamp01(value.Float));
	}

	public static VelocityMagnitude Min(VelocityMagnitude a, VelocityMagnitude b) {
		return new VelocityMagnitude(Mathf.Min(a.Float, b.Float));
	}

	public static VelocityMagnitude Max(VelocityMagnitude a, VelocityMagnitude b) {
		return new VelocityMagnitude(Mathf.Max(a.Float, b.Float));
	}

	public static VelocityMagnitude Clamp(VelocityMagnitude value, VelocityMagnitude min, VelocityMagnitude max) {
		return new VelocityMagnitude(Mathf.Clamp(value.Float, min.Float, max.Float));
	}

	public static VelocityMagnitude Lerp(VelocityMagnitude a, VelocityMagnitude b, float t) {
		return new VelocityMagnitude(Mathf.Lerp(a.Float, b.Float, t));
	}

	public static VelocityMagnitude LerpUnclamped(VelocityMagnitude a, VelocityMagnitude b, float t) {
		return new VelocityMagnitude(Mathf.LerpUnclamped(a.Float, b.Float, t));
	}

	public static VelocityDot Clamp01(VelocityDot value) {
		return new VelocityDot(Mathf.Clamp01(value.Float));
	}

	public static VelocityDot Min(VelocityDot a, VelocityDot b) {
		return new VelocityDot(Mathf.Min(a.Float, b.Float));
	}

	public static VelocityDot Max(VelocityDot a, VelocityDot b) {
		return new VelocityDot(Mathf.Max(a.Float, b.Float));
	}

	public static VelocityDot Clamp(VelocityDot value, VelocityDot min, VelocityDot max) {
		return new VelocityDot(Mathf.Clamp(value.Float, min.Float, max.Float));
	}

	public static VelocityDot Lerp(VelocityDot a, VelocityDot b, float t) {
		return new VelocityDot(Mathf.Lerp(a.Float, b.Float, t));
	}

	public static VelocityDot LerpUnclamped(VelocityDot a, VelocityDot b, float t) {
		return new VelocityDot(Mathf.LerpUnclamped(a.Float, b.Float, t));
	}

	public static VelocityMgSq Clamp01(VelocityMgSq value) {
		return new VelocityMgSq(Mathf.Clamp01(value.Float));
	}

	public static VelocityMgSq Min(VelocityMgSq a, VelocityMgSq b) {
		return new VelocityMgSq(Mathf.Min(a.Float, b.Float));
	}

	public static VelocityMgSq Max(VelocityMgSq a, VelocityMgSq b) {
		return new VelocityMgSq(Mathf.Max(a.Float, b.Float));
	}

	public static VelocityMgSq Clamp(VelocityMgSq value, VelocityMgSq min, VelocityMgSq max) {
		return new VelocityMgSq(Mathf.Clamp(value.Float, min.Float, max.Float));
	}

	public static VelocityMgSq Lerp(VelocityMgSq a, VelocityMgSq b, float t) {
		return new VelocityMgSq(Mathf.Lerp(a.Float, b.Float, t));
	}

	public static VelocityMgSq LerpUnclamped(VelocityMgSq a, VelocityMgSq b, float t) {
		return new VelocityMgSq(Mathf.LerpUnclamped(a.Float, b.Float, t));
	}

	public static AccelerationX Clamp01(AccelerationX value) {
		return new AccelerationX(Mathf.Clamp01(value.Float));
	}

	public static AccelerationX Min(AccelerationX a, AccelerationX b) {
		return new AccelerationX(Mathf.Min(a.Float, b.Float));
	}

	public static AccelerationX Max(AccelerationX a, AccelerationX b) {
		return new AccelerationX(Mathf.Max(a.Float, b.Float));
	}

	public static AccelerationX Clamp(AccelerationX value, AccelerationX min, AccelerationX max) {
		return new AccelerationX(Mathf.Clamp(value.Float, min.Float, max.Float));
	}

	public static AccelerationX Lerp(AccelerationX a, AccelerationX b, float t) {
		return new AccelerationX(Mathf.Lerp(a.Float, b.Float, t));
	}

	public static AccelerationX LerpUnclamped(AccelerationX a, AccelerationX b, float t) {
		return new AccelerationX(Mathf.LerpUnclamped(a.Float, b.Float, t));
	}

	public static AccelerationY Clamp01(AccelerationY value) {
		return new AccelerationY(Mathf.Clamp01(value.Float));
	}

	public static AccelerationY Min(AccelerationY a, AccelerationY b) {
		return new AccelerationY(Mathf.Min(a.Float, b.Float));
	}

	public static AccelerationY Max(AccelerationY a, AccelerationY b) {
		return new AccelerationY(Mathf.Max(a.Float, b.Float));
	}

	public static AccelerationY Clamp(AccelerationY value, AccelerationY min, AccelerationY max) {
		return new AccelerationY(Mathf.Clamp(value.Float, min.Float, max.Float));
	}

	public static AccelerationY Lerp(AccelerationY a, AccelerationY b, float t) {
		return new AccelerationY(Mathf.Lerp(a.Float, b.Float, t));
	}

	public static AccelerationY LerpUnclamped(AccelerationY a, AccelerationY b, float t) {
		return new AccelerationY(Mathf.LerpUnclamped(a.Float, b.Float, t));
	}

	public static AccelerationMagnitude Clamp01(AccelerationMagnitude value) {
		return new AccelerationMagnitude(Mathf.Clamp01(value.Float));
	}

	public static AccelerationMagnitude Min(AccelerationMagnitude a, AccelerationMagnitude b) {
		return new AccelerationMagnitude(Mathf.Min(a.Float, b.Float));
	}

	public static AccelerationMagnitude Max(AccelerationMagnitude a, AccelerationMagnitude b) {
		return new AccelerationMagnitude(Mathf.Max(a.Float, b.Float));
	}

	public static AccelerationMagnitude Clamp(AccelerationMagnitude value, AccelerationMagnitude min, AccelerationMagnitude max) {
		return new AccelerationMagnitude(Mathf.Clamp(value.Float, min.Float, max.Float));
	}

	public static AccelerationMagnitude Lerp(AccelerationMagnitude a, AccelerationMagnitude b, float t) {
		return new AccelerationMagnitude(Mathf.Lerp(a.Float, b.Float, t));
	}

	public static AccelerationMagnitude LerpUnclamped(AccelerationMagnitude a, AccelerationMagnitude b, float t) {
		return new AccelerationMagnitude(Mathf.LerpUnclamped(a.Float, b.Float, t));
	}

	public static AccelerationDot Clamp01(AccelerationDot value) {
		return new AccelerationDot(Mathf.Clamp01(value.Float));
	}

	public static AccelerationDot Min(AccelerationDot a, AccelerationDot b) {
		return new AccelerationDot(Mathf.Min(a.Float, b.Float));
	}

	public static AccelerationDot Max(AccelerationDot a, AccelerationDot b) {
		return new AccelerationDot(Mathf.Max(a.Float, b.Float));
	}

	public static AccelerationDot Clamp(AccelerationDot value, AccelerationDot min, AccelerationDot max) {
		return new AccelerationDot(Mathf.Clamp(value.Float, min.Float, max.Float));
	}

	public static AccelerationDot Lerp(AccelerationDot a, AccelerationDot b, float t) {
		return new AccelerationDot(Mathf.Lerp(a.Float, b.Float, t));
	}

	public static AccelerationDot LerpUnclamped(AccelerationDot a, AccelerationDot b, float t) {
		return new AccelerationDot(Mathf.LerpUnclamped(a.Float, b.Float, t));
	}

	public static AccelerationMgSq Clamp01(AccelerationMgSq value) {
		return new AccelerationMgSq(Mathf.Clamp01(value.Float));
	}

	public static AccelerationMgSq Min(AccelerationMgSq a, AccelerationMgSq b) {
		return new AccelerationMgSq(Mathf.Min(a.Float, b.Float));
	}

	public static AccelerationMgSq Max(AccelerationMgSq a, AccelerationMgSq b) {
		return new AccelerationMgSq(Mathf.Max(a.Float, b.Float));
	}

	public static AccelerationMgSq Clamp(AccelerationMgSq value, AccelerationMgSq min, AccelerationMgSq max) {
		return new AccelerationMgSq(Mathf.Clamp(value.Float, min.Float, max.Float));
	}

	public static AccelerationMgSq Lerp(AccelerationMgSq a, AccelerationMgSq b, float t) {
		return new AccelerationMgSq(Mathf.Lerp(a.Float, b.Float, t));
	}

	public static AccelerationMgSq LerpUnclamped(AccelerationMgSq a, AccelerationMgSq b, float t) {
		return new AccelerationMgSq(Mathf.LerpUnclamped(a.Float, b.Float, t));
	}

	public static ForceX Clamp01(ForceX value) {
		return new ForceX(Mathf.Clamp01(value.Float));
	}

	public static ForceX Min(ForceX a, ForceX b) {
		return new ForceX(Mathf.Min(a.Float, b.Float));
	}

	public static ForceX Max(ForceX a, ForceX b) {
		return new ForceX(Mathf.Max(a.Float, b.Float));
	}

	public static ForceX Clamp(ForceX value, ForceX min, ForceX max) {
		return new ForceX(Mathf.Clamp(value.Float, min.Float, max.Float));
	}

	public static ForceX Lerp(ForceX a, ForceX b, float t) {
		return new ForceX(Mathf.Lerp(a.Float, b.Float, t));
	}

	public static ForceX LerpUnclamped(ForceX a, ForceX b, float t) {
		return new ForceX(Mathf.LerpUnclamped(a.Float, b.Float, t));
	}

	public static ForceY Clamp01(ForceY value) {
		return new ForceY(Mathf.Clamp01(value.Float));
	}

	public static ForceY Min(ForceY a, ForceY b) {
		return new ForceY(Mathf.Min(a.Float, b.Float));
	}

	public static ForceY Max(ForceY a, ForceY b) {
		return new ForceY(Mathf.Max(a.Float, b.Float));
	}

	public static ForceY Clamp(ForceY value, ForceY min, ForceY max) {
		return new ForceY(Mathf.Clamp(value.Float, min.Float, max.Float));
	}

	public static ForceY Lerp(ForceY a, ForceY b, float t) {
		return new ForceY(Mathf.Lerp(a.Float, b.Float, t));
	}

	public static ForceY LerpUnclamped(ForceY a, ForceY b, float t) {
		return new ForceY(Mathf.LerpUnclamped(a.Float, b.Float, t));
	}

	public static ForceMagnitude Clamp01(ForceMagnitude value) {
		return new ForceMagnitude(Mathf.Clamp01(value.Float));
	}

	public static ForceMagnitude Min(ForceMagnitude a, ForceMagnitude b) {
		return new ForceMagnitude(Mathf.Min(a.Float, b.Float));
	}

	public static ForceMagnitude Max(ForceMagnitude a, ForceMagnitude b) {
		return new ForceMagnitude(Mathf.Max(a.Float, b.Float));
	}

	public static ForceMagnitude Clamp(ForceMagnitude value, ForceMagnitude min, ForceMagnitude max) {
		return new ForceMagnitude(Mathf.Clamp(value.Float, min.Float, max.Float));
	}

	public static ForceMagnitude Lerp(ForceMagnitude a, ForceMagnitude b, float t) {
		return new ForceMagnitude(Mathf.Lerp(a.Float, b.Float, t));
	}

	public static ForceMagnitude LerpUnclamped(ForceMagnitude a, ForceMagnitude b, float t) {
		return new ForceMagnitude(Mathf.LerpUnclamped(a.Float, b.Float, t));
	}

	public static ForceDot Clamp01(ForceDot value) {
		return new ForceDot(Mathf.Clamp01(value.Float));
	}

	public static ForceDot Min(ForceDot a, ForceDot b) {
		return new ForceDot(Mathf.Min(a.Float, b.Float));
	}

	public static ForceDot Max(ForceDot a, ForceDot b) {
		return new ForceDot(Mathf.Max(a.Float, b.Float));
	}

	public static ForceDot Clamp(ForceDot value, ForceDot min, ForceDot max) {
		return new ForceDot(Mathf.Clamp(value.Float, min.Float, max.Float));
	}

	public static ForceDot Lerp(ForceDot a, ForceDot b, float t) {
		return new ForceDot(Mathf.Lerp(a.Float, b.Float, t));
	}

	public static ForceDot LerpUnclamped(ForceDot a, ForceDot b, float t) {
		return new ForceDot(Mathf.LerpUnclamped(a.Float, b.Float, t));
	}

	public static ForceMgSq Clamp01(ForceMgSq value) {
		return new ForceMgSq(Mathf.Clamp01(value.Float));
	}

	public static ForceMgSq Min(ForceMgSq a, ForceMgSq b) {
		return new ForceMgSq(Mathf.Min(a.Float, b.Float));
	}

	public static ForceMgSq Max(ForceMgSq a, ForceMgSq b) {
		return new ForceMgSq(Mathf.Max(a.Float, b.Float));
	}

	public static ForceMgSq Clamp(ForceMgSq value, ForceMgSq min, ForceMgSq max) {
		return new ForceMgSq(Mathf.Clamp(value.Float, min.Float, max.Float));
	}

	public static ForceMgSq Lerp(ForceMgSq a, ForceMgSq b, float t) {
		return new ForceMgSq(Mathf.Lerp(a.Float, b.Float, t));
	}

	public static ForceMgSq LerpUnclamped(ForceMgSq a, ForceMgSq b, float t) {
		return new ForceMgSq(Mathf.LerpUnclamped(a.Float, b.Float, t));
	}

	public static MomentumX Clamp01(MomentumX value) {
		return new MomentumX(Mathf.Clamp01(value.Float));
	}

	public static MomentumX Min(MomentumX a, MomentumX b) {
		return new MomentumX(Mathf.Min(a.Float, b.Float));
	}

	public static MomentumX Max(MomentumX a, MomentumX b) {
		return new MomentumX(Mathf.Max(a.Float, b.Float));
	}

	public static MomentumX Clamp(MomentumX value, MomentumX min, MomentumX max) {
		return new MomentumX(Mathf.Clamp(value.Float, min.Float, max.Float));
	}

	public static MomentumX Lerp(MomentumX a, MomentumX b, float t) {
		return new MomentumX(Mathf.Lerp(a.Float, b.Float, t));
	}

	public static MomentumX LerpUnclamped(MomentumX a, MomentumX b, float t) {
		return new MomentumX(Mathf.LerpUnclamped(a.Float, b.Float, t));
	}

	public static MomentumY Clamp01(MomentumY value) {
		return new MomentumY(Mathf.Clamp01(value.Float));
	}

	public static MomentumY Min(MomentumY a, MomentumY b) {
		return new MomentumY(Mathf.Min(a.Float, b.Float));
	}

	public static MomentumY Max(MomentumY a, MomentumY b) {
		return new MomentumY(Mathf.Max(a.Float, b.Float));
	}

	public static MomentumY Clamp(MomentumY value, MomentumY min, MomentumY max) {
		return new MomentumY(Mathf.Clamp(value.Float, min.Float, max.Float));
	}

	public static MomentumY Lerp(MomentumY a, MomentumY b, float t) {
		return new MomentumY(Mathf.Lerp(a.Float, b.Float, t));
	}

	public static MomentumY LerpUnclamped(MomentumY a, MomentumY b, float t) {
		return new MomentumY(Mathf.LerpUnclamped(a.Float, b.Float, t));
	}

	public static MomentumMagnitude Clamp01(MomentumMagnitude value) {
		return new MomentumMagnitude(Mathf.Clamp01(value.Float));
	}

	public static MomentumMagnitude Min(MomentumMagnitude a, MomentumMagnitude b) {
		return new MomentumMagnitude(Mathf.Min(a.Float, b.Float));
	}

	public static MomentumMagnitude Max(MomentumMagnitude a, MomentumMagnitude b) {
		return new MomentumMagnitude(Mathf.Max(a.Float, b.Float));
	}

	public static MomentumMagnitude Clamp(MomentumMagnitude value, MomentumMagnitude min, MomentumMagnitude max) {
		return new MomentumMagnitude(Mathf.Clamp(value.Float, min.Float, max.Float));
	}

	public static MomentumMagnitude Lerp(MomentumMagnitude a, MomentumMagnitude b, float t) {
		return new MomentumMagnitude(Mathf.Lerp(a.Float, b.Float, t));
	}

	public static MomentumMagnitude LerpUnclamped(MomentumMagnitude a, MomentumMagnitude b, float t) {
		return new MomentumMagnitude(Mathf.LerpUnclamped(a.Float, b.Float, t));
	}

	public static MomentumDot Clamp01(MomentumDot value) {
		return new MomentumDot(Mathf.Clamp01(value.Float));
	}

	public static MomentumDot Min(MomentumDot a, MomentumDot b) {
		return new MomentumDot(Mathf.Min(a.Float, b.Float));
	}

	public static MomentumDot Max(MomentumDot a, MomentumDot b) {
		return new MomentumDot(Mathf.Max(a.Float, b.Float));
	}

	public static MomentumDot Clamp(MomentumDot value, MomentumDot min, MomentumDot max) {
		return new MomentumDot(Mathf.Clamp(value.Float, min.Float, max.Float));
	}

	public static MomentumDot Lerp(MomentumDot a, MomentumDot b, float t) {
		return new MomentumDot(Mathf.Lerp(a.Float, b.Float, t));
	}

	public static MomentumDot LerpUnclamped(MomentumDot a, MomentumDot b, float t) {
		return new MomentumDot(Mathf.LerpUnclamped(a.Float, b.Float, t));
	}

	public static MomentumMgSq Clamp01(MomentumMgSq value) {
		return new MomentumMgSq(Mathf.Clamp01(value.Float));
	}

	public static MomentumMgSq Min(MomentumMgSq a, MomentumMgSq b) {
		return new MomentumMgSq(Mathf.Min(a.Float, b.Float));
	}

	public static MomentumMgSq Max(MomentumMgSq a, MomentumMgSq b) {
		return new MomentumMgSq(Mathf.Max(a.Float, b.Float));
	}

	public static MomentumMgSq Clamp(MomentumMgSq value, MomentumMgSq min, MomentumMgSq max) {
		return new MomentumMgSq(Mathf.Clamp(value.Float, min.Float, max.Float));
	}

	public static MomentumMgSq Lerp(MomentumMgSq a, MomentumMgSq b, float t) {
		return new MomentumMgSq(Mathf.Lerp(a.Float, b.Float, t));
	}

	public static MomentumMgSq LerpUnclamped(MomentumMgSq a, MomentumMgSq b, float t) {
		return new MomentumMgSq(Mathf.LerpUnclamped(a.Float, b.Float, t));
	}

}