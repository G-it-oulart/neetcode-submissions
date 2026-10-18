public class Solution {
    List<List<int>> res = new List<List<int>>();
    public List<List<int>> Permute(int[] nums) {
        List<int> permutation = new List<int>();
        for (int i = 0; i < nums.Length; i++) {
            MakePermutations(nums, i, permutation, res);
            permutation.Clear();
        }
        return res;
    }

    public void MakePermutations(int[] nums, int index, List<int> permutation,
                                 List<List<int>> res) {
        permutation.Add(nums[index]);
        if (permutation.Count == nums.Length) {
            List<int> permutationCopy = new List<int>(permutation);
            res.Add(permutationCopy);
            return;
        } else {
            for (int i = 0; i < nums.Length; i++) {
                if (permutation.Contains(nums[i])) {
                    continue;
                }
                MakePermutations(nums, i, permutation, res);
                permutation.RemoveAt(permutation.Count-1);
            }
        }
    }
}
