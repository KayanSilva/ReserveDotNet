using System;
using System.Text.RegularExpressions;
using Refactoring.Interfaces;

namespace Refactoring.Services
{
    public class CpfFormatter : IFormatter
    {
        protected readonly string Formatted;
        protected readonly string FormattedReplacement;
        protected readonly string Unformatted;
        protected readonly string UnformattedReplacement;

        public CpfFormatter()
            : this(@"(\d{3})[.](\d{3})[.](\d{3})-(\d{2})", "$1.$2.$3-$4"
                  , @"(\d{3})(\d{3})(\d{3})(\d{2})", "$1$2$3$4")
        {
        }

        public CpfFormatter(string formatted, string formattedReplacement, string unformatted, string unformattedReplacement)
        {
            Formatted = formatted;
            FormattedReplacement = formattedReplacement;
            Unformatted = unformatted;
            UnformattedReplacement = unformattedReplacement;
        }

        public bool CanBeFormatted(string value)
        {
            return new Regex(Unformatted).IsMatch(value);
        }

        public string Format(string value)
        {
            if (value == null)
            {
                throw new ArgumentNullException("Value may not be null.");
            }
            return new Regex(Unformatted).Replace(value, FormattedReplacement);
        }

        public bool IsFormatted(string value)
        {
            return new Regex(Formatted).IsMatch(value);
        }

        public string Unformat(string value)
        {
            if (value == null)
            {
                throw new ArgumentNullException("Value may not be null.");
            }

            if (new Regex(Unformatted).IsMatch(value))
                return value;

            return new Regex(Formatted).Replace(value, UnformattedReplacement);
        }
    }
}