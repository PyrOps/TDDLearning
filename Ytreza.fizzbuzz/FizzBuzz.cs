using System.Text;

namespace Ytreza.fizzbuzz {
  //
  // Step 1 : Test list
  // - Covering non fizzbuzz values
  //    FizzBuzz(1)
  //    FizzBuzz(2)
  //    FizzBuzz(4)
  // - Covering fizz values (multiples of 3)
  //    FizzBuzz(3)
  //    FizzBuzz(6)
  //    FizzBuzz(9)
  // - Covering buzz values (multiples of 5)
  //    FizzBuzz(5)
  //    FizzBuzz(10)
  //    FizzBuzz(20)
  // - Covering fizzbuzz values (multiples of 15)
  //    FizzBuzz(15)
  //    FizzBuzz(30)
  //    FizzBuzz(0)
  //

  // Step 2 : Test writing
  // 1. FizzBuzz(1)
  // 2. FizzBuzz(2)
  // 3. FizzBuzz(4)
  // 4. FizzBuzz(3)
  // 5. FizzBuzz(6)
  // 6. FizzBuzz(9)
  // 7. FizzBuzz(5)
  // 8. FizzBuzz(10)
  // 9. FizzBuzz(20)
  // 10. FizzBuzz(15)
  // 11. FizzBuzz(30)
  // 12. FizzBuzz(0)

  public class FizzBuzzTest {
    [Fact]
    public void TestFizzBuzzOne() {
      Assert.Equal("1", FizzBuzz.Check(1));
    }

    [Fact]
    public void TestFizzBuzzTwo() {
      Assert.Equal("2", FizzBuzz.Check(2));
    }

    [Fact]
    public void TestFizzBuzzFour() {
      Assert.Equal("4", FizzBuzz.Check(4));
    }

    [Fact]
    public void TestFizzBuzzThree() {
      Assert.Equal("fizz", FizzBuzz.Check(3));
    }

    [Fact]
    public void TestFizzBuzzSix() {
      Assert.Equal("fizz", FizzBuzz.Check(6));
    }

    [Fact]
    public void TestFizzBuzzNine() {
      Assert.Equal("fizz", FizzBuzz.Check(9));
    }

    [Fact]
    public void TestFizzBuzzFive() {
      Assert.Equal("buzz", FizzBuzz.Check(5));
    }

    [Fact]
    public void TestFizzBuzzTen() {
      Assert.Equal("buzz", FizzBuzz.Check(10));
    }

    [Fact]
    public void TestFizzBuzzTwenty() {
      Assert.Equal("buzz", FizzBuzz.Check(20));
    }

    [Fact]
    public void TestFizzBuzzFifteen() {
      Assert.Equal("fizzbuzz", FizzBuzz.Check(15));
    }

    [Fact]
    public void TestFizzBuzzThirty() {
      Assert.Equal("fizzbuzz", FizzBuzz.Check(30));
    }

    [Fact]
    public void TestFizzBuzzZero() {
      Assert.Equal("fizzbuzz", FizzBuzz.Check(0));
    }
  }

  public class FizzBuzz {
    public static string Check(int value) {
      StringBuilder sb = new();
      if (!IsMultipleOfThree(value) && !IsMultipleOfFive(value))
        sb.Append(value.ToString());
      else {
        if (IsMultipleOfThree(value)) sb.Append("fizz");
        if (IsMultipleOfFive(value)) sb.Append("buzz");
      }
      return sb.ToString();
    }

    public static bool IsMultipleOfThree(int value) {
      return value % 3 == 0;
    }

    public static bool IsMultipleOfFive(int value) {
      return value % 5 == 0;
    }
  }
}