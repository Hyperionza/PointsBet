using System.Text;

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

            StringBuilder qry = new StringBuilder();
            foreach (var item in items)
            {
                item = removeLeadingAndTrailingWhiteSpace ? item.Trim() : item;
                if (excludeEmptyItems && string.IsNullOrWhitespace(item)) { continue; }
                qry.Append($"{quote}{items[i]}{quote}{(isFirst ? string.Empty : separator)}{(!isFirst && includeSpaceAfterSeparator ? " " : string.Empty)}");
            }

            return qry.ToString();

            // Have I overthought this, yeah, its very open ended, so I went with utility

            // A traditional csv, doesnt have spaces after a comma, your original did, 
            // formatting for display purposes (in app/web) is unlikely to require quote marks
            // so the exact intention of this method is difficult to discern out of context
            // and without comments. The method name is also vague enough to imply either use case.

            // Thinking with utility in mind (i.e. that it could be used for either use case), 
            // there are a raft of optional parameters to guide its behaviour.
            // In a similar vein, how are nulls/empty items handled, trimming whitespace?
            // Maybe you want different separators (not all files called CSV files are comma separated)

            // With an unknown size of items, a StringBuilder may be safer than using string.Join.
            // If items has been sanitized, you're confident in the content of the items array 
            // and its size is on the smaller end and dont need to perform null/empty/whitespace detection,
            // then use:
            // return string.Join(", ", items.Select(item => $"{quote}{item}{quote}"));
            // along with the validation in the first line of this method and be done with it.

            // Typically, writing a method like I ahve done above is not my preference because it increases 
            // complexity needlessly and makes maintenance that much more difficult.
        }
    }
}
