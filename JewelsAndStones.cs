public class Solution {
    public int NumJewelsInStones(string J, string S) {
        var count = 0;
        foreach(char j in J) {
            foreach(char s in S) {
                if(j == s)
                    count++;
            }
        }
        return count;
    }
}