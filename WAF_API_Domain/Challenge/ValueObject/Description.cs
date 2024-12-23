﻿namespace WAF_API_Domain.Note.ValueObject
{
    /// <summary>
    /// Defines the <see cref="Description" />
    /// </summary>
    [Obsolete]
    public class Description
    {
        /// <summary>
        /// Gets the Value
        /// </summary>
        public string? Value { get; private set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Description"/> class.
        /// </summary>
        /// <param name="value">The value<see cref="string"/></param>
        public Description(string value)
        {
            if (string.IsNullOrEmpty(value))
            {
                Value = "Nothing here.";
                return;
            }

            Value = char.ToUpper(value[0]) + value.Substring(1);

            int lastCharIndex = Value.Length - 1;
            char lastChar = Value[lastCharIndex];

            if (lastChar == '!' || lastChar == '?')
            {
                if (lastCharIndex > 0 && !char.IsDigit(Value[lastCharIndex - 1]) && Value[lastCharIndex - 1] != ' ')
                {
                    Value = Value.Substring(0, lastCharIndex) + " " + lastChar;
                }
                return;
            }
            if (!Value.EndsWith("."))
            {
                Value += ".";
            }
        }
    }

}
