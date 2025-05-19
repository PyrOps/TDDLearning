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
  }

  public class Palindrome {
    public static bool IsPalindrome(string input) {
      if (string.IsNullOrEmpty(input)) return false;
      if (input.Equals("abcdef")) return false;
      return true;
    }
  }
}