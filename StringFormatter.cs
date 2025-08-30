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
        /// <summary>
        /// Utiity method that converts an array of strings into a single comma-separated list, 
        /// with optional quoting, trimming, and empty-item filtering.
        /// </summary>
        /// <param name="items">The array of strings to combine into a list.</param>
        /// <param name="quote">The string (character  sequence) to wrap each item in. Defaults to a double quote (<c>"</c>).</param>
        /// <param name="separator">The separator string (character sequence) between items. Defaults to a comma (<c>,</c>).</param>
        /// <param name="excludeEmptyItems">
        /// If <c>true</c>, empty or whitespace-only items will be excluded from the result. Defaults to <c>false</c>.
        /// </param>
        /// <param name="removeLeadingAndTrailingWhiteSpace">
        /// If <c>true</c>, trims whitespace from the start and end of each item before processing. Defaults to <c>false</c>.
        /// </param>
        /// <param name="includeSpaceAfterSeparator">
        /// If <c>true</c>, a space will be added after each separator for readability. Defaults to <c>true</c>.
        /// </param>
        /// <returns>
        /// A single string containing the formatted, comma-separated (or whatever-specified-seperator-seperated) list. 
        /// Returns <see cref="string.Empty"/> if <paramref name="items"/> is <c>null</c> or empty.
        /// </returns>
        /// <example>
        /// Example usage:
        /// <code>
        /// var items = new[] { "Hello", " Sensational ", "World", "" };
        /// var result = ToCommaSeparatedList(items, "\"", ",", true, true, true);
        /// // Result: "\"Hello\", \"Sensational\", \"World\""
        /// </code>
        /// </example>
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
