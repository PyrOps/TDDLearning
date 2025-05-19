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
  }

  public class Palindrome {
    public static bool IsPalindrome(string input) {
      if (string.IsNullOrEmpty(input)) return false;
      if (input[0] != input[^1]) return false;
      return true;
    }
  }
}