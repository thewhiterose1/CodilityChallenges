public class Solution {
    public IList<IList<int>> GroupThePeople(int[] groupSizes) {
        
        IList<IList<int>> finalList = new List<IList<int>>();
        
        Dictionary<int, List<int>> dict = new Dictionary<int, List<int>>();
        
        for (int i = 0; i < groupSizes.Length; i++) {
            if (dict.ContainsKey(groupSizes[i])) dict[groupSizes[i]].Add(i);                
            else dict.Add(groupSizes[i], new List<int>() {i});
        }
        
        foreach(KeyValuePair<int, List<int>> entry in dict)
        {
            for (int i = 1; i <= entry.Value.Count / entry.Key; i++) {
                finalList.Add(entry.Value.Take(entry.Key).ToList());
            }
            entry.Value.RemoveRange(0, entry.Key);
        }    
        return finalList;
    }
}