using System;

namespace SkeletonCode.ReversingString
{
	public class StringUtilities
	{
		public string Reverse(string input)
        {
            string output = string.Empty;

            if (!string.IsNullOrEmpty(input))
            {
                // below is the implementation to improve the performance for the large strings
                char[] cArray = input.ToCharArray();
                Array.Reverse(cArray);
                output = new string(cArray);

                // Instead of using Array method, Linq can also be used as mentioned below. 
                // In this case, we need to add using directive to System.Linq namespace (i.e., using System.Linq)
                // output = new string(Enumerable.Range(1, input.Length).Select(i => input[input.Length - i]).ToArray());
            }

            return output;
        }
    }
}
