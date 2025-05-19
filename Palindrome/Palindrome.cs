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

    [Fact]
    public void SimpleShortPalindromeStringReturnsTrue() {
      string input = "abccba";
      Assert.True(Palindrome.IsPalindrome(input));
    }

    [Fact]
    public void ComplexLongNonPalindromeStringReturnsFalse() {
      string input = "TDD is really cool";
      Assert.False(Palindrome.IsPalindrome(input));
    }

    [Fact]
    public void LongPalindromeStringReturnsTrue() {
      string input = "Engage le jeu que je le gagne";
      Assert.True(Palindrome.IsPalindrome(input));
    }
  }

  public class Palindrome {
    public static bool IsPalindrome(string input) {
      string updatedInput = input.ToLower().Replace(" ", "");
      if (string.IsNullOrEmpty(updatedInput)) return false;
      int startIndex, endIndex;
      int offset = 1;
      startIndex = 0;
      endIndex = updatedInput.Length - 1;
      while (startIndex < updatedInput.Length) {
        if (updatedInput[startIndex] != updatedInput[endIndex]) return false;
        startIndex += offset;
        endIndex -= offset;
      }
      return true;
    }
  }
}