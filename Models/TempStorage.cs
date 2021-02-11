using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment42.Models
{
    public class TempStorage
    {
        private static List<NewSuggestion> suggestions = new List<NewSuggestion>();
        public static IEnumerable<NewSuggestion> Suggestions => suggestions;

        public static void AddSuggestion(NewSuggestion suggestion)
        {
            suggestions.Add(suggestion);
        }
    }
}
