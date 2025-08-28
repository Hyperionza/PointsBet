using System;

namespace PointsBet_Backend_Online_Code_Test
{

    /*
    Improve a block of code as you see fit in C#.
    You may make any improvements you see fit, for example:
      - Cleaning up code
      - Removing redundancy
      - Refactoring / simplifying
      - Fixing typos
      - Any other light-weight optimisation
    */
    public class StringFormatter
    {
        //Code to improve
        public static string ToCommaSeparatedList(string[] items, string quote = "\"", string separator = ",", bool excludeEmptyItems = false, bool removeLeadingAndTrailingWhiteSpace = false, bool includeSpaceAfterSeparator = true)
        {
            if (items == null || items.Length == 0) { return string.Empty; }

            var formattedItems = new List<string>(); // an array might be faster, but the quality of items is unknown
            for (int i = 0; i < items.Length; i++)
            {
                var item = removeLeadingAndTrailingWhiteSpace ? item[i].Trim() : item[i];
                if (excludeEmptyItems && string.IsNullOrWhitespace(item)) { continue; }
                formattedItems.Add($"{quote}{item}{quote}");
            }

            var joinSequence = separator;
            if (includeSpaceAfterSeparator) { separator += " "; }

            return string.Join(joinSequence, formattedItems);

            // Have I overthought this, yeah, its very open ended, so I went with utility

            // A traditional csv, doesnt have spaces after a comma, your original did, 
            // formatting for display purposes (in app/web) is unlikely to require quote marks
            // so the exact intention of this method is difficult to discern out of context
            // and without comments. The method name is also vague enough to imply either use case.

            // Thinking with utility in mind (i.e. that it could be used for either use case), 
            // there are a raft of optional parameters to guide its behaviour.
            // In a similar vein, how are nulls/empty items handled, trimming whitespace?
            // Maybe you want different separators (not all files called CSV files are comma separated)
        }
    }
}
