using System;

namespace RhymeLib
{
  public class RhymedWord : IComparable
  {
    internal string _word;
    private Int32 _score;
    private string _flags;
    private Int32 _syllables;
    private Int32 _frequency;

    public RhymedWord(string raw)
    {
      //     " {\"word\":\"bore\",\"freq\":22,\"score\":300,\"flags\":\"bc\",\"syllables\":\"1\"},"
      //        ^^    ^^ ^^    ^^ ^^    ^^    ^^     ^^     ^^     ^^ ^^  ^^ ^^         ^^ ^^ ^^
      //       0    1   2    3   4    5    6      7     8       9    10 11  12     13     14 15

      // Parse the raw JSON to get the data.
      string[] tokens = raw.Split('\"');

      _word = tokens[3];                      // bore
      string temp = tokens[6];                // :22
      _frequency = Int32.Parse(temp.Substring(1, temp.Length - 2));

      temp = tokens[8];                       // :300
      _score = Int32.Parse(temp.Substring(1, temp.Length - 2));
      _flags = tokens[11];                    // bc
      _syllables = Int32.Parse(tokens[15]);   // 1
    }

    public Int32 Syllables { get { return _syllables; } }
    public string Flags { get { return _flags; } }
    public Int32 Score { get { return _score; } }
    public string Word { get { return _word; } }
    public Int32 Frequency { get { return _frequency; } }

    /// <summary>
    /// Overridden method to allow sorting of List<RhymedWord>.
    /// </summary>
    /// <param name="obj"></param>
    /// <returns></returns>
    public int CompareTo(object obj)
    {
      // Put the highest fidelity rhymes at the top of the list.
      Int32 result = ((RhymedWord)obj).Score.CompareTo(_score);

      // If the rhymed word has the same Score as the RhymedWord being compared, sort them alphabetically.
      if (result == 0)
      {
        return _word.CompareTo(((RhymedWord)obj).Word);
      }

      return result;
    }

    public override string ToString()
    {
      return _word + " (" + _score + ")";
    }
  }
}