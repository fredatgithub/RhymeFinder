using System;
using System.Collections.Generic;
using System.IO;
using System.Net;

namespace RhymeLib
{
  /// <summary>
  /// A class with a static method to interface with the rhyming web service 
  /// and manage caching of previously looked up words.
  /// </summary>
  public static class RhymingWords
  {
    // http://rhymebrain.com/api.html
    private const string WORD_DIRECTORY = @".\Words";
    private const string LOOKUP_URL = "http://rhymebrain.com/talk?function=getRhymes&word=";

    static RhymingWords()
    {
      if (!Directory.Exists(WORD_DIRECTORY))
      {
        Directory.CreateDirectory(WORD_DIRECTORY);
      }
    }

    /// <summary>
    /// Method to call to retrieve a list of words that rhyme with a particular word.
    /// </summary>
    /// <param name="word">The word to rhyme.</param>
    /// <returns></returns>
    public static List<string> GetRhymes(string word)
    {
      string cachedWordFileName = WORD_DIRECTORY + @"\" + word + ".txt";

      List<string> results = new List<string>();

      // Check to see if we have a local file (i.e. we called the web service before).
      if (File.Exists(cachedWordFileName))
      {
        // We did.  Read the cached words.
        string raw = string.Empty;
        using (StreamReader sr = new StreamReader(cachedWordFileName))
        {
          raw = sr.ReadToEnd();
          sr.Close();
        }

        foreach (string wordLine in raw.Split('\n'))
        {
          if (wordLine.Trim().Length > 0)
          {
            results.Add(wordLine);
          }
        }
      }
      else
      {
        // No local file exists.  Go get the new word rhymes.
        WebRequest webRequest = WebRequest.Create(LOOKUP_URL + word);

        IWebProxy proxy = webRequest.Proxy;
        string proxyURI = proxy.GetProxy(webRequest.RequestUri).ToString();

        webRequest.UseDefaultCredentials = true;
        webRequest.Proxy = new WebProxy(proxyURI, false);
        webRequest.Proxy.Credentials = CredentialCache.DefaultCredentials;

        try
        {
          WebResponse webResponse = webRequest.GetResponse();
          string response = string.Empty;

          using (StreamReader sr = new StreamReader(webResponse.GetResponseStream()))
          {
            response = sr.ReadToEnd();
            sr.Close();
          }

          List<RhymedWord> words = new List<RhymedWord>();

          // Iterate over the results.  Each line contains a rhyming word to be parsed.
          foreach (string line in response.Split('\n'))
          {
            if (line.Trim().Length > 0)
            {
              RhymedWord rhymedWord = new RhymedWord(line);
              // The word to be rhymed always comes back too.  Skip it, and all of the
              // other words that were rhymed with less than perfect (Score < 300) confidence.
              if (rhymedWord.Word.ToLower() != word.ToLower() && rhymedWord.Score == 300)
              {
                words.Add(rhymedWord);
              }
            }
          }

          words.Sort();

          // Cache the results to prevent future requests for rhymes of the same word.
          using (System.IO.StreamWriter sw = new System.IO.StreamWriter(cachedWordFileName))
          {
            foreach (RhymedWord rw in words)
            {
              results.Add(rw.Word);
              sw.WriteLine(rw.Word);
            }

            sw.Close();
          }
        }
        catch (Exception)
        {
          /* Some problem with the web service or writing the cache file.  Can't do much. */
        }
      }

      return results;
    }
  }
}