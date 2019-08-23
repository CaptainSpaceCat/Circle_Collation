

public class Slice {

	public Vector2 trunk;
	public float extent;
	public Vector2 a;
	public Vector2 b;

	public Slice(Vector2 _trunk, float _extent) {
		trunk = _trunk;
		extent = _extent;
	}

	//tries to combine another slice into this slice
	//if this is impossible, returns the slice that was passed in
	//if it is possible, combines the other slice into this one, and returns null
	public Slice Add(Slice other) {

	}

	//tries to subtract the other slice from this slice
	//returns null if this subtraction can be integrated into this slice
	//returns another slice if the subtraction would break this slice in two
	public Slice Subtract(Slice other) {
		if (other.Contains(GetVector(extent)) && other.Contains(GetVector(-extent))) {
			//our slice is entirely within the other slice, delete us!
			extent = 0;
			return null;
		}
		if (Contains(other.GetVector(other.extent)) && Contains(-other.GetVector(other.extent))) {
			//we entirely contain the other slice, so we're getting cut in half!

		}

	}

	public bool Contains(Vector2 dir) {
		return Vector2.angle(trunk, dir) < extent; //TODO: check signs
	}

	public float ArcLength() {
		//percent = ((2 * extent) / (360 degrees, probably in radians))
		//return percent * 2 * pi * trunk.magnitude
	}

	public bool IsEmpty() {
		return extent == 0;
	}

}