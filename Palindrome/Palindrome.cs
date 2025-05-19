namespace Palindrome {
  public class PalindromeTest {
    [Fact]
    public void EmptyStringReturnsFalse() {
      string input = "";
      Assert.False(Palindrome.IsPalindrome(input));
    }

    [Fact]
    public void ShortPalindromeStringReturnsTrue() {
      string input = "aa";
      Assert.True(Palindrome.IsPalindrome(input));
    }

    [Fact]
    public void ShortNonPalindromeStringReturnsFalse() {
      string input = "abcdef";
      Assert.False(Palindrome.IsPalindrome(input));
    }

    [Fact]
    public void LongNonPalindromeStringReturnsFalse() {
      string input = "abcdefghijklmnopqrstuvwxyz";
      Assert.False(Palindrome.IsPalindrome(input));
    }

    [Fact]
    public void ComplexShortNonPalindromeStringReturnsFalse() {
      string input = "abcdea";
      Assert.False(Palindrome.IsPalindrome(input));
    }

    [Fact]
    public void MoreComplexShortNonPalindromeStringReturnsFalse() {
      string input = "abcdba";
      Assert.False(Palindrome.IsPalindrome(input));
    }
  }

  public class Palindrome {
    public static bool IsPalindrome(string input) {
      if (string.IsNullOrEmpty(input)) return false;
      int startIndex, endIndex;
      int offset = 1;
      startIndex = 0;
      endIndex = input.Length - 1;
      if (startIndex < input.Length) {
        if (input[startIndex] != input[endIndex]) return false;
      }
      startIndex += offset;
      endIndex -= offset;
      if (startIndex < input.Length) {
        if (input[startIndex] != input[endIndex]) return false;
      }
      startIndex += offset;
      endIndex -= offset;
      if (startIndex < input.Length) {
        if (input[startIndex] != input[endIndex]) return false;
      }
      return true;
    }
  }
}