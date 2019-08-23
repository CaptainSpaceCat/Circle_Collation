

public class NodeMap {

	public List<CircleNode> nodes = new List<CircleNode>();
	public List<CircleNode> fringe = new List<CircleNode>();
	public float nodeRadius;
	public Vector2 mapSize;

	public void Generate() {
		CircleNode root = new CircleNode(Vector2.zero);
		nodes.Add(root);
		fringe.Add(root);
		while (true) {
			Vector2 point = GetRandomFringePoint();
			fringe.Add(new CircleNode(point));
			foreach (CircleNode node in fringe) {
				//see if slices need to be blocked
			}
			//see if any nodes need to be removed from fringe
		}
	}

	public Vector2 GetRandomFringePoint() {
		WeightedRandom wr = new WeightedRandom();
		foreach (CircleNode node in fringe) {
			foreach (Slice slice in node.freeSlices) {
				wr.AddRange(/* TODO: slice min, slice max, slice length*/)
			}
		}
		float result = wr.GetFloat();
		return result;
	}

	public bool InBounds(Vector2 center) {

	}

}