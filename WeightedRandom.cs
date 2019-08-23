

public class WeightedRandom {
	
	private List<Range> ranges;

	public void AddRange(float start, float finish, float weight) {
		ranges.Add(new Range(start, finish, weight));
	}

	public void ClearRange() {
		ranges.Clear();
	}

	public float GetFloat() {
		float totalWeight;
		foreach (Range r in ranges) {
			totalWeight += r.weight;
		}
		float choice = 0; //TODO: choose random value from 0 - totalWeight
		float cumulative = 0;
		foreach (Range r in ranges) {
			cumulative += r.weight;
			if (choice <= cumulative) {
				return 0; //TODO: choose random value from r.min - r.max
			}
		}
		//TODO: return some contingency value
	}

}