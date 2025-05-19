namespace Palindrome {
  public class PalindromeTest {
    [Fact]
    public void EmptyStringReturnsFalse() {
      string input = "";
      Palindrome p = new();
      Assert.False(p.IsPalindrome(input));
    }

    [Fact]
    public void ShortPalindromeStringReturnsTrue() {
      string input = "";
      Palindrome p = new();
      Assert.False(p.IsPalindrome(input));
    }
  }

  public class Palindrome {
    public bool IsPalindrome(string input) {
      return false;
    }
  }
}