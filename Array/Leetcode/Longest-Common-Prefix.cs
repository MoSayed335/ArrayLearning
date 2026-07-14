//Write a function to find the longest common prefix string amongst an array of strings.

//If there is no common prefix, return an empty string "".



//Example 1:

//Input: strs = ["flower", "flow", "flight"]
//Output: "fl"
//Example 2:

//Input: strs = ["dog", "racecar", "car"]
//Output: ""
//Explanation: There is no common prefix among the input strings.


namespace ArrayLearning.Leetcode
{
    public class Longest_Common_Prefix
    {
            //strs = {"Flow","Fly"}
            public string LongestCommonPrefix(string[] strs)
            {
                string prefix = strs[0];//Flow
                for(int i = 1; i < strs.Length; i++) //i<2; 1 degit
                {
                    string currentprefix = string.Empty;
                    for(int j = 0; j < strs[i].Length; j++)
                    {
                        if(j >= prefix.Length) break; //j>=1

                        if (strs[i][j] == prefix[j])
                        {
                            currentprefix += strs[i][j];
                        }
                        else
                            break;
                    }
                    prefix = currentprefix;
                }
              return prefix;
            }
        }
    }
