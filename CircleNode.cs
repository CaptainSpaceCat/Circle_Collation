

public class CircleNode {

	public Vector2 center;
	//assume radius is normalized
	public List<Slice> freeSlices = new List<Slice>();
	public List<CircleNode> connections;

	public CircleNode() {
		//TODO: set freeslices to have one all encompassing slice
		freeSlices.Add(new Slice(Vector2.up, 180f));
	}

	public void BlockSlice(Slice other) {
		foreach (Slice slice in freeSlices) {
			//will subtract this slice from any other slices
			Slice result = slice.Subtract(other);

			//if a subtraction would've split a slice in two, adds the other slice to freeSlices
			if (result != null) {
				freeSlices.Add(result);
			}

			if (slice.IsEmpty()) {
				//delete this slice if it has been consumed by the subtraction
			}
		}
	}

	public void ConnectTo(CircleNode other) {
		connections.Add(other);
		other.connections.Add(this);
	}

	public float GetFreeLength() {
		float total = 0;
		foreach (Slice slice in freeSlices) {
			total += slice.ArcLength();
		}
	}

	public bool IsBlocked() {
		return freeSlices.Count == 0;
	}

}